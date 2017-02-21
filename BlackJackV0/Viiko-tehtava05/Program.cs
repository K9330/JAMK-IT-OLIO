using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;
namespace Viiko_tehtava05
{
    class Program
    {

        static void Main(string[] args)
        {
            Lab05Teht01();
        }
        static void Tehtava1()
        {

        }
        static void Lab05Teht01()
        {
            //testataan tyre ja vehecle luokkia

            //luodaan ensimmäinen ajoneuvo
            Vehicle auto = new JAMK.IT.Vehicle();
            auto.Brand = "BMW";
            auto.Model = "320";
            //ostetaan renkaida
            Tyre rinkula = new Tyre();
            rinkula.Branch = "Hankook";
            rinkula.Size = "205/55r16";
            //laitetaan renkaad
            auto.AddTyre(rinkula);
            auto.AddTyre(rinkula);
            auto.AddTyre(rinkula);
            auto.AddTyre(rinkula);

            Console.WriteLine("autosi {0} on seuraavat tiedot: {1}", auto.Brand, auto.ToString());
        }


    }

}
