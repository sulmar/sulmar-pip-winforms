using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.Models;

namespace WinFormsApp.Abstractions;

public interface IInspectorRepository
{
    List<Inspector> GetAll();
    List<Inspector> GetByYear(int year);
}
