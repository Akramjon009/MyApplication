using MyApplication.Infrastruct;
using Microsoft.AspNetCore.Mvc;
using Mypplication.Application.Services.CarServices;
using MyApplication.Domain.Entities.DTOs;
using MyApplication.Domain.Entities.Models;

namespace MyApplication.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpPost]
        public async Task<string> CreateCar(CarDTO cs)
        {
            return await _carService.CreateCar(cs);
        }

        [HttpGet]
        public async Task<IEnumerable<Car>> GetAllCars()
        {
            return await _carService.GetAllCars();
        }
        [HttpDelete]
        public async Task<string> DeleteCarById(int id)
        {
            return await _carService.DeleteCar(id);
        }
        [HttpPut]
        public async Task<string> UpdateCarById(int id, CarDTO cs)
        {
            return await _carService.UpdateCar(id, cs);
        }
        [HttpGet]
        public async Task<Car> GetCarById(int id)
        {
            return await _carService.GetCarById(id);
        }
    }
}
