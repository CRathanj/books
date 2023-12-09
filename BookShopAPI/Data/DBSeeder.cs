using Bogus;
using Bogus.DataSets;
using BookShopAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Data;

public static class DbSeeder
{
    public static void Seed(BookShopDbContext context)
    {
        context.Database.Migrate();
        if (context.Employees.Any())
        {
            return;
        }
        Randomizer.Seed = new Random(8675309);

        // insert dummy data
        context.AddRange(GetDummyEmployeeList());
        context.SaveChanges();
    }

    private static List<Employee> GetDummyEmployeeList()
    {
        var employees = new Faker<Employee>()
            .RuleFor(e => e.Id, f => Guid.NewGuid().ToString())
            .RuleFor(e => e.Name, f => f.Person.FullName)
            .RuleFor(e => e.Gender, f =>  f.PickRandom<Name.Gender>().ToString())
            .RuleFor(e => e.Position, f => f.Name.JobTitle())
            .RuleFor(e => e.Salary, f => f.Finance.Amount(300, 1500))
            .RuleFor(e => e.Address, f => f.Address.FullAddress())
            .RuleFor(e => e.Contact, f => f.Phone.PhoneNumber("(###)-###-####"))
            .RuleFor(e => e.HireDate, f => f.Date.Past(1, DateTime.Now.AddYears(-5)))
            .RuleFor(e => e.Active, f => f.Random.Bool(40));

        return employees.Generate(50);
    }
}