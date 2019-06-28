using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Note : BaseEntity
    {
        public Note()
        {
            SetDefaults();
        }
        [Key]
        [ScaffoldColumn(false)]
        public int NoteID { get; set; }

        [ScaffoldColumn(false)]
        public Guid OwnerKey { get; set; }

        [Required]
        [Display(Name = "Note")]
        [MaxLength(500, ErrorMessage = "{0} can have a max of {1} characters")]
        [DataType(DataType.MultilineText)]
        public string NoteText { get; set; }

        public void SetDefaults()
        {
            SetBaseDefaults();
        }
    }
}
