using CRANameGeneratorLib.Abstractions;
using CRANameGeneratorLib.Models;
using System;

namespace CRANameGeneratorLib.NameGenerableImplementations
{
    /// <summary>
    /// This service manage the name generation of the CRA.
    /// </summary>
    public class StandardNameGenerator : INameGenerable
    {
        /// <summary>
        /// Generate the CRA file name.
        /// </summary>
        /// <param name="business">Business containing the datas for the name generation.</param>
        /// <param name="triGram">TriGram of the user.</param>
        /// <returns>The CRA file name.</returns>
        public string GenerateName(Business business, string triGram)
        {
            string date = $"{DateTime.Now.ToString("MM")} {DateTime.Now.ToString("yyyy")}";
            return $"{business.Type}-{triGram}-{business.ClientName} {business.ProjectName} {business.BusinessCode}-{date}";
        }

    }
}
