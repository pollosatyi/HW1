namespace HW1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите число для выбора задания: ");
                Console.WriteLine("0 - для выхода\n" +
                                 "1 - для задания на цвета\n" +
                                  "2 - два отрезка\n" +
                                  "3 - две клетки\n" +
                                  "4 - слон\n" +
                                  "5 - ферзь\n" +
                                  "6 - конь\n" +
                                  "7 - первая цифра\n" +
                                  "8 - корни квадратного уравнения\n");
                int.TryParse(Console.ReadLine(), out int value);
                if (value == 0) break;
                switch ((MenuEnum)value)
                {
                    case MenuEnum.ColorsMixer:
                        Console.WriteLine("Задание 1");
                        Console.WriteLine("Введите первый цвет:");
                        string color1 = Console.ReadLine();
                        Console.WriteLine("Введите второй цвет:");
                        string color2 = Console.ReadLine();
                        ColorMixerPrint(color1, color2);
                        break;

                    case MenuEnum.IntersectionSegments:
                        Console.WriteLine("Задание 2");
                        Console.WriteLine("Введите первую точку отрезка 1");
                        int.TryParse(Console.ReadLine(), out int a1);
                        Console.WriteLine("Введите вторую точку отрезка 2");
                        int.TryParse(Console.ReadLine(), out int b1);
                        Console.WriteLine("Введите первую точку отрезка 2");
                        int.TryParse(Console.ReadLine(), out int a2);
                        Console.WriteLine("Введите вторую точку отрезка 2");
                        int.TryParse(Console.ReadLine(), out int b2);
                        Print(IntersectionSegments(new Segment(a1, b1), new Segment(a2, b2)));
                        break;

                }

            }
        }


        public static void Print(IEnumerable<int> items)
        {
            foreach (int item in items) Console.Write(item + " ");
            Console.WriteLine("\n");
        }


        public static HashSet<int> IntersectionSegments(Segment segment1, Segment segment2)
        {
            HashSet<int> result = new HashSet<int>();
            if (segment1.B < segment2.A || segment1.A > segment2.B) return result;
            else if (segment1.B == segment2.A) result.Add(segment1.B);
            else if (segment1.A == segment2.B) result.Add(segment1.A);
            else
            {
                if (segment1.A <= segment2.A)
                {
                    result.Add(segment2.A);
                    result.Add(segment1.B);
                }
                else
                {
                    result.Add(segment1.A);
                    result.Add(segment2.B);
                }
            }
            return result;
        }


        public static void ColorMixerPrint(string color1, string color2)
        {
            string colorResult = string.Empty;
            if (!IsCorrectColor(color1)) colorResult = $"мы не поддерживаем {color1}";
            else if (!IsCorrectColor(color2)) colorResult = $"мы не поддерживаем {color2}";
            else
            {
                colorResult = ColorMixer(color1, color2);
            }
            Console.WriteLine(colorResult + "\n");
        }


        public static string ColorMixer(string color1, string color2)
        {
            (string, string) colors = (color1, color2);
            return (colors) switch
            {
                ("красный", "красный") => "красный",
                ("синий", "синий") => "синий",
                ("желтый", "желтый") => "желтый",
                ("красный", "желтый") => "оранжевый",
                ("желтый", "красный") => "оранжевый",
                ("красный", "синий") => "фиолетовый",
                ("синий", "красный") => "фиолетовый",
                ("желтый", "синий") => "зеленый",
                ("синий", "желтый") => "зеленый",
                _ => "Не подходящие цвета"
            };
        }



        public static bool IsCorrectColor(string color) => color switch
        {
            "синий" => true,
            "желтый" => true,
            "красный" => true,
            _ => false
        };
    }
}
