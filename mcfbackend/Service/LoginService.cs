using mcfbackend.Context;
using mcfbackend.Models;
using mcfbackend.Repository;

namespace mcfbackend.Service
{
    public class LoginService
    {
        private LoginRepo _Loginrepo;
        public LoginService(LoginRepo loginrepo)
        {
            _Loginrepo = loginrepo;
        }
        public LoginService(McfDbContext dbContext)
        {
            _Loginrepo = new LoginRepo(dbContext);
        }

        public string CheckUserlogin(Ms_user user)
        {
            var result = _Loginrepo.LoginCheck(user);
            if (result != null)
            {
                if(user.password != result.password)
                {
                    return "password salah";
                }
                return "OK";
            }
            else
            {
                return "User tidak ditemukan";
            }
        }
    }
}
