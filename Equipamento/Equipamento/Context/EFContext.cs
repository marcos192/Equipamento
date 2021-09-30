using Equipamento.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Equipamento.Context
    {

    public class EFContext : DbContext
        {

        public EFContext() : base("Projeto") { }

            public DbSet<Categoria> categorias { get; set; }
        public DbSet<Fabricante> fabricantes { get; set; }

        }
    }
 