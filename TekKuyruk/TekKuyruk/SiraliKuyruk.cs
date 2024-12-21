using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekKuyruk
{
    public class SiraliKuyruk
    {
        public int Id { get; set; }
        public string PName { get; set; }
        public SiraliKuyruk next { get; set; }

        public SiraliKuyruk(int id, string name)
        {
            Id = id;
            PName = name;
            next = null;
        }
    }
}
