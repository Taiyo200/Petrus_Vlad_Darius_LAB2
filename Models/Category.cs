namespace Petrus_Vlad_Darius_LAB2.Models
{
    public class Category
    {
        
       public int ID { get; set; }

        public string CategoryName { get; set; }

        public ICollection<BookCategory>? BookCategories { get; set; }
    
}
}
