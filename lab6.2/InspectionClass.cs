using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6._2
{
    public class InspectionClass
    {
        [Conv("Конструктор 1")]
        public InspectionClass() { }
        [Conv("Конструктор 2")]
        public InspectionClass(int i, string s) { }
        public InspectionClass(string str,string s) { }

        public double MetrToYard(double x) { return x*1.094; }
        public double YardtoMetr(double x) { return x* 0.9144; }

        public bool  ConvOk
        {
            get { return _ConvOk; }
            set { _ConvOk = value; }
        }
        private bool _ConvOk;

        public int ConvError { get; set; }
        public double ConvResult { get; private set; }

        private int CountStep;
        public float TotalYard;
        public float TotalMetr;

    }
}
