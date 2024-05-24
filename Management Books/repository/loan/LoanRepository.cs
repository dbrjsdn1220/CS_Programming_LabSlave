using Management_Books.repository.bookCopies;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Books.repository.loan
{
	class LoanRepository : CommonRepository
	{
		MySqlConnection conn;
		MySqlCommand cmd;
		MySqlDataReader reader;

		public LoanRepository()
		{
			conn = GetConnection(); conn.Open();
		}

		public bool Insert(LoanEntity loan)
		{
			string query = "INSERT INTO VALUES(@id, @copyId, @customersId, @startDate, @endDate, @extend)";
	
			string startDate = DateTime.Now.ToString("yyyy-MM-dd");
			string endDate = DateTime.Today.AddDays(7).ToString();

			try
			{
				cmd = GetCommand(query, conn);
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@copyId", loan.getCopyId());
				cmd.Parameters.AddWithValue("@customersId", loan.getCustomerId());
				cmd.Parameters.AddWithValue("@startDate", startDate);
				cmd.Parameters.AddWithValue("@endDate", endDate);
				cmd.Parameters.AddWithValue("@extend", false);
				cmd.ExecuteNonQuery();

				return true;
			}
			catch (MySqlException e)
			{
				Console.WriteLine("[LoanRepository.cs / Insert.method / Error : " + e.Message + "]");
			}
			finally
			{
				ReaderClose();
				CommandClose();
			}
			return false;
		}

		public List<LoanEntity> SelectCustomerId(long customer_id)
		{
			string query = "SELECT * FROM loan WHERE customers_id = @customers_id";
			List<LoanEntity> loanList = new List<LoanEntity>();

			try
			{
				cmd = GetCommand(query, conn);
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@customers_id", customer_id);
				reader = cmd.ExecuteReader();

				while (reader.Read())
				{
					loanList.Add(new LoanBuilder()
						.id(reader.GetInt64(0))
						.copyId(reader.GetInt64(1))
						.customerId(reader.GetInt64(2))
						.build());
				}
			}
			catch (MySqlException e)
			{
				Console.WriteLine("[LoanRepository.cs / SelectCustomerId.method / Error : " + e.Message + "]");
			}
			finally
			{
				ReaderClose();
				CommandClose();
			}
			return loanList;
		}

		public bool Update(LoanEntity loan)
		{


			return false;
		}

		public List<LoanEntity> GetLoansByCopyIds(long bookId)
		{
			// string query = "SELECT * FROM loan WHERE ";
			string query = "SELECT loan.* " +
							"FROM book_copies " +
							"INNER JOIN loan ON loan.book_copy_id = book_copies.id " +
							"WHERE book_copies.id IN (@bookId)";
			List<LoanEntity> loanList = new List<LoanEntity>();

			try
			{
				cmd = GetCommand(query, conn);
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@bookId", bookId);
				reader = cmd.ExecuteReader();

				while (reader.Read())
				{
					Console.WriteLine(
						reader.GetInt64(0) + " / " +
						reader.GetInt64(1) + " / " +
						reader.GetInt64(2) + " / " +
						reader.GetDateTime(3) + " / " +
						reader.GetDateTime(4) + " / " +
						reader.GetBoolean(5)
					);
					loanList.Add(new LoanBuilder()
									.id(reader.GetInt64(0))
									.copyId(reader.GetInt64(1))
									.customerId(reader.GetInt64(2))
									.startDate(reader.GetDateTime(3))
									.endDate(reader.GetDateTime(4))
									.extend(reader.GetBoolean(5))
									.build());
				}
				return loanList;
			}
			catch (MySqlException e)
			{
				Console.WriteLine("[LoanRepository.cs / GetLoansByCopyIds.method / Error : " + e.Message + "]");
			}
			finally
			{
				ReaderClose();
				CommandClose();
			}
			return loanList;
		}

		private void ReaderClose()
		{
			try
			{
				if (reader != null)
				{
					reader.Close();
				}
			}
			catch (MySqlException e)
			{
				Console.WriteLine("\n\nreader closing error : " + e.Message + "\n\n");
			}
			finally
			{
				if (reader != null)
				{
					reader.Dispose();
				}
			}
		}

		private void CommandClose()
		{
			try
			{
				if (cmd != null)
				{
					cmd.Dispose();
				}
			}
			catch (MySqlException e)
			{
				Console.WriteLine("\n\ncommand disposing error : " + e.Message + "\n\n");
			}
		}

		private void ConnectionClose()
		{
			try
			{
				if (conn != null)
				{
					conn.Close();
				}
			}
			catch (MySqlException e)
			{
				Console.WriteLine("\n\nconnection closing  error : " + e.Message + "\n\n");
			}
			finally
			{
				if (conn != null)
				{
					conn.Dispose();
				}
			}
		}

		public void AllClose()
		{
			ReaderClose();
			CommandClose();
			ConnectionClose();
		}
	}
}
