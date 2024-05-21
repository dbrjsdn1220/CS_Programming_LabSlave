using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Books.repository.book
{
	class BookEntity
	{
		private long id;
		private string title;
		private string author;
		private string category;

		public BookEntity(long id, string title, string author, string category)
		{
			this.id = id;
			this.title = title;
			this.author = author;
			this.category = category;
		}

		public long getId()
		{
			return id;
		}

		public string getTitle()
		{
			return title;
		}

		public string getAuthor()
		{
			return author;
		}

		public string getCategory()
		{
			return category;
		}
	}
}
