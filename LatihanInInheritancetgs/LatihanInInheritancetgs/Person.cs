using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInInheritancetgs
{
    public class Person
    {
        public string Name { get; set; }

        public string Addres { get; set; }
        public string Identitas { get; set; }

        public void Ngomong()
        {
            Console.WriteLine("Nama saya adalah : {0}", Name);
        }

        public void TempatId()
        {
            Console.WriteLine("Saya adalah {0}, saya seorang {1}", Name,Identitas);
           
        }

        public void StatusId()
        {
            Console.WriteLine("Saya seorang {0} , dan nama saya adalah {1}", Identitas, Name);
        }


    }
}
