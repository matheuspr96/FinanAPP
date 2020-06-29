using FinanApp.Dominio.Entidades;
using FinanApp.Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;


namespace FinanApp.WebAPI.Controllers
{
    [ApiController]
    public class ReceitaController : Controller
    {
        private readonly IReceitaRepository _receitaRepository;
        public ReceitaController(IReceitaRepository receitaRepository)
        {
            _receitaRepository = receitaRepository;
        }

        [HttpGet]
        [Route("api/Receita")]
        public IActionResult Get()
        {
            try
            {
                return Ok(_receitaRepository.ObterTodos());
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
        [Route("api/Receita/{Id}")]
        public IActionResult GetAll(int Id)
        {
            try
            {
                return Ok(_receitaRepository.ObterPorId(Id));
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
        [Route("api/Receita")]
        public IActionResult Post([FromBody] Receita model)
        {
            try
            {
                _receitaRepository.Adicionar(model);
                return Created("Receita", model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("api/Receita")]
        public IActionResult Put([FromBody] Receita model)
        {
            _receitaRepository.Atualizar(model);
            return Ok();
        }
    }
}
