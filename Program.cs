using System;
using jurnalmod4_103022300069;
using static jurnalmod4_103022300069.FanLaptop;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Soal 1----");
        foreach(KodeProduk.produkElektronik elk in Enum.GetValues(typeof(KodeProduk.produkElektronik)))
        {
            Console.WriteLine(elk + ": " + KodeProduk.getKodeProduk(elk));
        }

        Console.WriteLine("\nSoal 2----");
        FanLaptop fan = new FanLaptop();
        fan.Simulasi();
    }
}