using mcfbackend.Context;
using mcfbackend.Models;

namespace mcfbackend.Repository
{

    public interface ILogin { }
    public class LoginRepo : ILogin
    {
        private McfDbContext db;
        public LoginRepo(McfDbContext db)
        {
            this.db = db;
        }

        public Ms_user LoginCheck(Ms_user request)
        {
            var user = db.Ms_user.Where(x => x.user_name.Equals(request.user_name.ToLower()) && x.is_active == true).FirstOrDefault();
            return user;
        }
    }
    
}
