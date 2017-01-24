using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demot
{
    class Program
    {
        static void Main(string[] args)
        {
            OOIWindowdemo();
        }
        static void OOIWindowdemo()
        {
            //program counts the size of the window (X,Y)(^2)
            float Width = 0;
            float Height = 0;
            float Asize, Outline = 0;
            Console.WriteLine("calkulates size of window, inpud width of windows in mm. Input width");
            Width = float.Parse(Console.ReadLine());
            Console.WriteLine("inpud height");
            Height = float.Parse(Console.ReadLine());
            Asize = Width * Height;
            Outline = 2 * (Width + Height);
            Console.WriteLine("Windows area is {0}mm^2 and outline is {1}mm", Asize, Outline);
            Draw window = new Demot.Draw();
            window.Width = Width;
            window.Height = Height;
            Asize = window.CountAreaSize();
            Console.WriteLine("test {0}mm^2 {1}mm", Asize, Outline);
        }
    }

    class Draw
    {
        //ominaisuutet
        public float Width { get; set; }
        public float Height { get; set; }
        public float AreaSize
        {
            get { return Height * Width; }
        }
        public float Outline
        {
            get { return 2 * Height + Width; }
        }
        //konstruktorit
        public Draw ()
        {
            
        }
        //metotit
        public Draw (float width, float height)
        {
            Width = width;
            Height = height;
        }
        public float CountAreaSize()
        {
            return Width * Height;
        }
    }
}
