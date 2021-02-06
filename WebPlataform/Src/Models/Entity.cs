using Microsoft.Extensions.Logging;
using System;

namespace WebPlataform.Src.Models
{
    public abstract class Entity
    {
        //private readonly ILogger _logger;

        public long Id { get; /*private*/ set; }
        public long Code { get; /*private*/ set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; /*private*/ set; }
        public DateTime LastUpdate { get; /*private*/ set; }
        public DateTime InclusionDate { get; /*private*/ set; }

        //protected Entity(ILogger logger)
        //{
        //    _logger = logger;
        //}

        public void Disable()
        {
            IsActive = false;
            LastUpdate = DateTime.Now;
            //_logger.LogTrace($"Desabilitando item codigo {Code}");
        }
    }
}
