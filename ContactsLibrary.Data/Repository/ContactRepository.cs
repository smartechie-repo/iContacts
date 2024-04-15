using ContactsLibrary.Data.Repository.IRepository;
using ContactsLibrary.Models;

namespace ContactsLibrary.Data.Repository;

public class ContactRepository : Repository<Contact>, IContactRepository
{
    private ApplicationDbContext _db;
    public ContactRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }

    public void Update(Contact obj)
    {
        _db.Contacts.Update(obj);
    }
}