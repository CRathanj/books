using System.Net;
using BookShopAPI.Extensions;
using BookShopAPI.Models;
using BookShopAPI.Models.Requests;
using BookShopAPI.Models.Responses;
using BookShopAPI.Repositories;

namespace BookShopAPI.Services.Impl;

public class CustomerService : ICustomerService
{
    private readonly ICustomerRepository _customerRepository;
    public CustomerService(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }
    public Response<CustomerResponse> Create(CustomerCreateRequest req)
    {
        var found = _customerRepository.GetByNameAndContact(req.Name, req.Contact);
        if (found != null)
        {
            return Response<CustomerResponse>.Fail($"The customer with the Name, {req.Name} contact, {req.Contact}, does already exist", HttpStatusCode.Conflict);
        }

        Customer entity = req.ToEntity();
        try
        {
            _customerRepository.Create(entity);
            return Response<CustomerResponse>.Success(entity.ToResponse(), "Successfully created", HttpStatusCode.Created);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return Response<CustomerResponse>.Fail("Server internal error.", HttpStatusCode.InternalServerError);
        }
    }

    public Response<CustomerResponse> Delete(string id)
    {
        var found = _customerRepository.GetById(id);
        if (found == null)
            return Response<CustomerResponse>.Fail($"No product with id, {id}");
        try
        {
            var succeed = _customerRepository.Delete(found);
            if (!succeed)
            {
                return Response<CustomerResponse>.Fail($"Failed to delete product with id, {id}", HttpStatusCode.BadRequest);
            }

            return Response<CustomerResponse>.Success(null, "Successfully deleted");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return Response<CustomerResponse>.Fail("Server internal error.", HttpStatusCode.InternalServerError);
        }
    }

    public Response<List<CustomerResponse>> GetAll()
    {
        var result = _customerRepository.GetAll().Select(x => x.ToResponse()).ToList();
        return Response<List<CustomerResponse>>.Success(result);
    }

    public Response<CustomerResponse> Update(CustomerUpdateRequest req)
    {
        var entity = _customerRepository.GetById(req.Id);
        if (entity == null)
        {
            return Response<CustomerResponse>.Fail($"No book with id, {req.Id}");
        }
        var found2 = _customerRepository.GetById(req.Id);
        if (found2 != null && entity.Id != found2.Id)
        {
            return Response<CustomerResponse>.Fail($"The book with the ISBN, {req.Id}, does already exist", HttpStatusCode.BadRequest);
        }

        entity.Copy(req);
        try
        {
            var succeed = _customerRepository.Update(entity);
            if (!succeed)
            {
                return Response<CustomerResponse>.Fail($"Failed to update product with id, {req.Id}", HttpStatusCode.BadRequest);
            }

            return Response<CustomerResponse>.Success(entity.ToResponse(), "Successfully updated");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return Response<CustomerResponse>.Fail("Server internal error.", HttpStatusCode.InternalServerError);
        }
    }
}
