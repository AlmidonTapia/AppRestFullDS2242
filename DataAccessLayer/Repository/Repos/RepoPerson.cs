using DataTransferLayer.Objects;

namespace DataAccessLayer.Repository.Repos
{
    public interface RepoPerson : RepoGeneric<PersonDto>
    {
        public PersonDto getByDni(string dni);
    }
}
