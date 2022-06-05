namespace TestProject1
{
    public class MoodAnalyserFactory
    {
        public MoodAnalyserFactory(string v1, string v2)
        {
        }

        public string Constructor { get; internal set; }
        public string ClassName { get; internal set; }

        internal static object FactoryMethod(MoodAnalyserFactory factory)
        {
            throw new NotImplementedException();
        }

        internal static object InvokeMethod(MoodAnalyserFactory factory, string v)
        {
            throw new NotImplementedException();
        }
    }
}