using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace asp.net_core_api.Controllers
{


    [ApiController]
    [Route("[controller]")]
    public class UsersController : Controller
    {
        public static List<string> lista = new List<string> { "Antonio", "Pepe", "Juan", "Vicente", "Victor", "Pedro" };


        [HttpGet]
        public ActionResult Get(string id)
        {

            try
            {
                return Ok(lista);
            }
            catch (ArgumentException e)
            {
                return BadRequest(e);
            }
        }


        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            try
            {
                return Ok(lista[id]);
            }
            catch (ArgumentException e)
            {
                return BadRequest(e);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post()
        {
            try
            {
                string name = "";
                using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
                {
                    name = await reader.ReadToEndAsync();
                }
                User user = new User();
                var nameUs = JsonConvert.DeserializeObject<User>(name);

                lista.Add(nameUs.name);
                return Ok(lista);
            }
            catch (ArgumentException e)
            {
                return BadRequest(e);
            }
        }



        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id)
        {
            try
            {
                string name = "";
                using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
                {
                    name = await reader.ReadToEndAsync();
                }
                User user = new User();
                var nameUs = JsonConvert.DeserializeObject<User>(name);
                lista[id] = nameUs.name;
                return Ok(lista);
            }
            catch (ArgumentException e)
            {
                return BadRequest(e);
            }
        }


        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                lista.RemoveAt(id);
                return Ok(lista);
            }
            catch (ArgumentException e)
            {
                return BadRequest(e);
            }
        }












    }








}
