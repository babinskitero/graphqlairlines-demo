﻿namespace GraphQlAirlines.Data.Models
{
    public class Route
    {
        public Route(string airline, int airlineId, string sourceAirport, int sourceAirportId,
            string destinationAirport, int destinationAirportId, bool codeShare, string stops, string equipment)
        {
            Airline = airline;
            AirlineId = airlineId;
            SourceAirport = sourceAirport;
            SourceAirportId = sourceAirportId;
            DestinationAirport = destinationAirport;
            DestinationAirportId = destinationAirportId;
            CodeShare = codeShare;
            Stops = stops;
            Equipment = equipment;
        }

        /// <summary>
        ///     2-letter (IATA) or 3-letter (ICAO) code of the airline.
        /// </summary>
        public string Airline { get; }

        /// <summary>
        ///     Unique OpenFlights identifier for airline (see Airline).
        /// </summary>
        public int AirlineId { get; }

        /// <summary>
        ///     3-letter (IATA) or 4-letter (ICAO) code of the source airport.
        /// </summary>
        public string SourceAirport { get; }

        /// <summary>
        ///     Unique OpenFlights identifier for source airport (see Airport)
        /// </summary>
        public int SourceAirportId { get; }

        /// <summary>
        ///     3-letter (IATA) or 4-letter (ICAO) code of the destination airport.
        /// </summary>
        public string DestinationAirport { get; }

        /// <summary>
        ///     Unique OpenFlights identifier for destination airport (see Airport)
        /// </summary>
        public int DestinationAirportId { get; }

        /// <summary>
        ///     Y if this flight is a codeshare (that is, not operated by Airline, but another carrier), empty otherwise.
        /// </summary>
        public bool CodeShare { get; }

        /// <summary>
        ///     Number of stops on this flight (0 for direct)
        /// </summary>
        public string Stops { get; set; }

        /// <summary>
        ///     3-letter codes for plane type(s) generally used on this flight, separated by spaces
        /// </summary>
        public string Equipment { get; set; }
    }
}