using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekKuyruk
{
    public class Yigin
    {
        public string PName { get; set; }
        public int Id { get; set; }
        public Yigin next { get; set; }

        public Yigin(int id, string name)
        {
            Id = id;
            PName = name;
            next = null;
        }
    }
}
