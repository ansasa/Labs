using System;
using System.Collections.Generic;
using System.Text;

namespace Hon.Demo
{
    public class PriorityCalculator
    {
        public string Calculate(int score)
        {
            if (score >= 80) return "HIGH";
            if (score >= 50) return "MEDIUM";
            return "LOW";
        }
    }
}

