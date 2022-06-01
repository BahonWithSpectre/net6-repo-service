using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net6.Domain
{
    public class User
    {
        /// <summary>
        /// User ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// User Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// User Age
        /// </summary>
        public string Age { get; set; }
    }
}
