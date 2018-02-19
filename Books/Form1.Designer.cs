namespace Books
{
    partial class Książki
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btUpdate = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btDetails = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pDetail = new System.Windows.Forms.Panel();
            this.tbPageReade = new System.Windows.Forms.TextBox();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tbPageNumber = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.pMenu = new System.Windows.Forms.Panel();
            this.pAddBook = new System.Windows.Forms.Panel();
            this.rbOk = new System.Windows.Forms.RadioButton();
            this.nuAddPageNumber = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAddAuthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAddTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbCancel = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pDetail.SuspendLayout();
            this.pMenu.SuspendLayout();
            this.pAddBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuAddPageNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(5, 4);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(100, 23);
            this.btUpdate.TabIndex = 0;
            this.btUpdate.Text = "Aktualizuj";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(5, 33);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(100, 23);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "Dodaj książke";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDetails
            // 
            this.btDetails.Location = new System.Drawing.Point(5, 62);
            this.btDetails.Name = "btDetails";
            this.btDetails.Size = new System.Drawing.Size(100, 23);
            this.btDetails.TabIndex = 2;
            this.btDetails.Text = "Szczegóły";
            this.btDetails.UseVisualStyleBackColor = true;
            this.btDetails.Click += new System.EventHandler(this.btDetail_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(150, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(550, 202);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pDetail
            // 
            this.pDetail.Controls.Add(this.tbPageReade);
            this.pDetail.Controls.Add(this.pbProgress);
            this.pDetail.Controls.Add(this.textBox5);
            this.pDetail.Controls.Add(this.tbPageNumber);
            this.pDetail.Controls.Add(this.tbTitle);
            this.pDetail.Controls.Add(this.tbAuthor);
            this.pDetail.Location = new System.Drawing.Point(150, 220);
            this.pDetail.Name = "pDetail";
            this.pDetail.Size = new System.Drawing.Size(550, 29);
            this.pDetail.TabIndex = 4;
            this.pDetail.Paint += new System.Windows.Forms.PaintEventHandler(this.pDetail_Paint);
            // 
            // tbPageReade
            // 
            this.tbPageReade.Location = new System.Drawing.Point(272, 6);
            this.tbPageReade.Name = "tbPageReade";
            this.tbPageReade.Size = new System.Drawing.Size(45, 20);
            this.tbPageReade.TabIndex = 6;
            this.tbPageReade.TextChanged += new System.EventHandler(this.tbPageReaded_TextChanged);
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(323, 6);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(100, 19);
            this.pbProgress.TabIndex = 5;
            this.pbProgress.Click += new System.EventHandler(this.pbProgress_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(428, 6);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 4;
            // 
            // tbPageNumber
            // 
            this.tbPageNumber.Location = new System.Drawing.Point(216, 6);
            this.tbPageNumber.Name = "tbPageNumber";
            this.tbPageNumber.Size = new System.Drawing.Size(45, 20);
            this.tbPageNumber.TabIndex = 2;
            this.tbPageNumber.TextChanged += new System.EventHandler(this.tbPageNumber_TextChanged);
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(110, 6);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(100, 20);
            this.tbTitle.TabIndex = 1;
            this.tbTitle.TextChanged += new System.EventHandler(this.tbTitle_TextChanged);
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(4, 6);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(100, 20);
            this.tbAuthor.TabIndex = 0;
            this.tbAuthor.TextChanged += new System.EventHandler(this.tbAuthor_TextChanged);
            // 
            // pMenu
            // 
            this.pMenu.Controls.Add(this.pAddBook);
            this.pMenu.Controls.Add(this.btDetails);
            this.pMenu.Controls.Add(this.btUpdate);
            this.pMenu.Controls.Add(this.btAdd);
            this.pMenu.Location = new System.Drawing.Point(12, 12);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(132, 248);
            this.pMenu.TabIndex = 5;
            this.pMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pMenu_LostFocus);
            // 
            // pAddBook
            // 
            this.pAddBook.Controls.Add(this.rbCancel);
            this.pAddBook.Controls.Add(this.rbOk);
            this.pAddBook.Controls.Add(this.nuAddPageNumber);
            this.pAddBook.Controls.Add(this.label4);
            this.pAddBook.Controls.Add(this.tbAddAuthor);
            this.pAddBook.Controls.Add(this.label3);
            this.pAddBook.Controls.Add(this.tbAddTitle);
            this.pAddBook.Controls.Add(this.label2);
            this.pAddBook.Location = new System.Drawing.Point(5, 92);
            this.pAddBook.Name = "pAddBook";
            this.pAddBook.Size = new System.Drawing.Size(124, 153);
            this.pAddBook.TabIndex = 3;
            // 
            // rbOk
            // 
            this.rbOk.AutoSize = true;
            this.rbOk.Location = new System.Drawing.Point(7, 126);
            this.rbOk.Name = "rbOk";
            this.rbOk.Size = new System.Drawing.Size(40, 17);
            this.rbOk.TabIndex = 6;
            this.rbOk.TabStop = true;
            this.rbOk.Text = "OK";
            this.rbOk.UseVisualStyleBackColor = true;
            this.rbOk.CheckedChanged += new System.EventHandler(this.rbOk_CheckedChanged);
            // 
            // nuAddPageNumber
            // 
            this.nuAddPageNumber.Location = new System.Drawing.Point(7, 100);
            this.nuAddPageNumber.Name = "nuAddPageNumber";
            this.nuAddPageNumber.Size = new System.Drawing.Size(114, 20);
            this.nuAddPageNumber.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Liczba stron";
            // 
            // tbAddAuthor
            // 
            this.tbAddAuthor.Location = new System.Drawing.Point(7, 60);
            this.tbAddAuthor.Name = "tbAddAuthor";
            this.tbAddAuthor.Size = new System.Drawing.Size(114, 20);
            this.tbAddAuthor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Autor";
            // 
            // tbAddTitle
            // 
            this.tbAddTitle.Location = new System.Drawing.Point(7, 21);
            this.tbAddTitle.Name = "tbAddTitle";
            this.tbAddTitle.Size = new System.Drawing.Size(114, 20);
            this.tbAddTitle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tytuł";
            // 
            // rbCancel
            // 
            this.rbCancel.AutoSize = true;
            this.rbCancel.Location = new System.Drawing.Point(67, 126);
            this.rbCancel.Name = "rbCancel";
            this.rbCancel.Size = new System.Drawing.Size(54, 17);
            this.rbCancel.TabIndex = 7;
            this.rbCancel.TabStop = true;
            this.rbCancel.Text = "Anuluj";
            this.rbCancel.UseVisualStyleBackColor = true;
            this.rbCancel.CheckedChanged += new System.EventHandler(this.rbCancel_CheckedChanged);
            // 
            // Książki
            // 
            this.ClientSize = new System.Drawing.Size(712, 261);
            this.Controls.Add(this.pMenu);
            this.Controls.Add(this.pDetail);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Książki";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pDetail.ResumeLayout(false);
            this.pDetail.PerformLayout();
            this.pMenu.ResumeLayout(false);
            this.pAddBook.ResumeLayout(false);
            this.pAddBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuAddPageNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btDetails;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pDetail;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox tbPageNumber;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.TextBox tbPageReade;
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Panel pAddBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAddAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAddTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nuAddPageNumber;
        private System.Windows.Forms.RadioButton rbOk;
        private System.Windows.Forms.RadioButton rbCancel;
    }
}

