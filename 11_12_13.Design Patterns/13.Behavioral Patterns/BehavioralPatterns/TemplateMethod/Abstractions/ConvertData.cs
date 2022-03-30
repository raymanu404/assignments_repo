
namespace TemplateMethod.Abstractions
{
    public abstract class ConvertData
    {
        public void MineData()
        {
            Console.WriteLine("Data mining process has started....");
            OpenFile();
            ReadData();
            ParseData();
            AnalyzeData();
            SendReport();
            CloseFile();
            Console.WriteLine("Data mining process completed...");
            Console.WriteLine();
        }

        protected abstract void OpenFile();
        protected abstract void ReadData();
        protected abstract void ParseData();

        protected virtual void AnalyzeData()
        {
            Console.WriteLine("Analyzing data....");
        }

        protected virtual void SendReport()
        {
            Console.WriteLine("Sending report....");
        }

        protected abstract void CloseFile();
    }
}
