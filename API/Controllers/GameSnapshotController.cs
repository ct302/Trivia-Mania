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
    [Route("api/[controller]")]
    [ApiController]
    public class GameSnapshotController : GenericController<GameSnapshot>
    {
        
        public GameSnapshotController(IGenericService<GameSnapshot> genericService):base(genericService)
        {



        }
        
        
 

    }



}
