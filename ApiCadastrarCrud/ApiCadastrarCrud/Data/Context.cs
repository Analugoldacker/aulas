using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;
using ApiCadastrarCrud.Entidades;

namespace ApiCadastrarCrud.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)  : base(options)   { }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}
