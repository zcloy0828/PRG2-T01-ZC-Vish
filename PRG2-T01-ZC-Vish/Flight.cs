﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2_T01_ZC_Vish
{
    abstract class Flight
    {
        private string flightNumber;
        public string FlightNumber
        {
            get { return flightNumber; }
            set { flightNumber = value; }
        }

        private string origin;
        public string Origin
        {
            get { return origin; }
            set { origin = value; }
        }

        private string destination;
        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        private DateTime expectedTime;
        public DateTime ExpectedTime
        {
            get { return expectedTime; }
            set { expectedTime = value; }
        }

        private string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public Flight(string flightNumber, string origin, string destination, DateTime expectedTime, string status)
        {
            FlightNumber = flightNumber;
            Origin = origin;
            Destination = destination;
            ExpectedTime = expectedTime;
            Status = status;
        }

        public abstract double CalculateFees();


        public override string ToString()
        {
            return "FlightNumber: " + flightNumber + "\tOrigin: " + origin + "\tDestination: " + destination + "\tExpectedTime: " + expectedTime + "\tStatus: " + status;
        }
    }
}

