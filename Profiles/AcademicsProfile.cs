using AutoMapper;
using Universalis.Dtos;
using Universalis.Models;

namespace Universalis.Profiles
{
    /// <summary>
    /// Class with mapping profile
    /// </summary>
    public class AcademicsProfile : Profile
    {
        /// <summary>
        /// Constructor initialize the mapping of Academics
        /// </summary>
        public AcademicsProfile()
        {
            // the mapping of Academic
            CreateMap<Academic, AcademicReadDto>();

            // inverse mapping, create Dto and converse to Academic
            CreateMap<AcademicCreateDto, Academic>();

            // mapping to update academic from endpoint DTO to Academic
            CreateMap<AcademicUpdateDto, Academic>();

            // to update, asignation of Academic to object validated to save in DB
            CreateMap<Academic, AcademicUpdateDto>();
        }
    }
}