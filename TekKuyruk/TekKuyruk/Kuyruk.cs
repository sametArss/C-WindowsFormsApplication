using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekKuyruk
{
    public class Kuyruk
    {
        public int Id { get; set; }
        public string PName { get; set; }
        public Kuyruk next { get; set; }

        public Kuyruk(int id, string name)
        {
            Id = id;
            PName = name;
            next = null;
        }
    }
}
