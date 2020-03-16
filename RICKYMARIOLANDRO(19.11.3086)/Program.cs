using System;

namespace TheSuperComputer
{
    class Program
    {
        static void Main(string[] args)
        {
            monitor lgmonitor = new monitor("1200x600", true, 32);
            printer hpprinter = new printer("HP", "MP102", 50);

            vga nvdiaVga = new vga("Nvidia", 2054, 2054);
            ram samsungRam = new ram("DDR4", 5000, 8000);
            processor intelProcessor = new processor();
            intelProcessor.setCache(254);
            intelProcessor.setCore(8);
            intelProcessor.setSeries("CORE i7 8th Gen");

            computer computer = new computer.Builder(samsungRam, nvdiaVga, intelProcessor)//parameter wajib
                .withMonitor(lgmonitor)//parameter opsional
                .withPrinter(hpprinter)//parameter opsional
                .build();
            Console.WriteLine(computer.ToString());
        }
    }
}
    

