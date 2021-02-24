using System;

namespace WebPlataform.Src.Models
{
    public class Product : Entity
    {
        public override Guid Id { get => base.Id; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Information { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }
        //public Guid SubcategoryId { get; set; }
        public Subcategory Subcategory { get; set; }
        public override bool IsActive { get => base.IsActive; }
        public override DateTime LastUpdate { get => base.LastUpdate; set => base.LastUpdate = value; }
        public override DateTime InclusionDate { get => base.InclusionDate; }

        public Product() : base(null)
        {
        }

        public Product(string name, string description, string information, decimal price, 
            string image, int quantity, Subcategory subcategory, bool isActive) : base(isActive)
        {
            Name = name;
            Description = description;
            Information = information;
            Price = price;
            Image = image;
            Quantity = quantity;
            Subcategory = subcategory;
        }
    }
}