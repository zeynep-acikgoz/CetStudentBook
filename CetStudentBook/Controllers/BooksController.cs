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
    
    // Düzenleme sayfasını sç - ID'ye göre kitabı bul formu doldur
    public IActionResult Edit(int id)
    {
        var book = _context.Books.Find(id);
        if (book == null)
        {
            return NotFound();
        }
        return View(book);
    }

// Değişiklikleri kaydet-post
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(int id, Book book)
    {
        // Formdan gelen 'book' içindeki ID, URL'deki 'id' ile aynı mı?
        if (id != book.ID)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            // EF'e bu kaydın yeni olmadığını, güncelleneceğini söyler
            _context.Update(book); 
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(book);
    }
    
    
    
    
    // 1. ADIM: SİLME ONAY SAYFASINI AÇ (GET)
    public IActionResult Delete(int id)
    {
        var book = _context.Books.Find(id);
        if (book == null)
        {
            return NotFound();
        }
        return View(book); // Delete.cshtml sayfasını açar
    }

// 2. ADIM: GERÇEKTEN SİL (POST)
    [HttpPost, ActionName("Delete")] // Buradaki ActionName "Delete" olmalı!
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        var book = _context.Books.Find(id);
        if (book != null)
        {
            _context.Books.Remove(book);
            _context.SaveChanges();
        }
        return RedirectToAction(nameof(Index));
    }
    
}