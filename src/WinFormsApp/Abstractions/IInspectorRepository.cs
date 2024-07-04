using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.Models;

namespace WinFormsApp.Abstractions;

public interface IInspectorRepository
{
    public List<Inspector> GetAll();
    public List<Inspector> GetByYear(int year);
}
