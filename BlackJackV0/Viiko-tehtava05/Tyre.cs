using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Vehicle
    {
        //constants and variables
        private const int maxTyres = 4;
        private int countTyres = 0;
        //properties
        public string Brand { get; set; }
        public string Model { get; set; }
        public Tyre[] Tyres { get; }

        //constructors
        public Vehicle()
        {
            Tyres = new Tyre[maxTyres];
        }
        //methods
        public void AddTyre(Tyre tyre)
        {
            if (countTyres < maxTyres)
            {
                Tyres[countTyres] = tyre;
                countTyres++;
                Console.WriteLine("rengas {0} lisätty ajoneuvoon {1}", tyre.ToString(), this.Brand);
            }
            else
            {
                Console.WriteLine("ei sovi enää uusia renkaita, sori");
            }
        }
        public override string ToString()
        {
            string retval = "ajoneuvo valmistaja: " + Brand + "malli; " + Model + "\nrenkaat: ";
            foreach (Tyre tyre in Tyres)
            {
                if (tyre != null)
                {
                    retval += "\n" + tyre.ToString();
                }
            }
            return retval;
        }

    }
    public class Tyre
    {
        public string Branch { get; set; }
        public string Size { get; set; }
        public override string ToString()
        {
            //return "valmistaja: " + Branch + "koko: " + Size;
            return string.Format("valmistaja on {0} koko on {1}", Branch, Size);
        }

    }
}
