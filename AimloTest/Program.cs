using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AimloTest
{
    class Program
    {
        static Aimlo.Aimlo _aimlo;
        static void Main(string[] args)
        {
            _aimlo = new Aimlo.Aimlo();
            TalkWithAimlo();
        }


        static void TalkWithAimlo()
        {
            var input = Console.ReadLine();
            if (input == "exit")
                return;
            var output = _aimlo.getOutput(input);
            Console.WriteLine(output);
            TalkWithAimlo();
        }
    }
}
