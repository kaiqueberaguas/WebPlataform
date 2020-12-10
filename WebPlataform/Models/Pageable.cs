using System.Collections.Generic;

namespace WebPlataform.Models
{
    public class Pageable<T>
    {
        public IList<T> Itens { get; set; }
        public int Page { get; set; }
        public int Size { get; set; }
        public int TotalPages { get; set; }
    }
}
