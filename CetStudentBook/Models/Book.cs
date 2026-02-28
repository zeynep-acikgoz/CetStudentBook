using System.ComponentModel.DataAnnotations;

namespace CetStudentBook.Models;

public class Book
{
    
    public int ID { get; set; }
    [Required]
    [StringLength(200, MinimumLength = 2)]
    public string Name { get; set; }
    [Required]
    [StringLength(200, MinimumLength = 2)] 
    public string Author { get; set; }
    [Required]
    [DataType(DataType.Date)]
    public DateTime PublishDate { get; set; }
    [Required]
    [Range(1,10000)]  
    public int PageCount { get; set; }
    [Required]
    public bool IsSecondHand { get; set; }
    
}