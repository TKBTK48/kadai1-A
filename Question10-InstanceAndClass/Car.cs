using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Question10_InstanceAndClass
{
    public class Car
    {
        public string color;
        public int gasoline;
        public int Run()
        {
            Random randomnumber = new System.Random();
            gasoline = gasoline - 1;
            int result;
            if (gasoline <= 0)
            {
                result = -1;
            }
            result = randomnumber.Next(15);
            return result;
        }
    }
}
