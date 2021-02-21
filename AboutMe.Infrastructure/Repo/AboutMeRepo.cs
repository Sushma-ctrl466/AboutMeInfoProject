using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AboutMe.Domain.Entities.AboutMeEntity;
using AboutMe.Domain.Abstract.Repositories.RepoInterface;

namespace AboutMe.Infrastructure.Repo
{
    public class AboutMeRepo : AboutMeRepoInterface
    {
        AboutMeEntity addEntity;
        AboutMeRepo(AboutMeEntity entityobj)
        {
            addEntity = entityobj;
        }
        public async Task AddInfotoAboutMe(AboutMeEntity aboutMe)
        {
            if (aboutMe != null)
            {
               addEntity = aboutMe;
            }
        }

        public async Task<AboutMeEntity> GetAboutMeInfo()
        {
            return addEntity;
        }
    }
}
