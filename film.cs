using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace gabrielli.gianmarco._5i.EasyTrain {

    public enum Genere{nient, fantascienza = 10, commedia = 20, documentario = 30, comico = 40, azione = 50};

    public class Film
    {
        public int Filmid{get; set;} 
        public string Titolo{get; set;}
        public int Durata{get; set;}
        public int AnnoProduzione{get; set;}
        public Genere Genere{get; set;}
        public string BreveTrama{get; set;}
    }
}