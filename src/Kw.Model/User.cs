using System.ComponentModel.DataAnnotations;

namespace Kw.Model
{
    public class User
    {
        public int Id { get; set; }
        
        [MaxLength(80)]
        public string FirstName { get; set; }

    }
}
