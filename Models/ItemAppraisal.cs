using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Models.Interfaces;
using System.Text;

namespace Models
{
    public class ItemAppraisal : BaseEntity, Interfaces.iItem
    {
        public ItemAppraisal()
        {
            Item = new Item();
            //Appraisal = new Appraisal;
            SetDefaults();
        }

        [Key]
        [ScaffoldColumn(false)]
        public int ItemAppraisalID { get; set; }

        [Required]
        [ScaffoldColumn(false)]
        public int ItemID { get; set; }

        virtual public Item Item { get; set; }

        public decimal AppraisedValue { get; set; }

        public string Description
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
        public void SetDefaults()
        {
            SetBaseDefaults();
            

        }
        public void SetDescription()
        {
          
            StringBuilder sb = new StringBuilder();
            sb.Append("this");
            Item.Description = sb.ToString();
            throw new NotImplementedException();
        }

        public void SetCost()
        {
            throw new NotImplementedException();
        }
    }
}
