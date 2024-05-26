using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Books.repository.bookCopies
{
	class CopyBookEntity
	{
		private long copyBookId;
		private long bookId;
		private bool alive;
		private DateTime buyDate;

		public CopyBookEntity(long copyBookId, long bookId, bool alive, DateTime buyDate)
		{
			this.copyBookId = copyBookId;
			this.bookId = bookId;
			this.alive = alive;
			this.buyDate = buyDate;
		}

		public long getCopyBookId() { return copyBookId; }

		public long getBookId() { return bookId; }

		public bool getAlive() { return alive; }

		public DateTime getBuyDate() { return buyDate; }
	}
}
