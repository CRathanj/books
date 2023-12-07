using BookShopAPI.Models;
using BookShopAPI.Models.Responses;

namespace BookShopAPI.Extensions;

public static class MemberExtensions
{
    public static MemberResponse ToResponse(this Member mb)
    {
        return new MemberResponse
        {
            // Id = mb.Id,
            // Name = mb.Name,
            // Contact = mb.Contact.ToString(),
            // Address = mb.Address,

        };
    }

}
