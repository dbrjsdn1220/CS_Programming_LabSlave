using Management_Books.repository;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Management_Books.SQL
{
	class studentDataPush
	{
		private const string DB_SERVER_ID = "localhost";
		private const string DB_NAME = "bookdb";
		private const string DB_ID = "root";
		private const string DB_PASSWORD = "1234";

		public static void main(string[] args)
		{
			string connStr = "Server=" + DB_SERVER_ID + ";Database=" + DB_NAME + ";Uid=" + DB_ID + ";Pwd=" + DB_PASSWORD + ";";
			string query = "INSERT INTO students(student_id) VALUES(@student_id)";

			MySqlConnection conn = new MySqlConnection(connStr); conn.Open();
			MySqlTransaction transaction = conn.BeginTransaction();
			MySqlCommand cmd = new MySqlCommand(query, conn, transaction);
			MySqlDataReader reader;

			try
			{
				for (int grade = 1; grade <= 6; grade++) // 학년: 1 ~ 6
				{
					for (int classNum = 1; classNum <= 10; classNum++) // 반: 1 ~ 10
					{
						for (int studentNum = 1; studentNum <= 30; studentNum++) // 번호: 1 ~ 30
						{
							// 학년과 반의 자릿수를 맞추기 위해 10으로 곱한 후 학생 번호를 더함
							int studentCode = grade * 10000 + classNum * 100 + studentNum;
							cmd.Parameters.Clear();
							cmd.Parameters.AddWithValue("@student_id", studentCode);
							cmd.ExecuteNonQuery();
						}
					}
				}
				transaction.Commit();
			}
			catch (MySqlException e)
			{
				transaction.Rollback();
				Console.WriteLine(e.Message);
			}
		}
	}
}
