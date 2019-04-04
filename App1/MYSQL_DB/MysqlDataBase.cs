using MySql.Data.MySqlClient;
using System;

namespace App1.MYSQL_DB
{
    class MysqlDataBase
    {
        public Boolean tetst_db()
        {
            string query = "select u.current_login as id ,p.name as userName,p.phone" +
                " from sys_user u left join person_info p " +
                "on p.id = u.persion_id limit 2";
            MySqlConnection myConnection = new MySqlConnection("server=localhost;user id=root;password=123456;database=jims-his");
            MySqlCommand myCommand = new MySqlCommand(query, myConnection);
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            MySqlDataReader myDataReader = myCommand.ExecuteReader();
            string bookres = string.Empty;
            while (myDataReader.Read() == true)
            {
                bookres += myDataReader["id"]+"|";
                bookres += myDataReader["userName"]+"|";
                bookres += myDataReader["phone"]+"\r\n";
            }
            myDataReader.Close();
            myConnection.Close();
            Console.WriteLine(bookres);

            return bookres.Equals(string.Empty);
        }
    }
}
