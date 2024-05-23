using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Books.repository.bookCopies
{
	class BookCopieBuilder
	{
		private long Id;
		private long Book_id;
		private bool Available;
		private DateTime Date;

		public BookCopieBuilder id(long Id)
		{
			this.Id = Id;
			return this;
		}

		public BookCopieBuilder book_id(long Book_id)
		{
			this.Book_id = Book_id;
			return this;
		}

		public BookCopieBuilder available(bool Available)
		{
			this.Available = Available;
			return this;
		}

		public BookCopieBuilder date(DateTime Date)
		{
			this.Date = Date;
			return this;
		}

		public BookCopieEntity build()
		{
			return new BookCopieEntity(Id, Book_id, Available, Date);
		}
	}
}
