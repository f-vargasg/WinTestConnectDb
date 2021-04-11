using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinTestConnectDb
{
    class TestBE
    {
        public int IdTabla { get; set; }

        public string  NomArticulo { get; set; }

        public override string ToString()
        {
            string res = "(" +  this.IdTabla.ToString() + " - " + this.NomArticulo + ")"; 

            return res;
        }
    }
}
