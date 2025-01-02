using DataTransferLayer.Objects;

namespace BusinessLayer.Business.Person
{
    public partial class BusinessPerson
    {
        private void insertValidation(PersonDto personDto)
        {
               if (string.IsNullOrWhiteSpace(personDto.dni))
            {
                _message.AddMessage("El DNI no puede ser nulo o vacío");
            }

            if (string.IsNullOrWhiteSpace(personDto.firstName))
            {
                _message.AddMessage("El nombre no puede ser nulo o vacío");
            }

            if (string.IsNullOrWhiteSpace(personDto.surName))
            {
                _message.AddMessage("El apellido no puede ser nulo o vacío");
            }
            
        }
        private void updateValidation(PersonDto personDto) 
        {
            
        }

    }
}
