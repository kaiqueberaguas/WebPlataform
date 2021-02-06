using Microsoft.Extensions.Logging;

namespace WebPlataform.Src.Models
{
    public class Product : Entity
    {
        //private readonly ILogger _logger;
        public decimal Price { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }

        //public Product(ILogger logger) : base(logger)
        //{
        //    _logger = logger;
        //}
    }
}