using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplicationOpenData.Models
{
    public class Wifi
    {
        public int id { get; set; }
        public string centro { get; set; }
        public string descripcion { get; set; }
    }

    class WifiDBContext : DbContext
    {
        public DbSet<Wifi> AgendaEventos { get; set; }
    }
}