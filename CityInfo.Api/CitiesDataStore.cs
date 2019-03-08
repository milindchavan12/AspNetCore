using System;
using System.Collections.Generic;
using CityInfo.Api.Models;

namespace CityInfo.Api
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public List<CityDTO> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDTO>()
            {
                new CityDTO
                {
                    Id = 1,
                    Name = "NewYork",
                    Description = "Beatiful City",
                    PointOfInterest = new List<PointOfInterestDTO>()
                    {
                        new PointOfInterestDTO{
                            Id = 1,
                            Description = "Central Park Outerside",
                            Name = "Central Park"
                        },
                        new PointOfInterestDTO{
                            Id = 2,
                            Description = "Park Outerside",
                            Name = "City Center"
                        }
                    }
                },
                new CityDTO
                {
                    Id = 1,
                    Name = "Mumbai",
                    Description = "Excellent City",
                    PointOfInterest = new List<PointOfInterestDTO>()
                    {
                        new PointOfInterestDTO{
                            Id = 1,
                            Description = "Central Park Outerside",
                            Name = "Gateway of India"
                        },
                        new PointOfInterestDTO{
                            Id = 2,
                            Description = "Park Outerside",
                            Name = "Mumbai Central"
                        }
                    }
                }
            };
        }
    }
}
