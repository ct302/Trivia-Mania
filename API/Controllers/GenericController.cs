using API.IService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trivia_App.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GenericController<T> : Controller where T : class
    {


        private IGenericService<T> _genericService;

        public GenericController(IGenericService<T> genericService)
        {
            _genericService = genericService;

        }


        // GET: api/<GenericController>
        [HttpGet]
        public List<T> Get()
        {
            return _genericService.GetAll();


        }

        // GET api/<GenericController>/5
        [HttpGet("{UserID}")]
        public T Get(string UserID)
        {
            return _genericService.GetById(UserID);

        }

        // POST api/<GenericController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<GenericController>/5
        [HttpPut("{UserID}")]
        public List<T> Put(string UserID, [FromBody] T gameSnapshot)
        {

            //Original Entry
            var gameToUpdate = _genericService.GetById(UserID);

           

            return  _genericService.Insert(gameSnapshot);

            
            
            

        }

        // DELETE api/<GenericController>/5
        [HttpDelete("{UserID}")]
        public List<T> Delete(string UserID)
        {
            return _genericService.Delete(UserID);

        }

      
    }
}
