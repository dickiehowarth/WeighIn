using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository.Models
{
    public class User
    {
        public User()
        {
            WeightValues = new List<WeightValue>();
        }

        [Key]
        public long Id { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public int Age { get; set; }

        public virtual UserPreference UserPreferences { get; set; }
        public virtual ICollection<WeightValue> WeightValues { get; set; }
    }
}
