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
        }
    }
}