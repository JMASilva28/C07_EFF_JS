using System.ComponentModel.DataAnnotations;

namespace D04_EF6_Migrations_DAL
{

    public class Book
    {

        #region Scalar properties
        // PK
        public int BookID { get; set; }

        // FK
        public int PublisherID { get; set; }

        [Required]       
        [MaxLength(100, ErrorMessage = "100 character limit.")]
        public string Title { get; set; }

        [Required]       
        [MaxLength(9, ErrorMessage = "9 character limit.")]
        public string ISBN { get; set; }

        [Required]
        [MaxLength(9, ErrorMessage = "100 character limit.")]
        public string DDC { get; set; } 
        /*
        [Required]
        [StringLength(100, ErrorMessage = "100 character limit.")]
        [MaxLength(100)]
        public string DDC { get; set; }     // Dewey Decimal Classification
        */
        #endregion

        #region Navigation properties
        public Publisher Publisher { get; set; }
        #endregion

    }

}
