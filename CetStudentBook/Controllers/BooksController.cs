using CetStudentBook.Data;
using CetStudentBook.Models;
using Microsoft.AspNetCore.Mvc;

namespace CetStudentBook.Controllers;

public class BooksController : Controller
{
    private readonly ApplicationDbContext _context;
    public BooksController(ApplicationDbContext context)
    {
        _context = context;
    }
    
    
    
    // get
    public IActionResult Create()
    {
        return View();
    }

// post
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Book book)
    {
        if (ModelState.IsValid)
        {
            _context.Add(book);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(book);
    }
    
    
    public IActionResult Index()
    {
        var books = _context.Books.ToList(); //tabloyu listeye çevir (books tablosunu), tepsiye koy
        return View(books); //tepsiyi gönder
    }
}