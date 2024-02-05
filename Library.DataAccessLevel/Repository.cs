using LiteDB;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
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

        public bool CreateUser(RegistrationTemplate registrationTemplate)
        {
            try
            {


                using (LiteDatabase db = new LiteDatabase(Path))
                {
                    var result = db.GetCollection<RegistrationTemplate>("RegistrationTemplate");

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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool DeleteUser(int Id)
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(Path))
                {
                    var result = db.GetCollection<RegistrationTemplate>("RegistrationTemplate");

                    result.Delete(Id);
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
        /// <summary>
        /// Return registratin panel
        /// </summary>
        /// <returns></returns>
        public List<RegistrationTemplate> registrationTemplates()
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(Path))
                {
                    var result = db.GetCollection<RegistrationTemplate>("RegistrationTemplate");

                    return result.FindAll().ToList();
                }

            }
            catch (Exception ex)
            {
                using (StreamWriter sw = File.AppendText("Log.txt"))
                {
                    sw.WriteLine(ex.Message);
                }
            }
            return null;
        }
    }
}
            
      

        
