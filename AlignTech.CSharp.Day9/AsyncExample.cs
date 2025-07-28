namespace AlignTech.CSharp.Day9
{
    internal class AsyncExample
    {
        public async Task<string> DownloadAsync()
        {
            using HttpClient client = new HttpClient();
            return await client.GetStringAsync("https://www.wikipedia.org/");
        }
    }

    public class FileHandling
    {
        public async static Task<string> ReadDataAsync(string filePath)
        {
            //FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            //StreamReader reader = new StreamReader(fs);
            //string data = await reader.ReadToEndAsync();
            var data = await File.ReadAllTextAsync(filePath);
            //Assume time taken to read from file
            Thread.Sleep(2000);            
            return data;
        }

        public async Task FetchAndDisplayDataAsync(string filePath)
        {
            Console.WriteLine("Reading started....");
            // string result = await Task.Run(() => ReadDataAsync(filePath));
            string result = await ReadDataAsync(filePath);
            Console.WriteLine("Reading Data....");
            Console.WriteLine($"File Data :{result}");
        }

        public static string ReadData(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs);
            string data = reader.ReadToEnd();
            //Assume time taken to read from file
            Thread.Sleep(2000);
            reader.Close();
            fs.Close();
            return data;
        }

        public void FetchAndDisplayData(string filePath)
        {
            Console.WriteLine("Reading started....");
            var result = ReadData(filePath);
            Console.WriteLine("Reading Data....");
            Console.WriteLine($"File Data :{result}");
        }
    }
}
