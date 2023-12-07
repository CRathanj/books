using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookShop.Contracts;
using BookShopAPI.Models.Requests;
using BookShopAPI.Models.Responses;

namespace BookShopAPI.Services
{
    public interface IReportService : IService<ReportResponse, ReportCreateRequest, ReportUpdateRequest>
    {
        
    }
}   