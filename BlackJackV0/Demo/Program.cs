using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Car
    {
        //property = ominaisuus, ominaisuutet on aina julkisia
        //näinki voi tehdä mutta vältä
        //public int Speed;
        public int Horsepower { get; set; }
        //sisäinen muutuja määritele maximinopeuten joka oliolle voi asettaa
        private const int maxSpeed = 200;
        private int speed;
        public int Speed
        {
            //get-aksessori palauttaa propertylle arvon
            get
            {
                return speed;
            }
            //set-aksessori asettaa propertylle arvoa 
            set
            {
                if (value > maxSpeed)
                    speed = maxSpeed;
                else
                    speed = value;
            }
        }
        //constructors
        public Car()
            //oletus konstruktori
        { }
        public Car (int horsepower, int speed)
        {
            Horsepower = horsepower;
            if (speed < maxSpeed)
                this.speed = speed;// this. viita olioon itseensä
            else
                this.speed = maxSpeed;
        }
        //methods
        public void Accelerate(int addition)
        {
            //kiihtytetään mutta ei yli maxnopeuden
            if (speed + addition < maxSpeed)
                speed = speed + addition;
            else
                speed = maxSpeed;
        }
        
    }
    class Program
    {
        static void TestMyCarClass()
        {
            //luodaan car-olio
            Car car = new Car();
            car.Speed = 175;
            car.Horsepower = 120;
            //lisätään toinen prissi
            Car car2 = new Car();
            car2.Horsepower = 300;
            car2.Speed = 250;
            //luodaan kolma auto
            Car fiat = new Car(55, 105);
            //näytetään kosolilla
            Console.WriteLine("Autosi 1 nopeus on {0} ja hevosvaomat on {1}", car.Speed, car.Horsepower);
            Console.WriteLine("Autosi 2 nopeus on {0} ja hevosvaomat on {1}", car2.Speed, car2.Horsepower);
            Console.WriteLine("Autosi fiat nopeus on {0} ja hevosvaomat on {1}", fiat.Speed, fiat.Horsepower);
            //kiihtytetään autoa 20km/h
            car.Accelerate(20);
            car2.Accelerate(20);
            fiat.Accelerate(20);
            Console.WriteLine("Kiihtytetiin autoja 20km/h");
            Console.WriteLine("Autosi 1 nopeus on {0} ja hevosvaomat on {1}", car.Speed, car.Horsepower);
            Console.WriteLine("Autosi 2 nopeus on {0} ja hevosvaomat on {1}", car2.Speed, car2.Horsepower);
            Console.WriteLine("Autosi fiat nopeus on {0} ja hevosvaomat on {1}", fiat.Speed, fiat.Horsepower);
        }
        static void Main(string[] args)
        {
            TestMyCarClass();
        }

    }
}
