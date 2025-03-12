using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

class KodeProduk
{
    private static Dictionary<string, string> kodeProdukTable = new Dictionary<string, string>()
    {
        { "Laptop", "E100" },
        { " Laptop", "E100" },
        { "Smartphone", "E101" },
        { "Tablet", "E102" },
        { "Headset", "E103" },
        { "Keyboard", "E104" },
        { "Mouse", "E105" },
        { "Printer", "E106" },
        { "Monitor", "E107" },
        { "Smartwatch", "E108" },
        { "Kamera", "E109" }
    };

    public static string GetKodeProduk(string produk)
    {
        if (kodeProdukTable.ContainsKey(produk))
            return kodeProdukTable[produk];
        else
            return "Kode barang tidak ditemukan.";
    }

}
