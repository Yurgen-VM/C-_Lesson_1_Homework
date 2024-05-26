using System.Runtime.Serialization.Json;

namespace Task_1_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Вы не указали выражение");
                return;
            }
            else
            {
                if (args.Length <= 2) // Реализация для случая, когда выражение записано слитно, к примеру: a+b, a-b, a*b, a/b
                {
                    //string str = args[0];
                    string str = String.Concat(args);
                    Console.WriteLine(str);
                    if (str.Length >= 3)
                    {
                        for (int i = 0; i < str.Length; i++ )
                        {
                            char[] sep = new char[] {'+', '-', '*', '/',' ' };
                            string[] strArray = str.Split(sep);
                            double.TryParse(strArray[0], out double oprnd_1);
                            double.TryParse(strArray[1], out double oprnd_2);
                            double result;
                            switch (str[i])
                            {
                                case '+':
                                    if (strArray.Length > 2)
                                    {
                                        Console.WriteLine("Превышено количестово операндов в выражении");
                                        return;
                                    }
                                    result = oprnd_1 + oprnd_2;
                                    Console.WriteLine($"Значение выражения {oprnd_1} + {oprnd_2} = {result}");
                                    return;
                                
                                case '-':
                                    if (strArray.Length > 2)
                                    {
                                        Console.WriteLine("Превышено количестово операндов в выражении");
                                        return;
                                    }
                                    result = oprnd_1 - oprnd_2;
                                    Console.WriteLine($"Значение выражения {oprnd_1} - {oprnd_2} = {result}");
                                    return;
                                
                                case '*':
                                    if (strArray.Length > 2)
                                    {
                                        Console.WriteLine("Превышено количестово операндов в выражении");
                                        return;
                                    }
                                    result = oprnd_1 * oprnd_2;
                                    Console.WriteLine($"Значение выражения {oprnd_1} * {oprnd_2} = {result}");
                                    return;


                            }
                                                    

                            
                         
                        }


                    }
                    else
                    {
                        Console.WriteLine("Недостаточное количество аргументов");
                        return;
                    }
                }
                else
                {
                    double.TryParse(args[0], out double oprnd_1);
                    double.TryParse(args[2], out double oprnd_2);
                    char.TryParse(args[1], out char oprt);
                    double result;
                    switch (oprt)
                    {
                        case '+':
                            result = oprnd_1 + oprnd_2;
                            Console.WriteLine(result);
                            break;

                        case '-':
                            result = oprnd_1 - oprnd_2;
                            Console.WriteLine(result);
                            break;

                        case '*':
                            result = oprnd_1 * oprnd_2;
                            Console.WriteLine(result);
                            break;

                        case '/':
                            result = oprnd_1 / oprnd_2;
                            Console.WriteLine(result);
                            break;
                    }

                }





            }
        }
    }
}
