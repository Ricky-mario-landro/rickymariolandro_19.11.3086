using System;
using System.Collections.Generic;
using System.Text;
//Ricky mario landro
//19.11.3086
//informatika 08
namespace TheSuperComputer
{
    class computer
    {
        private monitor monitor;
        private printer printer;
        private processor processor;
        private ram ram;
        private vga vga;


        private computer(Builder builder)
        {
            this.monitor = builder.monitor;
            this.processor = builder.processor;
            this.printer = builder.printer;
            this.ram = builder.ram;
            this.vga = builder.vga;
        }
        public override string ToString()
        {
            return $"Monitor spec :{this.monitor} \n" +
                $"Processor spec : {this.processor} \n" +
                $"Printer spec : {this.printer} \n" +
                $"Vga spec : {this.vga} \n" +
                $"Ram spec : {this.ram}";
        }
        public class Builder
        {
            public monitor monitor;
            public printer printer;
            public processor processor;
            public ram ram;
            public vga vga;

            public Builder(ram ram, vga vga, processor processor)
            {
                this.ram = ram;
                this.vga = vga;
                this.processor = processor;
            }

            public Builder withMonitor(monitor monitor)
            {
                this.monitor = monitor;
                return this;
            }

            public Builder withPrinter(printer printer)
            {
                this.printer = printer;
                return this;
            }

            public computer build()
            {
                return new computer(this);
            }

        }
    }
}