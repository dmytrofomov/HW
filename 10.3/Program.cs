using System;

namespace _10._3
{
	class Program
	{
		static void Main(string[] args)
		{
			//			Используя Visual Studio, создайте проект по шаблону Console Application.
			//Создайте класс MyDictionary<TKey, TValue>.Реализуйте в простейшем приближении возможность
			//использования его экземпляра аналогично экземпляру класса Dictionary(Урок 6 пример 5).
			//Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления
			//пар элементов, индексатор для получения значения элемента по указанному индексу и свойство только
			//для чтения для получения общего количества пар элементов.
			var dic = new MyDictionary<int, string>();
			dic.Add(1, "First");
			dic.Add(2, "Second");
			dic.Add(3, "Thirt");
			
			Console.WriteLine(dic[1]);
			dic[1] = "SECOND";
			Console.WriteLine(dic[1]);
			Console.WriteLine("length = " + dic.Length);
			Console.Read();
		}
	}

	class MyDictionary<TKey, TValue>
	{
		private TKey[] Keys;
		private TValue[] Values;

		public int Length
		{
			get
			{
				return Keys.Length;
			}
		}

		public void Add(TKey key, TValue value)
		{
			int currenLength = Keys?.Length ?? 0;
			var newArrayKeys = new TKey[currenLength + 1];
			var newArrayValues = new TValue[currenLength + 1];
			for (int i = 0; i < currenLength; i++)
			{
				newArrayKeys[i] = Keys[i];
				newArrayValues[i] = Values[i];
			}
			newArrayKeys[currenLength] = key;
			newArrayValues[currenLength] = value;
			Keys = newArrayKeys;
			Values = newArrayValues;
		}

		public TValue this[int indexer]
		{
			get
			{
				if (indexer < Keys.Length)
				{
					return Values[indexer];
				}
				throw new IndexOutOfRangeException();
			}
			set
			{
				if (indexer < Keys.Length)
				{
					Values[indexer] = value;
				}
				else
				{
					throw new IndexOutOfRangeException();
				}
			}
		}
	}
}
