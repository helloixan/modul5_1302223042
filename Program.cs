class Program
{
    public static void Main(string[] args)
    {
        // NIM = 1302223042
        Penjumlahan penjumlahan = new Penjumlahan();
        float hasil = penjumlahan.JumlahTigaAngka<float>(13, 02, 22);
        Console.WriteLine("13 + 02 + 22 = " + hasil);

        SimpleDataBase<float> dataBase = new SimpleDataBase<float>();
        dataBase.AddNewData(13);
        dataBase.AddNewData(02);
        dataBase.AddNewData(22);
        dataBase.PrintAllData();
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


class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        this.storedData.Add(data);
        this.inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < this.storedData.Count; i++)
        {
            String date = inputDates[i].ToString("dd/MM/yyyy hh:mm:ss tt");
            Console.WriteLine("Data " + (i+1) + " berisi: " + storedData[i] + " yang disimpan pada waktu UTC: " + date);
        }
    }
}