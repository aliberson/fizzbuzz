using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace ClassLibrary1
{
    public static class Class1
    {
        //public static List<string> AnalyzeNumbers(int startingRangeNumber, int endingRangeNumber, Dictionary<int, string> dict)
        //{
        //    string text;
        //    List<string> items = new List<string>();
            
        //    for (int i = startingRangeNumber; i < endingRangeNumber + 1; i++)
        //    {
        //        text = ""; // init

        //        for (int j = 0; j < dict.Keys.Count; j++)
        //        {
        //            var operand = dict.ElementAt(j).Key;
                    

        //            if ((i % operand) == 0)
        //            {
        //                text += dict.ElementAt(j).Value.ToString();
        //            }
        //        }

        //        items.Add(i + " " + text);

                
        //        //System.Diagnostics.Debug.WriteLine("{0} {1}", i, text);
        //    }
        //    return items;
        //}


        public static List<string> AnalyzeNumbers(int startingRangeNumber, int endingRangeNumber, Dictionary<int, string> dict)
        {
            List<string> items = new List<string>();

            for (int i = startingRangeNumber; i < endingRangeNumber + 1; i++)
            {
                string analysisResult = ""; // init

                analysisResult = getAnalysis(i, dict);
                items.Add(i + " " + analysisResult);


                //System.Diagnostics.Debug.WriteLine("{0} {1}", i, text);
            }
            return items;
        }

        public static string getAnalysis(int numberToAnalyze, Dictionary<int, string> dict)
        {
            string text = "";

            for (int i = 0; i < dict.Keys.Count; i++)
            {
                var operand = dict.ElementAt(i).Key;


                if ((numberToAnalyze % operand) == 0)
                {
                    text += dict.ElementAt(i).Value.ToString();
                }
            }

            return text;
        }

        public static void writeOutput(List<string> analyzedNumbers)
        {
            foreach (var item in analyzedNumbers)
            {
                System.Diagnostics.Debug.WriteLine(item);
            }
        }

    }
}
