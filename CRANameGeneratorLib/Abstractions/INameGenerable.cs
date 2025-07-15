using CRANameGeneratorLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRANameGeneratorLib.Abstractions
{
    /// <summary>
    /// Abstraction for the name generation.
    /// </summary>
    public interface INameGenerable
    {
        /// <summary>
        /// Generate the CRA file name.
        /// </summary>
        /// <param name="business">Business containing the datas for the name generation.</param>
        /// <param name="triGram">TriGram of the user.</param>
        /// <returns>The CRA file name.</returns>
        public string GenerateName(Business business, string triGram);
    }
}
