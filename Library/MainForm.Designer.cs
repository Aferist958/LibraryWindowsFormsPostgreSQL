namespace Library
{
    partial class MainForm
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
            helpProvider1 = new HelpProvider();
            tabPage2 = new TabPage();
            authorDataGridView = new DataGridView();
            clearSearchAuthorButton = new Button();
            createAuthorButton = new Button();
            searchAuthorButton = new Button();
            searchAuthorTextBox = new TextBox();
            tabPage1 = new TabPage();
            bookDataGridView = new DataGridView();
            clearSearchBookButton = new Button();
            createBookButton = new Button();
            searchBookButton = new Button();
            searchBookTextBox = new TextBox();
            tabControl1 = new TabControl();
            bookId = new DataGridViewTextBoxColumn();
            titleColumn = new DataGridViewTextBoxColumn();
            authorColumn = new DataGridViewTextBoxColumn();
            yearColumn = new DataGridViewTextBoxColumn();
            quantityColumn = new DataGridViewTextBoxColumn();
            authorId = new DataGridViewTextBoxColumn();
            nameColumn = new DataGridViewTextBoxColumn();
            descriptionColumn = new DataGridViewTextBoxColumn();
            booksColumn = new DataGridViewTextBoxColumn();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)authorDataGridView).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bookDataGridView).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(authorDataGridView);
            tabPage2.Controls.Add(clearSearchAuthorButton);
            tabPage2.Controls.Add(createAuthorButton);
            tabPage2.Controls.Add(searchAuthorButton);
            tabPage2.Controls.Add(searchAuthorTextBox);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(481, 407);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Авторы";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // authorDataGridView
            // 
            authorDataGridView.AllowUserToAddRows = false;
            authorDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            authorDataGridView.Columns.AddRange(new DataGridViewColumn[] { authorId, nameColumn, descriptionColumn, booksColumn });
            authorDataGridView.Location = new Point(18, 38);
            authorDataGridView.Name = "authorDataGridView";
            authorDataGridView.Size = new Size(343, 330);
            authorDataGridView.TabIndex = 6;
            // 
            // clearSearchAuthorButton
            // 
            clearSearchAuthorButton.Location = new Point(309, 9);
            clearSearchAuthorButton.Name = "clearSearchAuthorButton";
            clearSearchAuthorButton.Size = new Size(113, 23);
            clearSearchAuthorButton.TabIndex = 9;
            clearSearchAuthorButton.Text = "Очистить поиск";
            clearSearchAuthorButton.UseVisualStyleBackColor = true;
            // 
            // createAuthorButton
            // 
            createAuthorButton.Location = new Point(18, 374);
            createAuthorButton.Name = "createAuthorButton";
            createAuthorButton.Size = new Size(158, 23);
            createAuthorButton.TabIndex = 5;
            createAuthorButton.Text = "Создать автора";
            createAuthorButton.UseVisualStyleBackColor = true;
            // 
            // searchAuthorButton
            // 
            searchAuthorButton.Location = new Point(228, 9);
            searchAuthorButton.Name = "searchAuthorButton";
            searchAuthorButton.Size = new Size(75, 23);
            searchAuthorButton.TabIndex = 8;
            searchAuthorButton.Text = "Поиск";
            searchAuthorButton.UseVisualStyleBackColor = true;
            // 
            // searchAuthorTextBox
            // 
            searchAuthorTextBox.Location = new Point(18, 9);
            searchAuthorTextBox.Name = "searchAuthorTextBox";
            searchAuthorTextBox.Size = new Size(204, 23);
            searchAuthorTextBox.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(bookDataGridView);
            tabPage1.Controls.Add(clearSearchBookButton);
            tabPage1.Controls.Add(createBookButton);
            tabPage1.Controls.Add(searchBookButton);
            tabPage1.Controls.Add(searchBookTextBox);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(481, 407);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Книги";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // bookDataGridView
            // 
            bookDataGridView.AllowUserToAddRows = false;
            bookDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookDataGridView.Columns.AddRange(new DataGridViewColumn[] { bookId, titleColumn, authorColumn, yearColumn, quantityColumn });
            bookDataGridView.Location = new Point(19, 39);
            bookDataGridView.Name = "bookDataGridView";
            bookDataGridView.Size = new Size(445, 330);
            bookDataGridView.TabIndex = 1;
            // 
            // clearSearchBookButton
            // 
            clearSearchBookButton.Location = new Point(310, 10);
            clearSearchBookButton.Name = "clearSearchBookButton";
            clearSearchBookButton.Size = new Size(113, 23);
            clearSearchBookButton.TabIndex = 4;
            clearSearchBookButton.Text = "Очистить поиск";
            clearSearchBookButton.UseVisualStyleBackColor = true;
            // 
            // createBookButton
            // 
            createBookButton.Location = new Point(19, 375);
            createBookButton.Name = "createBookButton";
            createBookButton.Size = new Size(158, 23);
            createBookButton.TabIndex = 0;
            createBookButton.Text = "Создать книгу";
            createBookButton.UseVisualStyleBackColor = true;
            // 
            // searchBookButton
            // 
            searchBookButton.Location = new Point(229, 10);
            searchBookButton.Name = "searchBookButton";
            searchBookButton.Size = new Size(75, 23);
            searchBookButton.TabIndex = 3;
            searchBookButton.Text = "Поиск";
            searchBookButton.UseVisualStyleBackColor = true;
            // 
            // searchBookTextBox
            // 
            searchBookTextBox.Location = new Point(19, 10);
            searchBookTextBox.Name = "searchBookTextBox";
            searchBookTextBox.Size = new Size(204, 23);
            searchBookTextBox.TabIndex = 2;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(489, 435);
            tabControl1.TabIndex = 5;
            // 
            // bookId
            // 
            bookId.HeaderText = "Id";
            bookId.Name = "bookId";
            bookId.ReadOnly = true;
            bookId.Visible = false;
            // 
            // titleColumn
            // 
            titleColumn.HeaderText = "Название";
            titleColumn.Name = "titleColumn";
            titleColumn.ReadOnly = true;
            // 
            // authorColumn
            // 
            authorColumn.HeaderText = "Автор";
            authorColumn.Name = "authorColumn";
            authorColumn.ReadOnly = true;
            // 
            // yearColumn
            // 
            yearColumn.HeaderText = "Год публикации";
            yearColumn.Name = "yearColumn";
            yearColumn.ReadOnly = true;
            // 
            // quantityColumn
            // 
            quantityColumn.HeaderText = "Количество";
            quantityColumn.Name = "quantityColumn";
            quantityColumn.ReadOnly = true;
            // 
            // authorId
            // 
            authorId.HeaderText = "Id";
            authorId.Name = "authorId";
            authorId.ReadOnly = true;
            authorId.Visible = false;
            // 
            // nameColumn
            // 
            nameColumn.HeaderText = "Имя";
            nameColumn.Name = "nameColumn";
            nameColumn.ReadOnly = true;
            // 
            // descriptionColumn
            // 
            descriptionColumn.HeaderText = "Описание";
            descriptionColumn.Name = "descriptionColumn";
            descriptionColumn.ReadOnly = true;
            // 
            // booksColumn
            // 
            booksColumn.HeaderText = "Книги";
            booksColumn.Name = "booksColumn";
            booksColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 450);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Книги";
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)authorDataGridView).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bookDataGridView).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private HelpProvider helpProvider1;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private DataGridView bookDataGridView;
        private Button clearSearchBookButton;
        private Button createBookButton;
        private Button searchBookButton;
        private TextBox searchBookTextBox;
        private TabControl tabControl1;
        private DataGridView authorDataGridView;
        private Button clearSearchAuthorButton;
        private Button createAuthorButton;
        private Button searchAuthorButton;
        private TextBox searchAuthorTextBox;
        private DataGridViewTextBoxColumn authorId;
        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn descriptionColumn;
        private DataGridViewTextBoxColumn booksColumn;
        private DataGridViewTextBoxColumn bookId;
        private DataGridViewTextBoxColumn titleColumn;
        private DataGridViewTextBoxColumn authorColumn;
        private DataGridViewTextBoxColumn yearColumn;
        private DataGridViewTextBoxColumn quantityColumn;
    }
}
