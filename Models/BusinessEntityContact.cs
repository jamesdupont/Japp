
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("Person.BusinessEntityContact")]
    public class BusinessEntityContact
    {
        public int BusinessEntityID { get; set; }
        public int PersonID { get; set; }
        public int ContactTypeID { get; set; }
        public virtual BusinessEntity BusinessEntity { get; set; }
        public virtual ContactType ContactType { get; set; }
        public virtual Person Person { get; set; }
    }
}
