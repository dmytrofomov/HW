using System;

namespace HW.Classes1
{

    class Book
    {
        private Title _title;
        Author _author;
        Content _content;

        public Book(string bookName, string autor, string content)
        {
            _title = new Title(bookName);
            _author = new Author(autor);
            _content = new Content(content);
        }

        void Show()
        {
            _title.Show();
            _author.Show();
            _content.Show();
        }
    }

    class Title : Base
    {
        public Title(string AuthorName) : base(AuthorName)
        {
            color = ConsoleColor.Cyan;
        }
    }

    class Author : Base
    {
        public Author(string AuthorName) : base(AuthorName)
        {
            color = ConsoleColor.Blue;
        }

    }

    class Content : Base
    {
        public Content(string AuthorName) : base(AuthorName)
        {
            color = ConsoleColor.Red;
        }
    }

    class Base
    {
        private string content;
        protected ConsoleColor color = ConsoleColor.DarkRed;

        public Base(string content)
        {
            this.content = content;
        }

        public void Show()
        {
            Console.ForegroundColor = color;
            Console.WriteLine(content);
        }
    }
}
