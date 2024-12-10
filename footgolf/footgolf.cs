using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace footgolf
{
    internal class footgolf
    {
        public string Nev { get; set; }
        public string Kategória { get; set; }
        public string Csapat { get; set; }
        public string elsoeredmeny { get; set; }
        public string masodikeredmeny { get; set; }
        public string harmadikeredmeny { get; set; }
        public footgolf(string sor)
        {
            string[] darabok = sor.Split(';');
            Nev = darabok[0];
            Kategória = darabok[1];
            Csapat = darabok[2];
            elsoeredmeny = darabok[3];
            masodikeredmeny = darabok[4];
            harmadikeredmeny = darabok[5];
        }
         
        
         
         
    }
}
