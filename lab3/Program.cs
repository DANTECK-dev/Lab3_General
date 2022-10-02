using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
        }
        static void Task1() 
        {
            /*Описать структуру с именем Note, содержащую следующие поля: фамилия, имя, день
            рождения. Написать программу, выполняющую следующие действия:
             Ввод данных в массив, состоящий из нескольких элементов типа Note.
             Вывод на дисплей информации о людях, чьи дни рождения приходятся раньше даты,
            введенной с клавиатуры. Если таких нет, вывести сообщение об этом.
            Напишите соответствующие методы для этого.*/
            List<Note> list = new List<Note>();
            while (true)
            {
                Console.WriteLine("1 - Добавить\n2 - Выести всех\n3 - Вывести по дате рождения");
                int switcher = Convert.ToInt32(Console.ReadLine());
                switch (switcher)
                {
                    case 0:
                        {
                            return;
                        }
                    case 1:
                        {
                            try
                            {
                                Console.Write("Фамилия - ");
                                string? Surname = Console.ReadLine();
                                Console.Write("Имя - ");
                                string? Name = Console.ReadLine();
                                Console.Write("День рождения - ");
                                int Day = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Месяц рождения - ");
                                int Month = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Год рождения - ");
                                int Year = Convert.ToInt32(Console.ReadLine());
                                list.Add(new Note(Surname, Name, Day, Month, Year));
                                break;
                            } catch(Exception e) { Console.WriteLine(e.ToString()); break; }
                        }
                    case 2:
                        {
                            for(int i = 0; i < list.Count; i++)
                            {
                                Console.WriteLine(list[i].ToString());
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.Write("День рождения - ");
                            int Day = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Месяц рождения - ");
                            int Month = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Год рождения - ");
                            int Year = Convert.ToInt32(Console.ReadLine());
                            list[0].printBeforeBorn(list, Day, Month, Year);
                            break;
                        }
                    default: break;
                }
            }
        }
        struct Note
        {
            string? Surname;
            string? Name;
            string? Born;
            private int Day;
            private int Month;
            private int Year;
            public Note(string? Surname, string? Name, int Day, int Month, int Year)
            {
                this.Surname = Surname;
                this.Name = Name;
                this.Day = (Day >= 30 && Day <= 1) ? 1 : Day;
                this.Month = (Month >= 12 && Month <= 1) ?  1 : Month;
                this.Year = (Year >= 2023 && Year <= 1900) ? 2023 : Year;
                this.Born = Day + "." + Month + "." + Year;
            }
            public void printBeforeBorn(List<Note> list, int Day, int Month, int Year)
            {
                bool searched = false;
                for (int i = 0; i < list.Count; i++)
                {
                    
                    if (list[i].Year > Year)
                    {
                        Console.WriteLine(list[i].ToString());
                        searched = true;
                        continue;
                    } 
                    else if (list[i].Month > Month)
                    {
                        Console.WriteLine(list[i].ToString());
                        searched = true;
                        continue;
                    } 
                    else if (list[i].Day > Day)
                    {
                        Console.WriteLine(list[i].ToString());
                        searched = true;
                        continue;
                    }
                }
                if (!searched)
                {
                    Console.WriteLine("Ошибка не найдено");
                }
            }
            public override string? ToString()
            {
                return "Фамилия " + this.Surname + " | Имя "
                            + this.Name + " | Родился(лась) " + this.Born;
            }
        }
        static void Task2()
        {
            /*Создайте класс «прямоугольник» (Rectangle) в отдельном файле (Rectangle.cs). Поля класса –
            высота и ширина (private). Методы класса должны вычислять площадь и периметр.
            Создайте конструкторы: пустой (определяет значения по умолчанию) и с параметрами. В
            случае передачи в конструктор с параметрами некорректных данных, устанавливать значение по
            умолчанию.
            С помощью метода деконструкции организовать декомпозицию объекта класса на его
            ширину и высоту. То есть получить ширину и высоту из объекта должно быть можно только через
            декомпозицию.
            Продемонстрируйте работу класса.*/

            Rectangle rectangle = new Rectangle();
            Console.WriteLine("Периметр: " + rectangle.Perimeter() + " Периметр: " + rectangle.Square());
            int width, height;
            rectangle.Deconstruct(out width, out height);
            Console.WriteLine("Высота: " + height + " Длина: " + width);



            rectangle = new Rectangle(657, 983);
            Console.WriteLine("Периметр: " + rectangle.Perimeter() + " Периметр: " + rectangle.Square());
            rectangle.Deconstruct(out width, out height);
            Console.WriteLine("Высота: " + height + " Длина: " + width);
            Console.ReadKey();
        }
    }
}