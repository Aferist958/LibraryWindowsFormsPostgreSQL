using System.Threading.Tasks;

namespace Library
{
    partial class CreateBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateBookForm));
            titleMaskedTextBox = new MaskedTextBox();
            yearMaskedTextBox = new MaskedTextBox();
            createBookButton = new Button();
            quantityMaskedTextBox = new MaskedTextBox();
            titleLabel = new Label();
            authorLabel = new Label();
            yearLabel = new Label();
            quantityLabel = new Label();
            authorCheckedListBox = new CheckedListBox();
            SuspendLayout();
            // 
            // titleMaskedTextBox
            // 
            titleMaskedTextBox.Location = new Point(3, 35);
            titleMaskedTextBox.Mask = resources.GetString("titleMaskedTextBox.Mask");
            titleMaskedTextBox.Name = "titleMaskedTextBox";
            titleMaskedTextBox.Size = new Size(100, 23);
            titleMaskedTextBox.TabIndex = 0;
            // 
            // yearMaskedTextBox
            // 
            yearMaskedTextBox.Location = new Point(204, 35);
            yearMaskedTextBox.Mask = "0000";
            yearMaskedTextBox.Name = "yearMaskedTextBox";
            yearMaskedTextBox.Size = new Size(100, 23);
            yearMaskedTextBox.TabIndex = 2;
            yearMaskedTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // createBookButton
            // 
            createBookButton.Location = new Point(146, 151);
            createBookButton.Name = "createBookButton";
            createBookButton.Size = new Size(102, 23);
            createBookButton.TabIndex = 4;
            createBookButton.Text = "Создать книгу";
            createBookButton.UseVisualStyleBackColor = true;
            // 
            // quantityMaskedTextBox
            // 
            quantityMaskedTextBox.Location = new Point(312, 35);
            quantityMaskedTextBox.Mask = "9999999999";
            quantityMaskedTextBox.Name = "quantityMaskedTextBox";
            quantityMaskedTextBox.Size = new Size(68, 23);
            quantityMaskedTextBox.TabIndex = 5;
            quantityMaskedTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(22, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(59, 15);
            titleLabel.TabIndex = 6;
            titleLabel.Text = "Название";
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new Point(136, 9);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new Size(40, 15);
            authorLabel.TabIndex = 7;
            authorLabel.Text = "Автор";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new Point(222, 9);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(73, 15);
            yearLabel.TabIndex = 8;
            yearLabel.Text = "Год издания";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new Point(312, 9);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(72, 15);
            quantityLabel.TabIndex = 9;
            quantityLabel.Text = "Количество";
            // 
            // authorCheckedListBox
            // 
            authorCheckedListBox.FormattingEnabled = true;
            authorCheckedListBox.HorizontalScrollbar = true;
            authorCheckedListBox.Location = new Point(109, 35);
            authorCheckedListBox.Name = "authorCheckedListBox";
            authorCheckedListBox.Size = new Size(89, 94);
            authorCheckedListBox.TabIndex = 11;
            // 
            // CreateBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 206);
            Controls.Add(authorCheckedListBox);
            Controls.Add(quantityLabel);
            Controls.Add(yearLabel);
            Controls.Add(authorLabel);
            Controls.Add(titleLabel);
            Controls.Add(quantityMaskedTextBox);
            Controls.Add(createBookButton);
            Controls.Add(yearMaskedTextBox);
            Controls.Add(titleMaskedTextBox);
            Name = "CreateBookForm";
            Text = "Создание книги";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox titleMaskedTextBox;
        private MaskedTextBox authorMaskedTextBox;
        private MaskedTextBox yearMaskedTextBox;
        private Button createBookButton;
        private MaskedTextBox quantityMaskedTextBox;
        private Label titleLabel;
        private Label authorLabel;
        private Label yearLabel;
        private Label quantityLabel;
        private CheckedListBox authorCheckedListBox;
    }
}