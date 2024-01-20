using mcfbackend.Context;
using mcfbackend.Models;

namespace mcfbackend.Repository
{
    public interface IBpkb { }
    public class BpkbRepo : IBpkb
    {
        private McfDbContext db;
        public BpkbRepo(McfDbContext db)
        {
            this.db = db;
        }

        public void Insertbpkbrepo(Tr_bpkb value)
        {
            db.Tr_bpkb.Add(value);
            db.SaveChanges();
        }
        public List<Ms_storage_location> Liststorage()
        {
            return db.Ms_storage_location.ToList();
        }
    }
}
