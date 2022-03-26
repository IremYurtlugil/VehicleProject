using WebApp.Entities.Enum;

namespace WebApp.Entities.Abstract
{
    public abstract class Vehicle
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public ColorType Color { get; set; }
    }
}
