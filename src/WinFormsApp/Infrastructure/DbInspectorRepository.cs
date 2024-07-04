using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.Abstractions;
using WinFormsApp.Models;

namespace WinFormsApp.Infrastructure;

// dotnet add package Microsoft.Data.SqlClient
public class DbInspectorRepository : IInspectorRepository
{
    private readonly SqlConnection _connection;

    public DbInspectorRepository(SqlConnection connection)
    {
        _connection = connection;
    }

    public List<Inspector> GetAll()
    {
        string sql = "SELECT InspectorId, Number, FirstName, LastName, Department, Year FROM dbo.Inspectors";

        List<Inspector> inspectors = new List<Inspector>();

        SqlCommand command = new SqlCommand(sql, _connection);
        _connection.Open();

        SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            inspectors.Add(Map(reader));
        }

        _connection.Close();

        return inspectors;

    }

    private static Inspector Map(SqlDataReader reader)
    {
        var id = reader.GetInt32(reader.GetOrdinal("InspectorId"));
        var number = reader.GetString(reader.GetOrdinal("Number"));
        var firstName = reader.GetString(reader.GetOrdinal("FirstName"));
        var lastName = reader.GetString(reader.GetOrdinal("LastName"));
        var deparment = reader.GetString(reader.GetOrdinal("Department"));
        var year = reader.GetInt32(reader.GetOrdinal("Year"));

        Inspector inspector = new Inspector();
        inspector.Id = id;
        inspector.Number = number;
        inspector.FirstName = firstName;
        inspector.LastName = lastName;
        inspector.Department = deparment;
        inspector.Year = year;
        return inspector;
    }

    public List<Inspector> GetByYear(int year)
    {
        string sql = "SELECT InspectorId, Number, FirstName, LastName, Department, Year FROM dbo.Inspectors WHERE Year = @Year";

        List<Inspector> inspectors = new List<Inspector>();

        SqlCommand command = new SqlCommand(sql, _connection);
        command.Parameters.AddWithValue("@Year", year);
        _connection.Open();

        SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            inspectors.Add(Map(reader));
        }

        _connection.Close();

        return inspectors;
    }
}
