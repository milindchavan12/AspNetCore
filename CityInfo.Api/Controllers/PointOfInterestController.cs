using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CityInfo.Api.Controllers
{
    [Route("api/cities")]
    public class PointOfInterestController : Controller
    {
        [HttpGet("{cityId}/pointofinterest")]
        public IActionResult GetPointOfInterests(int cityId)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(cityInfo => cityInfo.Id.Equals(cityId));
            if (city == null)
            {
                return NotFound();
            }

            return Ok(city.PointOfInterest);
        }

        [HttpGet("{cityId}/pointofinterest/{id}")]
        public IActionResult GetPointOfInterest(int cityId, int id)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(cityInfo => cityInfo.Id.Equals(cityId));
            if (city == null)
            {
                return NotFound();
            }

            var pointOfInterest = city.PointOfInterest.FirstOrDefault(p => p.Id.Equals(id));
            if (pointOfInterest == null)
            {
                return NotFound();
            }

            return Ok(pointOfInterest);
        }
    }
}
