using System;

namespace _5._3
{
	class Program
	{
		static void Main(string[] args)
		{
			//			Создать класс Article, содержащий следующие закрытые поля:
			//			• название товара;
			//			• название магазина, в котором продается товар;
			//			• стоимость товара в гривнах.
			//			Создать класс Store, содержащий закрытый массив элементов типа Article.
			//			Обеспечить следующие возможности:
			//			• вывод информации о товаре по номеру с помощью индекса;
			//			• вывод на экран информации о товаре, название которого введено с клавиатуры, если таких товаров нет,
			//			выдать соответствующее сообщение;
			//			Написать программу, вывода на экран информацию о товаре.

			var str = new Store(10);
			str.AddArticle(new Article("Cat", "AnimalShop", "1000"));
			Console.WriteLine(str[0]);
			var a = str["Cat"];
			Console.WriteLine(a.ShopTitle);
			str.AddArticle(new Article("Dog", "AnimalShop", "1100"));
			str.ForceAddArticle(new Article("Dog", "AnimalShop", "1100"), 0);
			Console.WriteLine(str[0]);
			Console.WriteLine(str[1]);
			Console.Read();

		}
	}
}
