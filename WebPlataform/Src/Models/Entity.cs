namespace WebPlataform.Src.Models
{
    public abstract class Entity
    {
        public long Id { get; set; }
        public long Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
