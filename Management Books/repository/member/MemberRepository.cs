using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Management_Books.repository.member
{
	class MemberRepository : CommonRepository
	{
		private MySqlConnection conn;
		private MySqlCommand cmd;
		private MySqlDataReader reader;

		public MemberRepository()
		{
			conn = GetConnection(); conn.Open();
		}

		public MemberEntity Select(MemberEntity member)
		{
			string query = "SELECT * FROM members WHERE member_id = @member_id";
			cmd = GetCommand(query, conn);
			cmd.Parameters.Clear();
			cmd.Parameters.AddWithValue("@member_id", member.getId());
			reader = cmd.ExecuteReader();
			try
			{
				if (reader.Read())
				{
					return new MemberBuilder()
								.id(reader.GetString(0))
								.pwd(reader.GetString(1))
								.build();
				}
			}
			catch (MySqlException e)
			{
				Console.WriteLine("[MemberRepository.cs / Select / error : " + e.Message + "]");
			} finally
			{
				ReaderClose();
				CommandClose();
			}
			return new MemberBuilder().build();
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
