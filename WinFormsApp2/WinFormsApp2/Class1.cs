using System;

namespace ClassLab
{
    public class Mass
    {
        private int[] arr;
        public Mass(int legt)

        {
            arr = new int[legt];
        }
        public Mass(int[] arrVal)
        {
            arr = new int[arrVal.Length];
            arr = arrVal;

        }
        public int getLegtMass
        {
            get { return arr.Length; }
        }
        public int this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
        public static int MaxMass(int[] arr) //поиск максимального
        {
            int max;
            int ind;

            max = arr[0];
            ind = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            
            return max;
        }

        public static int MaxMassInd(int[] arr, int startIndex, int endIndex) // поиск максимального числа в интервале 
        {
            int max = int.MinValue; //Представляет минимально допустимое значение типа Int32.

            for (int i = startIndex; i <= endIndex; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }

            return max;
        }
    }
}
