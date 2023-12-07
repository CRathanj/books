using System.Net;
using BookShopAPI.Extensions;
using BookShopAPI.Models;
using BookShopAPI.Models.Requests;
using BookShopAPI.Models.Responses;
using BookShopAPI.Repositories;

namespace BookShopAPI.Services.Impl
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public Response<EmployeeResponse> Create(EmployeeCreateRequest req)
        {
            var found = _employeeRepository.GetById(req.Name,req.Contact);
        if (found != null)
        {
            return Response<EmployeeResponse>.Fail($"The customer with the Name, {req.Name} contact, {req.Contact}, does already exist", HttpStatusCode.Conflict);
        }

        Employee entity = req.ToEntity();
        try
        {
            _employeeRepository.Create(entity);
            return Response<EmployeeResponse>.Success(entity.ToResponse(), "Successfully created", HttpStatusCode.Created);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return Response<EmployeeResponse>.Fail("Server internal error.", HttpStatusCode.InternalServerError);
        }
        }

        public Response<EmployeeResponse> Delete(string id)
        {
            var found = _employeeRepository.GetById(id);
        if (found == null)
            return Response<EmployeeResponse>.Fail($"No product with id, {id}");
        try
        {
            var succeed = _employeeRepository.Delete(found);
            if (!succeed)
            {
                return Response<EmployeeResponse>.Fail($"Failed to delete product with id, {id}", HttpStatusCode.BadRequest);
            }

            return Response<EmployeeResponse>.Success(null, "Successfully deleted");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return Response<EmployeeResponse>.Fail("Server internal error.", HttpStatusCode.InternalServerError);
        }
        }

        public Response<List<EmployeeResponse>> GetAll()
        {
            var result = _employeeRepository.GetAll().Select(x => x.ToResponse()).ToList();
        return Response<List<EmployeeResponse>>.Success(result);
        }

        public Response<EmployeeResponse> Update(EmployeeUpdateRequest req)
        {
            var entity = _employeeRepository.GetById(req.Id);
        if (entity == null)
        {
            return Response<EmployeeResponse>.Fail($"No book with id, {req.Id}");
        }
        var found2 = _employeeRepository.GetById(req.Id);
        if (found2 != null && entity.Id != found2.Id)
        {
            return Response<EmployeeResponse>.Fail($"The book with the ISBN, {req.Id}, does already exist", HttpStatusCode.BadRequest);
        }

        entity.Copy(req);
        try
        {
            var succeed = _employeeRepository.Update(entity);
            if (!succeed)
            {
                return Response<EmployeeResponse>.Fail($"Failed to update product with id, {req.Id}", HttpStatusCode.BadRequest);
            }

            return Response<EmployeeResponse>.Success(entity.ToResponse(), "Successfully updated");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return Response<EmployeeResponse>.Fail("Server internal error.", HttpStatusCode.InternalServerError);
        }
        }
    }
}