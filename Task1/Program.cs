//Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.Clear();
Console.WriteLine("введите число от 1 до 7 по количеству дней в неделе: ");
int number = int.Parse(Console.ReadLine());
if (number == 1)
    Console.Write("понедельник - будний день");
if (number == 2)
    Console.Write("вторник - будний день");
if (number == 3)
    Console.Write("среда - будний день");
if (number == 4)
    Console.Write("чевтерг - будний день");
if (number == 5)
    Console.Write("пятница - будний день");
if (number == 6)
    Console.Write("суббота - ВЫХОДНОЙ");
if (number == 7)
    Console.Write("воскресенье - ВЫХОДНОЙ");
if ((number > 7 || number < 0))
    Console.Write("нет такого дня недели");



