﻿using System;
using System.Collections.Generic;

namespace ListIntro {
    class Program {
        static void Main (string[] args) {
            List<string> nssCohorts = new List<string> {
                "Cohort 36",
                "Cohort 37",
                "Cohort 38"
            };

            nssCohorts.Add ("Cohort 39");

            List<int> birthYears = new List<int> {
                1996,
                1993,
                1992,
                2001,
                1998
            };

            birthYears.Add (1999);
            birthYears.Add (1989);
            birthYears.Add (1987);
            birthYears.Add (1985);

            foreach (string cohort in nssCohorts) {
                Console.WriteLine (cohort);
            }

            birthYears.Remove (1989);

            foreach (int year in birthYears) {
                Console.WriteLine (year);

                if (year == 1996) {
                    Console.WriteLine ("Holden was born");
                    Console.WriteLine ("Oh and Go Buls");
                }
            }
        }
    }
}