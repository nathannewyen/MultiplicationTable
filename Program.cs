﻿using System;
using System.Collections.Generic;

namespace multidimensional {
    class Program {
        static void Main (string[] args) {
            int[] multiplicationTable = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 1; i <= 10; i++) {
                for (int j = 1; j <= 10; j++) {
                    Console.Write ((i * j).ToString () + "\t");
                }
                Console.WriteLine ();
            }
        }
    }
}