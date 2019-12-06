using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tolotu_Web.Models
{
    public class login
    {
        public login()
        {

        }
        public String usuario { get; set; }
        public String pass { get; set; }


        public override string ToString()
        {
            return "{ usuario: " + usuario + ", contrasena: " + pass + " }";
        }
    }
}
