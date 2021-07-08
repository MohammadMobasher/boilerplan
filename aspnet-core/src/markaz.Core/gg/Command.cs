using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markaz.gg
{
    public class Command: Entity<int>
    {
        /// <summary>
        /// Represents the unique ID for the command.
        /// </summary>
        

        /// <summary>
        /// Represents the how-to for the command.
        /// </summary>
        [Required]
        public string HowTo { get; set; }

        /// <summary>
        /// Represents the command line.
        /// </summary>
        [Required]
        public string CommandLine { get; set; }

        /// <summary>
        /// Represents the unique ID of the platform which the command belongs.
        /// </summary>
        [Required]
        public int PlatformId { get; set; }

        /// <summary>
        /// This is the platform to which the command belongs.
        /// </summary>
        public Platform Platform { get; set; }
    }
}
