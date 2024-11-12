using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiftYönlüBagliListt
{
    public class Dugum
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Dugum next { get; set; }
        public Dugum onceki { get; set; }



        public Dugum(string name , int id)
        {
            Name = name;
            Id = id;
            next = null;
            onceki = null;
        }
    }
}
