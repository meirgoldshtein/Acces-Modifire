using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acces_Modifire
{
    internal class LibraryItem
    {
        protected string Title { get; set; }

        public string GetTitel()
        {
            return Title;
        }
    }
}
