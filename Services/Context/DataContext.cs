using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using boldapibackend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace boldapibackend.Services.Context;

    public class DataContext : DbContext

    {
            public DataContext(DbContextOptions options) : base(options)
            {
                
            }

            public DbSet<UserModel> UserInfo {get; set;}

            public DbSet<BlogItemModel> BlogInfo {get; set;}
    }
