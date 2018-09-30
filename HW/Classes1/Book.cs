using System;
using System.Collections.Generic;
using System.Text;

namespace HW.Classes1
{

	class Book
	{
		public Book(string bookName, string autor , string Content)
		{
			book = bookName;
		}

		string book;
		string autor;
		string Content;

		void Show()
		{
			Console.WriteLine($"{book} +  {autor} + {Content}");
		}
	}
	class Title
	{
		public Title(string Title)
		{
			title = Title;
		}

		string title;
	}

	class Author
	{
		public Author(string AuthorName)
		{
			author = AuthorName;
		}

		string author;

		
	}

	class Content
	{
		public Content(string ContentName)
		{
			content = ContentName;
		}

		string content;

		
	}
}
