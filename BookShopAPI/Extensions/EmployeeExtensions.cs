using BookShopAPI.Models;
using BookShopAPI.Models.Requests;
using BookShopAPI.Models.Responses;

namespace BookShopAPI.Extensions
{
    public static class EmployeeExtensions
    {
        public static EmployeeResponse ToResponse(this Employee emp)
        {
            return new EmployeeResponse
            {
                Id = emp.Id,
                Name = emp.Name,
                Gender = emp.Gender,
                Position = emp.Position,
                Salary = emp.Salary,
                Contact = emp.Contact.ToString(),
                Address = emp.Address,
                HireDate = emp.HireDate,
                StopDate = emp.StopDate,
                Active = emp.Active
            };
        }
        public static Employee ToEntity(this EmployeeCreateRequest req)
        {
            return new Employee()
            {
                Id = Guid.NewGuid().ToString(),
                Name = req.Name,
                Gender = req.Gender,
                Position = req.Position,
                Salary = req.Salary,
                Contact = req.Contact.ToString(),
                Address = req.Address,
                HireDate = req.HireDate,
                StopDate = req.StopDate,
                Active = req.Active

            };
        }
        public static void Copy(this Employee emp, EmployeeUpdateRequest req)
        {
            emp.Name = req.Name;
            emp.Gender = req.Gender;
            emp.Position = req.Position;
            emp.Salary = req.Salary;
            emp.Contact = req.Contact.ToString();
            emp.Address = req.Address;
            emp.HireDate = req.HireDate;
            emp.StopDate = req.StopDate;
            emp.Active = req.Active;
        }
    }
}