using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Books.repository.bookCopies
{
	class BookCopieEntity
	{
		private long id;
		private long book_id;
		private bool available;
		private DateTime date;

		public BookCopieEntity(long id, long book_id, bool available, DateTime date)
		{
			this.id = id;
			this.book_id = book_id;
			this.available = available;
			this.date = date;
		}

		public long getId() { return id; }

		public long getBook_id() { return book_id; }

		public bool getAvailable() { return available; }

		public DateTime getDate() { return date; }
	}
}
