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
            if (Current.ElementAt(0).Equals('-'))
            {
                return Current;
            }
            string output = "";
            if (Current.Contains("+") ||
                Current.Contains("-") ||
                Current.Contains("x") ||
                Current.Contains("/"))
            {
                string[] numbers = Current.Split('+');
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i].Contains("x"))
                    {
                        string[] temp = numbers[i].Split('x');
                        numbers[i] = multiplication(temp).ToString();
                    }
                    if (numbers[i].Contains("/"))
                    {
                        string[] temp = numbers[i].Split('/');
                        numbers[i] = division(temp).ToString();
                    }
                    if (numbers[i].Contains("-"))
                    {
                        string[] temp = numbers[i].Split('-');
                        numbers[i] = reductions(temp).ToString();
                    }
                }
                double result = sum(numbers);
                output = result.ToString();
            }
            else
            {
                output = Current;
            }
            return output;
        }
        public string SolveBasic()
        {
            if (Current.ElementAt(0).Equals('-'))
            {
                return Current;
            }
            string output = "";
            if (Current.Contains("+") ||
                Current.Contains("-") || 
                Current.Contains("x") ||
                Current.Contains("/"))
            {
                string [] numbers = Current.Split('+');
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i].Contains("x"))
                    {
                        string[] temp = numbers[i].Split('x');
                        numbers[i] = multiplication(temp).ToString();
                    }
                    if (numbers[i].Contains("/"))
                    {
                        string[] temp = numbers[i].Split('/');
                        numbers[i] = division(temp).ToString();
                    }
                    if (numbers[i].Contains("-"))
                    {
                        string[] temp = numbers[i].Split('-');
                        numbers[i] = reductions(temp).ToString();
                    }
                }
                double result = sum(numbers);
                output = result.ToString();
            }
            else
            {
                output = Current;
            }
            return output;
        }

        private double sum(string[] numbers)
        {
            double sum = 0.0;
            foreach (string s in numbers)
            {
                sum += Double.Parse(s);
            }
            return sum;
        }

        private double reductions(string[] numbers)
        {
            double output = Double.Parse(numbers[0]);
            for (int i = 1; i < numbers.Length; i++) 
            {
                output = reduction(output, Double.Parse(numbers[i]));
            }
            return output;
        }

        private double division(string[] numbers)
        {
            double dividedElements = Double.Parse(numbers[0]);
            for (int i = 1; i < numbers.Length; i++)
            {
                dividedElements =
                    divide(dividedElements, Double.Parse(numbers[i]));
            }
            return dividedElements;
        }

        private double multiplication(string[] numbers)
        {
            double multiplyElement = 1;
            foreach (string s in numbers)
            {
                multiplyElement *= Double.Parse(s);
            }
            return multiplyElement;
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
