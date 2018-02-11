using System;

public class DataBase
{
	public DataBase()
	{
        SQLiteConnection polaczenie = new SQLiteConnection(string.Format("Data Source={0}", Path.Combine(Application.StartupPath, "book.db")));
        SQLiteCommand komenda;
        string zapytanieSQL;

        polaczenie.Open();

        //MessageBox.Show("polaczono");
        if (polaczenie.State == ConnectionState.Open)
        {
            zapytanieSQL = string.Format("create table if not exists book(id integer primary key AUTOINCREMENT, author varchar(20), title varchar(20), pageNumber integer, pageReade integer, isReaded integer, startDate dateTimeVariable)");

            komenda = new SQLiteCommand(zapytanieSQL, polaczenie);
            komenda.ExecuteNonQuery();
        }

        polaczenie.Close();
        
    }
}
