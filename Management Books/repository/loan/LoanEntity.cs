using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Books.repository.loan
{
	class LoanEntity
	{
		private long id;
		private long copyId;
		private long customerId;
		private DateTime startDate;
		private DateTime endDate;
		private bool extend;

		public LoanEntity(long id, long copyId, long customerId, DateTime startDate, DateTime endDate, bool extend)
		{
			this.id = id;
			this.copyId = copyId;
			this.customerId = customerId;
			this.startDate = startDate;
			this.endDate = endDate;
			this.extend = extend;
		}

		public long getId(){ return id; }

		public long getCopyId() { return copyId; }

		public long getCustomerId() {  return customerId; }

		public DateTime getStartDate() { return startDate; }

		public DateTime getEndDate() { return endDate; }

		public bool getExtend() { return extend; }
	}
}
