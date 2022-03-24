using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Attrib
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie mov = new Movie();
            mov.movreview();

        }
    }

    class Movie
    {
        public int Movid { get; set; }
        public string Movname { get; set; }

        [CusotmAttrib(CustomInfo = "info")]
        
        public void movreview()
        {
            Console.WriteLine("Very engaging movie");
        }

        [CusotmAttrib(CustomInfo = "Newinfo")]
        public void review()
        {

        }
        
    }

    
}
