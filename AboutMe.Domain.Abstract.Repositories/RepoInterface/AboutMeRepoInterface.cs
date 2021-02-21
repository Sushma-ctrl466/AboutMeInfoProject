using AboutMe.Domain.Entities.AboutMeEntity;
using System.Threading.Tasks;

namespace AboutMe.Domain.Abstract.Repositories.RepoInterface
{
    public interface AboutMeRepoInterface
    {
        Task AddInfotoAboutMe(AboutMeEntity aboutMe);
        Task<AboutMeEntity> GetAboutMeInfo();
    }
}
