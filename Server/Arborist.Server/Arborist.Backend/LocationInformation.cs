using System;

namespace Arborist.Backend
{
    public sealed class LocationInformation
    {
        public Uri Uri { get; private set; }
        public LocationInformationTypes LocationTypes { get; private set; }

        public static LocationInformation CreateOnlineOnlyInformation(string uri)
        {
            return new LocationInformation
            {
                LocationTypes = LocationInformationTypes.Uri,
                Uri = new Uri(uri)
            };
        }
    }
}