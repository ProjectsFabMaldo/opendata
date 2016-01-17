using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplicationOpenData.Models
{
    public class AgendaEventos
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public DateTime fecha { get; set; }
        public string lugar { get; set; }
    }

    class AgendaEventosDBContext : DbContext
    {
        public DbSet<AgendaEventos> AgendaEventos { get; set; }
    }
}