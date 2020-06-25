using System;
using System.Collections.Generic;


namespace NarekLibrary.Statistics
{
    public static partial class Statistics
    {
        public static int Median(List<int> list)
        {
            if (list == null)
            {
                throw new ArgumentNullException("List is asigned to null");
            }
            if (list.Count == 0)
            {
                return 0;
            }

            list.Sort();

            if (list.Count % 2 == 1)
            {
                return list[list.Count / 2];
            }
            else
            {
                return (list[list.Count / 2] + list[(list.Count / 2) - 1]) / 2;
            }
        }


        public static decimal Median(List<decimal> list)
        {
            if (list == null)
            {
                throw new ArgumentNullException("List is asigned to null");
            }
            if (list.Count == 0)
            {
                return 0;
            }

            list.Sort();

            if (list.Count % 2 == 1)
            {
                return list[list.Count / 2];
            }
            else
            {
                return (list[list.Count / 2] + list[(list.Count / 2) - 1]) / 2;
            }
        }


        public static double Median(List<double> list)
        {
            if (list == null)
            {
                throw new ArgumentNullException("List is asigned to null");
            }
            if (list.Count == 0)
            {
                return 0;
            }

            list.Sort();

            if (list.Count % 2 == 1)
            {
                return list[list.Count / 2];
            }
            else
            {
                return (list[list.Count / 2] + list[(list.Count / 2) - 1]) / 2;
            }
        }


        public static long Median(List<long> list)
        {
            if (list == null)
            {
                throw new ArgumentNullException("List is asigned to null");
            }
            if (list.Count == 0)
            {
                return 0;
            }

            list.Sort();

            if (list.Count % 2 == 1)
            {
                return list[list.Count / 2];
            }
            else
            {
                return (list[list.Count / 2] + list[(list.Count / 2) - 1]) / 2;
            }
        }




        public static List<int> Mode(List<int> list, out long count)
        {
            count = 0;
            if (list == null)
            {
                throw new ArgumentNullException("List is asigned to null");
            }
            if (list.Count == 0)
            {
                return list;
            }

            List<int> result = new List<int>();
            int currentNumber = list[0];
            long currentCount = 1;


            list.Sort();

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] == currentNumber)
                {
                    currentCount++;
                }
                else if (currentCount > count)
                {
                    result.Clear();
                    result.Add(currentNumber);
                    count = currentCount;
                    currentCount = 1;
                    currentNumber = list[i];
                }
                else if (currentCount == count)
                {
                    result.Add(currentNumber);
                    currentNumber = list[i];
                    currentCount = 1;
                }
                else
                {
                    currentNumber = list[i];
                    currentCount = 1;
                }
            }

            if (currentCount > count)
            {
                result.Clear();
                result.Add(currentNumber);
                count = currentCount;

            }
            else if (currentCount == count)
            {
                result.Add(currentNumber);

            }
            return result;

        }

        public static List<long> Mode(List<long> list, out long count)
        {
            count = 0;
            if (list == null)
            {
                throw new ArgumentNullException("List is asigned to null");
            }
            if (list.Count == 0)
            {
                return list;
            }

            List<long> result = new List<long>();
            long currentNumber = list[0];
            long currentCount = 1;


            list.Sort();

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] == currentNumber)
                {
                    currentCount++;
                }
                else if (currentCount > count)
                {
                    result.Clear();
                    result.Add(currentNumber);
                    count = currentCount;
                    currentCount = 1;
                    currentNumber = list[i];
                }
                else if (currentCount == count)
                {
                    result.Add(currentNumber);
                    currentNumber = list[i];
                    currentCount = 1;
                }
                else
                {
                    currentNumber = list[i];
                    currentCount = 1;
                }
            }

            if (currentCount > count)
            {
                result.Clear();
                result.Add(currentNumber);
                count = currentCount;

            }
            else if (currentCount == count)
            {
                result.Add(currentNumber);

            }
            return result;

        }

        public static List<decimal> Mode(List<decimal> list, out long count)
        {
            count = 0;
            if (list == null)
            {
                throw new ArgumentNullException("List is asigned to null");
            }
            if (list.Count == 0)
            {
                return list;
            }

            List<decimal> result = new List<decimal>();
            decimal currentNumber = list[0];
            long currentCount = 1;


            list.Sort();

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] == currentNumber)
                {
                    currentCount++;
                }
                else if (currentCount > count)
                {
                    result.Clear();
                    result.Add(currentNumber);
                    count = currentCount;
                    currentCount = 1;
                    currentNumber = list[i];
                }
                else if (currentCount == count)
                {
                    result.Add(currentNumber);
                    currentNumber = list[i];
                    currentCount = 1;
                }
                else
                {
                    currentNumber = list[i];
                    currentCount = 1;
                }
            }

            if (currentCount > count)
            {
                result.Clear();
                result.Add(currentNumber);
                count = currentCount;

            }
            else if (currentCount == count)
            {
                result.Add(currentNumber);

            }
            return result;

        }

        public static List<double> Mode(List<double> list, out long count)
        {
            count = 0;
            if (list == null)
            {
                throw new ArgumentNullException("List is asigned to null");
            }
            if (list.Count == 0)
            {
                return list;
            }

            List<double> result = new List<double>();
            double currentNumber = list[0];
            long currentCount = 1;


            list.Sort();

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] == currentNumber)
                {
                    currentCount++;
                }
                else if (currentCount > count)
                {
                    result.Clear();
                    result.Add(currentNumber);
                    count = currentCount;
                    currentCount = 1;
                    currentNumber = list[i];
                }
                else if (currentCount == count)
                {
                    result.Add(currentNumber);
                    currentNumber = list[i];
                    currentCount = 1;
                }
                else
                {
                    currentNumber = list[i];
                    currentCount = 1;
                }
            }

            if (currentCount > count)
            {
                result.Clear();
                result.Add(currentNumber);
                count = currentCount;

            }
            else if (currentCount == count)
            {
                result.Add(currentNumber);

            }
            return result;

        }


        public static double StandardDeviation(List<int> list, bool isPopulation)
        {

            if (list == null)
            {
                throw new ArgumentNullException("List is asigned to null");
            }
            if (list.Count == 0)
            {
                throw new ArgumentException("List is empty");
            }
            if (list.Count == 1 && !isPopulation)
            {
                throw new ArgumentException("Devided by zero, due to one item in the list");
            }

            double mean = TruncatedMean(list, 0);
            double variance = 0;
            foreach (int i in list)
            {
                variance += (i - mean) * (i - mean);
            }

            if (isPopulation)
            {
                return Math.Sqrt(variance / list.Count);
            }
            return Math.Sqrt(variance / (list.Count - 1));

        }

        public static double StandardDeviation(List<long> list, bool isPopulation)
        {

            if (list == null)
            {
                throw new ArgumentNullException("List is asigned to null");
            }
            if (list.Count == 0)
            {
                throw new ArgumentException("List is empty");
            }
            if (list.Count == 1 && !isPopulation)
            {
                throw new ArgumentException("Devided by zero, due to one item in the list");
            }

            double mean = TruncatedMean(list, 0);
            double variance = 0;
            foreach (int i in list)
            {
                variance += (i - mean) * (i - mean);
            }

            if (isPopulation)
            {
                return Math.Sqrt(variance / list.Count);
            }
            return Math.Sqrt(variance / (list.Count - 1));

        }

        public static double StandardDeviation(List<decimal> list, bool isPopulation)
        {

            if (list == null)
            {
                throw new ArgumentNullException("List is asigned to null");
            }
            if (list.Count == 0)
            {
                throw new ArgumentException("List is empty");
            }
            if (list.Count == 1 && !isPopulation)
            {
                throw new ArgumentException("Devided by zero, due to one item in the list");
            }

            decimal mean = TruncatedMean(list, 0);
            decimal variance = 0;
            foreach (int i in list)
            {
                variance += (i - mean) * (i - mean);
            }

            if (isPopulation)
            {
                return Math.Sqrt((double)variance / list.Count);
            }
            return Math.Sqrt((double)variance / (list.Count - 1));

        }

        public static double StandardDeviation(List<double> list, bool isPopulation)
        {

            if (list == null)
            {
                throw new ArgumentNullException("List is asigned to null");
            }
            if (list.Count == 0)
            {
                throw new ArgumentException("List is empty");
            }
            if (list.Count == 1 && !isPopulation)
            {
                throw new ArgumentException("Devided by zero, due to one item in the list");
            }

            double mean = TruncatedMean(list, 0);
            double variance = 0;
            foreach (int i in list)
            {
                variance += (i - mean) * (i - mean);
            }

            if (isPopulation)
            {
                return Math.Sqrt(variance / list.Count);
            }
            return Math.Sqrt(variance / (list.Count - 1));

        }

    }
}
