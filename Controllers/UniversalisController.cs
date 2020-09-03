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
        /// MockNabullenRepo instance void 
        /// </summary>
        /// <returns>the new mock</returns>
        private readonly MockAcademicRepo _repository = new MockAcademicRepo();

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
            var nabullItem = this._repository.GetAcademicById(id);

            return Ok(nabullItem);
        }
    }
}