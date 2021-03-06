﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace CityInfo.Api.Models
{
    public class CityDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int NumberOfPointOfInterest 
        { get
            {
                return PointOfInterest.Count;
            }
        }
        public ICollection<PointOfInterestDTO> PointOfInterest { get; set; } = new List<PointOfInterestDTO>();
    }
}
