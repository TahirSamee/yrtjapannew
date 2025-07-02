using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YRTJapan.Core;
using YRTJapan.Core.Entities;

namespace YRTJapan.DataAccess.Repository.IRepository
{
    using Microsoft.AspNetCore.Http;
    using System.Collections.Generic;

    public interface IStock
    {
        // Get all cars with images
        List<Car> GetAllCars();

        // Add a new car with multiple image files
        void AddCar(Car car, List<IFormFile> imageFiles);

        // Update an existing car (images not updated here)
        void UpdateCar(Car car);

        // Delete car and its images
        void DeleteCar(string carId);
    }

}
