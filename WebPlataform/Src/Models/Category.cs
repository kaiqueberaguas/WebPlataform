using System;
using System.Collections.Generic;

namespace WebPlataform.Src.Models
{
    public class Category : Entity
    {
        public override Guid Id { get => base.Id; set => base.Id = value; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
        public override bool IsActive { get => base.IsActive; set => base.IsActive = value; }
        public override DateTime LastUpdate { get => base.LastUpdate; set => base.LastUpdate = value; }
        public override DateTime InclusionDate { get => base.InclusionDate; set => base.InclusionDate = value; }
    }
}
