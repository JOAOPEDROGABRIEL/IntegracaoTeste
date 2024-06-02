using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UsuarioAPI.Entities;

namespace UsuarioAPI.Context
{
    public class UsuarioContext : DbContext
    {
        public UsuarioContext(DbContextOptions<UsuarioContext> options) : base(options)
        {

        } 
        public DbSet<UsuarioItem> Usuario { get; set; }
    }
}