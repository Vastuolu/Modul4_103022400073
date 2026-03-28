using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("####Soal 1");
        Console.Write("Masukkan Nama Paket: ");
        string inNamaPaket = Console.ReadLine();
        string gettedKodePaket = KodePaket.getKodePaket(inNamaPaket);
        if (gettedKodePaket.Length <= 0)
        {
            Console.WriteLine("Nama Paket tidak ditemukan");
        }
        else
        {
            Console.WriteLine("Kode Paket: " + gettedKodePaket);
        }

        Console.WriteLine("####Soal 2");
        MesinKopi mesinKopi = new MesinKopi();
        mesinKopi.Jalankan();
    }
}