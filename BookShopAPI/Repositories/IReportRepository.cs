using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookShopAPI.Models;

namespace BookShopAPI.Repositories;

public interface IReportRepository
{
    IQueryable<Report> GetQueryable();

    Report? GetById(string id);
}
