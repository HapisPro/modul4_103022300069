using System;
using jurnalmod4_103022300069;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Soal 1----");
        foreach(KodeProduk.produkElektronik elk in Enum.GetValues(typeof(KodeProduk.produkElektronik)))
        {
            Console.WriteLine(elk + ": " + KodeProduk.getKodeProduk(elk));
        }
    }
}