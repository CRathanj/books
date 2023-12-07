using BookShop.Contracts;
using BookShopAPI.Models;

namespace BookShopAPI.Repositories.Impl
{
    public class ReportRepository : IReportRepository
    {
        private readonly IDbContext _context;
        public ReportRepository(IDbContext context)
        {
            _context = context;
        }
        public Report? GetById(string id)
        {
            return GetQueryable().FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<Report> GetQueryable()
        {
            // return _context.Reports.AsQueryable();
            throw new NotImplementedException();
        }
        public IQueryable<Report> GetAll()
        {
            // return _context.Reports.AsQueryable();
            throw new NotImplementedException();
        }
    }
}