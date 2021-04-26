using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridgeClient.Models
{
    public class AppDBContext : DbContext
    {
        
            public AppDBContext(DbContextOptions<AppDBContext> options)
                : base(options)
            {
                //Database.EnsureCreated();
            }

            public DbSet<Product> Products { get; set; }

      
    }
}
