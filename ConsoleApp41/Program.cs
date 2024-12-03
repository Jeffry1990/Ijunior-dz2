string name;
string zodiacSign;
string placeOfWork;
int age;

Console.Write("Ваше имя: ");
name = Console.ReadLine();
Console.Write("Ваш знак зодиака: ");
zodiacSign = Console.ReadLine();
Console.Write("Сколько вам лет: ");
age = Convert.ToInt32(Console.ReadLine());
Console.Write("Кем вы работаете: ");
placeOfWork = Console.ReadLine();

Console.WriteLine($"Вас зовут {name}, Вам {age}, Вы {zodiacSign} и Вы {placeOfWork}");
