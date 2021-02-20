using System;

namespace WebPlataform.Src.Models
{
    public abstract class Entity
    {
        public virtual Guid Id { get; /*private*/ set; }
        public virtual bool IsActive { get; /*private*/ set; }
        public virtual DateTime LastUpdate { get; /*private*/ set; }
        public virtual DateTime InclusionDate { get; /*private*/ set; }
                
        public virtual void Disable()
        {
            IsActive = false;
            LastUpdate = DateTime.Now;
        }
    }
}
