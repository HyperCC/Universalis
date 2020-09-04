using Microsoft.AspNetCore.Mvc;
using Universalis.Data;
using Universalis.Models;
using System.Collections.Generic;

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
        /// The constructor with dependency injection
        /// </summary>
        /// <param name="repository"></param>//  
        public UniversalisController(IUniversalisRepo repository)
        {
            this._repository = repository;
        }

        /// <summary>
        /// Get all Academic endpoint
        /// </summary>
        /// <returns>the response code with re result</returns>
        [HttpGet]
        public ActionResult<IEnumerable<Academic>> GetAllAcademics()
        {
            var academicItems = this._repository.GetAppAcademics();

            return Ok(academicItems);
        }

        /// <summary>
        /// Get Academic by id endpoint
        /// </summary>
        /// <param name="id">Academic's id</param>
        /// <returns>the response code with re result</returns>
        [HttpGet("{id}")]
        public ActionResult<Academic> GetAcademicById(int id)
        {
            var academicItems = this._repository.GetAcademicById(id);

            return Ok(academicItems);
        }
    }
}