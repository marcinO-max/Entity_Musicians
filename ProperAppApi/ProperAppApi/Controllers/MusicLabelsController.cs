using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProperAppApi.Exceptions;
using ProperAppApi.Services;

namespace ProperAppApi.Controllers
{
    [Route("api/music-labels")]
    [ApiController]
    public class MusicLabelsController : Controller
    {

        private readonly IMusicDbService _dbService;
        public MusicLabelsController(IMusicDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet("{id}")]
        public IActionResult GetMusicLabel(int id)
        {
            try
            {
                var result = _dbService.GetMusicLabel(id);
                return Ok(result);

            }
            catch (MusicLabelNotFoundException exc)
            {
                return NotFound(exc);
            }
        }
    }
}
