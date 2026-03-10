using Library.Data;
using Library.Data.Entities;
using Library.Data.Repositories;
using Library.Utilities;

namespace Library
{
    public partial class CreateBookForm : Form
    {
        private BookRepository _booksRepository;

        private AuthorRepository _authorsRepository;

        public delegate void BookAdd(BookRepository bookRepository);

        public event BookAdd? bookAdded;
        public CreateBookForm(BookRepository booksRepository, AuthorRepository authorRepository)
        {
            InitializeComponent();

            _booksRepository = booksRepository;
            _authorsRepository = authorRepository;

            authorCheckedListBox.Items.Clear();
            authorCheckedListBox.Items.AddRange(_authorsRepository.GetAllAuthors().ToArray());
            authorCheckedListBox.HorizontalExtent = CheckedListBoxHelper. GetMaxItemWidth(authorCheckedListBox);
            createBookButton.Click += createBookButtonClick;
        }

        private void createBookButtonClick(object? sender, EventArgs e)
        {
            try
            {
                var book = new Book
                {
                    Title = titleMaskedTextBox.Text.Trim(),
                    Authors = authorCheckedListBox.CheckedItems.Cast<Author>().ToList(),
                    YearOfPublication = int.Parse(yearMaskedTextBox.Text),
                    Quantity = int.Parse(quantityMaskedTextBox.Text),
                };
                _booksRepository.AddBook(book);
                titleMaskedTextBox.Text = yearMaskedTextBox.Text = quantityMaskedTextBox.Text = "";
                MessageBox.Show("Книга успешно создана");
                bookAdded?.Invoke(_booksRepository);
            }
            catch
            {
                MessageBox.Show("При создании книги возникла ошибка");
            }
        }
    }
}
