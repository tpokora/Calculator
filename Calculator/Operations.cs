using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    
    public class Operations
    {
        public string Current { get; set; }
        public string Result { get; set; }

        public void AddToCurrent(string old, string addition)
        {
            Current = old + addition;
        }

        public string DeleteLast()
        {
            if (Current.Length > 0) {
                StringBuilder output = new StringBuilder();
                for (int i = 0; i < Current.Length - 1; i++)
                {
                    output.Append(Current.ElementAt(i));
                }
                this.Current = output.ToString();
                return output.ToString();
            }
            else
            {
                return "";
            }
        }

        public string Clear()
        {
            Current = "";
            Result = "0";
            return Current;
        }

        public string Solve()
        {
            string output = "";
            if (Current.Contains("+"))
            {
                string [] numbers = Current.Split('+');
                for (int i = 0; i < numbers.Length; i++)
                {

                }
                double result = 0.0;
                foreach (string s in numbers)
                {
                    result = add(result, Double.Parse(s));
                }
                output = result.ToString();
            }
            else
            {
                output = Current;
            }
            return output;
        }

        private double add(double x, double y) {
            return x + y;
        }

        private double reduction(double x, double y)
        {
            return x - y;
        }

        private double multiply(double x, double y)
        {
            return x * y;
        }

        private double divide(double x, double y)
        {
            return x / y;
        }
    }

    
}
