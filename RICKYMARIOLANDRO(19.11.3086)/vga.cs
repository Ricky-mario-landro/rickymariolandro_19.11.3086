using System;
using System.Collections.Generic;
using System.Text;

//Ricky mario landro
//19.11.3086
//informatika 08

namespace TheSuperComputer
{
    class vga
    {
        //brand,graphics clock, memory clock
        private String brand;
        private int graphicsClock;//Mhz
        private int memoryClock;//Mhz

        public vga(String brand, int graphicsClock, int memoryClock)
        {
            this.brand = brand;
            this.graphicsClock = graphicsClock;
            this.memoryClock = memoryClock;
        }

        public String getBrand()
        {
            return this.brand;
        }

        public int getGraphicsClock()
        {
            return this.graphicsClock;
        }

        public int getMemoryClock()
        {
            return this.memoryClock;
        }

        public override string ToString()
        {
            return $"Vga brand : {this.brand} ; Vga clock graphics : {this.graphicsClock} ; Vga clock memory : {this.memoryClock} ";
        }
    }
}
