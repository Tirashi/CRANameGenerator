using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRANameGeneratorLib.Models
{
    /// <summary>
    /// Model of business
    /// </summary>
    public class Business
    {   
        /// <summary>
        /// Gets or sets the type of business
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the name of the client
        /// </summary>
        public string ClientName { get; set; }

        /// <summary>
        /// Gets or sets the name of the project
        /// </summary>
        public string ProjectName { get; set; }

        /// <summary>
        /// Gets or sets the code of the business
        /// </summary>
        public string BusinessCode { get; set; }
    }
}
