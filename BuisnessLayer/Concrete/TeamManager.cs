using BuisnessLayer.Abstract; 
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Concrete
{
   public class TeamManager:ITeamService
    {
        ITeamDal _teamDal;

        public TeamManager(ITeamDal teamDal)
        {
            _teamDal = teamDal;
        }

        public void Delete(Team p)
        {
            _teamDal.Delete(p);
        }

        public Team GetById(int id)
        {
            return _teamDal.GetById(id);
        }

        public List<Team> GetListAll()
        {
            return _teamDal.GetListAll();
        }

        public void Insert(Team p)
        {
            _teamDal.Insert(p);
        }

        public void Update(Team p)
        {
            _teamDal.Update(p);
        }
    }
}
