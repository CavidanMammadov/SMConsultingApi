using AutoMapper;
using SMConsulting.BL.DTOs.Blog;
using SMConsulting.Core.Entities;

namespace SMConsulting.API.Profiles
{
    public class BlogProfile :Profile
    {
        public BlogProfile()
        {
            CreateMap<BlogCreateDto, Blog>()
                .ForMember(x => x.BlogMainImage, opt => opt.Ignore())
                .ForMember(x => x.BlogSecondaryImage, opt => opt.Ignore())
                .ForMember(x => x.BlogCreatedAt, opt => opt.Ignore());

            CreateMap<BlogUpdateDto, Blog>()
                .ForMember(x => x.BlogMainImage, opt => opt.Ignore())
                .ForMember(x => x.BlogSecondaryImage, opt => opt.Ignore())
                .ForMember(x => x.BlogCreatedAt, opt => opt.Ignore());

            CreateMap<Blog, BlogGetAllDto>();
        }
    }
}
