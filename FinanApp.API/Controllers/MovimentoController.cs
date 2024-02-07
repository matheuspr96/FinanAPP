using FinanApp.Dominio.Entidades;
using FinanApp.Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;


namespace FinanApp.WebAPI.Controllers
{
    [ApiController]
    public class MovimentoController : Controller
    {
        private readonly IMovimentoRepository _movimentoRepository;
        public MovimentoController(IMovimentoRepository movimentoRepository)
        {
            _movimentoRepository = movimentoRepository;
        }

        [HttpGet]
        [Route("api/Movimento")]
        public IActionResult Get()
        {
            try
            {
                return Ok(_movimentoRepository.ObterTodos());
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
        [Route("api/Movimento/{Id}")]
        public IActionResult GetAll(int Id)
        {
            try
            {
                return Ok(_movimentoRepository.ObterPorId(Id));
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
        [Route("api/Movimento")]
        public IActionResult Post([FromBody] MovimentacaoFinanceira model)
        {
            try
            {
                _movimentoRepository.Adicionar(model);
                return Created("Movimento", model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("api/Movimento")]
        public IActionResult Put([FromBody] MovimentacaoFinanceira model)
        {
            _movimentoRepository.Atualizar(model);
            return Ok();
        }
    }
}
