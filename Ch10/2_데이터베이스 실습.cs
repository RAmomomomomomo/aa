using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10
{
    internal class _2_데이터베이스_실습
    {
        static void Main2(string[] args)
        {
            //데이터 베이스 접속 정보
            string server = "127.0.0.1";
            string port = "3306";
            string username = "root";
            string password = "1234";
            string database = "orderdb";

            //데이터 베이스 커넥션 생성
            string strConn = $"server={server};port={port};username={username};password={password};database={database}";
            MySqlConnection conn = new MySqlConnection(strConn);

            try
            {
                conn.Open();
                Console.WriteLine("성공 ");

                //sql실행 (추가) insert 부분만 바꾸면 삭제 수정도 가능함 좆같농 ㅋㅋ
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO `customer` VALUES ('sunggun','김성근','010-9999-8888','sbs','2022-01-13')";
                cmd.ExecuteNonQuery();
                Console.WriteLine("sql 실행완료 ");
            }
            catch (Exception e)
            {
                Console.WriteLine("접속 실패 : " + e.Message);
            }
            finally
            {
                conn.Close();
                Console.WriteLine("ㅂㅂ");
            }
        }
    }
}
