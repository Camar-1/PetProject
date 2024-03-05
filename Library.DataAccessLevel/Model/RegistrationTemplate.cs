using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccessLevel.Model
{
    public class RegistrationTemplate
    {
      public int Id { get; set; }
      public string Login { get; set; }
      public DateTime CreateTime { get; set; }
      public RegistrationCategory registrationCategoryCategory { get; set; }
      public string Password { get; set; }
      
    }
}


