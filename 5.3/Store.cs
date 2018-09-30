using System;
using System.Collections.Generic;
using System.Text;

namespace _5._3
{
	class Store
	{
		//			• вывод информации о товаре по номеру с помощью индекса;
		//			• вывод на экран информации о товаре, название которого введено с клавиатуры, если таких товаров нет,
		//			выдать соответствующее сообщение;

		private Article[] indexer;

		public Store(int size)
		{
			indexer = new Article[size];
		}

		public void AddArticle(Article a)
		{
			for (int i = 0; i < indexer.Length; i++)
			{
				if (indexer[i] != null)
				{
					continue;
				}
				else
				{
					indexer[i] = a;
					return;
				}
			}
			Console.WriteLine("Sorry store is full");
		}

		public void ForceAddArticle(Article a, int shiftedArticleIndexer)
		{
			Console.WriteLine($"Warning, Article at possition{shiftedArticleIndexer} can be repleaced");
			indexer[shiftedArticleIndexer] = a;
		}

		public string this[int number]
		{
			get
			{
				if (number > indexer.Length - 1)
				{
					return "Out on renge";
				}
				return indexer[number].Name;
			}
		}

		public Article this[string name]
		{
			get
			{
				for (int i = 0; i < indexer.Length; i++)
				{
					if (name == indexer[i].Name)
					{
						return indexer[i];
					}
				}
				Console.WriteLine("There was no Article with such name");
				return null;
			}
		}
	}
}
