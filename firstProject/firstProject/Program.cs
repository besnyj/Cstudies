﻿using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static string IsElseConditionalStatement()
        {
            int number = 0;

            string result;

            result = "";

            if(number < 0)
            {
                result = "negative";
            }
            else if(number == 0)
            {
                result = "zero";
            }
            else
            {
                result = "positive";
            }

            return result;
        }
    }
}