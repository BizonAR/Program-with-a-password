using System;

namespace ProgramWithPassword
{
	internal class ProgramWithPassword
	{
		static void Main(string[] args)
		{
			int numberOfAttempts = 3;
			string password = "password";

			Console.WriteLine($"У вас есть {numberOfAttempts} попыток, чтобы ввести верный пароль");

			for (int i = 0; i < numberOfAttempts; ++i)
			{
				Console.Write("Введите пароль: ");
				string enteredPassword = Console.ReadLine();

				if (enteredPassword == password)
				{
					Console.WriteLine("Секретное сообщение");
					break;
				}
				else
				{
					int attemptsLeft = numberOfAttempts - i - 1;
					Console.WriteLine($"Неверный пароль. У вас осталось попыток {attemptsLeft}");
				}
			}
		}
	}
}
