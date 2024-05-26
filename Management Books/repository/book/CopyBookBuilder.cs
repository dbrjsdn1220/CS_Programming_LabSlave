using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Books.repository.bookCopies
{
	class CopyBookBuilder
	{
		private long CopyBookId;
		private long BookId;
		private bool Alive;
		private DateTime BuyDate;

		public CopyBookBuilder copyBookId(long CopyBookId)
		{
			this.CopyBookId = CopyBookId;
			return this;
		}

		public CopyBookBuilder bookId(long BookId)
		{
			this.BookId = BookId;
			return this;
		}

		public CopyBookBuilder alive(bool Alive)
		{
			this.Alive = Alive;
			return this;
		}

		public CopyBookBuilder buyDate(DateTime BuyDate)
		{
			this.BuyDate = BuyDate;
			return this;
		}

		public CopyBookEntity build()
		{
			return new CopyBookEntity(CopyBookId, BookId, Alive, BuyDate);
		}
	}
}
