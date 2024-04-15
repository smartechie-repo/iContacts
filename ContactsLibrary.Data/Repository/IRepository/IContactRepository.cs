using ContactsLibrary.Models;

namespace ContactsLibrary.Data.Repository.IRepository;

public interface IContactRepository :IRepository<Contact>
{
    void Update(Contact obj);
}