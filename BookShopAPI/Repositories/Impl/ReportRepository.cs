using BookShop.Contracts;
using BookShop.Models;
using Dapper;

namespace BookShopAPI.Repositories.Impl
{
    public class ReportRepository : IReportRepository
    {
        private readonly IDbContext _context;

        public ReportRepository(IDbContext context)
        {
            _context = context;
        }

        public List<Report> GetAll()
        {
            string sql = """
                SELECT 
                	b.isbn as ISBN,
                    b.name as bookTitle,
                	cus.id as customerId, 
                    cus.name as customerName, 
                    e.id as employeeId,
                    e.name as employeeName,
                    sd.quantity as quantity,
                    sd.amount as amount,
                    s.date_created as saleDate
                FROM sale_details sd
                JOIN sales s on sd.SaleId = s.id
                JOIN customers cus on s.CustomerId = cus.id
                JOIN employees e on s.EmployeeId = e.id
                JOIN books b on b.id = sd.BookId;
             """;
            
            return _context.Connection.Query<Report>(sql).ToList();
        }
    }
}