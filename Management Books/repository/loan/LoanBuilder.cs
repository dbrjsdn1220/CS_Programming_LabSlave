using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Books.repository.loan
{
	class LoanBuilder
	{
		private long LoanId;
		private long CopyBookId;
		private int StudentId;
		private DateTime StartDate;
		private DateTime EndDate;
		private bool Extend;

		public LoanBuilder loanId(long LoanId)
		{
			this.LoanId = LoanId;
			return this;
		}

		public LoanBuilder copyBookId(long CopyBookId)
		{
			this.CopyBookId = CopyBookId;
			return this;
		}

		public LoanBuilder studentId(int StudentId)
		{
			this.StudentId = StudentId;
			return this;
		}

		public LoanBuilder startDate(DateTime StartDate)
		{
			this.StartDate = StartDate;
			return this;
		}

		public LoanBuilder endDate(DateTime EndDate)
		{
			this.EndDate = EndDate;
			return this;
		}

		public LoanBuilder extend(bool Extend)
		{
			this.Extend = Extend;
			return this;
		}

		public LoanEntity build()
		{
			return new LoanEntity(LoanId, CopyBookId, StudentId, StartDate, EndDate, Extend);
		}
	}
}
