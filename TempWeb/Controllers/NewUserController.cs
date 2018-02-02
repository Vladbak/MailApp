using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;


namespace TempWeb.Controllers
{
    [RoutePrefix("api/users")]
    public class NewUserController : ApiController
    {

        [Route("{id:int}")]
        [HttpGet]
        public int Create(int id)
        {
            return id;
        }

        [Route("create")]
        [HttpPost]
        public int NewUser(MailClient.GHAZA g)
        {
            string  ConnectionString =  @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Corrector\Test_projects\WebApplication1\Web-Service\App_Data\MailServiceDB.mdf;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();

                command.CommandText = "insert into [EmployeeTable] values (@Name, @Surname, @Password);SELECT SCOPE_IDENTITY();";
                command.Parameters.AddWithValue("@Name", g.name);
                command.Parameters.AddWithValue("@Surname", g.surname);
                command.Parameters.AddWithValue("@Password", g.password);
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

        // GET: api/NewUser
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/NewUser/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/NewUser
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/NewUser/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/NewUser/5
        public void Delete(int id)
        {
        }
    }
}
