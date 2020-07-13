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
    public class TramiteDivorcioController: ControllerBase
    {
        private readonly ITramiteDivorcioService _service;

        public TramiteDivorcioController(ITramiteDivorcioService service)
        {
            _service = service;
        }

        [HttpPost]

        public IActionResult post(RegistroTramiteDto tramite)
        {
            try
            {
                return new JsonResult(_service.createTramiteDivorcio(tramite)) { StatusCode = 201 };
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
                return new JsonResult(_service.GetTramites()) { StatusCode = 201 };
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
