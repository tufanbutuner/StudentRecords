﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using StudentRecords.API.Models;

namespace StudentRecords.API.Data
{
    public interface IDbContext
    {
        DbSet<Student> Students { get; }
        DbSet<Degree> Degrees { get; }
        DbSet<Modules> Modules { get; }
        DbSet<Address> Address { get; }
        EntityEntry Attach(object entity);
        EntityEntry Entry(object entity);

        Task SaveChangesAsync();
    }
}
