Console.WriteLine("Array:");
int[] array = ReadArray();

Console.WriteLine(string.Join(';', array));



int[] ReadArray()
{
	string arrayAsString = Console.ReadLine(); // 1, 2, 3, 4
	string[] numbersAsString = arrayAsString.Split(", "); // Разбить строку на массив строк учитывая разделитель

	int[] array = new int[numbersAsString.Length];

	for (int i = 0; i < array.Length; i++)
	{
		array[i] = int.Parse(numbersAsString[i]);
	}

	return array;
}
