using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WebApplication1
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
                SqlConnection sql_con = new SqlConnection(ConfigurationManager.ConnectionStrings["MailConnectionString"].ConnectionString);
                
                string insert_string = "insert into [Mail_table] values (@text, @time, @title, @senderid, @recieverid)";
                SqlCommand sqlcom = new SqlCommand(insert_string, sql_con);
                sqlcom.Parameters.AddWithValue("@text", text);
                sqlcom.Parameters.AddWithValue("@time", time);
                sqlcom.Parameters.AddWithValue("@title", title);
                sqlcom.Parameters.AddWithValue("@senderid", senderid);
                sqlcom.Parameters.AddWithValue("@recieverid", recieverid);
                sql_con.Open();
                int result = sqlcom.ExecuteNonQuery();
                sql_con.Close();
                return true;
            }catch (SqlException sqlexp)
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
            using (SqlConnection sql_con = new SqlConnection(ConfigurationManager.ConnectionStrings["MailConnectionString"].ConnectionString))
            {
                DataSet ds = new DataSet();
                string insert_string = "Select * from [Mail_table] where id = @Mail_id";
                SqlCommand sqlcom = new SqlCommand(insert_string, sql_con);
                sqlcom.Parameters.AddWithValue("@Mail_id", Mail_id);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlcom);
               
                sql_con.Open();
                adapter.Fill(ds);
                return ds;             
            }
         
        }

    }
}
