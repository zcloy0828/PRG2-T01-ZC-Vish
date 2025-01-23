﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2_T01_ZC_Vish
{
    internal class Terminal
    {
        private string terminalName;
        public string TerminalName
        {
            get { return terminalName; }
            set { terminalName = value; }
        }

        private Dictionary<string, Airline> airlines;
        public Dictionary<string, Airline> Airlines
        {
            get { return airlines; }
            set { airlines = value; }
        }

        private Dictionary<string, Flight> flights;
        public Dictionary<string, Flight> Flights
        {
            get { return flights; }
            set { flights = value; }
        }

        private Dictionary<string, BoardingGate> boardingGates;
        public Dictionary<string, BoardingGate> BoardingGates
        {
            get { return boardingGates; }
            set { boardingGates = value; }
        }

        private Dictionary<string, double> gateFees;
        public Dictionary<string, double> GateFees
        {
            get { return gateFees; }
            set { gateFees = value; }
        }


        public Terminal() { }
        public Terminal(string terminalName, Dictionary<string, Airline> airlines, Dictionary<string, Flight> flights, Dictionary<string, BoardingGate> boardingGates, Dictionary<string, double> gateFees)
        {
            TerminalName = terminalName;
            Airlines = airlines;
            Flights = flights;
            BoardingGates = boardingGates;
            GateFees = gateFees;
        }

        public override bool AddAirline(Airline)
        {

        }

    }
}

