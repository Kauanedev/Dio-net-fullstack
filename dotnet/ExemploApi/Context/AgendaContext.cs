using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExemploApi.Context
{
    public class AgendaContext : DbContext
    {
        // Conexão com o banco de dados
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }

        public DbSet<Contato> Contatos { get; set; }
    }
}