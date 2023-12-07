using BookShop.Contracts;
using BookShopAPI.Models;

namespace BookShopAPI.Repositories.Impl;

public class MemberRepository : IMemberRepository
{
    public readonly IDbContext _context;
    public MemberRepository(IDbContext context)
    {
        _context = context;
    }

    public bool Create(Member entity)
    {
        throw new NotImplementedException();
    }

    public bool Delete(Member entity)
    {
        throw new NotImplementedException();
    }

    public IQueryable<Member> GetAll()
    {
        throw new NotImplementedException();
    }

    public Member? GetById(string key)
    {
        throw new NotImplementedException();
    }

    public bool Update(Member entity)
    {
        throw new NotImplementedException();
    }
}
