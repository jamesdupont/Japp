using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Models
{
    public class Image : BaseEntity
    {
        public Image()
        {
            SetDefaults();
        }

        [Key] [ScaffoldColumn(false)]
        public int ImageID { get; set; }


        public string ImageType { get; set; }


        [MaxLength(257, ErrorMessage = "{0} can have a max of {1} characters")]
        [Required]
        public string FileName { get; set; }

        [DataType(DataType.MultilineText)]
        [MaxLength(100, ErrorMessage = "{0} can have a max of {1} characters")]
        public string Description { get; set; }
        public string ImageName { get; set; }

        public string Caption { get; set; }

        public int PersonID { get; set; }
        public Person Person { get; set; }
        public void SetDefaults()
        {
            SetBaseDefaults();
        }

        public class ImageConfiguration : EntityTypeConfiguration<Image>
        {

            public ImageConfiguration()
            {
               
                HasKey(I => I.ImageID);
                HasOptional(p => p.Person);
                


                //HasMany(ea => ea.EmailAddresses).WithOptional(p => p.Person);
                //HasMany(pn => pn.PhoneNumbers).WithOptional(p => p.Person);
                //HasMany(i => i.Images).WithOptional(p => p.Person);
            }
        }

    }
}
