namespace Library
{
    partial class InfoAuthorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoAuthorForm));
            nameMaskedTextBox = new MaskedTextBox();
            descriptionTextBox = new TextBox();
            booksCheckedListBox = new CheckedListBox();
            updateButton = new Button();
            deleteButton = new Button();
            SuspendLayout();
            // 
            // nameMaskedTextBox
            // 
            nameMaskedTextBox.Location = new Point(12, 12);
            nameMaskedTextBox.Mask = resources.GetString("nameMaskedTextBox.Mask");
            nameMaskedTextBox.Name = "nameMaskedTextBox";
            nameMaskedTextBox.Size = new Size(100, 23);
            nameMaskedTextBox.TabIndex = 4;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(157, 12);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(100, 23);
            descriptionTextBox.TabIndex = 5;
            // 
            // booksCheckedListBox
            // 
            booksCheckedListBox.FormattingEnabled = true;
            booksCheckedListBox.HorizontalScrollbar = true;
            booksCheckedListBox.Location = new Point(307, 12);
            booksCheckedListBox.Name = "booksCheckedListBox";
            booksCheckedListBox.Size = new Size(120, 94);
            booksCheckedListBox.TabIndex = 6;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(117, 186);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(75, 23);
            updateButton.TabIndex = 7;
            updateButton.Text = "Изменить";
            updateButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(211, 186);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 8;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // InfoAuthorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 221);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(booksCheckedListBox);
            Controls.Add(descriptionTextBox);
            Controls.Add(nameMaskedTextBox);
            Name = "InfoAuthorForm";
            Text = "InfoAuthorForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox nameMaskedTextBox;
        private TextBox descriptionTextBox;
        private CheckedListBox booksCheckedListBox;
        private Button updateButton;
        private Button deleteButton;
    }
}