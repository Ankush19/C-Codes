using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class PersonalController : ApiController
    {
        // GET: Personal
        public static List<Info> entries = new List<Info>()
            {
                new Info { MyID=1,Name="Ankush", Age=21 },
                new Info { MyID=2, Name="Anki", Age=20},
                new Info { MyID=3, Name="AnkiD", Age=40},

            };

        public IEnumerable<Info> Get()
        {
            return entries;
        }

        public IHttpActionResult Get(int id)
        {
            var entry = entries.FirstOrDefault((e) => e.MyID == id);
            if (entry == null)
            {
                return NotFound();
            }

            return Ok(entry);

        }

        public IEnumerable<Info> Post([FromBody] Info a)
        {
            entries.Add(a);
            return entries;
        }
    }
}