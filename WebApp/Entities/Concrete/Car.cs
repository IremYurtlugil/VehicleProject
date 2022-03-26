using WebApp.Entities.Abstract;
using WebApp.Entities.Intefaces;

namespace WebApp.Entities.Concrete
{
    public class Car : Vehicle, ICar
    {
        public bool Headlight { get; set; }
        public bool HasWheels => true;

        public bool Wheels => true;
    }
}
