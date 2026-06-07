using Application.Database;
using Application.Domain;
using Application.Repository.Base;
using Application.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Application.Repository
{
    public class ReportDatabaseRepository : CrudDatabaseRepository<Report, FlowerShopManagerDbContext>, IReportRepository
    {
        public ReportDatabaseRepository(FlowerShopManagerDbContext context) : base(context) {}

        public List<Report> GetAllWithUser()
        {
            return DbContext.Reports.AsNoTracking().Include(r => r.GeneratedBy).ToList();
        }
    }
}
