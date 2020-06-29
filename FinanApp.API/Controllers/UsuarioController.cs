using FinanApp.Dominio.Entidades;
using FinanApp.Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;

namespace FinanApp.WebAPI.Controllers
{
    [ApiController]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet]
        [Route("api/Usuario")]
        public IActionResult Get()
        {
            try
            {
                return Ok(_usuarioRepository.ObterTodos());
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
        [Route("api/Usuario/{Id}")]
        public IActionResult GetAll(int Id)
        {
            try
            {
                return Ok(_usuarioRepository.ObterPorId(Id));
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
        [Route("api/Usuario")]
        public IActionResult Post([FromBody] Usuario model)
        {
            try
            {
                _usuarioRepository.Adicionar(model);
                return Created("usuario",model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("api/Usuario")]
        public IActionResult Put([FromBody] Usuario model)
        {
            _usuarioRepository.Atualizar(model);
            return Ok();
        }

    }
}
