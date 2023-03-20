﻿// See https://aka.ms/new-console-template for more information

// leap year

namespace tsd2023_linq2
{
    public class Leap
    {
        public Func<int, bool> leap = (int year) => (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
    }

}