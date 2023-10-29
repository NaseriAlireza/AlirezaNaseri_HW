#region Using
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace AlirezaNaseri_HW
{
    public class Practice2
    {
        public int AddDigits(int num)
        {
           
            int digitcounter = new();  // For Count Digits
            int yekan = new(); // For Getting Yekan ha
            int sum = new(); // For Add Digits
            int fakenum = num;
            
            #region Main Condition

            if (fakenum < 10)
            {
                return num;
            }
            else
            {
                for (; num >= 10;)
                {
                    yekan = fakenum % 10;
                    sum = sum + yekan;
                    fakenum /= 10;

                    if (fakenum == 0)
                    {
                        fakenum = sum;
                        num = sum;
                        sum = 0;
                    }

                }
                return num;
                
            }
            #endregion

        }

    }
}
