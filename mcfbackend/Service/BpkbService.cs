using mcfbackend.Context;
using mcfbackend.Models;
using mcfbackend.Repository;

namespace mcfbackend.Service
{
    public class BpkbService
    {
        private BpkbRepo _bpkpRepo;
        public BpkbService(BpkbRepo bpkpRepo)
        {
            _bpkpRepo = bpkpRepo;
        }
        public BpkbService(McfDbContext dbContext)
        {
            _bpkpRepo = new BpkbRepo(dbContext);
        }
        public string Addinsertbpkb(Tr_bpkb bpkb)
        {
            bpkb.created_on = DateTime.Now;
            _bpkpRepo.Insertbpkbrepo(bpkb);
            return "OK";
        }
        public List<Ms_storage_location> GetStorageLocations()
        {
            return _bpkpRepo.Liststorage();
        }
    }
}
