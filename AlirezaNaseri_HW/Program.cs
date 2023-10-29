namespace AlirezaNaseri_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Practice1 practice1 = new();
            var x1=practice1.ValidAnagram("ma1d", "mda1");
           
            Practice2 practice2 = new();
            var x2=practice2.AddDigits(38);

            Practice3 practice3 = new();
            var x3=practice3.IsUgly(14);

            Practice4 practice4 = new();
            practice4.MoveZeroes(new int[] {0,65,4,0,2,-1,0,42,5});

            Practice5 practice5 = new();
            var x5=practice5.WordPattern("abab", "cat rabbit dog rabbit");


        }
    }
}