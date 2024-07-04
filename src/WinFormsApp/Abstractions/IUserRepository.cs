using WinFormsApp.Models;

namespace WinFormsApp.Abstractions;

public interface IUserRepository
{
    List<DocumentsByUser> GetByPeriod(DateTime from, DateTime to);
}