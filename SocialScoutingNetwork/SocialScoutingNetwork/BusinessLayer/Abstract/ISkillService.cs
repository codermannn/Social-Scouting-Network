using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ISkillService
    {
        void AddSkill(Skill skill);
        void DeleteSkill(Skill skill);
        void UpdateSkill(Skill skill);
        List<Skill> GetList();
        Skill GetByID(int id);
        List<Skill> GetListWithAllAttribution();
    }
}
