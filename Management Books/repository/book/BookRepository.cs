using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Books.repository.book
{
	class BookRepository : CommonRepository
	{
		private MySqlConnection conn;
		private MySqlCommand cmd;
		private MySqlDataReader reader;

		public BookRepository()
		{
			conn = GetConnection(); conn.Open();
		}

		public bool Insert(BookEntity book)
		{
			long bookId;
			string queryBook = "INSERT INTO books(title, author, category, copy_count) VALUES(@title, @author, @category, @copy_count)";   // id, 
			string queryBookCopies = "INSERT INTO book_copies(id, book_id, available, storeDate) VALUES(@id, @book_id, @available, @storeDate)";
			DateTime date = DateTime.Now;
			string storeDate = date.ToString("yyyy-MM-dd");

			MySqlTransaction transaction = conn.BeginTransaction();
			try
			{
				// Books 데이터 저장
				cmd = new MySqlCommand(queryBook, conn, transaction);
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@title", book.getTitle());
				cmd.Parameters.AddWithValue("@author", book.getAuthor());
				cmd.Parameters.AddWithValue("@category", book.getCategory());
				cmd.Parameters.AddWithValue("@copy_count", book.getCopyCount());
				cmd.ExecuteNonQuery();
				bookId = cmd.LastInsertedId;

				// BookCopies 데이터 저장
				cmd = new MySqlCommand(queryBookCopies, conn, transaction);
				for (int n = 1; n <= book.getCopyCount(); n++)
				{
					cmd.Parameters.Clear();
					cmd.Parameters.AddWithValue("@id", (bookId * 1000) + n);
					cmd.Parameters.AddWithValue("@book_id", bookId);
					cmd.Parameters.AddWithValue("@available", true);
					cmd.Parameters.AddWithValue("@storeDate", storeDate);
					cmd.ExecuteNonQuery();
				}
				transaction.Commit();
				return true;
			}
			catch (MySqlException e)
			{
				Console.WriteLine("[BookRepository.cs / Insert / error : " + e.Message + "]");
				transaction.Rollback();
			}
			finally
			{
				ReaderClose();
				CommandClose();
			}
			return false;
		}

		public List<BookEntity> SelectTitle(string title)
		{
			string query = "SELECT * FROM books WHERE title LIKE @title";

			try
			{
				cmd = GetCommand(query, conn);
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@title", "%" + title + "%");
				reader = cmd.ExecuteReader();
				return LoadDataList(reader);
			}
			catch (MySqlException e)
			{
				Console.WriteLine("[BookRepository.cs / SelectTitle / error : " + e.Message + "]");
			}
			finally
			{
				ReaderClose();
				CommandClose();
			}
			return new List<BookEntity>();
		}

		public List<BookEntity> SelectAuthor(string author)
		{
			string query = "SELECT * FROM books WHERE author LIKE @author";

			try
			{
				cmd = GetCommand(query, conn);
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@author", "%" + author + "%");
				reader = cmd.ExecuteReader();
				return LoadDataList(reader);
			}
			catch (MySqlException e)
			{
				Console.WriteLine("[BookRepository.cs / SelectAuthor / error : " + e.Message + "]");
			} finally
			{
				ReaderClose();
				CommandClose();
			}
			return new List<BookEntity>();
		}

		public List<BookEntity> GetAllData()
		{
			string query = "SELECT * FROM books";

			try
			{
				cmd = GetCommand(query, conn);
				cmd.Parameters.Clear();
				reader = cmd.ExecuteReader();
				return LoadDataList(reader);
			}
			catch (MySqlException e)
			{
				Console.WriteLine("[BookRepository.cs / GetBooks / error : " + e.Message + "]");
			}
			finally
			{
				ReaderClose();
				CommandClose();
			}
			return new List<BookEntity>();
		}

		public List<BookEntity> LoadDataList(MySqlDataReader reader)
		{
			List<BookEntity> bookList = new List<BookEntity>();

			while (reader.Read())
			{
				bookList.Add(new BookBuilder()
								.id(reader.GetInt64(0))
								.author(reader.GetString(1))
								.title(reader.GetString(2))
								.category(reader.GetString(3))
								.copyCount(reader.GetInt32(4))
								.build());
			}
			return bookList;
		}

		public void ReaderClose()
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

		public void CommandClose()
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

		public void ConnectionClose()
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
