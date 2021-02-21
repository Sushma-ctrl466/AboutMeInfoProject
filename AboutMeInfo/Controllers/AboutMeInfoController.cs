using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AboutMe.Domain.Entities.AboutMeEntity;
using AboutMe.Domain.Abstract.Repositories.BusinessInterface;

namespace AboutMeInfo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AboutMeInfoController : ApiControllerAttribute
    {
        AboutMeBusinessInterface aboutMe;
        public AboutMeInfoController(AboutMeBusinessInterface aboutMeobj)
        {
            aboutMe = aboutMeobj;
        }

        [HttpGet]
        public AboutMeEntity GetAboutMeInfo()
        {
            return aboutMe.GetAboutMeInfo().Result;
        }

        [HttpPost]
        public async void AddAboutMeInfo()
        {
            AboutMeEntity obj = new AboutMeEntity()
            {
                FirstName = "John",
                LastName ="Wick",
                Occupation="Movies",
                Designation="Director",
                Location="Hollywood",
                Phone=98943467332354,
                Salary=32.4m
            };

            await aboutMe.AddInfotoAboutMe(obj);
        }
    }
}
