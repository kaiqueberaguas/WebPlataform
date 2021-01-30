﻿using System.Collections.Generic;

namespace WebPlataform.Models
{
    public class Pageable<T>
    {
        public IList<T> Itens { get; private set; } = new List<T>();
        public int Page { get; private set; }
        public int Size { get; private set; }
        public int TotalPages { get; private set; }

        public Pageable(IList<T> itens, int page, int size)
        {
            Itens = itens;
            Page = page;
            Size = size;
            TotalPages = (itens.Count - (itens.Count % size)) / size;
        }
    }
}
