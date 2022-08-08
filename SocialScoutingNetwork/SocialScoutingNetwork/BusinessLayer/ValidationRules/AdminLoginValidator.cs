using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AdminLoginValidator: AbstractValidator<Admin>
    {
        private bool UniqueName(Admin writer, string name)

        {
            if (name == null || name == "")
            {
                return true;
            }

            Context _db = new Context();
            var dbCategory = _db.Admins
                                .Where(x => x.AdminUserName.ToLower() == name.ToLower())
                                .FirstOrDefault();

            if (dbCategory == null)
            {
                return false;
            }
            else

                return true;

        }
        private bool UniquePassword(Admin writer, string password)

        {
            if (password == null || password == "")
            {
                return true;
            }

            Context _db = new Context();
            var dbCategory = _db.Admins
                                .Where(x => x.AdminPassword.ToLower() == password.ToLower())
                                .FirstOrDefault();

            if (dbCategory == null)
            {
                return false;
            }
            else

                return true;

        }
        public AdminLoginValidator()
        {

            RuleFor(x => x.AdminUserName).NotEmpty().WithMessage("Admin kullanıcı adı boş geçilemez!").Must(UniqueName).WithMessage("Kullanıcı kullanıcı adı hatalı!");
            RuleFor(x => x.AdminPassword).NotEmpty().WithMessage("Admin şifresi boş geçilemez!").Must(UniquePassword).WithMessage("Admin şifresi hatalı!");

        }
    }
}
