using System.Collections.Generic;
using System.IO;
using CRANameGeneratorLib.Abstractions;
using CRANameGeneratorLib.Models;
using CSVReaderNetFive;
using Microsoft.Extensions.Configuration;

namespace CRANameGeneratorLib.DataAccessImplementations
{
    /// <summary>
    /// Generate the name of the file corresponding to the business
    /// </summary>
    public class DataAccessFromCSV: IDataAccess
    {
        private readonly string _pathToCSV;
        private readonly CSVFileReader<Business> _reader;
        private readonly IConfiguration _configuration;

        /// <summary>
        /// Constructor
        /// </summary>
        public DataAccessFromCSV(IConfiguration config)
        {
            _configuration = config;

            _pathToCSV = _configuration.GetValue<string>("PathToCsv");

            if(!File.Exists(_pathToCSV))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(_pathToCSV));
            }

            _reader = new CSVFileReader<Business>(_pathToCSV);
        }        

        /// <summary>
        /// Add a business in the CSV file.
        /// </summary>
        /// <param name="business">Business to add.</param>
        public void Add(Business business)
        {            
            _reader.AddData(business);
        }

        /// <summary>
        /// Get all the data saved in the CSV file.
        /// </summary>
        /// <returns>A Business list.</returns>
        public List<Business> GetAll()
        {
            return _reader.GetData();
        }

        /// <summary>
        /// Delete an entry in the CSV file.
        /// </summary>
        /// <param name="business">Business to delete.</param>
        /// <returns>true if the Business has been deleted.</returns>
        public bool Delete(Business business)
        {
            List<Business> lBusiness = GetAll();
            int nbDelete = 0;

            nbDelete = lBusiness.RemoveAll(h => h.BusinessCode == business.BusinessCode);
            _reader.WriteData(lBusiness);

            return nbDelete > 0;
        }
    }
}
