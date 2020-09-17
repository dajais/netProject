using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BijouWorld.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BijouWorld.Data
{
    public class BijouWorldContext : IdentityDbContext
    {
        public BijouWorldContext (DbContextOptions<BijouWorldContext> options)
            : base(options)
        {
        }
            
        //Cada vez que quiero crear una nueva tabla, creo una nueva Entity Class y creo un nuevo DbSet aca y despues migration.
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }


    }
}
