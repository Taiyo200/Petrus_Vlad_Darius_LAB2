using System.ComponentModel.DataAnnotations;

namespace Petrus_Vlad_Darius_LAB2.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public virtual ICollection<Book> Books { get; set; }
    }
}
