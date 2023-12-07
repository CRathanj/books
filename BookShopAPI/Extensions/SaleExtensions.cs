using BookShop.Contracts;
using BookShop.Models;
using BookShopAPI.Models;
using BookShopAPI.Models.Requests;
using BookShopAPI.Models.Responses;

namespace BookShopAPI.Extensions;

public static class SaleExtensions
{
    public static SaleResponse ToResponse(this Sale req)
    {
        return new SaleResponse
        {
            Id = req.Id,
            EmployeeId = req.EmployeeId,
            Employee = req.Employee,
            CreatedOn = req.CreatedOn,
            LastUpdatedOn = req.LastUpdatedOn,
            SaleDetails = req.SaleDetails,
            CustomerId = req.CustomerId,
            Customer = req.Customer
        };
    }
    public static Sale ToEntity(this SaleCreateRequest req, IDbContext context)
    {
        var saleId = Guid.NewGuid().ToString();
        return new Sale()
        {
            Id = saleId,
            EmployeeId = req.EmployeeId,
            Employee = context.Employees.FirstOrDefault(e => e.Id == req.EmployeeId),
            SaleDetails = req.Books.Select(bk => bk.ToEntity(saleId, context)).ToArray(),
            CustomerId = req.CustomerId,
            Customer = context.Customers.FirstOrDefault(c => c.Id == req.CustomerId)
        };
    }

    public static SaleDetail ToEntity(this SaleBookCreateRepuest req, string saleId, IDbContext context)
    {
        return new SaleDetail
        {
            Amount = req.Amount,
            Quantity = req.Quantity,
            BookId = req.BookId,
            SaleId = saleId,
            Book = context.Books.FirstOrDefault(x => x.Id == req.BookId),
            Sale = context.Sales.FirstOrDefault(x => x.Id == saleId)
        };
    }

}
