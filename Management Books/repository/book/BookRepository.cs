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

		public long Insert(BookEntity book)
		{
			string query = "INSERT INTO books(id, title, author, category) VALUES(@id, @title, @author, @category)";
			try
			{
				cmd = GetCommand(query, conn);
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@id", book.getId());
				cmd.Parameters.AddWithValue("@title", book.getTitle());
				cmd.Parameters.AddWithValue("@author", book.getAuthor());
				cmd.Parameters.AddWithValue("@category", book.getCategory());
				cmd.ExecuteNonQuery();

				return book.getId();
			}
			catch (MySqlException e)
			{
				Console.WriteLine("[BookRepository.cs / Insert / error : " + e.Message + "]");
			}
			finally
			{
				ReaderClose();
				CommandClose();
			}
			return new BookBuilder().build().getId();
		}

		public List<BookEntity> SelectTitle(string title)
		{
			string query = "SELECT * FROM books WHERE title LIKE @title";
			List<BookEntity> books = new List<BookEntity>();
			try
			{
				cmd = GetCommand(query, conn);
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@title", "%" + title + "%");
				reader = cmd.ExecuteReader();

				while (reader.Read())
				{
					books.Add(new BookBuilder()
								.id(reader.GetInt64(0))
								.author(reader.GetString(1))
								.title(reader.GetString(2))
								.category(reader.GetString(3))
								.build());
				}
				return books;
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
			return books;
		}

		public long GetCount()
		{
			string query = "SELECT COUNT(id) FROM books";
			try
			{
				cmd = GetCommand(query, conn);
				cmd.Parameters.Clear();
				reader = cmd.ExecuteReader();
				
				if (reader.Read())
				{
					return reader.GetInt64(0);
				}
			}
			catch (MySqlException e)
			{
				Console.WriteLine("[BookRepository.cs / GetCount / error : " + e.Message + "]");
			}
			finally
			{
				ReaderClose();
				CommandClose();
			}
			return -1;
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
