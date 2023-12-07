// using BookShop.Contracts;
// using BookShopAPI.Extensions;
// using BookShopAPI.Models;
// using BookShopAPI.Models.Requests;
// using BookShopAPI.Models.Responses;
// using BookShopAPI.Repositories;

// namespace BookShopAPI.Services.Impl;

// public class ProductService : IProductService
// {
//     private readonly IProductRepository _productRepository;
//     private readonly IDbContext _dbContext;
//     public ProductService(
//         IProductRepository repo,
//         IDbContext context
//     )
//     {
//         _productRepository = repo;
//         _dbContext = context;
//     }

//     // public Result<List<string?>> Initialize()
//     // {
//     //     if (_repo.DbContext.Products.Any()) return new();
//     //     var reqs = new List<ProductCreateReq>()
//     //     {
//     //         new()
//     //         {
//     //             Code = "PRD001",
//     //             Name = "Coca",
//     //             Category= "Food"
//     //         },
//     //         new()
//     //         {
//     //             Code = "PRD002",
//     //             Name = "Dream 125",
//     //             Category= "Vehicle"
//     //         },
//     //         new()
//     //         {
//     //             Code = "PRD003",
//     //             Name = "TShirt-SEA game 2023",
//     //             Category= "Cloth"
//     //         }
//     //     };
//     //     var result = reqs.Select(x => Create(x).Data).ToList();
//     //     return Result<List<string?>>.Success(result);
//     // }

//     public Response<bool> Exist(string key)
//     {
//         var result = _productRepository
//                     .GetQueryable()
//                     .Any(
//                         x => x.Id == key
//                         || x.Code.ToLower() == key.ToLower()
//                     );
//         return Response<bool>.Success(result);
//     }

//     public ProductResponse Create(ProductCreateRequest req)
//     {
//         if (Exist(req.Code).Data)
//         {
//             throw new Exception($"The product with the code, {req.Code}, does already exist");
//         }

//         Product entity = req.ToEntity();

//         try
//         {
//             _productRepository.Create(entity);
//             _dbContext.SaveChanges();
//             return entity.ToResponse();
//         }
//         catch (Exception ex)
//         {
//            throw new Exception(ex.Message);
//         }
//     }


//     public List<ProductResponse> GetAll()
//     {
//         return _productRepository
//             .GetAll()
//             .Select(p => p.ToResponse())
//             .ToList();
//     }

//     public ProductResponse? Read(string key)
//     {
//         throw new NotImplementedException();
//     }

//     public bool Update(ProductUpdateRequest req)
//     {
//         throw new NotImplementedException();
//     }

//     public bool Delete(string id)
//     {
//         throw new NotImplementedException();
//     }

//     // public Result<List<ProductResponse>> ReadAll()
//     // {
//     //     var result = _repo.GetQueryable().Select(x => x.ToResponse()).ToList();
//     //     return Result<List<ProductResponse>>.Success(result);
//     // }
//     // public Result<ProductResponse?> Read(string key)
//     // {
//     //     var entity = _repo.GetQueryable().FirstOrDefault(x => x.Id == key || x.Code.ToLower() == key.ToLower());
//     //     return Result<ProductResponse?>.Success(entity?.ToResponse());
//     // }

//     // public Result<string?> Update(ProductUpdateReq req)
//     // {
//     //     var found = _repo.GetQueryable().FirstOrDefault(x => (x.Id == req.Key)
//     //                                                       || (x.Code.ToLower() == req.Key.ToLower()));
//     //     if (found == null)
//     //         return Result<string?>.Fail($"No product with id/code, {req.Key}");
//     //     var entity = found.Clone();
//     //     entity.Copy(req);
//     //     try
//     //     {
//     //         var result = _repo.Update(entity);
//     //         return result == true ? Result<string?>.Success(entity.Id, "Successfully updated")
//     //                 : Result<string?>.Fail($"Failed to update product with id/code, {req.Key}");
//     //     }
//     //     catch (Exception ex)
//     //     {
//     //         return Result<string?>.Fail(ex.Message);
//     //     }
//     // }
//     // public Result<string?> Delete(string key)
//     // {
//     //     var found = _repo.GetQueryable().FirstOrDefault(x => (x.Id == key)
//     //                                                       || (x.Code.ToLower() == key.ToLower()));
//     //     if (found == null)
//     //         return Result<string?>.Fail($"No product with id/code, {key}");
//     //     try
//     //     {
//     //         var result = _repo.Delete(found.Id);
//     //         return result == true ? Result<string?>.Success(found.Id, "Successfully deleted")
//     //                 : Result<string?>.Fail($"Failed to delete product with id/code, {key}");
//     //     }
//     //     catch (Exception ex)
//     //     {
//     //         return Result<string?>.Fail(ex.Message);
//     //     }
//     // }
// }