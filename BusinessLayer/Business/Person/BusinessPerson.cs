using BusinessLayer.Generic;
using DataTransferLayer.Objects;
using DataTransferLayer.OtherObject;
using System.Transactions;

namespace BusinessLayer.Business.Person
{
    public partial class BusinessPerson : BusinessGeneric
    {
        public (MessageDto, PersonDto) getById(Guid id) 
        {
            PersonDto? personDto = repoPerson.getById(id);
            if (personDto != null)
            {
                _message.Success();
                return (_message, personDto);
            }
            _message.Warning();
            _message.AddMessage("No se encontro la persona");
            return (_message, personDto);
        }
        public (MessageDto, PersonDto) getByDni(string dni)
        {
            PersonDto? personDto = repoPerson.getByDni(dni);
            if (personDto != null)
            {
                _message.Success();
                return (_message, personDto);
            }
            _message.Warning();
            return (_message, personDto);
        }

        public (MessageDto, List<PersonDto>) getAll()
        {
            List<PersonDto>? personDto = repoPerson.getAll();
            if (personDto != null)
            {
                _message.Success();
                return (_message, personDto);
            }
            _message.Warning();
            return (_message, personDto);
        }

        public MessageDto insert(PersonDto personDto)
        {
            using TransactionScope transactionScope = new();
            insertValidation(personDto);
            if(_message.ExistsMessage()){
                _message.Conflict();
                return _message;
            }

            personDto.idPerson = Guid.NewGuid();
            personDto.createdAt = DateTime.Now;
            personDto.updatedAt = DateTime.Now;
            repoPerson.insert(personDto);
            transactionScope.Complete();

            _message.Success();
            _message.AddMessage("Persona registrada");
            return _message;
        }

        public MessageDto update(PersonDto dto)
        {
            using TransactionScope transactionScope = new();
            PersonDto? personDto = repoPerson.getById(dto.idPerson);
            if(personDto != null)
            {
                personDto.idPerson = Guid.NewGuid();
                personDto.firstName = dto.firstName;
                personDto.dni = dto.dni;
                personDto.surName = dto.surName;
                personDto.gender = dto.gender;
                personDto.updatedAt = DateTime.Now;

                repoPerson.update(personDto);
                transactionScope.Complete();

                _message.Success();
                _message.AddMessage("Persona actualizada");
                return _message;
            }
            _message.Error();
            _message.AddMessage("No se encontró la persona");
            return _message;
        }

        public MessageDto delete(Guid id) 
        { 
            PersonDto? personDto = repoPerson.getById(id);
            if (personDto != null) { 
                repoPerson.delete(id);
                _message.Success();
                _message.AddMessage("Se borro correctamente.");
                return _message;
            }
            _message.Error();
            _message.AddMessage("No se encontre la persona");
            return _message;
        }


    }
}
