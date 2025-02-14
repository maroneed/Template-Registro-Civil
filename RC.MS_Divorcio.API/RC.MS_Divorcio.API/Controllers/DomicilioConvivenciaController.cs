﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RC.MS_Divorcio.Application.Services;
using RC.MS_Divorcio.Domain.Entities;
using RC.MS_Divorcio.Domain.DTOs;
using RC.MS_Divorcio.Domain.Queries;

namespace RC.MS_Divorcio.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class DomicilioConvivenciaController: ControllerBase
    {
        private readonly IDomicilioConvivenciaService _service;
        private readonly IDomicilioConvivenciaQuery _query;


        public DomicilioConvivenciaController(IDomicilioConvivenciaService service)
        {
            _service = service;
        }

        [HttpPost]

        public IActionResult post(DomicilioConvivenciaDto domicilio)
        {
            try
            {
                return new JsonResult(_service.createDomicilioConvivencia(domicilio)) { StatusCode = 201 };
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
                return new JsonResult(_service.GetDomicilios()) { StatusCode = 201 };
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
