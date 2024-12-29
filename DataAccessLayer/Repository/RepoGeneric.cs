namespace DataAccessLayer.Repository
{
    public interface RepoGeneric<Dto>
    {
        public int insert(Dto dto);
        public int update(Dto dto);
        public int delete(Guid id);
        public Dto getById(Guid id);
        public List<Dto> getAll();
    }
}
