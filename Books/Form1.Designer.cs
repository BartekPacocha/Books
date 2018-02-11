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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pDetail.SuspendLayout();
            this.pMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(5, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Aktualizuj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(5, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Dodaj książke";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.pMenu.Controls.Add(this.btDetails);
            this.pMenu.Controls.Add(this.button2);
            this.pMenu.Controls.Add(this.button3);
            this.pMenu.Location = new System.Drawing.Point(12, 12);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(132, 233);
            this.pMenu.TabIndex = 5;
            this.pMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pMenu_LostFocus);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
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
    }
}

