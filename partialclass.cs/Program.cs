using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partialclass.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Multimedia mul=new Multimedia();
            //mul.Display();
            //mul.PlayAudio();
            //mul.PlayVideo();
            //Console.ReadLine();

            //Television tv = new Television();
            //tv.TurnOn();
            //tv.TurnOff();
            employee e = new employee(1, "abc", "hhg");
            e.edisplay();
        }
    }
}
