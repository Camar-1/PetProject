using LiteDB;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccessLevel.Model
{
    public class Repository
    {
        private readonly string Path;

        public Repository(string Path)
        {
            this.Path = Path;
        }

        bool CreateUser(RegistrationTemplate registrationTemplate)
        {
            try
            {


                using (LiteDatabase db = new LiteDatabase(Path))
                {
                    var result = db.GetCollection<RegistrationTemplate>("Path");

                    result.Insert(registrationTemplate);

                }
                return true;
            }
            catch (Exception ex)
            {
                using (StreamWriter sw = File.AppendText("Log.txt"))
                {

                    sw.WriteLine(ex.Message);

                }
                return false;
            }
        }
    }
}
            
      

        
