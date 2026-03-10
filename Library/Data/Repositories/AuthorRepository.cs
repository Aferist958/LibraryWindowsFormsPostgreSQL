using Library.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library.Data.Repositories
{
    public class AuthorRepository
    {
        private AppDbContext _dbContext;

        public AuthorRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext; 
        }

        public List<Author> GetAllAuthors()
        {
            return _dbContext.Authors.Include(a => a.Books).ToList();
        }

        public Author? GetAuthor(Guid id)
        {
            return _dbContext.Authors.Find(id);
        }

        public void AddAuthor(Author author)
        {
            _dbContext.Authors.Add(author);
            _dbContext.SaveChanges();
        }

        public void UpdateAuthor(Author author)
        {
            _dbContext.Authors.Update(author);
            _dbContext.SaveChanges();
        }

        public void DeleteAuthor(Guid id)
        {
            var author = _dbContext.Authors.Find(id);
            if (author != null)
            {
                _dbContext.Authors.Remove(author);
                _dbContext.SaveChanges();
            }
        }
    }
}
