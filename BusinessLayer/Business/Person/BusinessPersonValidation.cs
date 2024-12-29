using DataTransferLayer.Objects;

namespace BusinessLayer.Business.Person
{
    public partial class BusinessPerson
    {
        private void insertValidation(PersonDto personDto)
        {
            if(repoPerson.getByDni(personDto.dni) is not null)
            {
                _message.AddMessage("El dni ya existe");
            }
        }
        private void updateValidation(PersonDto personDto) 
        {
            
        }

    }
}
