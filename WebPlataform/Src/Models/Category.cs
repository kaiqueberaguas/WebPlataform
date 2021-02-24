using System;
using System.Collections.Generic;

namespace WebPlataform.Src.Models
{
    public class Category : Entity
    {

        public override Guid Id => base.Id;
        public string Name { get; set; }
        public List<Subcategory> Subcategories { get; set; } = new List<Subcategory>();
        public override bool IsActive => base.IsActive;
        public override DateTime LastUpdate { get => base.LastUpdate; set => base.LastUpdate = value; }
        public override DateTime InclusionDate => base.InclusionDate;
        
        public Category(string name,bool isActive) : base(isActive)
        {
            Name = name;
        }


    }
}
