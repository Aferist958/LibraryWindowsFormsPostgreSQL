using Library.Data;
using Library.Data.Entities;
using Library.Data.Repositories;
using Library.Utilities;
using static Library.InfoBookForm;

namespace Library
{
    public partial class InfoAuthorForm : Form
    {
        private BookRepository _booksRepository;

        private AuthorRepository _authorRepository;

        public delegate void AuthorChange(AuthorRepository authorAdded);

        public event AuthorChange? authorChange;

        private Guid _authorId;

        private Author? _author;

        public InfoAuthorForm(Guid authorId, BookRepository booksRepository, AuthorRepository authorRepository)
        {
            InitializeComponent();

            _booksRepository = booksRepository;
            _authorRepository = authorRepository;
            _authorId = authorId;
            _author = _authorRepository.GetAuthor(authorId);

            nameMaskedTextBox.Text = _author.Name;
            descriptionTextBox.Text = _author.Description;
            booksCheckedListBox.Items.Clear();
            booksCheckedListBox.Items.AddRange(_booksRepository.GetAllBooks().ToArray());
            booksCheckedListBox.HorizontalExtent = CheckedListBoxHelper.GetMaxItemWidth(booksCheckedListBox);
            CheckedListBoxHelper.SetItemsChecked<Book>(booksCheckedListBox, book => _author.Books.Any(b => b.Id == book.Id));
            updateButton.Click += updateAuthorButtonClick;
            deleteButton.Click += deleteAuthorButtonClick;
        }

        private void updateAuthorButtonClick(object? sender, EventArgs e)
        {
            try
            {
                _author.Name = nameMaskedTextBox.Text;
                _author.Description = descriptionTextBox.Text;
                _author.Books = booksCheckedListBox.CheckedItems.Cast<Book>().ToList();
                _authorRepository.UpdateAuthor(_author);
                MessageBox.Show("Автор успешно обновлён");
                authorChange?.Invoke(_authorRepository);
                this.Close();
            }
            catch
            {
                MessageBox.Show("При обновлении автора возникла ошибка");
            }
        }

        private void deleteAuthorButtonClick(object? sender, EventArgs e)
        {
            try
            {
                _authorRepository.DeleteAuthor(_authorId);
                MessageBox.Show("Автор успешно удалён");
                authorChange?.Invoke(_authorRepository);
                this.Close();
            }
            catch
            {
                MessageBox.Show("При удалении автора возникла ошибка");
            }
        }
    }
}
