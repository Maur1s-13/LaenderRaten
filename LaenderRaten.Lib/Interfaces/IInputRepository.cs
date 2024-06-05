using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaenderRaten.Lib.Interfaces
{
    public interface IInputRepository
    {
        public string ReplaceUmlaute(string input);
        public string RemoveSpace(string input);
        public string PlaceUmlate(string input);
    }
}
