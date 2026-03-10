using Library.Data;
using Library.Data.Entities;
using Library.Data.Repositories;
using Library.Utilities;

namespace Library
{
    public partial class CreateAuthorForm : Form
    {
        private AuthorRepository _authorRepository;

        private BookRepository _booksRepository;

        public delegate void AuthorAdd(AuthorRepository authorRepository);

        public event AuthorAdd? authorAdded;

        public CreateAuthorForm(BookRepository booksRepository, AuthorRepository authorRepository)
        {
            InitializeComponent();

            _authorRepository = authorRepository;
            _booksRepository = booksRepository;

            booksCheckedListBox.Items.Clear();
            booksCheckedListBox.Items.AddRange(_booksRepository.GetAllBooks().ToArray());
            booksCheckedListBox.HorizontalExtent = CheckedListBoxHelper.GetMaxItemWidth(booksCheckedListBox);
            createAuthorButton.Click += createAuthorButtonClick;

        }

        private void createAuthorButtonClick(object? sender, EventArgs e)
        {
            try
            {
                var author = new Author
                {
                    Name = nameMaskedTextBox.Text.Trim(),
                    Description = descriptionTextBox.Text.Trim(),
                    Books = booksCheckedListBox.CheckedItems.Cast<Book>().ToList()
                };
                _authorRepository.AddAuthor(author);
                nameMaskedTextBox.Text = descriptionTextBox.Text = "";
                MessageBox.Show("Автор успешно создан");
                authorAdded?.Invoke(_authorRepository);
            }
            catch
            {
                MessageBox.Show("При создании автора произошла ошибка");
            }

        }
    }
}
