using ItemInsight.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItemInsight.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Consumer> Consumers { get; }
        IGenericRepository<Producer> Producers { get; }
        IGenericRepository<Product> Products { get; }
        IGenericRepository<Review> Reviews { get; }
        IGenericRepository<Staff> Staffs { get; }
    }
}