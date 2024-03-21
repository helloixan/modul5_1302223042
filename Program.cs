class Program
{
    public static void Main(string[] args)
    {
        // NIM = 1302223042
        Penjumlahan penjumlahan = new Penjumlahan();
        float hasil = penjumlahan.JumlahTigaAngka<float>(13, 02, 22);
        Console.WriteLine("13 + 02 + 22 = " + hasil);
    }
}

class Penjumlahan
{
    public float JumlahTigaAngka <T> (T num1, T num2, T num3)
    {
        dynamic angka1 = num1;
        dynamic angka2 = num2;
        dynamic angka3 = num3;
        return (angka1 + angka2 + angka3);
    }
}