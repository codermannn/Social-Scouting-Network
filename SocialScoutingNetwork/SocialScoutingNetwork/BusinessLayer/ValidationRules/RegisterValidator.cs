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
    public class RegisterValidator : AbstractValidator<Writer>

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
                                .SingleOrDefault();

            if (dbCategory == null)
            {
                return true;
            }
            else

            return dbCategory.WriterID == writer.WriterID;

        }

      
        public RegisterValidator()
        {


            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı boş geçilemez!");
            RuleFor(x => x.WriterName).MaximumLength(25).WithMessage("Yazar adı maksimum 25 karakter olmalı!");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Yazar adı minimum 2 karakter olmalı!");


            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar soyadı boş geçilemez!");
            RuleFor(x => x.WriterSurname).MaximumLength(25).WithMessage("Yazar soyadı maksimum 25 karakter olmalı!");
            RuleFor(x => x.WriterSurname).MinimumLength(2).WithMessage("Yazar soyadı minimum 2 karakter olmalı!");


            RuleFor(x => x.WriterUserName).NotNull().WithMessage("Yazar kullanıcı adı boş geçilemez!").Must(UniqueName).WithMessage("Bu kullanıcı adı kullanılmakta!");
            RuleFor(x => x.WriterUserName).MaximumLength(25).WithMessage("Yazar kullanıcı adı maksimum 25 karakter olmalı!");
            RuleFor(x => x.WriterUserName).MinimumLength(6).WithMessage("Yazar kullanıcı adı minimum 6 karakter olmalı!");

            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar soyadı boş geçilemez!");
            RuleFor(x => x.WriterSurname).MaximumLength(25).WithMessage("Yazar soyadı maksimum 25 karakter olmalı!");
            RuleFor(x => x.WriterSurname).MinimumLength(2).WithMessage("Yazar soyadı minimum 2 karakter olmalı!");

            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Yazar maili boş geçilemez!");
            RuleFor(x => x.WriterMail).MaximumLength(100).WithMessage("Yazar maili maksimum 25 karakter olmalı!");
            RuleFor(x => x.WriterMail).MinimumLength(15).WithMessage("Yazar maili minimum 10 karakter olmalı!");
            RuleFor(x => x.WriterMail).EmailAddress().WithMessage("Email formatı hatalı!");

            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Yazar şifresi boş geçilemez!");
            RuleFor(x => x.WriterPassword).MaximumLength(25).WithMessage("Yazar şifresi maksimum 25 karakter olmalı!");
            RuleFor(x => x.WriterPassword).MinimumLength(8).WithMessage("Yazar şifresi minimum 8 karakter olmalı!");




        }
    }
}
