using System.Net;
using BookShop.Models;
using BookShop.Models.Requests;
using BookShop.Models.Responses;
using BookShop.Repositories;
using BookShopAPI.Extensions;
using BookShopAPI.Models.Responses;

namespace BookShop.Services.Impl
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }


        public Response<BookResponse> Delete(string id)
        {
            var found = _bookRepository.GetById(id);
            if (found == null)
                return Response<BookResponse>.Fail($"No product with id, {id}");
            try
            {
                var succeed = _bookRepository.Delete(found);
                if (!succeed)
                {
                    return Response<BookResponse>.Fail($"Failed to delete product with id, {id}", HttpStatusCode.BadRequest);
                }

                return Response<BookResponse>.Success(null, "Successfully deleted");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Response<BookResponse>.Fail("Server internal error.", HttpStatusCode.InternalServerError);
            }
        }

        public Response<List<BookResponse>> GetAll()
        {
            return Response<List<BookResponse>>
                .Success([.. _bookRepository
                    .GetAll()
                    .Select(x => x.ToResponse())]
                );
        }

        public Response<BookResponse> Update(BookUpdateRequest req)
        {
            var entity = _bookRepository.GetById(req.Id);
            if (entity == null)
            {
                return Response<BookResponse>.Fail($"No book with id, {req.Id}");
            }
            var found2 = _bookRepository.GetByISBN(req.ISBN);
            if (found2 != null && entity.Id != found2.Id)
            {
                return Response<BookResponse>.Fail($"The book with the ISBN, {req.ISBN}, does already exist", HttpStatusCode.BadRequest);
            }

            entity.Copy(req);
            try
            {
                var succeed = _bookRepository.Update(entity);
                if (!succeed)
                {
                    return Response<BookResponse>.Fail($"Failed to update product with id, {req.Id}", HttpStatusCode.BadRequest);
                }

                return Response<BookResponse>.Success(entity.ToResponse(), "Successfully updated");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Response<BookResponse>.Fail("Server internal error.", HttpStatusCode.InternalServerError);
            }
        }

        public Response<BookResponse> Create(BookCreateRequest req)
        {
            var found = _bookRepository.GetByISBN(req.ISBN);
            if (found != null)
            {
                return Response<BookResponse>.Fail($"The book with the ISBN, {req.ISBN}, does already exist", HttpStatusCode.Conflict);
            }

            Book entity = req.ToEntity();
            try
            {
                _bookRepository.Create(entity);
                return Response<BookResponse>.Success(entity.ToResponse(), "Successfully created", HttpStatusCode.Created);
            }
            catch (Exception)
            {
                return Response<BookResponse>.Fail("Server internal error.", HttpStatusCode.InternalServerError);
            }
        }
    }
}