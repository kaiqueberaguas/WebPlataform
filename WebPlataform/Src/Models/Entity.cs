using System;

namespace WebPlataform.Src.Models
{
    public abstract class Entity
    {
        public virtual Guid Id { get; private set; }
        public virtual bool IsActive { get; private set; }
        public virtual DateTime LastUpdate { get; set; }
        public virtual DateTime InclusionDate { get; private set; }

        protected Entity(bool? isActive)
        {
            Id = new Guid();
            IsActive = isActive??false;
            LastUpdate = DateTime.Now;
            InclusionDate = DateTime.Now;
        }

        public virtual void Disable()
        {
            IsActive = false;
            LastUpdate = DateTime.Now;
        }

        public virtual void Eneable()
        {
            IsActive = true;
            LastUpdate = DateTime.Now;
        }
    }
}
