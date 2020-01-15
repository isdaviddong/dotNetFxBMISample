using System;
using System.Collections.Generic;
using System.Text;

namespace HealthMgr
{
   public class BmiCalculator
    {
        public int Weight { get; set; }
        public int Height { get; set; }
        public float BMI
        {
            get
            {
                return Calculate();
            }
        }


        public float Calculate()
        {
            float result = 0;
            //將 float 改成 int 試試看
            float height = (float)Height / 100;
            result = Weight / (height * height);

            return result;
        }
    }
}
