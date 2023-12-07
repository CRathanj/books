using System.Net;
using BookShop.Contracts;
using BookShopAPI.Extensions;
using BookShopAPI.Models;
using BookShopAPI.Models.Requests;
using BookShopAPI.Models.Responses;
using BookShopAPI.Repositories;

namespace BookShopAPI.Services.Impl
{
    public class SaleService : ISaleService
    {
        private readonly ISaleRepository _saleRepository;
        private readonly IDbContext _context;
        public SaleService(ISaleRepository saleRepository, IDbContext context)
        {
            _saleRepository = saleRepository;
            _context = context;
        }
        public Response<SaleResponse> Create(SaleCreateRequest req)
        {
            // var found = _saleRepository.GetByISBN(req.ISBN);
            // if (found != null)
            // {
            //     return Response<SaleResponse>.Fail($"The book with the ISBN, {req.ISBN}, does already exist", HttpStatusCode.Conflict);
            // }

            Sale entity = req.ToEntity(_context);
            try
            {
                _saleRepository.Create(entity);
                return Response<SaleResponse>.Success(entity.ToResponse(), "Successfully created", HttpStatusCode.Created);
            }
            catch (Exception)
            {
                return Response<SaleResponse>.Fail("Server internal error.", HttpStatusCode.InternalServerError);
            }
        }

        public Response<SaleResponse> Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Response<List<SaleResponse>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Response<SaleResponse> Update(SaleUpdateRequest req)
        {
            throw new NotImplementedException();
        }
    }
}