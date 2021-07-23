using Blueprint.Infrastructure.Identity.Models;
using Blueprint.Web.Areas.Admin.Models;
using AutoMapper;

namespace Blueprint.Web.Areas.Admin.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<ApplicationUser, UserViewModel>().ReverseMap();
        }
    }
}