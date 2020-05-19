using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RC.MS_Divorcio.Application.Services;
using RC.MS_Divorcio.Domain.Entities;
using RC.MS_Divorcio.Domain.DTOs;

namespace RC.MS_Divorcio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleHijosController: ControllerBase
    {
        private readonly IDetalleHijosService _service;

        public DetalleHijosController(IDetalleHijosService service)
        {
            _service = service;
        }

        [HttpPost]

        public IActionResult post(DetalleHijosDto detalleHijos)
        {
            try
            {
                return new JsonResult(_service.createDetalleHijos(detalleHijos)) { StatusCode = 201 };
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        public IActionResult get()
        {
            try
            {
                return new JsonResult(_service.GetDetalleHijos()) { StatusCode = 201 };
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
