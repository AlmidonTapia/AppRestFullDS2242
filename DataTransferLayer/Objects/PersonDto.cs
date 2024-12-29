using System.ComponentModel.DataAnnotations;

namespace DataTransferLayer.Objects
{
    public class PersonDto
    {
        public Guid idPerson { get; set; }
        public string firstName { get; set; }
        public string surName { get; set; }

        [Required(ErrorMessage = "El campo \"dni\"es requerido.")]
        [RegularExpression("^[0-9]{8}$", ErrorMessage = "El formato del campo \"dni\" no es correcto.")]
        public string dni { get; set; }
        public bool gender { get; set; }
        public DateTime birthDate { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
