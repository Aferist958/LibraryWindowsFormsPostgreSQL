namespace Library
{
    partial class CreateAuthorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAuthorForm));
            nameLabel = new Label();
            descriptionLabel = new Label();
            booksLabel = new Label();
            nameMaskedTextBox = new MaskedTextBox();
            descriptionTextBox = new TextBox();
            booksCheckedListBox = new CheckedListBox();
            createAuthorButton = new Button();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(42, 27);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(31, 15);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Имя";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(159, 27);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(62, 15);
            descriptionLabel.TabIndex = 1;
            descriptionLabel.Text = "Описание";
            // 
            // booksLabel
            // 
            booksLabel.AutoSize = true;
            booksLabel.Location = new Point(290, 27);
            booksLabel.Name = "booksLabel";
            booksLabel.Size = new Size(40, 15);
            booksLabel.TabIndex = 2;
            booksLabel.Text = "Книги";
            // 
            // nameMaskedTextBox
            // 
            nameMaskedTextBox.Location = new Point(12, 56);
            nameMaskedTextBox.Mask = resources.GetString("nameMaskedTextBox.Mask");
            nameMaskedTextBox.Name = "nameMaskedTextBox";
            nameMaskedTextBox.Size = new Size(100, 23);
            nameMaskedTextBox.TabIndex = 3;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(136, 56);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(100, 23);
            descriptionTextBox.TabIndex = 4;
            // 
            // booksCheckedListBox
            // 
            booksCheckedListBox.FormattingEnabled = true;
            booksCheckedListBox.HorizontalScrollbar = true;
            booksCheckedListBox.Location = new Point(251, 56);
            booksCheckedListBox.Name = "booksCheckedListBox";
            booksCheckedListBox.Size = new Size(120, 94);
            booksCheckedListBox.TabIndex = 5;
            // 
            // createAuthorButton
            // 
            createAuthorButton.Location = new Point(146, 171);
            createAuthorButton.Name = "createAuthorButton";
            createAuthorButton.Size = new Size(105, 23);
            createAuthorButton.TabIndex = 6;
            createAuthorButton.Text = "Создать автора";
            createAuthorButton.UseVisualStyleBackColor = true;
            // 
            // CreateAuthorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 206);
            Controls.Add(createAuthorButton);
            Controls.Add(booksCheckedListBox);
            Controls.Add(descriptionTextBox);
            Controls.Add(nameMaskedTextBox);
            Controls.Add(booksLabel);
            Controls.Add(descriptionLabel);
            Controls.Add(nameLabel);
            Name = "CreateAuthorForm";
            Text = "CreateAuthorForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Label descriptionLabel;
        private Label booksLabel;
        private MaskedTextBox nameMaskedTextBox;
        private TextBox descriptionTextBox;
        private CheckedListBox booksCheckedListBox;
        private Button createAuthorButton;
    }
}