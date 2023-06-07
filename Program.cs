using System;
namespace ConsoleApp39
{
    class Program
    {
        static void Main()
        {
            
            int[] array = new int[12];
            int nmonth, nday;
            Random rnd = new Random();
            array[0] = 31;
            array[1] = 29;
            array[2] = 31;
            array[3] = 30;
            array[4] = 31;
            array[5] = 30;
            array[6] = 31;
            array[7] = 31;
            array[8] = 30;
            array[9] = 31;
            array[10] = 30;
            array[11] = 31;
            try
            {
                Console.WriteLine("введите номер месяца ");
                nmonth = Convert.ToInt32(Console.ReadLine());
                if (nmonth <= 0 || nmonth > 12)
                {
                    throw new Exception("не корректно введены данные");
                    p();
                    return;
                }
                Console.WriteLine("введите номер дня месяца");
                nday = Convert.ToInt32(Console.ReadLine());
                if (array[nmonth - 1] < nday || nday <= 0)
                {
                    throw new Exception("не корректно введены данные");
                   
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                p();
                return;
            }
            Console.WriteLine();
            int countday = 0;
            for (int i = 0; i < (nmonth - 1); i++)
            {
                countday += array[i];
            }

            countday += nday;
            countday = countday % 7;
            switch (countday)
            {
                case 0:
                    Console.WriteLine("воскресенье");
                    break;
                case 1:
                    Console.WriteLine("понедельник");
                    break;
                case 2:
                    Console.WriteLine("вторник");
                    break;
                case 3:
                    Console.WriteLine("среда");
                    break;
                case 4:
                    Console.WriteLine("четверг");
                    break;
                case 5:
                    Console.WriteLine("пятница");
                    break;
                case 6:
                    Console.WriteLine("суббота");
                    break;
            }

            

            void p()
            {
                Console.WriteLine("повторить ввод если да то 1 нет то 0");
                string y = Convert.ToString(Console.ReadLine());
                if (y == "1")
                    Main();
                else
                    return;
            }
            p();
            return;
        }
    }
}


