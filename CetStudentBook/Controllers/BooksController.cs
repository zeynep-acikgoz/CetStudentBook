using CetStudentBook.Data;
using Microsoft.AspNetCore.Mvc;

namespace CetStudentBook.Controllers;

public class BooksController : Controller
{
    private readonly ApplicationDbContext _context;
    public BooksController(ApplicationDbContext context)
    {
        _context = context;
    }
    // GET
    public IActionResult Index()
    {
        var books = _context.Books.ToList(); //tabloyu listeye çevir (books tablosunu), tepsiye koy
        return View(books); //tepsiyi gönder
    }
}