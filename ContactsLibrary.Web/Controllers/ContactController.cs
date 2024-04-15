using ContactsLibrary.Data;
using ContactsLibrary.Data.Repository.IRepository;
using ContactsLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContactsLibrary.Web.Controllers;

public class ContactController : Controller
{
    private readonly IUnitOfWork _unitOfWork;

    public ContactController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    // GET
    public IActionResult Index()
    {
        List<Contact> contactList = new List<Contact>();
        
        try{
            contactList =  _unitOfWork.Contact.GetAll().ToList();
        } catch(Exception ex)
        {
            Console.Write("Error info:" + ex.Message);
        }
        finally
        {
            Console.Write("Setting empty value.");
        }
        
        return View(contactList);
    }
    public IActionResult Create()
    {
        return View();
    }

    // POST
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Contact contact)
    {
        if (ModelState.IsValid)
        {
            _unitOfWork.Contact.Add(contact);
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }

        return View(contact);
    }
    
    public IActionResult Delete(int? id)
    {
        if (id == null || id == 0)
            return NotFound();

        Contact? contactFromDb = _unitOfWork.Contact.Get(u => u.Id == id);
        if (contactFromDb == null)
            return NotFound();

        return View(contactFromDb);
    }
    
    // POST
    
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeletePOST(int ?id)
    {
        Contact? contactFromDb = _unitOfWork.Contact.Get(u => u.Id == id);

        if (contactFromDb == null)
            return NotFound();
        

        _unitOfWork.Contact.Remove(contactFromDb);
        _unitOfWork.Save();
        return RedirectToAction("Index");
    }
    public IActionResult Edit(int? id)
    {
        if (id == null || id == 0)
            return NotFound();
        
        var contactFromDb = _unitOfWork.Contact.Get(u => u.Id == id);
        
        if (contactFromDb == null)
            return NotFound();

        return View(contactFromDb);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(Contact contact)
    {
        if (ModelState.IsValid)
        {
            _unitOfWork.Contact.Update(contact);
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }

        return View(contact);
    }
}