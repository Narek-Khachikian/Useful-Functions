using System;
using System.Collections.Generic;


namespace NarekLibrary.Statistics
{
    public static partial class Statistics
    {
        public static double TruncatedMean(this List<double> list, int truncator)
        {

            if (list == null)
            {
                throw new ArgumentNullException("The list reference is null");
            }

            if (truncator < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid trancator : {0}", truncator.ToString());
            }
            if (truncator * 2 > list.Count)
            {
                throw new ArgumentOutOfRangeException("Big truncator : {0}", truncator.ToString());
            }




            list.Sort();
            double sum = 0;

            for (int i = truncator; i < list.Count - truncator; i++)
            {
                sum += list[i];

            }
            return sum / (list.Count - truncator * 2);

        }


        public static decimal TruncatedMean(this List<decimal> list, int truncator)
        {

            if (list == null)
            {
                throw new ArgumentNullException("The list reference is null");
            }

            if (truncator < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid trancator : {0}", truncator.ToString());
            }
            if (truncator * 2 > list.Count)
            {
                throw new ArgumentOutOfRangeException("Big truncator : {0}", truncator.ToString());
            }
            if (truncator * 2 == list.Count)
            {
                return 0;
            }




            list.Sort();
            decimal sum = 0;




            for (int i = truncator; i < list.Count - truncator; i++)
            {
                sum += list[i];

            }
            return sum / (list.Count - truncator * 2);

        }


        public static double TruncatedMean(this List<long> list, int truncator)
        {

            if (list == null)
            {
                throw new ArgumentNullException("The list reference is null");
            }

            if (truncator < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid trancator : {0}", truncator.ToString());
            }
            if (truncator * 2 > list.Count)
            {
                throw new ArgumentOutOfRangeException("Big truncator : {0}", truncator.ToString());
            }
            if (truncator * 2 == list.Count)
            {
                return 0;
            }




            list.Sort();
            long sum = 0;




            for (int i = truncator; i < list.Count - truncator; i++)
            {
                sum += list[i];

            }
            return sum / (list.Count - truncator * 2);

        }


        public static double TruncatedMean(this List<int> list, int truncator)
        {

            if (list == null)
            {
                throw new ArgumentNullException("The list reference is null");
            }

            if (truncator < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid trancator : {0}", truncator.ToString());
            }
            if (truncator * 2 > list.Count)
            {
                throw new ArgumentOutOfRangeException("Big truncator : {0}", truncator.ToString());
            }
            if (truncator * 2 == list.Count)
            {
                return 0;
            }




            list.Sort();
            int sum = 0;

            for (int i = truncator; i < list.Count - truncator; i++)
            {
                sum += list[i];

            }
            return sum / (list.Count - truncator * 2);

        }



    }
}
