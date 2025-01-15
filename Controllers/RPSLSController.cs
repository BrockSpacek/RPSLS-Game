using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RPSLS_Game.services;

namespace RPSLS_Game.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RPSLSController : ControllerBase
    {
        private readonly RSPLSServices _rsplsServices;

        public RPSLSController(RSPLSServices rSPLSServices){
            _rsplsServices = rSPLSServices;
        }

        [HttpGet]
        [Route("GetComputerResponse")]

        public string RandomComputerChoice(){
            return _rsplsServices.RandomComputerChoice();
        }
    }
}