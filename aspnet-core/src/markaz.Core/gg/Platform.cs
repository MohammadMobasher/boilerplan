using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markaz.gg
{
    /// <summary>
    /// Represents any software or service that has a command line interface.
    /// </summary>
    public class Platform : Entity<int>
    {
        

        /// <summary>
        /// Represents the name for the platform.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Represents a purchased, valid license for the platform.
        /// </summary>
        public string LicenseKey { get; set; }

        /// <summary>
        /// This is the list of available commands for this platform.
        /// </summary>
        public ICollection<Command> Commands { get; set; } = new List<Command>();

    }
}
