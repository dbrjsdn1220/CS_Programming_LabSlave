using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
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
			catch (MySqlException e)	// 조회 실패
			{
				Console.WriteLine(e.Message);
			} finally
			{
				ConnectionClose();
			}
			return new MemberBuilder().build();
		}

		private void ConnectionClose()
		{
			try
			{
				if (reader != null)
				{
					reader.Close();
				}
			}
			catch (MySqlException ex)
			{
				Console.WriteLine("\n\nreader closing error : " + ex.Message + "\n\n");
			}
			finally
			{
				if (reader != null)
				{
					reader.Dispose();
				}
			}

			try
			{
				if (cmd != null)
				{
					cmd.Dispose();
				}
			}
			catch (MySqlException ex)
			{
				Console.WriteLine("\n\ncommand disposing error : " + ex.Message + "\n\n");
			}
			try
			{
				if (conn != null)
				{
					conn.Close();
				}
			}
			catch (MySqlException ex)
			{
				Console.WriteLine("\n\nconnection closing error : " + ex.Message + "\n\n");
			}
			finally
			{
				if (conn != null)
				{
					conn.Dispose();
				}
			}
		}
	}
}
