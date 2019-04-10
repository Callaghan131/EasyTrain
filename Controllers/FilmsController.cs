using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace gabrielli.gianmarco._5i.EasyTrain.Controllers
{
    [Route("api/[controller]")]
    public class FilmsController : Controller
    {
        easyTrainContex db{get;}
        public FilmsController(){
            db = new easyTrainContex();
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<Film> Get()
        {
            if(db.films.Count() == 0){
                db.films.Add(new Film{Titolo = "BladeRunner", Durata=90, AnnoProduzione=1980, Genere = Genere.fantascienza, BreveTrama="Uomo che cerca bambocci che hanno visto cose che noi umani non possiamo immaginare..."});
                db.SaveChanges();
            }
            return db.films.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Film Get(int id)
        {
            return db.films.Find(id);
        }

        // POST api/values
        [HttpPost]
        public int Post([FromBody]Film value)
        {
            if(value != null){
                db.films.Add(value);
                //db.utenti.Add(new Utente{Nome="Gianmarco", Cognome="Gabrielli"});
                db.SaveChanges();
                return 1;
            }
            return 0;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Film value)
        {
            if(value!=null){
                Film f=db.films.Find(id);
                if(f!=null){
                    f.Titolo=value.Titolo;
                    f.Durata=value.Durata;
                    f.AnnoProduzione=value.AnnoProduzione;
                    f.Genere=value.Genere;
                    f.BreveTrama=value.BreveTrama;
                    db.SaveChanges();
                }
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Film f = db.films.Find(id);
            if(f != null)
            {
                db.films.Remove(f);
                db.SaveChanges();
            }
        }
    }
}
