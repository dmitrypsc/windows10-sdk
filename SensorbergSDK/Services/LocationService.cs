﻿// Created by Kay Czarnotta on 17.06.2016
// 
// Copyright (c) 2016,  Sensorberg
// 
// All rights reserved.

using System;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using SensorbergSDK.NGeoHash;

namespace SensorbergSDK.Services
{
    /// <summary>
    /// Service to handle location requests.
    /// </summary>
    public class LocationService : ILocationService
    {
        private const int HashLength = 6;
        public Geolocator Locator { get;  }
        public SdkConfiguration Configuration { get; set; }

        public LocationService()
        {
            Locator = new Geolocator();
        }

        public async Task Initialize()
        {
            if (Configuration != null && Configuration.UseLocation)
            {
                var accessStatus = await Geolocator.RequestAccessAsync();
                Configuration.UseLocation = accessStatus == GeolocationAccessStatus.Allowed;
            }
        }

        public async Task<string> GetGeoHashedLocation()
        {
            Geoposition position = await GetLocation();
            if (position != null)
            {
                return GeoHash.Encode(position.Coordinate.Latitude, position.Coordinate.Longitude, HashLength);
            }
            return null;
        }

        public async Task<Geoposition> GetLocation()
        {
            if (Configuration != null && Configuration.UseLocation)
            {
                return await Locator.GetGeopositionAsync();
            }
            return null;
        }
    }
}