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
    public class PropuestaController: ControllerBase
    {
        private readonly IPropuestaService _service;

        public PropuestaController(IPropuestaService service)
        {
            _service = service;
        }

        [HttpPost]

        public IActionResult post(PropuestaDto propuesta)
        {
            try
            {
                return new JsonResult(_service.CreatePropuesta(propuesta)) { StatusCode = 201 };
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
