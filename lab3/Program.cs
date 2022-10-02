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
        }
        struct Note
        {
            string Surname;
            string Name;
            string Born;
            private int Day;
            private int Month;
            private int Year;
            public Note(string Surname, string Name, int Day, int Month, int Year)
            {
                this.Surname = Surname;
                this.Name = Name;
                this.Day = (Day >= 30 && Day <= 1) ? Day : 1;
                this.Month = (Month >= 12 && Month <= 1) ?  Month : 1;
                this.Year = (Year >= 2023 && Year <= 1900) ? Year : 2023;
                this.Born = Day + "." + Month + "." + Year;
            }
            public void printBeforeBorn(Note[] notes, int Day, int Month, int Year)
            {
                bool searched = false;
                for (int i = 0; i < notes.Length; i++)
                {
                    if (notes[i].Year >= Year)
                    {
                        Console.WriteLine("Фамилия " + notes[i].Surname + " | Имя "
                            + notes[i].Name + " | Родился(лась) " + notes[i].Born);
                        searched = true;
                        continue;
                    } 
                    else if (notes[i].Month >= Month)
                    {
                        Console.WriteLine("Фамилия " + notes[i].Surname + " | Имя "
                            + notes[i].Name + " | Родился(лась) " + notes[i].Born);
                        searched = true;
                        continue;
                    } 
                    else if (notes[i].Day >= Day)
                    {
                        Console.WriteLine("Фамилия " + notes[i].Surname + " | Имя "
                            + notes[i].Name + " | Родился(лась) " + notes[i].Born);
                        searched = true;
                        continue;
                    }
                }
                if (!searched)
                {

                }
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
        }
    }
}