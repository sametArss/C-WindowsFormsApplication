using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekKuyruk
{
    public class IslKuyruk
    {
        public int Id { get; set; }
        public string PName { get; set; }
        public IslKuyruk next { get; set; }

        public IslKuyruk(int id, string name)
        {
            Id = id;
            PName = name;
            next = null;
        }
    }
}
