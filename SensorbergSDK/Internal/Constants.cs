﻿// Copyright (c) 2016,  Sensorberg
// 
// All rights reserved.

namespace SensorbergSDK.Internal
{
    internal static class Constants
    {
        public const string XApiKey = "X-Api-Key"; // Application api key / required
        public const string Xiid = "X-iid"; // Application installation id assigned by SDK / required
        public const string Xpid = "X-pid"; // Request layout with beacon pid
        public const string Xgeo = "X-geo"; // Request layout for given geo location
        public const string Xqos = "X-qos"; // Connection type
        public const string AdvertisementIdentifierHeader = "x-aid";
        public const string XUserAgent = "User-Agent"; // user agent
        public const string AuthorizationHeader = "Authorization"; // authorization token

        public const string DemoApiKey = "04a709a208c83e2bc0ec66871c46d35af49efde5151032b3e865768bbf878db8";

        public const string ResolverUri = "https://resolver.sensorberg.com/";

        public const string SensorbergUuidSpace = "7367672374000000ffff0000ffff00";

        public const int ActionTypeUrlMessage = 1;
        public const int ActionTypeVisitWebsite = 2;
        public const int ActionTypeInApp = 3;
        public const int ActionTypeSilent = 4;

        public const int Id1LengthWithoutDashes = 32;
        public const int MinimumLayoutContentLength = 10; // Arbitrary value to make sure that empty layouts are not validated

        public const int BeaconsListRefreshIntervalInMilliseconds = 1000;

        /// <summary>
        /// Default values for api settings. All time values are in miliseconds.
        /// </summary>
        public const ulong DefaultSettingsUpdateInterval = 43200000;
        public const ulong DefaultBeaconExitTimeout = 10000;
        public const ulong DefaultHistoryUploadInterval = 5*60*1000;
        public const ulong DefaultLayoutUpdateInterval = 3600000;
        public const int DefaultBackgroundScannerEnterThreshold = -120;

    }
}
