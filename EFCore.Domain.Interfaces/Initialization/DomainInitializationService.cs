using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCore.Domain.Core.Interfaces;
using EFCore.Infrastructure.Interfaces.Context;
namespace EFCore.Domain.Interfaces.Initialization
{
    public class DomainInitializationService: IDomainInitializationService
    {
        private readonly IMyContextInitialization _InitializationService;

        public DomainInitializationService(IMyContextInitialization InitializationService)
        {
            _InitializationService = InitializationService;
            
        }

        public void Initialization()
        {
            _InitializationService.Initialize();
        }
    
    }
}
