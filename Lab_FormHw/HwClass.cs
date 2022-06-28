using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_FormHw
{
    public struct StudentScore
    {
        public string StudentName;
        public int StudentChi;
        public int StudentEng;
        public int StudentMath;        
    }

    public struct StudentGrade
    {
        public string StudentName;
        public double StudentChi;
        public double StudentEng;
        public double StudentMath;
        public double StudentTotal;
        public double StudentAvg;
        public string StudentMax;
        public string StudentMin;
    }
}
