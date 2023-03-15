﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm
{
    public class InsertionSort
    {
        // string[] binaryArr;
        // public void ReadTextFile(string filepath)
        //{
        //  string words = File.ReadAllText(filepath);
        //binaryArr = words.Split(",");       
        //}
        public void Sort(int[] binaryArr)
        {
            for (int i = 0; i < binaryArr.Length - 1; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (binaryArr[j].CompareTo(binaryArr[i]) < 0)
                    {
                        int temp = binaryArr[i];
                        binaryArr[i] = binaryArr[j];
                        binaryArr[j] = temp;
                    }
                }
            }
            foreach (var data in binaryArr)
            {
                Console.WriteLine(data);
            }
        }
        // public void Display()
        //{
        //  foreach (var data in binaryArr)
        //{
        //  Console.WriteLine(data);
        //}
    }
}