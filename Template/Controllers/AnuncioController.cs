using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template.Application.Interfaces;
using Template.Application.ViewModels;

namespace Template.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnuncioController : Controller
    {
        private readonly IAnuncioService _anuncioService;
        
        public AnuncioController(IAnuncioService anuncioService)
        {
            _anuncioService = anuncioService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(this._anuncioService.Get());
        }

        [HttpGet("{id}")]
        public IActionResult GetbyId(int id)
        {
            return Ok(this._anuncioService.GetbyId(id));
        }

        [HttpPost]
        public IActionResult Post(AnuncioViewModel anuncioViewModel)
        {
            return Ok(this._anuncioService.Post(anuncioViewModel));
        }

        [HttpPut]
        public IActionResult Put(AnuncioViewModel anuncioViewModel)
        {
            return Ok(this._anuncioService.Put(anuncioViewModel));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(this._anuncioService.Delete(id));
        }
    }
}
