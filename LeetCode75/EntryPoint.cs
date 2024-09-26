using LeetCode75.ArrayString;

namespace LeetCode75
{
    public class EntryPoint
    {
        private static IRunFactoryMethod method;
        private static Dictionary<string,string>
            LeetCode75Dic = new Dictionary<string,string>
            {
                { "1768","MergeStringsAlternately_1768" }
            };

        

        public void Start()
        {
            IRunFactoryMethod method = new MergeStringsAlternately_1768();
            method.Run();
        }
    }
}
