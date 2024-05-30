using MySql.Data.MySqlClient;
using System;

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

		/**
		 * @param	(member	: members 테이블에 저장할 값을 지닌 객체)
		 * @return	만약 저장을 성공 했다면, 입력한 아이디 값을 반환한다.
		 **/
		public string Insert(MemberEntity member)
		{
			string query = "INSERT INTO members(member_id, member_pwd) VALUES(@member_id, @member_pwd)";
			try
			{
				cmd = GetCommand(query, conn);
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@member_id", member.getId());
				cmd.Parameters.AddWithValue("@member_pwd", member.getPwd());
				cmd.ExecuteNonQuery();

				return member.getId();
			}
			catch (MySqlException e)
			{
				Console.WriteLine("[MemberRepository.cs / Insert.method / Error : " + e.Message + "]");
			}
			finally
			{
				ReaderClose();
				CommandClose();
			}
			return new MemberBuilder().id("").build().getId();
		}

		/**
		 * @param	(member : members 테이블에 저장된 값을 검색할 용도의 객체)
		 * @return	입력한 아이디 값을 기준으로, members 테이블 내에 PK 값과
		 *			일치하는 행의 데이터를 반환한다.
		 **/
		public MemberEntity Select(MemberEntity member)
		{
			string query = "SELECT * FROM members WHERE member_id = @member_id";

			try
			{
				cmd = GetCommand(query, conn);
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@member_id", member.getId());
				reader = cmd.ExecuteReader();

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
				Console.WriteLine("[MemberRepository.cs / Select.method / Error : " + e.Message + "]");
			}
			finally
			{
				ReaderClose();
				CommandClose();
			}
			return new MemberBuilder().id("").pwd("").build();
		}

		// ================================================================================================

		/*
		 * 공용 기능 
		 */

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
				Console.WriteLine("[MemberRepository.cs / ReaderClose.method / Error : " + e.Message + "]");
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
				Console.WriteLine("[MemberRepository.cs / CommandClose.method / Error : " + e.Message + "]");
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
				Console.WriteLine("[MemberRepository.cs / ConnectionClose.method / Error : " + e.Message + "]");
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
