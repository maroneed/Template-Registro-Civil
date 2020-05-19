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
    public class SolicitudTipoController: ControllerBase
    {
        private readonly ISolicitudTipoService _service;

        public SolicitudTipoController(ISolicitudTipoService service)
        {
            _service = service;
        }

        [HttpPost]

        public IActionResult post(SolicitudTipoDto solicitudTipo)
        {
            try
            {
                return new JsonResult(_service.CreateSolicitudTipo(solicitudTipo)) { StatusCode = 201 };
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
                return new JsonResult(_service.GetSolicitudTipo()) { StatusCode = 201 };
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
