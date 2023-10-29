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
    public class Practice4
    {
        public void MoveZeroes(int[] nums)
        {
            
            for (int i = 0; i < nums.Length; i++) 
            {
                for (int j=i+1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j] && nums[i]!=0 && nums[j] != 0)
                    {
                        int index = nums[i];
                        nums[i] = nums[j];
                        nums[j] = index;
                    }//Shift For Non-Zeros 
                    else if (nums[i] < nums[j] && nums[i] == 0)
                    {
                        int index = nums[i];
                        nums[i] = nums[j];
                        nums[j] = index;
                    }//Shift For Zeros
                }
               
            }

        }
    }
}
