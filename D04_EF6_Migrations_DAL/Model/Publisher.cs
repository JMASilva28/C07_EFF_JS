using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace D04_EF6_Migrations_DAL
{

    public class Publisher
    {

        #region Scalar properties
        public int PublisherID { get; set; }
        
        [Required]        
        [MaxLength(100, ErrorMessage = "100 character limit.")]
        public string Name { get; set; }
        #endregion

        #region Navigation properties
        // 1 publisher - n books
        public ICollection<Book> Book { get; set; }
        #endregion

    }

}
