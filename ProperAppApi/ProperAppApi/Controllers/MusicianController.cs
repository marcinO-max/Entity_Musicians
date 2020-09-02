using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProperAppApi.Services;

namespace ProperAppApi.Controllers
{
    [Route("api/musician")]
    [ApiController]
    public class MusicianController : Controller
    {
        private readonly IMusicDbService _dbservice;
       public MusicianController(IMusicDbService dbservice)
        {
            _dbservice = dbservice;
        }


        [HttpDelete("{id:int}")]
        public IActionResult RemoveMusician(int id)
        {
            _dbservice.RemoveMusician(id);
            return NoContent();
        }
    }
}
