using AutoMapper;
using Acme.BookStore.Books;

namespace Acme.BookStore.Blazor;

public class BookStoreBlazorAutoMapperProfile : Profile
{
    public BookStoreBlazorAutoMapperProfile()
    {
        CreateMap<BookDto, CreateUpdateBookDto>();
        
        //Define your AutoMapper configuration here for the Blazor project.
    }
}
