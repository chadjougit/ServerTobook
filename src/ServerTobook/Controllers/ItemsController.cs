using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServerTobook.ViewModels;

using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ServerTobook.Controllers
{
    [Route("api/[controller]")]
    public class ItemsController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<ItemViewModel> Get()
        {
           // return new string[] { "item1", "item2" };

            var items = GetSampleItems();

            return items;

        }


        // GET: api/values
        [HttpGet("GetRandom")]
        public IActionResult Getrandom()
        {
          

            var items = GetSampleItems();
            return new JsonResult(items, DefaultJsonSettings);


        }


        [HttpGet("GetRandom/{id}")]
        public IActionResult Getrandom(int id)
        {

            var item = new ItemViewModel()
            {
                Id = id,
                Description = "Getrandom Description",
                Title = "just a fun text"
            };

            return new JsonResult(item, DefaultJsonSettings);

        }


        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }



        //тестовый метод для генерации  итемов 

        private List<ItemViewModel> GetSampleItems(int num = 999)
        {

            List<ItemViewModel> lst = new List<ItemViewModel>();
            for (int id = 1; id <= num; id++)
            {
                lst.Add(new ItemViewModel()
                {
                    Id = id,
                    Description = "simple Description",
                    Title = "just a text"
                }
                    );

            }
            return lst;
        }


        private JsonSerializerSettings DefaultJsonSettings
        {
            get
            {
                return new JsonSerializerSettings()
                {
                    Formatting = Formatting.Indented
                };
            }
        }


    }
}
