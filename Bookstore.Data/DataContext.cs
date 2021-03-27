﻿using Bookstore.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore.Data
{
    public class DataContext : IdentityDbContext<IdentityUser>
    {
        public DataContext(DbContextOptions options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region Category
            modelBuilder.Entity<Category>().HasData
                (
                    new Category { Id = 1, Name = "Fiction" },
                    new Category { Id = 2, Name = "Action" },
                    new Category { Id = 3, Name = "Crime" },
                    new Category { Id = 4, Name = "Adventure" },
                    new Category { Id = 5, Name = "Drama" },
                    new Category { Id = 6, Name = "Fantasy" },
                    new Category { Id = 7, Name = "Thriller" },
                    new Category { Id = 8, Name = "General" },
                    new Category { Id = 9, Name = "Horror" },
                    new Category { Id = 10, Name = "Comedy" },
                    new Category { Id = 11, Name = "Uncategorised" }
                );
            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }

    // *** have to tell the datacontextclass about our models
    // tuka treba da kazime ustvari koi entity modeli ke ni bidat tabelite
    // ------
    // ------ ova se tabelite




    //so ova metodce pri samoto pustanje na app ke se izvrsi ova metodce

    //ova ke ni bide mn potrebno za kreiranje na tabelite



    //nadole ke imame data seeding
}
