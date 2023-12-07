using BookShopAPI.Models.Responses;

namespace BookShop.Contracts;
public interface IService<TR, TC, TU>
    where TR: IResponse         //=> Template Response ,... .
    where TC : ICreateRequest
    where TU: IUpdateRequest
{
    public Response<TR> Create(TC req);
    public Response<List<TR>> GetAll();
    public Response<TR> Update(TU req);
    public Response<TR> Delete(string id);
}