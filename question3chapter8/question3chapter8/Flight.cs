using System;
using System.Collections.Generic;
using System.Text;

namespace question3chapter8
{
    class Flight
    {
        public int FlightNum { get; set; }
        public string AirportCode { get; set; }
        public string AirportName { get; set; }
        public int Time { get; set; }
        public Flight(int flightNum, string airportCode, string airportName, int time)
        {
            this.FlightNum = flightNum;
            this.AirportCode = airportCode;
            this.AirportName = airportName;
            this.Time = time;
        }
    }
}
