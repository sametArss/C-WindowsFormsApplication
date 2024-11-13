using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YiginÖdev
{
    public class Yigin
    {

        public char islem { get; set; }
        public Yigin  next { get; set; }



        public Yigin(char _islem )
        {
            islem = _islem;
            next = null;
        }
    }
}
