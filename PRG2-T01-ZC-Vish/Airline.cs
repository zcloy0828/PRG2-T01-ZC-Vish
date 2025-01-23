using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2_T01_ZC_Vish
{
    internal class Airline
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string code;
        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        private Dictionary<string, Flight> flight;
        public Dictionary<string, Flight> Flight
        {
            get { return flight; }
            set { flight = value; }
        }

        public Airline() { }

        public Airline(string name, string code, Dictionary<string, Flight> flight) //add base here
        {
            Name = name;
            Code = code;
            Flight = flight;
        }

        public override bool AddFlight(Flight)
        {

        }


        public override double CalculateFees()
        {

        }

        public override bool RemoveFlight(Flight)
        {

        }

        public override string Tostring()
        {
            return "Name: " + name + "\tCode: " + code + "\tFlight : " + flight;
        }

    }
}


