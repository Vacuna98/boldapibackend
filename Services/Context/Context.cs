using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using boldapibackend.Models;
using Microsoft.EntityFrameworkCore;

namespace boldapibackend.Services.Context;

    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
            
        }

        //This will create our tables
        public DbSet<UserModel> UserInfo {get; set;} // UserInfo is table name

        public DbSet<BlogItemModel> BlogInfo {get; set;}

    }
