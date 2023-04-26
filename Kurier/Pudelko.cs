using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurier
{
    public class Pudelko
    {
        private int dlugosc;
        private int szerokosc;
        private int wysokosc;
        private string jednostki;


     

    // tworzenie pudelka - konstruktor
    public Pudelko(int dl, int sz, int wy, string j="cm")
        {
            this.dlugosc = dl;
            this.szerokosc = sz;
            this.wysokosc = wy;
            this.jednostki = j;


            if (dl < 0 || sz < 0 || wy < 0)
                {

                Console.WriteLine("Wymiary pudełka nie mogą być mniejsze niż 0");

                }
                

            

        }
    }
}
