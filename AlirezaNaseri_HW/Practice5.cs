#region Using
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace AlirezaNaseri_HW
{
    public class Practice5:methods
    {
        public bool WordPattern(string pattern, string s)
        {
            char[] patternchar = pattern.ToCharArray();//pattern to char[]
            char[] schar = s.ToCharArray();//s to char[]
            char[][]? patternands = new char[patternchar.Length][];//pattern and s  to char[][]

            for (int i = 0; i < patternchar.Length; i++)
            {
                patternands[i]=SortArrayChar(schar);
                int index = patternands[i].Length - 1;
                patternands[i][index] = patternchar[i];
            }//put pattern and s next to each other 

            for(int i=0;i<patternchar.Length ;i++ )
            {
                for (int j=i+1;j<patternchar.Length ;j++)
                {
                    if (IsSameLastCharacter( patternands[i], patternands[j]) && !IsSame(patternands[i], patternands[j]) )
                    {
                        return false;
                    }//Is s follows the same pattern
                }
            }//Is s follows the same pattern
            return true;

        }

    }
    public class methods
    {
        
        protected static char[] SortArrayChar(char[] chars)
        {
            char[]? rechars = new char[10];
            int count = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == ' ' && count<4)
                {
                    count++;
                    for (int j = 0; j < i; j++)
                    {

                        rechars[j] = chars[j];
                        chars[j] = '\0';
                        chars[i] = '\0';

                    }
                    int index = i;

                    for (int j = 0; j < chars.Length; j++)
                    {
                        try
                        {
                            chars[j] = chars[j + index + 1];
                        }
                        catch (Exception)
                        {

                            chars[j] = '\0';
                        }

                    }




                    return rechars;
                }
                
            
            }
            for(int i = 0; chars[i]!='\0' ;i++ )
            {
                rechars[i] = chars[i];
            }
            return rechars;


        }
        protected static bool IsSame(char[] char1, char[] char2)
        {    
            bool flag = true;
            for (int i = 0; i < char1.Length; i++)
            {
                
                if (char1[i] != char2[i])
                {
                    flag = false;
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
        protected static bool IsSameLastCharacter(char[] char1, char[] char2)
        {
            if (char1[char1.Length-1] == char2[char2.Length - 1])
            {
                return true;
            }
            return false;

        }

    }
}
