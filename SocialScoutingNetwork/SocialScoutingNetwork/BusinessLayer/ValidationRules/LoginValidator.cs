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
    public class LoginValidator : AbstractValidator<Writer>
    {
        private bool UniqueName(Writer writer, string name)

        {
            if (name == null || name == "")
            {
                return true;
            }

            Context _db = new Context();
            var dbCategory = _db.Writers
                                .Where(x => x.WriterUserName.ToLower() == name.ToLower())
                                .FirstOrDefault();

            if (dbCategory == null)
            {
                return false;
            }
            else

                return true;

        }
        private bool UniquePassword(Writer writer, string password)

        {
            if (password == null || password == "")
            {
                return true;
            }

            Context _db = new Context();
            var dbCategory = _db.Writers
                                .Where(x => x.WriterPassword.ToLower() == password.ToLower())
                                .FirstOrDefault();

            if (dbCategory == null)
            {
                return false;
            }
            else

                return true;

        }

        public LoginValidator()
        {

            RuleFor(x => x.WriterUserName).NotEmpty().WithMessage("Yazar kullanıcı adı boş geçilemez!").Must(UniqueName).WithMessage("Kullanıcı adı hatalı!"); 
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Yazar şifresi boş geçilemez!").Must(UniquePassword).WithMessage("Kullanıcı şifresi hatalı!");

        }
    }
}
