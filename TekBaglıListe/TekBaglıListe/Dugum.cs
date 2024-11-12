using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekBaglıListe
{
    public class Dugum
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Dugum next { get; set; }

        public Dugum(string name, int id)
        {
            this.Name = name;
            this.Id = id;
            this.next = null;
        }
    }
}
