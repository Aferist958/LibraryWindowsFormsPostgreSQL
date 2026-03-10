using Library.Data;
using Library.Data.Entities;
using Library.Data.Repositories;
using Library.Utilities;

namespace Library
{
    public partial class InfoBookForm : Form
    {

        private BookRepository _booksRepository;

        private AuthorRepository _authorRepository;

        public delegate void BookChange(BookRepository bookAdded);

        public event BookChange? bookChange;

        private Guid _bookId;

        private Book? _book;

        public InfoBookForm(Guid bookId, BookRepository booksRepository, AuthorRepository authorRepository)
        {
            InitializeComponent();

            _booksRepository = booksRepository;
            _authorRepository = authorRepository;
            _bookId = bookId;
            _book = _booksRepository.GetBook(_bookId);

            titleMaskedTextBox.Text = _book.Title;
            authorsCheckedListBox.Items.Clear();
            authorsCheckedListBox.Items.AddRange(_authorRepository.GetAllAuthors().ToArray());
            authorsCheckedListBox.HorizontalExtent = CheckedListBoxHelper.GetMaxItemWidth(authorsCheckedListBox);
            CheckedListBoxHelper.SetItemsChecked<Author>(authorsCheckedListBox, author => _book.Authors.Any(a => a.Id == author.Id));
            yearMaskedTextBox.Text = _book.YearOfPublication.ToString();
            quantityMaskedTextBox.Text = _book.Quantity.ToString();
            issueButton.Click += issueBookButtonClick;
            returnButton.Click += returnBookButtonClick;
            updateButton.Click += updateBookButtonClick;
            deleteButton.Click += deleteBookButtonClick;
        }

        private void updateBookButtonClick(object? sender, EventArgs e)
        {
            try
            {
                _book.Title = titleMaskedTextBox.Text.Trim();
                _book.Authors = authorsCheckedListBox.CheckedItems.Cast<Author>().ToList();
                _book.YearOfPublication = int.Parse(yearMaskedTextBox.Text);
                _book.Quantity = int.Parse(quantityMaskedTextBox.Text);
                _booksRepository.UpdateBook(_book);
                MessageBox.Show("Книга успешно обновлена");
                bookChange?.Invoke(_booksRepository);
                this.Close();
            }
            catch
            {
                MessageBox.Show("При обновлении книги возникла ошибка");
            }
        }

        private void deleteBookButtonClick(object? sender, EventArgs e)
        {
            try
            {
                _booksRepository.DeleteBook(_bookId);
                MessageBox.Show("Книга успешно удалена");
                bookChange?.Invoke(_booksRepository);
                this.Close();
            }
            catch
            {
                MessageBox.Show("При удалении книги возникла ошибка");
            }
        }

        private void issueBookButtonClick(object? sender, EventArgs e)
        {
            try
            {
                if (_book.Quantity > 0)
                {
                    _book.Quantity--;
                    _booksRepository.UpdateBook(_book);
                    MessageBox.Show("Книга успешно выдана");
                    bookChange?.Invoke(_booksRepository);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Вы не можете выдать книгу, из-за их отсутвия");
                }
            }
            catch
            {
                MessageBox.Show("При выдаче книги возникла ошибка");
            }
        }

        private void returnBookButtonClick(object? sender, EventArgs e)
        {
            try
            {
                _book.Quantity++;
                _booksRepository.UpdateBook(_book);
                MessageBox.Show("Книга успешна вернута");
                bookChange?.Invoke(_booksRepository);
                this.Close();
            }
            catch
            {
                MessageBox.Show("При возращение книги возникла ошибка");
            }
        }
    }
}
