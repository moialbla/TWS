using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Core.Controller;
using TWSServerApiRest.Services.Interfaces;

namespace TWSServerApiRest.Controllers
{
    [Route("api/app")]
    public class AppController : CoreController
    {
        IConfigurationServices ConfigurationServices;

        public AppController(IConfigurationServices ConfigurationServices) {
            this.ConfigurationServices = ConfigurationServices;
        }

        [HttpGet]
        [Produces("text/html")]
        public async Task<string> GetAsync()
        {
            return await ConfigurationServices.Get();
        }
    }
}
