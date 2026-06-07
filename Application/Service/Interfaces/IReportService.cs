using Application.Domain;

namespace Application.Service.Interfaces
{
    public interface IReportService
    {
        List<Report> GetAll();
        Report GetById(int id);
        Report Create(Report report);
        void Delete(int id);
        List<Report> GetByDateRange(DateTime from, DateTime to);
    }
}
