// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом

// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.WriteLine("Введите пятизначное число ");
int fiveDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(fiveDigitNumber);

if ( stringNumber[0] == stringNumber[4] )
{
  Console.WriteLine("Да ");
}

else if( stringNumber[1] == stringNumber[3] )
{
  Console.WriteLine("Да ");
}

else
{
  Console.WriteLine("Нет ");
}
