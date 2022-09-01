using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Abstract
{
    public interface IAnnouncementService : IGenericService<Announcement>
    {
        public void AnnouncementStatusToFalse(int id);
        public void AnnouncementStatusToTrue(int id);

    }
}
