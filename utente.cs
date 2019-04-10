using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace gabrielli.gianmarco._5i.EasyTrain{
    
    public class Utente
    {
        public int Utenteid{get; set;}
        public string Nome{get; set;}
        public string Cognome{get; set;}
    }

    public class easyTrainContex : DbContext
    {
        public DbSet<Utente> utenti{get;set;}
        public DbSet<Film> films{get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=utente.db");
        }
    }
}