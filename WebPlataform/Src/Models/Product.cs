using System;
using System.Collections.Generic;

namespace WebPlataform.Src.Models
{
    public class Product : Entity
    {
        public override Guid Id { get => base.Id; set => base.Id = value; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Information { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }
        public List<Category> Categories { get; set; }
        public override bool IsActive { get => base.IsActive; set => base.IsActive = value; }
        public override DateTime LastUpdate { get => base.LastUpdate; set => base.LastUpdate = value; }
        public override DateTime InclusionDate { get => base.InclusionDate; set => base.InclusionDate = value; }

    }
}