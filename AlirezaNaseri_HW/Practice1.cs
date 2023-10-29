#region Using
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace AlirezaNaseri_HW
{
    public class Practice1
    {

        public bool ValidAnagram(string s, string t)// IS Not Case Sensitive
        {

            char[] S = s.ToCharArray();//convert string to char[] for s
            char[] T = t.ToCharArray();//convert string to char[] for t


            
            if (T.Length != S.Length)
            {
                return false;
            }//to be same  T length and S length

            for (int i = 0; i < S.Length; i++)
            {
                int count = 0;

                for (int j = 0; j < T.Length; j++)
                {
                    if (S[i] == T[j])
                    {
                        count++;
                    }
                }
                if (count < 1)
                {
                    return false;
                }
            }//to not being a character in only one char[]

            for (int i = 0; i < S.Length; i++)
            {
                int countT = 0;
                int countS = 0;

                char m = '\0';

                for (int j = 0; j < T.Length; j++)
                {
                    if (S[i] == T[j])
                    {
                        countT++;
                    }

                }
                m = S[i];
                for (int j = 0; j < T.Length; j++)
                {
                    if (S[j] == m)
                    {
                        countS++;
                    }

                }
                if (countS != countT)
                {
                    return false;
                }
            }//number of each character should be same in both char[]
            return true;
        }

    }

}

