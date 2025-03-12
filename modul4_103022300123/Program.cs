using System;

class program
{
    static void Main(string[] args)
    {
        Console.Write("Masukkan nama produk: ");
        string produk = Console.ReadLine();

        string kodeBarang = KodeProduk.GetKodeProduk(produk);
        Console.WriteLine($"Kode Barang {produk}: {kodeBarang}");
    }
}