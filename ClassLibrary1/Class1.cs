using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCEClassLibrary1
{
    public interface ILCE
    {
        string PrintNumbers(Range range,IDictionary<int,string> replaceMatrix);
    }

    public class Range
    {
        public Range()
        {
            LowerRange = 1;
            UpperRange = 100;
        }
        public Range(int lowerRange, int upperRange)
        {
            LowerRange = lowerRange;
            UpperRange = upperRange;
        }
        public int LowerRange { get; set; }
        public int UpperRange { get; set; }
    }

    public class LCE: ILCE
    {        
        public string PrintNumbers(Range range = null, IDictionary<int,string> replaceWith = null)
        {
            StringBuilder s = new StringBuilder();
            //If no range is specified then get the default range 
            if (range == null)
            {
                range = new Range();
            }
            //if no reaplce parameters are passed in, replace with the following. 
            if (replaceWith == null)
            {
                replaceWith = new Dictionary<int, string>
                {
                    {3,"FIZZ"},
                    {5,"BUZZ"}
                };
            }
            for (int i = (range.LowerRange < range.UpperRange ? range.LowerRange : range.UpperRange) ; 
                        i <= (range.UpperRange > range.LowerRange ? range.UpperRange : range.LowerRange); i++)
            {
                StringBuilder temp = new StringBuilder();

                if (replaceWith != null && replaceWith.Count > 0)
                {
                    foreach (var rNumber in replaceWith)
                    {
                        //You don't want to divide by 0 for obvious reasons.
                        //Devided by 1 should be handled only for equal case than divided by case
                        if (rNumber.Key != 1 && rNumber.Key != 0)
                        {
                            if (i % rNumber.Key == 0)
                            {
                                temp.Append(rNumber.Value);
                            }
                        }
                        else
                        {
                            if (i == rNumber.Key)
                            {
                                temp.Append(rNumber.Value);
                            }
                        }
                    }
                    if (temp.Length == 0)
                    {
                        temp.Append(i);
                    }
                }
                else
                {
                    temp.Append(i);
                }
                s.Append(temp.ToString());
                s.Append("\n");
            }
            return s.ToString();
        }
    }

    public class Excecise
    {
        private ILCE lce;
        public Excecise(ILCE lce)
        {
            this.lce = lce;
        }

        public Range range = null;
        public IDictionary<int, string> replaceMatrix = null;

        public string PrintNumbersSeries()
        {
            return lce.PrintNumbers(range, replaceMatrix);
        }
    }
}
