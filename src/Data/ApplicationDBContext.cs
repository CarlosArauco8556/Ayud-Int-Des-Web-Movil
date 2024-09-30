using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using api.src.Models;

namespace api.src.Data
{
    public class ApplicationDBContext(DbContextOptions dbContextOptions) : DbContext(dbContextOptions)
    {
        public DbSet <User> Users {get; set; } = null!;
        public DbSet <Product> Products {get; set; } = null!;
        public DbSet <Role> Roles {get; set; } = null!;
    }
}