using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ConventionPractice.Core;
using GeneratorData.Model;

namespace GeneratorData.MapperProfiles
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<AddressModelJson, Address>();
            CreateMap<CourseJsonModel, Course>();
            CreateMap<AddressModelJson, Address>()
                                    .ForMember(s => s.Street, opts => opts.MapFrom(src => src.Address1))
                                    .ForMember(s => s.Country, opts => opts.NullSubstitute("Unknown"));

            CreateMap<CourseJsonModel, Course>()
                                     .ForMember(s => s.CourseName, opts => opts.MapFrom(s => s.Link_Name));
        }
    }
}