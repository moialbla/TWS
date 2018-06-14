using Domain.Interfaces;
using System;

namespace TWSServerDomain
{
    public class Configuration : IDomainBase
    {
        public Guid Id { get ; set; }
    }
}
