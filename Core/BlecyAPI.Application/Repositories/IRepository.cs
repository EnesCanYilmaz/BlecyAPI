using System;
using BlecyAPI.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace BlecyAPI.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Table { get; }
    }
}

