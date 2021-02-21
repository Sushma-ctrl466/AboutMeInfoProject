using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AboutMe.Domain.Entities.AboutMeEntity;
using AboutMe.Domain.Abstract.Repositories.BusinessInterface;
using AboutMe.Domain.Abstract.Repositories.RepoInterface;

namespace AboutMe.Domain.BusinessEntity
{
    public class AboutMeBusinessEntity : AboutMeBusinessInterface
    {
        AboutMeEntity aboutMeobj;
        AboutMeRepoInterface aboutmeinterface;

        AboutMeBusinessEntity(AboutMeEntity entityobj, AboutMeRepoInterface aboutmeobj)
        {
            aboutMeobj = entityobj;
            aboutmeinterface = aboutmeobj;
        }
        public async Task AddInfotoAboutMe(AboutMeEntity aboutMe)
        {
            if (aboutMe != null)
            {
                await aboutmeinterface.AddInfotoAboutMe(aboutMe);
            }
        }

        public async Task<AboutMeEntity> GetAboutMeInfo()
        {
            return await aboutmeinterface.GetAboutMeInfo();
        }
    }
}
