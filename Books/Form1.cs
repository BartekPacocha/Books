using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Books
{
    public partial class Książki : Form
    {

        SQLiteConnection polaczenie = new SQLiteConnection(string.Format("Data Source={0}", Path.Combine(Application.StartupPath, "book.db")));
        SQLiteCommand komenda;
        string zapytanieSQL;
        int rowIndex;

        public Książki()
        {
            InitializeComponent();

            open();
            //MessageBox.Show("polaczono");
            if (polaczenie.State == ConnectionState.Open)
            {
                zapytanieSQL = string.Format("create table if not exists book(id integer primary key AUTOINCREMENT, author varchar(20), title varchar(20), pageNumber integer, pageReade integer, isReaded boolean, startDate dateTimeVariable)");
                komenda = new SQLiteCommand(zapytanieSQL, polaczenie);
                komenda.ExecuteNonQuery();                
            }

            zapytanieSQL = string.Format("select * FROM book");
            komenda = new SQLiteCommand(zapytanieSQL, polaczenie);

            //sCommand = new SqlCommand(sql, connection);

            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(komenda);

            dataGridView1.DataSource = dataAdapter;

            //sCommand = new SqlCommand(sql, connection);
            SQLiteDataAdapter sAdapter = new SQLiteDataAdapter(komenda);
            SQLiteCommandBuilder sBuilder = new SQLiteCommandBuilder(sAdapter);
            DataSet sDs = new DataSet();
            sAdapter.Fill(sDs, "book");
            DataTable sTable = sDs.Tables["book"];
            close();
            //dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = sDs.Tables["book"];
            dataGridView1.ReadOnly = true;
            //save_btn.Enabled = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            
           

           
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["pageNumber"].Visible = false;
            dataGridView1.Columns["pageReade"].Visible = false;
            dataGridView1.Columns["startDate"].Visible = false;
            dataGridView1.Columns["author"].HeaderText = "Autor";
            dataGridView1.Columns["title"].HeaderText = "Tytuł";
            dataGridView1.Columns["isReaded"].HeaderText = "Czytasz?";
            dataGridView1.Columns["isReaded"].ReadOnly = false;

            pDetail.Visible = true;



            



        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void open() { polaczenie.Open(); }
        public void close() { polaczenie.Close(); }
        public int getRowIndex() { return dataGridView1.CurrentCell.RowIndex; }
        public string setText(string text)
        {
            rowIndex = getRowIndex();
            return dataGridView1.Rows[rowIndex].Cells[text].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void pDetail_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbAuthor_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            rowIndex = getRowIndex();
            tbTitle.Text = rowIndex.ToString();
        }

        private void btDetail_Click(object sender, EventArgs e)
        {
            //rowIndex = getRowIndex();
            //string str = dataGridView1.Rows[rowIndex].Cells["author"].Value.ToString();

            tbAuthor.Text = setText("author");
            tbTitle.Text = setText("title");
            tbPageNumber.Text = setText("pageNumber");
            tbPageReade.Text = setText("pageReade");

        }

        private void tbTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPageNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPageReaded_TextChanged(object sender, EventArgs e)
        {

        }
    }
}




/*
string author, title;
int pageNumber, pageRead;
author = textBox1.Text;
title = textBox2.Text;
pageNumber = Int32.Parse(textBox3.Text);
pageRead = Int32.Parse(textBox4.Text);
            
int x = ((pageRead * 100) / pageNumber);
MessageBox.Show(x.ToString());
progressBar1.Value = x;
            
DateTime localDate = DateTime.Now;
DateTime past = DateTime.Now;

MessageBox.Show(localDate.ToString());
Console.WriteLine(localDate.CompareTo(past));
*/
