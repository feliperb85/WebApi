using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Models
{
    public class Db : DbContext
    {

        public Db(DbContextOptions<Db> options) : base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //=> optionsBuilder
        //    .UseMySql(@"Server=localhost;database=webapi;uid=root;pwd=root;");

        public DbSet<User> Users { get; set; }

    }
}
