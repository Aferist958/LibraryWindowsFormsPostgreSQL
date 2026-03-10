using Library.Data;
using Library.Data.Entities;
using Library.Data.Repositories;
using System.Diagnostics;
using static System.Reflection.Metadata.BlobBuilder;

namespace Library
{
    public partial class MainForm : Form
    {
        private BookRepository _booksRepository;

        private AuthorRepository _authorRepository;
        public MainForm()
        {
            InitializeComponent();

            var context = new AppDbContext();
            _booksRepository = new BookRepository(context);
            _authorRepository = new AuthorRepository(context);

            LoadBooksData(_booksRepository);
            searchBookButton.Click += searchBookButtonClick;
            clearSearchBookButton.Click += clearSearchBookButtonClick;
            createBookButton.Click += createBookButtonClick;
            bookDataGridView.CellClick += bookDataGridViewCellClick;

            LoadAuthorsData(_authorRepository);
            searchAuthorButton.Click += searchAuthorButtonClick;
            clearSearchAuthorButton.Click += clearSearchAuthorButtonClick;
            createAuthorButton.Click += createAuthorButtonClick;
            authorDataGridView.CellClick += authorDataGridViewCellClick;
        }

        private void LoadBooksData(BookRepository booksRepository)
        {
            bookDataGridView.Rows.Clear();
            foreach (var book in booksRepository.GetAllBooks())
            {
                bookDataGridView.Rows.Add(book.Id, book.Title, string.Join(", ", book.Authors
                    .Select(a => a.ToString())), book.YearOfPublication, book.Quantity);
            }
        }
        public void LoadAuthorsData(AuthorRepository authorRepository)
        {
            authorDataGridView.Rows.Clear();
            foreach (var author in authorRepository.GetAllAuthors())
            {
                authorDataGridView.Rows.Add(author.Id, author.Name, author.Description, string.Join(", ", author.Books));
            }
        }

        private void createBookButtonClick(object? sender, EventArgs e)
        {
            CreateBookForm createForm = new CreateBookForm(_booksRepository, _authorRepository);
            createForm.bookAdded += LoadBooksData;
            createForm.ShowDialog();
        }

        private void createAuthorButtonClick(object? sender, EventArgs e)
        {
            CreateAuthorForm createForm = new CreateAuthorForm(_booksRepository, _authorRepository);
            createForm.authorAdded += LoadAuthorsData;
            createForm.ShowDialog();
        }

        private void bookDataGridViewCellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow clickedBookRow = bookDataGridView.Rows[e.RowIndex];
                InfoBookForm infoForm = new InfoBookForm((Guid)clickedBookRow.Cells["bookId"].Value, _booksRepository, _authorRepository);
                infoForm.bookChange += LoadBooksData;
                infoForm.ShowDialog();
            }
        }

        private void authorDataGridViewCellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow clickedAuthorRow = authorDataGridView.Rows[e.RowIndex];
                InfoAuthorForm infoForm = new InfoAuthorForm((Guid)clickedAuthorRow.Cells["authorId"].Value, _booksRepository, _authorRepository);
                infoForm.authorChange += LoadAuthorsData;
                infoForm.ShowDialog();
            }
        }

        private void searchBookButtonClick(object? sender, EventArgs e)
        {
            try
            {
                List<Book> searchResult = new List<Book>(_booksRepository.GetAllBooks().Count);
                List<Book> books = _booksRepository.GetAllBooks();
                if (!string.IsNullOrEmpty(searchBookTextBox.Text))
                {
                    searchResult.AddRange(books
                        .Where(b => b.Title
                        .Contains(searchBookTextBox.Text, StringComparison.OrdinalIgnoreCase)));
                    searchResult.AddRange(books
                        .Where(b => b.Authors
                        .Any(a => a.Name
                        .Contains(searchBookTextBox.Text))));
                    if (int.TryParse(searchBookTextBox.Text, out int year))
                    {
                        searchResult.AddRange(books
                            .Where(b => b.YearOfPublication == year));
                    }
                    searchResult = searchResult
                        .DistinctBy(b => b.Id)
                        .ToList();
                    bookDataGridView.Rows.Clear();
                    foreach (Book book in searchResult)
                    {
                        bookDataGridView.Rows.Add(book.Id, book.Title, string.Join(", ", book.Authors.Select(a => a.ToString())), book.YearOfPublication, book.Quantity);
                    }
                }
            }
            catch
            {
                MessageBox.Show("При поиске возникла ошибка");
            }
        }

        private void clearSearchBookButtonClick(object? sender, EventArgs e)
        {
            searchBookTextBox.Text = "";
            LoadBooksData(_booksRepository);
        }

        private void searchAuthorButtonClick(object? sender, EventArgs e)
        {
            try
            {
                List<Author> searchResult = new List<Author>(_authorRepository.GetAllAuthors().Count);
                List<Author> authors = _authorRepository.GetAllAuthors();
                if (!string.IsNullOrEmpty(searchAuthorTextBox.Text))
                {
                    searchResult.AddRange(authors
                        .Where(a => a.Name
                        .Contains(searchAuthorTextBox.Text, StringComparison.OrdinalIgnoreCase)));
                    searchResult.AddRange(authors
                        .Where(a => a.Description
                        .Contains(searchAuthorTextBox.Text, StringComparison.OrdinalIgnoreCase)));
                    searchResult.AddRange(authors
                        .Where(a => a.Books
                        .Any(b => b.Title
                        .Contains(searchAuthorTextBox.Text))));
                    if (int.TryParse(searchAuthorTextBox.Text, out int year))
                    {
                        searchResult.AddRange(authors
                            .Where(a => a.Books
                            .Any(b => b.YearOfPublication == year)));
                    }
                    searchResult = searchResult
                        .DistinctBy(a => a.Id)
                        .ToList();
                    authorDataGridView.Rows.Clear();
                    foreach (Author author in searchResult)
                    {
                        authorDataGridView.Rows.Add(author.Id, author.Name, author.Description, string.Join(", ", author.Books.Select(a => a.ToString())));
                    }
                }
            }
            catch
            {
                MessageBox.Show("При поиске возникла ошибка");
            }
        }

        private void clearSearchAuthorButtonClick(object? sender, EventArgs e)
        {
            searchAuthorTextBox.Text = "";
            LoadAuthorsData(_authorRepository);
        }
    }
}
