using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccessLevel.Model
{
    public class ShopTemplate
    {
       public int Id { get; set; }
        
       public string Name { get; set; }

       public List <ShopTemplate> products { get; set; }
       
     
    }
}
