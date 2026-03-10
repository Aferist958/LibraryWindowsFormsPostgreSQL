namespace Library
{
    partial class InfoBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoBookForm));
            titleMaskedTextBox = new MaskedTextBox();
            yearMaskedTextBox = new MaskedTextBox();
            quantityMaskedTextBox = new MaskedTextBox();
            updateButton = new Button();
            deleteButton = new Button();
            issueButton = new Button();
            returnButton = new Button();
            authorsCheckedListBox = new CheckedListBox();
            SuspendLayout();
            // 
            // titleMaskedTextBox
            // 
            titleMaskedTextBox.Location = new Point(12, 12);
            titleMaskedTextBox.Mask = resources.GetString("titleMaskedTextBox.Mask");
            titleMaskedTextBox.Name = "titleMaskedTextBox";
            titleMaskedTextBox.Size = new Size(100, 23);
            titleMaskedTextBox.TabIndex = 9;
            // 
            // yearMaskedTextBox
            // 
            yearMaskedTextBox.Location = new Point(224, 12);
            yearMaskedTextBox.Mask = "0000";
            yearMaskedTextBox.Name = "yearMaskedTextBox";
            yearMaskedTextBox.Size = new Size(100, 23);
            yearMaskedTextBox.TabIndex = 7;
            yearMaskedTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // quantityMaskedTextBox
            // 
            quantityMaskedTextBox.Location = new Point(330, 12);
            quantityMaskedTextBox.Mask = "9999999999";
            quantityMaskedTextBox.Name = "quantityMaskedTextBox";
            quantityMaskedTextBox.Size = new Size(100, 23);
            quantityMaskedTextBox.TabIndex = 6;
            quantityMaskedTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(118, 186);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(75, 23);
            updateButton.TabIndex = 4;
            updateButton.Text = "Изменить";
            updateButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(249, 186);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // issueButton
            // 
            issueButton.Location = new Point(96, 157);
            issueButton.Name = "issueButton";
            issueButton.Size = new Size(97, 23);
            issueButton.TabIndex = 10;
            issueButton.Text = "Выдать книгу";
            issueButton.UseVisualStyleBackColor = true;
            // 
            // returnButton
            // 
            returnButton.Location = new Point(249, 157);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(98, 23);
            returnButton.TabIndex = 11;
            returnButton.Text = "Вернуть книгу";
            returnButton.UseVisualStyleBackColor = true;
            // 
            // authorsCheckedListBox
            // 
            authorsCheckedListBox.FormattingEnabled = true;
            authorsCheckedListBox.HorizontalScrollbar = true;
            authorsCheckedListBox.Location = new Point(118, 12);
            authorsCheckedListBox.Name = "authorsCheckedListBox";
            authorsCheckedListBox.Size = new Size(100, 94);
            authorsCheckedListBox.TabIndex = 12;
            // 
            // InfoBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 221);
            Controls.Add(authorsCheckedListBox);
            Controls.Add(returnButton);
            Controls.Add(issueButton);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(quantityMaskedTextBox);
            Controls.Add(yearMaskedTextBox);
            Controls.Add(titleMaskedTextBox);
            Name = "InfoBookForm";
            Text = "Информация о книге";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox titleMaskedTextBox;
        private MaskedTextBox yearMaskedTextBox;
        private MaskedTextBox quantityMaskedTextBox;
        private Button updateButton;
        private Button deleteButton;
        private Button issueButton;
        private Button returnButton;
        private CheckedListBox authorsCheckedListBox;
    }
}