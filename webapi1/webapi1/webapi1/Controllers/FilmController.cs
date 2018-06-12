using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi1.model;

namespace webapi1.Controllers
{
    [Produces("application/json")]
    [Route("api/Film")]
    public class FilmController : Controller
    {
        private List<Film> films = new List<Film>();
        public FilmController()
        {
            CaricaFilm();
        }
        private void CaricaFilm()
        {
            Film Item = new Film();
            Item.title = "pulp fiction";
            Item.id = 1;
            Item.title = "film 1";
            Item.desc = "film 1";
            films.Add(Item);
            Item = new Film();
            Item.title = "il gladiatore";
            Item.id = 2;
            Item.desc = "era laziale";
            films.Add(Item);
        }
            
            // GET: api/Film
        [HttpGet]
        public IEnumerable<Film> Get()
        {
            return films;
        }

        // GET: api/Film/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Film
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Film/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        
    }
}
