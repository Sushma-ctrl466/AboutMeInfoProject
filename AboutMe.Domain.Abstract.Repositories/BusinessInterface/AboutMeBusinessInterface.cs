using AboutMe.Domain.Entities.AboutMeEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AboutMe.Domain.Abstract.Repositories.BusinessInterface
{
    public interface AboutMeBusinessInterface
    {
        Task AddInfotoAboutMe(AboutMeEntity aboutMe);
        Task<AboutMeEntity> GetAboutMeInfo();
    }
}
