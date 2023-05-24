using System;
namespace Maxfour
{
    class Fourdigit
    {

        static string input = "3499994532324";
        int[] array = new int[20];
        int index = 0;
        int max = 0;
        public static void Main(string[] args)
        {
            Fourdigit obj_Digit = new Fourdigit();

            if (input.Length < 4)
            {
                Console.WriteLine("not possible");
            }

            else if(input.Length==4)
            {
                Console.WriteLine(input);
            }

            else 
            {
                //input values dupping into the array by converting in to int;
                while (obj_Digit.index != input.Length)
                {
                    int num = (int)input[obj_Digit.index]-48;

                    obj_Digit.array[obj_Digit.index] = num;
                    obj_Digit.index += 1;

                }

                // product of four adjecent digits
                for (int j = 0; j < obj_Digit.array.Length - 3; j++)
                {
                    int fourdigit_product = obj_Digit.array[j] * obj_Digit.array[j + 1] *obj_Digit.array[j + 2] * obj_Digit.array[j + 3];

                    //it checks which is max product
                    if (fourdigit_product > obj_Digit.max)
                    {
                        obj_Digit.max = fourdigit_product;
                    }
                }
                Console.WriteLine(obj_Digit.max);
            }
        }
        
    }
}