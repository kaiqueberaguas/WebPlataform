using System;
using System.Collections.Generic;

namespace WebPlataform.Src.Models
{
    public class Subcategory : Entity
    {
        public override Guid Id { get => base.Id;}
        public string Name { get; set; }
        //public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Product> Products { get; set; }
        public override bool IsActive { get => base.IsActive;}
        public override DateTime LastUpdate { get => base.LastUpdate; set => base.LastUpdate = value; }
        public override DateTime InclusionDate { get => base.InclusionDate; }

        public Subcategory(string name,bool isActive) : base(isActive)
        {
            Name = name;
        }
    }
}
