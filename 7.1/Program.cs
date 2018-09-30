using System;

namespace _7._1
{
	class Program
	{
		static void Main(string[] args)
		{
			//			Создайте структуру с именем -Notebook.
			//Поля структуры: модель, производитель, цена.
			//В структуре должен быть реализован конструктор для инициализации полей и метод для вывода
			//содержимого полей на экран.

			var b = new Notebook("A1029", "Apple", 1000);
			b.ShowInfo();

		}

		

	}
}
