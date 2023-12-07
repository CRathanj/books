using BookShopAPI.Models;
using BookShopAPI.Models.Requests;
using BookShopAPI.Models.Responses;

namespace BookShopAPI.Extensions;

public static class CustomerExtensions
{
    public static CustomerResponse ToResponse(this Customer cus)
    {
       return new CustomerResponse
        {
            Id = cus.Id,
            Name = cus.Name,
            Contact = cus.Contact.ToString(),
            Address = cus.Address,
        }; 
    }
    public static Customer ToEntity(this CustomerCreateRequest req)
    {
        return new Customer()
        {
            Id = Guid.NewGuid().ToString(),
            Name = req.Name,
            Contact = req.Contact,
            Address = req.Address,
            
        };
    }
    public static void Copy(this Customer bok, CustomerUpdateRequest req)
    {
        bok.Name = req.Name;
        bok.Contact = req.Contact;
        bok.Address = req.Address;
    }
}
