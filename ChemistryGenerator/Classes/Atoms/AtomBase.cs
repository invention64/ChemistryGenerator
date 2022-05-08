using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemistryGenerator.Atoms.Classes
{
    class AtomBase
    {
        private AtomicRules atomicRules { get; set; }
        public int mass { get; set; }
        public int protons { get; set; }
        public int neutrons { get; set; }
        public Electrons electrons { get; set; }
        public AtomBase(AtomicRules atomicRules)
        {

        }
    }
}
