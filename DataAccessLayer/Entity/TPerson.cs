using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Entity
{
    public class TPerson
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid idPerson { get; set; }
        public string firstName { get; set; }
        public string surName {  get; set; }
        public string dni {  get; set; } 
        public bool gender {  get; set; } 
        public DateTime birthDate {  get; set; } 
        public DateTime createdAt {  get; set; }
        public DateTime updatedAt { get; set; }
    }
}
