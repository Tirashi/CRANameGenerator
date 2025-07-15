using CRANameGeneratorLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRANameGeneratorLib.Abstractions
{
    /// <summary>
    /// A data accessor for the name generation abstraction.
    /// </summary>
    public interface IDataAccess
    {
        /// <summary>
        /// Add a business to the datas.
        /// </summary>
        /// <param name="business">Business to add.</param>
        public void Add(Business business);

        /// <summary>
        /// Return all the stored Business.
        /// </summary>
        /// <returns>The stored business list.</returns>
        public List<Business> GetAll();

        /// <summary>
        /// Delete a Business.
        /// </summary>
        /// <param name="business">Business to delete.</param>
        /// <returns>true if the data has been deleted.</returns>
        public bool Delete(Business business);


        //public void Update(Business oldBusiness, Business updBusiness);
    }
}
