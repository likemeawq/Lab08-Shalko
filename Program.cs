// int lessonNumber = 5;
// int totalLessons = 1;

// while (lessonNumber >= totalLessons)
// {
//     Console.WriteLine($"Пара {lessonNumber}");
//     lessonNumber++;
// }
// Console.WriteLine("Пары закончились");

// Console.WriteLine("Вводите оценки по одной, для завершения введите -1:");
// int grade = int.Parse(Console.ReadLine());

// while (grade != -1)
// {
//     Console.WriteLine($"Оценка принята: {grade}");
//     grade = int.Parse(Console.ReadLine());
// }
// Console.WriteLine("Ввод завершён");

// int sum = 0;
// int count = 0;

// Console.WriteLine("Вводите оценки, для завершения введите -1:");
// int grade = int.Parse(Console.ReadLine());

// while (grade != -1)
// {
//     sum += grade;
//     count++;
//     grade = int.Parse(Console.ReadLine());
// }
// if (count > 0)
// {
//     Console.WriteLine($"Средний балл: {(double)sum / count}");
// }
// else
// {
//     Console.WriteLine("Оценок не было введено");
// }
// string correctPassword = "qwerty123";

// while (true)
// {
//     Console.Write("Введите пароль от личного кабинета: ");
//     string password = Console.ReadLine();

//     if (password == correctPassword)
//     {
//         Console.WriteLine("Доступ разрешён");
//         break;
//     }
//     Console.WriteLine("Неверный пароль, попробуйте снова");
// }
// string answer;
// do
// {
//     Console.Write("Введите дату посещения (например, 01.09): ");
//     string date = Console.ReadLine();
//     Console.WriteLine($"Запись добавлена: {date}");

//     Console.Write("Добавить ещё одну запись? (да/нет): ");
//     answer = Console.ReadLine();
// } while (answer == "да");

// Console.WriteLine("Дневник сохранён");

// int count = 0;
// Console.WriteLine("Вводите имена, для завершения введите «конец»:");
// string name = Console.ReadLine();

// while (name != "конец")
// {
//     count++;
//     name = Console.ReadLine();
// }

// Console.WriteLine($"Введено имён: {count}");


// int n = 7;
// int i = 1;
// while (i <= 10)
// {
//     Console.WriteLine($"{n} x {i} = {n * i}");
//     i++;
// }

// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();

// if (string.IsNullOrEmpty(surname))
// {
//     Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
//     .OrderBy(_ => rnd.Next())
//     .Take(2).OrderBy(x => x)
//     .ToList();

// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

Console.WriteLine("Вводите символы по одному, для завершения введите q:");
char c = char.Parse(Console.ReadLine());
int count = 0;
while (c != 'q')
{
    count++;
    c = char.Parse(Console.ReadLine());
}
Console.WriteLine($"Введено символов (без q): {count}");

Console.WriteLine("Введите целое положительное число:");
int n = int.Parse(Console.ReadLine());
int count = 0;
while (n != 0)
{
    n = n / 10;
    count++;
}
Console.WriteLine($"Цифры: {count}");
