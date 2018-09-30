using System;
using System.Collections.Generic;
using System.Text;

namespace _5._3
{
	class Article
	{
		public string Name { get; }
		public string ShopTitle { get; }
		public string GoodsPrice { get; }

		public Article(string name, string shop, string price)
		{
			Name = name;
			ShopTitle = shop;
			GoodsPrice = price;
		}

	}
}
