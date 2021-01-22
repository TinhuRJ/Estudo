using Estudo.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Produto> Produtos { get; set; }        

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Estudo;Data Source=DESKTOP-2OBH9C3\\SQLEXPRESS");
        }
    }
}
