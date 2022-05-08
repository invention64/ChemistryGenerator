using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemistryGenerator.Classes.SimpleElement
{
    class ElementBase
    {
        public int mass { get; set; }
        // this could probably be replaced with a tile based flow rate
        public int viscosity { get; set; } // idk wtf this should be, maybe like negative is super loose, and positive is very viscous. Numbers around -10 to +10 are average?
        public int reactivity { get; set; }
        public string name { get; set; }

    }
}
