using FinanApp.Dominio.Entidades;
using FinanApp.Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;

namespace FinanApp.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet]
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


        [HttpGet("Id")]
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
        public IActionResult Put([FromBody] Usuario model)
        {
            _usuarioRepository.Atualizar(model);
            return Ok();
        }

        [HttpPost("VerificarUsuario")]
        public IActionResult VerificarUsuario([FromBody] Usuario model)
        {
            try
            {

                var usuario = _usuarioRepository.Obter(model.Email, model.Senha);
                if(usuario != null && model.Email == usuario.Email && model.Senha == usuario.Senha)
                {
                    return Ok(usuario);
                }
                else
                {
                    return BadRequest("Usuário ou senha inválidos!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
