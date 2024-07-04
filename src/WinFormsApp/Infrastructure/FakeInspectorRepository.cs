using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.Abstractions;
using WinFormsApp.Models;

namespace WinFormsApp.Infrastructure;

public class FakeInspectorRepository : IInspectorRepository
{
    private readonly Dictionary<int, Inspector> _inspectors = new Dictionary<int, Inspector>();

    public FakeInspectorRepository()
    {
        var inspectors = new List<Inspector>
        {
            new Inspector { Id = 1, Number = "001", FirstName = "John", LastName = "Smith", Department = "S01", Year = 2024 },
            new Inspector { Id = 2, Number = "002", FirstName = "Mark", LastName = "Spider", Department = "S02", Year = 2024 },
            new Inspector { Id = 3, Number = "003", FirstName = "Mariah", LastName = "Buterfly", Department = "S01", Year = 2024 },
            new Inspector { Id = 4, Number = "004", FirstName = "Bob", LastName = "Liberty", Department = "S02", Year = 2024 },
        };

        _inspectors = inspectors.ToDictionary(p => p.Id);
    }

    public List<Inspector> GetAll()
    {        
        return _inspectors.Values.ToList();
    }

    public List<Inspector> GetByYear(int year)
    {
        throw new NotImplementedException();
    }

    public void DoWork()
    {

    }
}
