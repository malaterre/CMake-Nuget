using System;
using Microsoft.Extensions.Logging;

namespace ClassLibrary
{
    public interface IClass2
    {
    }
    public class Class2 : IClass2
    {
        private readonly ILogger<Class2> _logger;
        public Class2(ILogger<Class2> logger)
        {
            _logger = logger;
        }
    }

}
