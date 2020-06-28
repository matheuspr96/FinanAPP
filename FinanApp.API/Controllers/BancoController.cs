using FinanApp.Dominio.Entidades;
using FinanApp.Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;


namespace FinanApp.WebAPI.Controllers
{
    [ApiController]
    public class BancoController : Controller
    {
        private readonly IBancoRepository _bancoRepository;
        public BancoController(IBancoRepository bancoRepository)
        {
            _bancoRepository = bancoRepository;
        }

        [HttpGet]
        [Route("api/Banco")]
        public IActionResult Get()
        {
            try
            {
                return Ok(_bancoRepository.ObterTodos());
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
        [Route("api/Banco/{Id}")]
        public IActionResult GetAll(int Id)
        {
            try
            {
                return Ok(_bancoRepository.ObterPorId(Id));
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
        [Route("api/Banco")]
        public IActionResult Post([FromBody] Banco model)
        {
            try
            {
                _bancoRepository.Adicionar(model);
                return Created("Banco", model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("api/Banco")]
        public IActionResult Put([FromBody] Banco model)
        {
            _bancoRepository.Atualizar(model);
            return Ok();
        }
    }
}
