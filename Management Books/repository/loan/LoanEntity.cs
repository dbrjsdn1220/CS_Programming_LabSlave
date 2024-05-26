using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Books.repository.loan
{
	class LoanEntity
	{
		private long loanId;
		private long copyBookId;
		private int studentId;
		private DateTime startDate;
		private DateTime endDate;
		private bool extend;

		public LoanEntity(long loanId, long copyBookId, int studentId, DateTime startDate, DateTime endDate, bool extend)
		{
			this.loanId = loanId;
			this.copyBookId = copyBookId;
			this.studentId = studentId;
			this.startDate = startDate;
			this.endDate = endDate;
			this.extend = extend;
		}

		public long getLoanId(){ return loanId; }

		public long getCopyBookId() { return copyBookId; }

		public int getStudentId() {  return studentId; }

		public DateTime getStartDate() { return startDate; }

		public DateTime getEndDate() { return endDate; }

		public bool getExtend() { return extend; }
	}
}
