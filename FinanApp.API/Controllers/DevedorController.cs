using FinanApp.Dominio.Entidades;
using FinanApp.Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;


namespace FinanApp.WebAPI.Controllers
{
    [ApiController]
    public class DevedorController : Controller
    {
        private readonly IDevedorRepository _devedorRepository;
        public DevedorController(IDevedorRepository devedorRepository)
        {
            _devedorRepository = devedorRepository;
        }

        [HttpGet]
        [Route("api/Devedor")]
        public IActionResult Get()
        {
            try
            {
                return Ok(_devedorRepository.ObterTodos());
                //if (true)
                //{
                //    return BadRequest();
                //}
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpGet]
        [Route("api/Devedor/{Id}")]
        public IActionResult GetAll(int Id)
        {
            try
            {
                return Ok(_devedorRepository.ObterPorId(Id));
                //if (true)
                //{
                //    return BadRequest();
                //}
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("api/Devedor")]
        public IActionResult Post([FromBody] Devedor model)
        {
            try
            {
                _devedorRepository.Adicionar(model);
                return Created("Devedor", model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("api/Devedor")]
        public IActionResult Put([FromBody] Devedor model)
        {
            _devedorRepository.Atualizar(model);
            return Ok();
        }
    }
}
