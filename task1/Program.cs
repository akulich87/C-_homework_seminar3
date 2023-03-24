// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом

// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.WriteLine("Введите пятизначное число "); // сто мы хотим от пользователя
string number = Console.ReadLine(); // получаем строчку


if(number.Length > 4 && number.Length < 6)
  {
  if (number[0] == number[4] && number[1] == number[3])
  {
    Console.WriteLine($"Число {number} является палиндромом "); // {number} - указываем какое число
  }

  else
  {
    Console.WriteLine($"Число {number} не является палиндромом ");
  }
  }
else
{
  Console.WriteLine("Вы ввели не пятизначное число ");
}