﻿namespace StaticMassiveTests
{
	public class StaticMassive
	{
		public int[] AddEvenNumbers(int[] numbers) //Дан массив чисел, нужно создать из данного массива массив в котором хранятся только четные цифры
		{
            int lenNum = numbers.Length;
            int[] numCet = new int[lenNum];
            foreach (int i in numbers)
            {
                if (numbers[i] % 2 == 0)
                {
                    numbers[i] = numCet[i];
                }
            }

            return new[] {1}; //Небходимо вернуть массив типа int[]
		}

		public int[] AddOddNumbers(int[] numbers) //Дан массив чисел, нужно создать из данного массивa массив в котором хранятся только нечетные цифры
		{
            int lenNum = numbers.Length;
            int[] numCet = new int[lenNum];
            foreach (int i in numbers)
            {
                if (numbers[i] % 2 != 0)
                {
                    numbers[i] = numCet[i];
                }
            }
            return new[] {1}; //Небходимо вернуть массив типа int[]
		}

		public int[] BreakingPassword(int number) //Задача взломать пароль методом перебора (Brute Force), на входе дано число,
                                            //которе означает сколько цифр в пароле, цифры могут быть от 0 до 9, первая цифра никогда не будет 0
		{
			return new[] {1}; //Небходимо вернуть массив типа int[]
		}

		public string FindDifferents(string first, string second) //Данны две строки, необходимо их сравнить и вернуть строку где знак '-'
																															//будет означать, что на данном индексе знаки одинаковы, а знак '^'
																															//там где знаки отличаются => Например first = "Nikita" a second = "Nakata" ответ здесь будет "-^----"
		{
            int len = first.Length;

            string[] compare = new string[len];

            for (int i = 0; i < len; i++)
            {
                if (first[i] == second[i])
                {
                    compare[i] = "-";
                }
                else compare[i] = "^";
            }
			return string.Empty;
		}
	}
}
