using System;
namespace Str
{
    public class Substrings
    {
        static string main_str = "abcdefgabvdhsjab";
        static string sub_str = "ab";
        int main_len = main_str.Length;
        int sub_len = sub_str.Length;
        int count = 0;
        public static void Main(string[] args)
        {
            Substrings str_obj = new Substrings();

            //checking the len of main_str and sub_str
            if (str_obj.main_len<str_obj.sub_len)
            {
                Console.WriteLine("not possible");
            }

            //to split main_str to substring and checking with the sub_string
            for(int index=0 ; index<str_obj.main_len +1 - str_obj.sub_len ; index++)
            {
                string s3 = main_str.Substring(index, str_obj.sub_len);

                if (sub_str == s3)
                {
                    str_obj.count += 1;
                    Console.WriteLine(index);
                }
                
            }
            Console.WriteLine(str_obj.count);
        }
    }
}