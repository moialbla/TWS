using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TWSServerApiRest.Services.Interfaces
{
    public interface IConfigurationServices
    {
        Task<string> Get();
    }
}
