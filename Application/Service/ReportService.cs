using Application.Database;
using Application.Domain;
using Application.Repository;
using Application.Repository.Interfaces;
using Application.Service.Interfaces;

namespace Application.Service
{
    public class ReportService : IReportService
    {
        private readonly IReportRepository _reportRepository;

        public ReportService()
        {
            _reportRepository = new ReportDatabaseRepository(AppDb.CreateContext());
        }

        public List<Report> GetAll()
        {
            return _reportRepository.GetAllWithUser();
        }

        public Report GetById(int id)
        {
            var report = _reportRepository.Get(id);
            if (report == null)
                throw new Exception($"Izveštaj sa ID {id} nije pronađen.");
            return report;
        }

        public Report Create(Report report)
        {
            return _reportRepository.Create(report);
        }

        public void Delete(int id)
        {
            _reportRepository.Delete(id);
        }

        public List<Report> GetByDateRange(DateTime from, DateTime to)
        {
            return GetAll()
                .Where(r => r.CreatedAt >= from && r.CreatedAt <= to)
                .OrderByDescending(r => r.CreatedAt)
                .ToList();
        }
    }
}
