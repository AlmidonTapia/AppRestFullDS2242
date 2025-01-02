using DataAccessLayer.Connection;
using DataAccessLayer.Entity;
using DataAccessLayer.Repository;
using DataAccessLayer.Repository.Repos;
using DataTransferLayer.Objects;
using System.Net;

namespace DataAccessLayer.Query
{
    public class QPerson : RepoPerson
    {
        public int delete(Guid id)
        {
            using DataBaseContext dbc = new();
            TPerson? person = dbc.Persons.FirstOrDefault(p => p.idPerson == id);
            dbc.Persons.Remove(person);
            return dbc.SaveChanges();
        }

        public List<PersonDto> getall()
        {
            using DataBaseContext dbc = new();
            return InitAutoMapper.mapper.Map<List<PersonDto>>(dbc.Persons.ToList());
        }

        public PersonDto getByDni(string dni)
        {
            using DataBaseContext dbc = new();
            return InitAutoMapper.mapper.Map<PersonDto>(dbc.Persons
                .FirstOrDefault(p => p.dni == dni));
        }

        public PersonDto getById(Guid id)
        {
            using DataBaseContext dbc = new();
            return InitAutoMapper.mapper.Map<PersonDto>(dbc.Persons
                .FirstOrDefault(p => p.idPerson == id));
        }

        public int insert(PersonDto dto)
        {
            using DataBaseContext dbc = new();
            TPerson? person = InitAutoMapper.mapper.Map<TPerson>(dto);
            dbc.Persons.Add(person);
            return dbc.SaveChanges();
        }

        public int update(PersonDto dto)
        {
            using DataBaseContext dbc = new();
            TPerson? person = InitAutoMapper.mapper.Map<TPerson>(dto);
            dbc.Persons.Update(person);
            return dbc.SaveChanges();
        }
    }
}
