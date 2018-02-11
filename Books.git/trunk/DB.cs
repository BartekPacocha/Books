using System;

public class DB
{
    public DB()
    {
        SQLiteConnection polaczenie = new SQLiteConnection(string.Format("Data Source={0}", Path.Combine(Application.StartupPath, "book.db")));
        SQLiteCommand komenda;
        string zapytanieSQL;

        fun();
        //MessageBox.Show("polaczono");
        if (polaczenie.State == ConnectionState.Open)
        {
            zapytanieSQL = string.Format("create table if not exists book(id integer primary key AUTOINCREMENT, author varchar(20), title varchar(20), pageNumber integer, pageReade integer, isReaded integer, startDate dateTimeVariable)");
            komenda = new SQLiteCommand(zapytanieSQL, polaczenie);
            komenda.ExecuteNonQuery();
        }

        polaczenie.Close();
    }

        public static void fun() { polaczenie.Open(); }

}
