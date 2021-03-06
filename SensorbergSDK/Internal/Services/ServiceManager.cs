﻿// Created by Kay Czarnotta on 04.03.2016
// 
// Copyright (c) 2016,  EagleEye .
// 
// All rights reserved.

using System.Diagnostics;
using SensorbergSDK.Services;

namespace SensorbergSDK.Internal.Services
{
    public static class ServiceManager
    {
        private static IApiConnection _apiConnction;
        private static IBeaconScanner _beaconScanner;
        private static ILayoutManager _layoutManager;
        private static IStorageService _storageService;
        private static ISettingsManager _settingsManager;
        private static ILocationService _locationService;
        private static IWriterFactory _writerFactory;

        public static IStorageService StorageService
        {
            [DebuggerStepThrough] get { return _storageService; }
            [DebuggerStepThrough]
            set
            {
                if (_storageService == null || !ReadOnlyForTests)
                {
                    _storageService = value;
                }
            }
        }

        public static IApiConnection ApiConnction
        {
            [DebuggerStepThrough] get { return _apiConnction; }
            [DebuggerStepThrough]
            set
            {
                if (_apiConnction == null || !ReadOnlyForTests)
                {
                    _apiConnction = value;
                }
            }
        }

        public static IBeaconScanner BeaconScanner
        {
            [DebuggerStepThrough] get { return _beaconScanner; }
            [DebuggerStepThrough]
            set
            {
                if (_beaconScanner == null || !ReadOnlyForTests)
                {
                    _beaconScanner = value;
                }
            }
        }

        public static ILayoutManager LayoutManager
        {
            [DebuggerStepThrough]
            get { return _layoutManager; }
            [DebuggerStepThrough]
            set
            {
                if (_layoutManager == null || !ReadOnlyForTests)
                {
                    _layoutManager = value;
                }
            }
        }

        public static ISettingsManager SettingsManager
        {
            [DebuggerStepThrough] get { return _settingsManager; }
            [DebuggerStepThrough]
            set
            {
                if (_settingsManager == null || !ReadOnlyForTests)
                {
                    _settingsManager = value;
                }
            }
        }

        public static ILocationService LocationService
        {
            [DebuggerStepThrough] get { return _locationService; }
            [DebuggerStepThrough]
            set
            {
                if (_locationService == null || !ReadOnlyForTests)
                {
                    _locationService = value;
                }
            }
        }

        public static IWriterFactory WriterFactory
        {
            get { return _writerFactory; }
            set
            {
                if (_writerFactory == null || !ReadOnlyForTests)
                {
                    _writerFactory = value;
                }
            }
        }

        public static bool ReadOnlyForTests { get; set; }

        public static void Clear()
        {
            if (ReadOnlyForTests)
            {
                return;
            }
            _apiConnction = null;
            _beaconScanner = null;
            _layoutManager = null;
            _storageService = null;
            _settingsManager = null;
            _locationService = null;
            ReadOnlyForTests = false;
        }
    }
}