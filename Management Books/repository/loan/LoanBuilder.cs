using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Books.repository.loan
{
	class LoanBuilder
	{
		private long Id;
		private long CopyId;
		private long CustomerId;
		private DateTime StartDate;
		private DateTime EndDate;
		private bool Extend;

		public LoanBuilder id(long id)
		{
			this.Id = id;
			return this;
		}

		public LoanBuilder copyId(long copyId)
		{
			this.CopyId = copyId;
			return this;
		}

		public LoanBuilder customerId(long customerId)
		{
			this.CustomerId = customerId;
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
			return new LoanEntity(Id, CopyId, CustomerId, StartDate, EndDate, Extend);
		}
	}
}
