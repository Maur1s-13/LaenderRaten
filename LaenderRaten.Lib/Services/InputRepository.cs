using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaenderRaten.Lib.Services
{
    public class InputRepository
    {

        public string ReplaceUmlaute(string input)
        {
            string output = input.Replace("ä", "ae")
                              .Replace("ö", "oe")
                              .Replace("ü", "ue")
                              .Replace("Ä", "Ae")
                              .Replace("Ö", "Oe")
                              .Replace("Ü", "Ue")
                              .Replace("ß", "ss");

            return output;
        }

        public string RemoveSpace(string input)
        {
            string output = input.Replace(" ", "");

            return output;
        }

        public string PlaceUmlate(string input)
        {
            string output = input.Replace("ae", "ä")
                              .Replace("oe", "ö")
                              .Replace("ue", "ü")
                              .Replace("Ae", "Ä")
                              .Replace("Oe", "Ö")
                              .Replace("Ue", "Ü");


            return output;
        }


    }
}
