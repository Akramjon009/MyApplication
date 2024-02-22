using MyApplication.Domain.Entities.DTOs;
using MyApplication.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mypplication.Application.Services.CarServices
{
    public interface ICarService
    {
        public Task<string> CreateCar(CarDTO cr);
        public Task<string> UpdateCar(int id, CarDTO cr);
        public Task<string> DeleteCar(int id);
        public Task<Car> GetCarById(int id);
        public Task<IEnumerable<Car>> GetAllCars();
    }
}
