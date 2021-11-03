using System;

namespace question3chapter8
{
    class Program
    {
        public Flight[] FlightArr { get; set; }
        public Program()
        {
            Flight Flight1 = new Flight(201, "AUS", "Austin", 0710);
            Flight Flight2 = new Flight(321, "CRP", "Corpus Christi", 0830);
            Flight Flight3 = new Flight(510, "DFW", "Dallas Fort Worth", 0915);
            Flight Flight4 = new Flight(633, "HOU", "Houston", 1140);
            Flight[] flightArr = { Flight1, Flight2, Flight3, Flight4 };
            this.FlightArr = flightArr;
            
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine(program.GetFlightInfo(21));
            Console.WriteLine(program.GetFlightInfo("DFW"));
        }

        public string GetFlightInfo(int flightNum)
        {
            string result = "Could not find your flight";
            //look for the right flight 
            foreach(Flight flight in FlightArr)
            {
                if(flight.FlightNum == flightNum)
                {
                    result = $"Airport Code: {flight.AirportCode} \n Airport Name: {flight.AirportName} \n Flight Time: {flight.Time}";
                }
            }
            return result;
        }

        public string GetFlightInfo(string airportCode)
        {
            string result = "Could not find your flight";
            //look for the right flight 
            foreach (Flight flight in FlightArr)
            {
                if (flight.AirportCode == airportCode)
                {
                    result = $"Flight Number: {flight.FlightNum} \n Airport Name: {flight.AirportName} \n Flight Time: {flight.Time}";
                }
            }
            return result;
        }
    }
}
