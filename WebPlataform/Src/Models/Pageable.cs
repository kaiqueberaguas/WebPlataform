using System.Collections.Generic;

namespace WebPlataform.Src.Models
{
    public class Pageable<T>
    {
        public IList<T> Itens { get; private set; } = new List<T>();
        public int Page { get; private set; }
        public int Size { get; private set; }
        public int TotalPages { get; private set; }

        public Pageable(IList<T> itens, int totalItens, int page, int size)
        {
            if (size < 1) size = 1;
            Itens = itens;
            Page = page;
            Size = size;
            TotalPages = (totalItens - (totalItens % size)) / size;
            if (totalItens % size != 0) TotalPages++;
        }
        public Pageable(int totalItens, int page, int size) : this(new List<T>(),
            totalItens, page, size)
        {
        }
    }
}
