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
                string str = String.Concat(args); // Реализация для случая, когда выражение записано слитно, к примеру: a+b, a +b, a+ b
                //Console.WriteLine(str);
                if (str.Length > 2)
                {
                    for (int i = 0; i < str.Length; i++)
                    {
                        char[] sep = new char[] { '+', '-', '*', '/', };
                        string[] strArray = str.Split(sep);
                        double result;
                        if (strArray.Length > 2)
                        {
                            Console.WriteLine("Превышено количестово операндов в выражении");
                            return;
                        }
                        if (double.TryParse(strArray[0], out double oprnd_1))
                        {
                            if (double.TryParse(strArray[1], out double oprnd_2))
                            {
                                switch (str[i])
                                {
                                    case '+':
                                        result = oprnd_1 + oprnd_2;
                                        Console.WriteLine($"Значение выражения {oprnd_1} + {oprnd_2} = {result}");
                                        return;

                                    case '-':
                                        result = oprnd_1 - oprnd_2;
                                        Console.WriteLine($"Значение выражения {oprnd_1} - {oprnd_2} = {result}");
                                        return;

                                    case '*':
                                        result = oprnd_1 * oprnd_2;
                                        Console.WriteLine($"Значение выражения {oprnd_1} * {oprnd_2} = {result}");
                                        return;

                                    case '/':
                                        if (oprnd_2 != 0)
                                        {
                                            result = oprnd_1 / oprnd_2;
                                            Console.WriteLine($"Значение выражения {oprnd_1} / {oprnd_2} = {result}");
                                            return;
                                        }
                                        Console.WriteLine("Делениие на 0 запрещено! Измените условия выражения.");
                                        return;
                                }
                            }
                        }
                    }
                    Console.WriteLine("Нельзя использовать буквы в качестве операнда");
                }
                else
                {
                    Console.WriteLine("Недостаточное количество аргументов");
                    return;
                }
            }
        }
    }
}
