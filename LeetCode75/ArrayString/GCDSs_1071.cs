using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode75.ArrayString
{

    [Description("1071. Greatest Common Divisor of Strings")]
    public class GCDSs_1071 : IRunFactoryMethod
    {

        #region fail trying
        //public string GcdOfStrings(string str1,string str2)
        //{

        //    int pointerStr1 = 0;
        //    int pointerStr2 = 0;
        //    string sstr1 = str1.Length>str2.Length?str1:str2;
        //    string sstr2 = str1.Length<str2.Length ? str1:str2;
        //    StringBuilder stringBuilder = new StringBuilder();
        //    while( pointerStr1 < sstr1.Length )
        //    {
        //        if( sstr2[pointerStr2] == sstr1[pointerStr1] )
        //        {
        //            pointerStr1++;
        //            pointerStr2++;
        //        }
        //        else { return string.Empty; }
        //        if( pointerStr2 > sstr2.Length-1 ) pointerStr2 = 0;
        //    }
        //    for( int i =sstr2.Length; i < sstr1.Length; i++ )
        //    {
        //        stringBuilder.Append(sstr1[i]);
        //    }
        //    return stringBuilder.ToString();
        //}
        #endregion


        #region using Euclidean Algorithm (GCD of Lengths)
        public string GcdOfStrings(string str1,string str2)
        {
            if( str1 + str2 != str2 + str1 )
                return string.Empty;
            int gcdLength = GCD(str1.Length,str2.Length);
            return str1.Substring(0,gcdLength);
        }
        private int GCD(int a,int b)
        {
            if( b == 0 ) return a;
            return GCD(b,a%b);
        }
        #endregion

        #region 5. Recursive Approach (Based on GCD of Strings)
        public string GcdOfStrings_Recursive(string str1,string str2)
        {
            if( str1 + str2 != str2 + str1 )
                return string.Empty;
            if( str2 == "" ) return str1;
            return GcdOfStrings_Recursive(str2,str1.Substring(0,str1.Length % str2.Length));
        }
       
        #endregion


        public void Run()
        {
            var str = GcdOfStrings_Recursive("ABCABC","ABC");
            Console.WriteLine(str);
            var str2 = GcdOfStrings_Recursive("ABCDEF","ABC");
            Console.WriteLine(str2);
            var str3 = GcdOfStrings_Recursive("TAUXXTAUXXTAUXXTAUXXTAUXX","TAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXX");
            Console.WriteLine(str3);
        }
    }
}
