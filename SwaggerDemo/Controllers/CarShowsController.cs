using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwaggerDemo.Models;

namespace SwaggerDemo.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CarShowsController : ControllerBase
    {
        /// <summary>
        /// Fetching Carshows.
        /// </summary>
        /// <remarks>
        /// List of CarShows {names and list of cars}
        /// </remarks>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public List<CarShow> Cars()
        {
            //Dummy data
            var car1 = new Car
            {
                Make = "Make1",
                Model = "Model1"
            };

            var car2 = new Car
            {
                Make = "Make2",
                Model = "Model2"
            };

            List<Car> carList = new List<Car>();
            carList.Add(car1);
            carList.Add(car2);

            var carShow1 = new CarShow
            {
                Name = "CarShow1",
                Cars = carList
            };

            var carShow2 = new CarShow
            {
                Name = "CarShow2",
                Cars = carList
            };

            List<CarShow> carShows = new List<CarShow>();
            carShows.Add(carShow1);
            carShows.Add(carShow2);

            return carShows;
        }
    }
}