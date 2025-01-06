using Cars;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        [HttpGet]
        [Route("GetById")]
        public Car getCar(int id)
        {
            return Autoshop.GetCar(id);
        }
        [HttpGet]
        [Route("GetByName")]
        public Car getCar(string Name)
        {
            return Autoshop.GetCar(1);
        }
        [HttpPost]
        public void AddCar(Car car)
        {
            Autoshop.AddCar(car);
        }
    }
}
