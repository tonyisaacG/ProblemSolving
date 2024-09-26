using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode75.ArrayString
{
   
    [Description("1768. Merge Strings Alternately")]
    public class MergeStringsAlternately_1768 : IRunFactoryMethod
    {

        public string MergeAlternately(string word1,string word2)
        {
            int pointer = 0;
            StringBuilder stringBuilder = new StringBuilder();
            while( pointer < word1.Length || pointer < word2.Length )
            {
                if( pointer < word1.Length ) { stringBuilder.Append(word1[pointer]); }
                if( pointer < word2.Length ) { stringBuilder.Append(word2[pointer]); }
                pointer++;
            }
            return stringBuilder.ToString();
        }

        public void Run()
        {
            var str = MergeAlternately("abc","pqr");
            Console.WriteLine(str);
        }
    }
}
