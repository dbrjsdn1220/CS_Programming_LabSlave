using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Books.repository.book
{
	class BookBuilder
	{
		private long Id;
		private string Title;
		private string Author;
		private string Category;

		public BookBuilder id(long Id)
		{
			this.Id = Id;
			return this;
		}

		public BookBuilder title(string Title)
		{
			this.Title = Title;
			return this;
		}

		public BookBuilder author(string Author)
		{
			this.Author = Author;
			return this;
		}

		public BookBuilder category(string Category)
		{
			this.Category = Category;
			return this;
		}

		public BookEntity build()
		{
			return new BookEntity(Id, Title, Author, Category);
		}
	}
}
