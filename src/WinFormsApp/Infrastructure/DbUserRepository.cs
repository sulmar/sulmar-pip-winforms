using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.Abstractions;
using WinFormsApp.Models;

namespace WinFormsApp.Infrastructure
{
    internal class DbUserRepository : IUserRepository
    {
        private readonly SqlConnection _connection;

        public DbUserRepository(SqlConnection connection)
        {
            _connection = connection;     
        }

        public List<DocumentsByUser> GetByPeriod(DateTime from, DateTime to)
        {

            string sql = "select u.Username, count(d.Title) as 'Ilosc' from dbo.Users u left join dbo.Documents d on d.UserFk = u.Username where d.AcceptDate between @From and @To group by u.Username";
            List<DocumentsByUser> ldocuments = new List<DocumentsByUser>();
            SqlCommand command = new SqlCommand(sql, _connection);
            command.Parameters.AddWithValue("@From", from);
            command.Parameters.AddWithValue("@To", to);
            _connection.Open();

        SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                DocumentsByUser documentsByUser = Map(reader);
                ldocuments.Add(documentsByUser);
            }
            _connection.Close();
            return ldocuments;
        }

        private static DocumentsByUser Map(SqlDataReader reader)
        {
            string username = reader.GetString(0);
            int quantity = reader.GetInt32(1);
            DocumentsByUser documentsByUser = new DocumentsByUser();
            documentsByUser.Username = username;
            documentsByUser.Quantity = quantity;
            return documentsByUser;
        }

    }
}
