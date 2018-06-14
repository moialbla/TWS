using Core.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TWSServerApiRest.Services.Interfaces;

namespace TWSServerApiRest.Services
{
    [Injectable(InstaceOf = typeof(IConfigurationServices))]
    public class ConfigurationServicesImpl : IConfigurationServices
    {
        Task<string> IConfigurationServices.Get()
        {
            throw new NotImplementedException();
        }
    }
}
