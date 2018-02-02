using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace Web_Service
{
    /// <summary>
    /// Сводное описание для MailService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class MailService : System.Web.Services.WebService
    {
        private string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\MailServiceDB.mdf;Integrated Security=True";


        [WebMethod]
        public string HelloWorld()
        {
            return "Привет всем!";
        }

        /// <summary>
        /// Вставляет письмо в БД
        /// </summary>
        [WebMethod]
        public bool Insert(string text, DateTime time, string title, int senderid, int recieverid)
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);

                SqlCommand command = connection.CreateCommand();
                command.CommandText = "insert into [MailTable] values (@text, @title, @time, @senderid, @recieverid)";
                command.Parameters.AddWithValue("@text", text);
                command.Parameters.AddWithValue("@time", time);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@senderid", senderid);
                command.Parameters.AddWithValue("@recieverid", recieverid);
                connection.Open();
                if (command.ExecuteNonQuery() == 1)
                    return true;
                return false;
            }
            catch (SqlException sqlexp)
            {
                return false;
            }

        }


        /// <summary>
        /// Получает письмо из БД по его id-шнику
        /// </summary>
        [WebMethod]
        public DataSet GetMail(int Mail_id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                DataSet ds = new DataSet();
            
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "select m.title, m.text, m.time,  s1.Name as senderName, s1.Surname as senderSurname, s2.Name as recieverName , s2.Surname as recieverSurname from (select * from MailTable where id=@Mail_id) m," +
                                        "(select Surname, name from [EmployeeTable] where id in (select SenderID from MailTable where id = @Mail_id)) s1," +
                                        "(select Surname, name from [EmployeeTable] where id in (select RecieverID from MailTable where id = @Mail_id)) s2; ";

                command.Parameters.AddWithValue("@Mail_id", Mail_id);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                connection.Open();
                adapter.Fill(ds);
                return ds;
            }

        }

        /// <summary>
        /// Создает в БД запись о новом сотруднике
        /// </summary>
        [WebMethod]
        public int NewUser(string Name, string Surname, string Password)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();

                command.CommandText = "insert into [EmployeeTable] values (@Name, @Surname, @Password);SELECT SCOPE_IDENTITY();";
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@Surname", Surname);
                command.Parameters.AddWithValue("@Password", Password);
                try
                {
                    return Convert.ToInt32(command.ExecuteScalar());
                     
                }
                catch
                {
                    return -1;
                }
            }
        }


        /// <summary>
        /// Проверяет, есть ли такой полльзователь в БД и возвращает его id
        /// </summary>
        [WebMethod]
        public int Login(string id,  string Password)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();

                command.CommandText = "select Password from [EmployeeTable] where Id = @ID;";
                command.Parameters.AddWithValue("@ID", id);
                
                try
                {
                    var result = Convert.ToString(command.ExecuteScalar());
                    
                    if (result.Equals(Password))
                        return Convert.ToInt32(id);
                    else
                        return -1;

                }
                catch
                {
                    return -2;
                }
            }
        }

    }
}
