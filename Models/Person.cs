using System.ComponentModel;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace nguyennhuthin189.Models
{
    public class Person
    {
        [Key]
      [StringLength(20)]
      [DisplayName("ID người dùng")]
     
        public int PersonId { get; set; }
        [StringLength(50)]
        [DisplayName("Tên người dùng")]
       
        public string PersonName { get; set; }

        }
}