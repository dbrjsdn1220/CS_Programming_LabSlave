using Management_Books.repository.bookCopies;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

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

		public bool InsertBookAndCopies(BookEntity book)
		{
			long bookId;
			string queryBook = "INSERT INTO books(title, author, category, copy_count) VALUES(@title, @author, @category, @copy_count)";   // id, 
			string queryBookCopies = "INSERT INTO book_copies(id, book_id, available, storeDate) VALUES(@id, @book_id, @available, @storeDate)";
			DateTime date = DateTime.Now;
			string storeDate = date.ToString("yyyy-MM-dd");

			// MySqlTransaction transaction = conn.BeginTransaction();
			try
			{
				// Books 데이터 저장
				cmd = GetCommand(queryBook, conn);// new MySqlCommand(queryBook, conn, transaction);
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@title", book.getTitle());
				cmd.Parameters.AddWithValue("@author", book.getAuthor());
				cmd.Parameters.AddWithValue("@category", book.getCategory());
				cmd.Parameters.AddWithValue("@copy_count", book.getCopyCount());
				cmd.ExecuteNonQuery();
				bookId = cmd.LastInsertedId;

				// BookCopies 데이터 저장
				cmd = GetCommand(queryBookCopies, conn); // new MySqlCommand(queryBookCopies, conn, transaction);
				for (int n = 1; n <= book.getCopyCount(); n++)
				{
					cmd.Parameters.Clear();
					cmd.Parameters.AddWithValue("@id", (bookId * 1000) + n);
					cmd.Parameters.AddWithValue("@book_id", bookId);
					cmd.Parameters.AddWithValue("@available", true);
					cmd.Parameters.AddWithValue("@storeDate", storeDate);
					cmd.ExecuteNonQuery();
				}
				// transaction.Commit();
				return true;
			}
			catch (MySqlException e)
			{
				Console.WriteLine("[BookRepository.cs / Insert.method / Error : " + e.Message + "]");
				// transaction.Rollback();
			}
			finally
			{
				ReaderClose();
				CommandClose();
			}
			return false;
		}

		public bool InsertCopies(long bookId, int start, int end)
		{
			string query = "INSERT INTO book_copies(id, book_id, available, storeDate) VALUES(@id, @book_id, @available, @storeDate)";
			DateTime date = DateTime.Now;
			string storeDate = date.ToString("yyyy-MM-dd");

			try
			{
				cmd = GetCommand(query, conn);

				for (int n = start + 1; n <= end; n++)
				{
					cmd.Parameters.Clear();
					cmd.Parameters.AddWithValue("@id", (bookId * 1000) + n);
					cmd.Parameters.AddWithValue("@book_id", bookId);
					cmd.Parameters.AddWithValue("@available", true);
					cmd.Parameters.AddWithValue("@storeDate", storeDate);
					cmd.ExecuteNonQuery();
				}
				return true;
			}
			catch (MySqlException e)
			{
				Console.WriteLine("[BookRepository.cs / InsertCopies.method / Error : " + e.Message + "]");
			}
			finally
			{
				ReaderClose();
				CommandClose();
			}
			return false;
		}

		public BookEntity SelectBookId(long bookId)
		{
			string query = "SELECT * FROM books WHERE id = @bookId";

			try
			{
				cmd = GetCommand(query, conn);
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@bookId", bookId);
				reader = cmd.ExecuteReader();

				if (reader.Read())
				{
					return new BookBuilder()
								.id(reader.GetInt64(0))
								.title(reader.GetString(1))
								.author(reader.GetString(2))
								.category(reader.GetString(3))
								.copyCount(reader.GetInt32(4))
								.build();
				}
			}
			catch (MySqlException e)
			{
				Console.WriteLine("[BookRepository.cs / SelectBookId.method / Error : " + e.Message + "]");
			}
			finally
			{
				ReaderClose();
				CommandClose();
			}
			return new BookBuilder().build();
		}

		public List<BookEntity> SelectTitle(string title)
		{
			string query = "SELECT * FROM books WHERE title LIKE @title";

			try
			{
				cmd = GetCommand(query, conn);
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@title1", "%" + title + "%");
				reader = cmd.ExecuteReader();
				return LoadDataList(reader);
			}
			catch (MySqlException e)
			{
				Console.WriteLine("[BookRepository.cs / SelectTitle.method / Error : " + e.Message + "]");
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
				Console.WriteLine("[BookRepository.cs / SelectAuthor.method / Error : " + e.Message + "]");
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
				Console.WriteLine("[BookRepository.cs / GetAllData.method / Error : " + e.Message + "]");
			}
			finally
			{
				ReaderClose();
				CommandClose();
			}
			return new List<BookEntity>();
		}

		public List<BookCopieEntity> FindAllCopyBook(long bookId)
		{
			string query = "SELECT * FROM book_copies WHERE book_id = @bookId";
			List<BookCopieEntity> copyBookList = new List<BookCopieEntity>();

			try
			{
				cmd = GetCommand(query, conn);
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@bookId", bookId);
				reader = cmd.ExecuteReader();

				while (reader.Read())
				{
					copyBookList.Add(new BookCopieBuilder()
											.id(reader.GetInt64(0))
											.book_id(reader.GetInt64(1))
											.available(reader.GetBoolean(2))
											.date(reader.GetDateTime(3))
											.build());
				}
				return copyBookList;
			}
			catch (MySqlException e)
			{
				Console.WriteLine("[BookRepository.cs / SelectBookId.method / Error : " + e.Message + "]");
			}
			finally
			{
				ReaderClose();
				CommandClose();
			}
			return copyBookList;
		}

		// first : book_id // second : copy_count
		public Tuple<long, int> CheckBookTitleExists(string title, int plusCount)
		{
			long bookId = -1; int copyCount = -1;
			string selectQeury = "SELECT id, copy_count FROM books WHERE title = @title LIMIT 1";
			string updateQuery = "UPDATE books SET copy_count = @copy_count WHERE id = @bookId";

			try
			{
				cmd = GetCommand(selectQeury, conn);
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@title", title);
				reader = cmd.ExecuteReader();

				if (reader.Read())
				{
					bookId = reader.GetInt64("id");
					copyCount = reader.GetInt32("copy_count");
					ReaderClose();
				}
				cmd = GetCommand(updateQuery, conn);
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@copy_count", copyCount + plusCount);
				cmd.Parameters.AddWithValue("@bookId", bookId);
				cmd.ExecuteNonQuery();

				return Tuple.Create(bookId, copyCount);
			}
			catch (MySqlException e)
			{
				Console.WriteLine("[BookRepository.cs / CheckBookTitleExists.method / Error : " + e.Message + "]");
			}
			finally
			{
				ReaderClose();
				CommandClose();
			}
			return Tuple.Create(bookId, copyCount);
		}

		private List<BookEntity> LoadDataList(MySqlDataReader reader)
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
