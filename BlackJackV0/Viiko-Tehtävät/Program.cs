﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viiko_Tehtävät
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tehtava1();
            //Tehtava2();
            Tehtava3();
        }

        static void Tehtava1()
        {
            //Tee ohjelma, joka tulostaa käyttäjän antamaa lukua (1, 2 tai 3) vastaavan luvun sanana (yksi, kaksi tai kolme). Jos käyttäjä syöttää jonkin muun luvun, tulee näytölle tulostaa teksti: "joku muu luku". 
            Console.WriteLine("Anna 1, 2 tai 3 ja tulostan sen tekstinä");
            string retval = Console.ReadLine();
            int luku = int.Parse(retval);
            if (luku == 1)
            {
                retval = "yksi";
            }
            else if (luku == 2)
            {
                retval = "kaksi";
            }
            else if (luku == 3)
            {
                retval = "kolme";
            }
            else
            {
                retval = "Joku muu luku";
            }
            //tulostus käytäjälle
            Console.WriteLine(retval);
        }
        static void Tehtava2()
        {
            /* Tee ohjelma, jossa annetaan oppilaalle koulunumero seuraavan taulukon mukaan (pistemäärä kysytään ja ohjelma tulostaa numeron):
            pisteraja   numero
            0-1         0
            2-3 	    1
            4-5 	    2
            6-7 	    3
            8-9 	    4
            10-12 	    5*/
            Console.WriteLine("Anna pistemäärä ja tulostan numeron");
            string retval = Console.ReadLine();
            int numper = int.Parse(retval);
            if (numper <= 1 && numper >= 0)
            {
                retval = "0";
            }
            if (numper <= 2 && numper >= 3)
            {
                retval = "1";
            }
            if (numper <= 4 && numper >= 5)
            {
                retval = "2";
            }
            if (numper <= 6 && numper >= 7)
            {
                retval = "3";
            }
            if (numper <= 8 && numper >= 9)
            {
                retval = "4";
            }
            if (numper <= 10 && numper >= 12)
            {
                retval = "5";
            }
        }
        static void Tehtava3()
        {
            /*
             Tee ohjelma, joka kysyy käyttäjältä kolme lukua ja tulostaa niiden summan ja keskiarvon. 
             */
            Console.WriteLine("Syötä 3 lukua ja tulostan niiten summan ja keski arvon");
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
            string num3 = Console.ReadLine();
            string num4 = num1 + num2 + num3;
            Console.WriteLine("summa: "+ num4);

        }
    }
}
