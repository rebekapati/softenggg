namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            authorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yearDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isAvailableDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            bookBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, authorDataGridViewTextBoxColumn, yearDataGridViewTextBoxColumn, genreDataGridViewTextBoxColumn, isAvailableDataGridViewCheckBoxColumn });
            dataGridView1.DataSource = bookBindingSource;
            dataGridView1.Location = new Point(27, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(845, 228);
            dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            authorDataGridViewTextBoxColumn.HeaderText = "Author";
            authorDataGridViewTextBoxColumn.MinimumWidth = 6;
            authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            authorDataGridViewTextBoxColumn.Width = 125;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            yearDataGridViewTextBoxColumn.HeaderText = "Year";
            yearDataGridViewTextBoxColumn.MinimumWidth = 6;
            yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            yearDataGridViewTextBoxColumn.Width = 125;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            genreDataGridViewTextBoxColumn.MinimumWidth = 6;
            genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            genreDataGridViewTextBoxColumn.Width = 125;
            // 
            // isAvailableDataGridViewCheckBoxColumn
            // 
            isAvailableDataGridViewCheckBoxColumn.DataPropertyName = "IsAvailable";
            isAvailableDataGridViewCheckBoxColumn.HeaderText = "IsAvailable";
            isAvailableDataGridViewCheckBoxColumn.MinimumWidth = 6;
            isAvailableDataGridViewCheckBoxColumn.Name = "isAvailableDataGridViewCheckBoxColumn";
            isAvailableDataGridViewCheckBoxColumn.Width = 125;
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(BookModels.Book);
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", bookBindingSource, "Id", true));
            textBox1.Location = new Point(27, 273);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(310, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", bookBindingSource, "Title", true));
            textBox2.Location = new Point(27, 306);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(310, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", bookBindingSource, "Author", true));
            textBox3.Location = new Point(27, 339);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(310, 27);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", bookBindingSource, "Year", true));
            textBox4.Location = new Point(27, 372);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(310, 27);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", bookBindingSource, "Genre", true));
            textBox5.Location = new Point(27, 411);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(310, 27);
            textBox5.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(398, 273);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(398, 339);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(597, 297);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 8;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isAvailableDataGridViewCheckBoxColumn;
        private BindingSource bookBindingSource;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
