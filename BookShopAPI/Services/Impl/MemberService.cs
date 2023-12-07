using BookShopAPI.Models.Requests;
using BookShopAPI.Models.Responses;
using BookShopAPI.Repositories;

namespace BookShopAPI.Services.Impl;

public class MemberService : IMemberService
{
    private readonly IMemberRepository _memberRepository;

    public MemberService(IMemberRepository memberRepository)
    {
        _memberRepository = memberRepository;
    }

    public Response<MemberResponse> Create(MemberCreateRequest req)
    {
        throw new NotImplementedException();
    }

    public Response<MemberResponse> Delete(string id)
    {
        throw new NotImplementedException();
    }

    public Response<List<MemberResponse>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Response<MemberResponse> Update(MemberUpdateRequest req)
    {
        throw new NotImplementedException();
    }
}
