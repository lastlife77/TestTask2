using System;
using GMap.NET;
using GMap.NET.WindowsForms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tusk2
{
    class DataStream
    {
        Random rand = new Random();
        public PointLatLng genStartPoint()
        {
            double minLatitude = 45;
            double maxLatitude = 65;
            double latitude = rand.NextDouble() * (maxLatitude - minLatitude) + minLatitude;

            double minLongitude = 27;
            double maxLongitude = 57;
            double longitude = rand.NextDouble() * (maxLongitude - minLongitude) + minLongitude;

            PointLatLng startPoint = new PointLatLng(latitude, longitude);
            return startPoint;
        }


        public PointLatLng genRandomPoint(PointLatLng prevPoint)
        {
            double minLatitude = prevPoint.Lat + 0.1;
            double maxLatitude = prevPoint.Lat - 0.1;
            double latitude = rand.NextDouble() * (maxLatitude - minLatitude) + minLatitude;

            double minLongitude = prevPoint.Lng - 0.1;
            double maxLongitude = prevPoint.Lng + 0.1;
            double longitude = rand.NextDouble() * (maxLongitude - minLongitude) + minLongitude;

            PointLatLng point = new PointLatLng(latitude, longitude);
            return point;
        }
    }
}
