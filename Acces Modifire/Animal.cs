using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acces_Modifire
{
    internal class Animal
    {
        protected string Species { get; set; }
        public string GetSpecies() { return Species; }
    }
}
