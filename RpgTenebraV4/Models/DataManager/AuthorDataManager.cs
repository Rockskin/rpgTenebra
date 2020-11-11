using Microsoft.EntityFrameworkCore;
using RpgTenebraV4.Repository;
using System.Collections.Generic;
using System.Linq;

namespace RpgTenebraV4.Models.DataManager
{
    public class AuthorDataManager: IDataRepository
    {
        BookStoreContext _bookStoreContext = new BookStoreContext();
        public IEnumerable<Author> GetAll()
        {
            return _bookStoreContext.Author
                .Include(author => author.AuthorContact)
                .ToList();
        }
        public AuthorDto GetDto(long id)
        {
            _bookStoreContext.ChangeTracker.LazyLoadingEnabled = true;

            using (var context = new BookStoreContext())
            {
                var author = context.Author
                       .SingleOrDefault(b => b.Id == id);
                return AuthorDtoMapper.MapToDto(author);
            }
        }

        public class AuthorDto
        {
            public AuthorDto()
            {
            }

            public long Id { get; set; }

            public string Name { get; set; }

            public AuthorContactDto AuthorContact { get; set; }
        }

        public class AuthorContactDto
        {
            public long AuthorId { get; set; }
            public string Address { get; set; }
            public string ContactNumber { get; set; }
        }

        public static class AuthorDtoMapper
        {
            public static AuthorDto MapToDto(Author author)
            {
                return new AuthorDto()
                {
                    Id = author.Id,
                    Name = author.Name,

                    AuthorContact = new AuthorContactDto()
                    {
                        AuthorId = author.Id,
                        Address = author.AuthorContact.Address,
                        ContactNumber = author.AuthorContact.ContactNumber
                    }
                };
            }
        }

    }
}
