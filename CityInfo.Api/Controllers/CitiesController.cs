using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CityInfo.Api.Controllers
{
    [Route("api/cities")]
    public class CitiesController : Controller
    {
        public CitiesController()
        {
        }

        [HttpGet()]
        public IActionResult GetCities()
        {
            return Ok(CitiesDataStore.Current.Cities);
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(cityInfo => cityInfo.Id.Equals(id));
            if(city == null)
            {
                return NotFound();
            }

            return Ok(city);
        }
    }
}
