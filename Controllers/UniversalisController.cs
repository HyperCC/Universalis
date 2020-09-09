using Microsoft.AspNetCore.Mvc;
using Universalis.Data;
using System.Collections.Generic;
using AutoMapper;
using Universalis.Dtos;
using Universalis.Models;

namespace Universalis.Controller
{
    /// <summary>
    /// Nabullen controller return responses to client request
    /// </summary>
    [Route("api/academics")]
    [ApiController]
    public class UniversalisController : ControllerBase
    {
        /// <summary>
        /// Repo interface with all operations
        /// </summary>
        private readonly IUniversalisRepo _repository;

        /// <summary>
        /// Mapper instance
        /// </summary>
        private readonly IMapper _mapper;

        /// <summary>
        /// The constructor with dependency injection
        /// </summary>
        /// <param name="repository"></param>
        /// <param name="mapper"></param>
        public UniversalisController(IUniversalisRepo repository, IMapper mapper)
        {
            this._repository = repository;
            this._mapper = mapper;
        }

        /// <summary>
        /// Get all Academic endpoint
        /// </summary>
        /// <returns>the response code with re result</returns>
        [HttpGet]
        public ActionResult<IEnumerable<AcademicReadDto>> GetAllAcademics()
        {
            var academicItems = this._repository.GetAllAcademics();

            // 200 status code with data founded
            return Ok(this._mapper.Map<IEnumerable<AcademicReadDto>>(academicItems));
        }

        /// <summary>
        /// Get Academic by id endpoint
        /// </summary>
        /// <param name="id">Academic's id</param>
        /// <returns>the response code with re result</returns>
        [HttpGet("{id}", Name = "GetAcademicById")]
        public ActionResult<AcademicReadDto> GetAcademicById(int id)
        {
            var academicItems = this._repository.GetAcademicById(id);

            if (academicItems != null)
            {
                // 200 status code with data founded
                return Ok(this._mapper.Map<AcademicReadDto>(academicItems));
            }

            // 404 status code
            return NotFound();
        }

        /// <summary>
        /// Create a new Academic endpoint
        /// </summary>
        /// <param name="academicCreateDto"></param>
        /// <returns></returns>
        public ActionResult<AcademicReadDto> CreateAcademic(AcademicCreateDto academicCreateDto)
        {
            var academicModel = _mapper.Map<Academic>(academicCreateDto);
            _repository.CreateAcademic(academicModel);
            _repository.SaveChanges();

            var AcademicReadDto = _mapper.Map<AcademicReadDto>(academicModel);

            // 201 created status code new Academic added to DB
            return CreatedAtRoute(nameof(GetAcademicById), new { Id = AcademicReadDto.Id }, AcademicReadDto);
        }
    }
}