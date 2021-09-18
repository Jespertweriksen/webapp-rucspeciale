using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapp_rucspeciale.Models
{
    public class UserModel
    {
   

        ///<summary>
        /// Gets or sets Id.
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// Gets or sets Email.
        ///</summary>
        public string Email { get; set; }

        ///<summary>
        /// Gets or sets Name.
        ///</summary>
        public string Name { get; set; }

        public long Phone { get; set; }

        public string StatusMessage { get; set; }

        public bool Empty
        {
            get
            {
                return (Id == 0 &&
                        string.IsNullOrWhiteSpace(Email) &&
                        string.IsNullOrWhiteSpace(Name));
            }
        }
    }
}
