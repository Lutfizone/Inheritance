using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInInheritancetgs
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "Beckham";
            person.Identitas = "Pemain Sepak Bola";
            person.Ngomong();
            person.TempatId();

            var student = new Student();
            student.Name = "Donald Trump";
            student.Identitas = "President";
            student.StatusId();
        }
    }
}
