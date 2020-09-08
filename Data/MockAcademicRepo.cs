using System.Collections.Generic;
using Universalis.Models;

namespace Universalis.Data
{
    /// <summary>
    /// Implementation to simulate IUniversalisRepo interface
    /// </summary>
    public class MockAcademicRepo : IUniversalisRepo
    {
        /// <summary>
        /// Mock with all the Academics
        /// </summary>
        /// <returns>Enumerable to all Academics</returns>
        public IEnumerable<Academic> GetAllAcademics()
        {
            var academics = new List<Academic>
            {
                new Academic{
                    Id=0,
                    Nombre="Marclo Norambuena",
                    Cargo="Profesor",
                    Telefono="+56984621195"
                },
                new Academic{
                    Id=1,
                    Nombre="Emiliano Monfest",
                    Cargo="Decano",
                    Telefono="+56997642514"
                }
            };

            return academics;
        }

        /// <summary>
        /// Search Academic by id
        /// </summary>
        /// <param name="id">the id from client</param>
        /// <returns>Academic searched</returns>
        public Academic GetAcademicById(int id)
        {
            //TODO: fix method with real search wuth the DB.
            return new Academic
            {
                Id = 0,
                Nombre = "Marclo Norambuena",
                Cargo = "Profesor",
                Telefono = "+56984621195"
            };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void CreateAcademic(Academic academic)
        {
            throw new System.NotImplementedException();
        }
    }
}