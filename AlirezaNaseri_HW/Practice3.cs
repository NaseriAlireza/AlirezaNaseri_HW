#region Using
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace AlirezaNaseri_HW
{
    public class Practice3:Methods3
    {
        public bool IsUgly(int n)
        {       
            
            double a=Convert.ToDouble(n);//For more accurate division
            int[] nums = { 2, 3, 5 };//The main number
            
            #region Main Condition
            if (n == 1)
            {
                return true;
            }
            if (Check(a))
            {
                return true;
            }
            else
            {

                while (true)
                {

                    for (int i = 0; a % nums[i] == 0; i++)
                    {
                        if (a % nums[i] == 0)
                        {
                            while (a % nums[i] == 0)
                            {
                                a = a / nums[i];
                            }
                        }
                        if (i == 2)
                        {
                            i = 0;
                        }
                    }
                    if (a == 1 || Check(a))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }


            }
            #endregion
            
        }
    }
    public class Methods3
    {
        protected bool Check(double num)
        {
            bool flag = false;
            int[] nums = { 2, 3, 5 };
            for (int i = 0; i < 3; i++)
            {
                if (num == nums[i])
                {
                    flag = true;
                    break;
                }

            }
            if (flag)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
