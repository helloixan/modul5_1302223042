class Program
{
    public static void Main(string[] args)
    {
        SimpleDataBase<float> dataBase = new SimpleDataBase<float>();
        dataBase.AddNewData(13);
        dataBase.AddNewData(02);
        dataBase.AddNewData(22);
        dataBase.PrintAllData();
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