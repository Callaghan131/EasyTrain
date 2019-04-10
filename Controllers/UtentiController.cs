using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace gabrielli.gianmarco._5i.EasyTrain.Controllers
{
    [Route("api/[controller]")]
    public class UtentiController : Controller
    {
        easyTrainContex db{get;}
        public UtentiController(){
            db = new easyTrainContex();
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<Utente> Get()
        {
            return db.utenti.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Utente Get(int id)
        {
            return db.utenti.Find(id);
        }

        // POST api/values
        [HttpPost]
        public int Post([FromBody]Utente value)
        {
            if(value != null){
                db.utenti.Add(value);
                //db.utenti.Add(new Utente{Nome="Alessandro", Cognome="Carichini"});
                db.SaveChanges();
                return 1;
            }
            return 0;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Utente value)
        {
            if(value!=null){
                Utente u=db.utenti.Find(id);
                if(u!=null){
                    u.Nome=value.Nome;
                    u.Cognome=value.Cognome;
                    db.SaveChanges();
                }
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Utente u = db.utenti.Find(id);
            if(u != null)
            {
                db.utenti.Remove(u);
                db.SaveChanges();
            }
        }
    }
}
