using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccessLevel.Model
{
    public class ShopTemplate
    {
       private int Id { get; set; }
        
       private string Name { get; set; }

       






        /// <summary>
        /// Admin Panel
        /// </summary>
        public int Equality { 

            set { Id = value; }

            get { return Id; }
        }
     
    }
}
