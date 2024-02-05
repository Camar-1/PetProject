using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Library.BussnessLogicLevel;
using Library.DataAccessLevel.Model;

namespace Library.BussnessLogicLevel.BLL
{
    public class ReturnAdmin
    {
        private string Path;

        public ReturnAdmin(string path)
        {
            Path = path;
        }

        public string CreateAdmin(RegistrationTemplate registrationTemplate)
        {
            try
            {
                Repository repository = new Repository(Path);
                var result = repository.CreateUser(registrationTemplate);

                if (registrationTemplate != null)
                {
                    return "Аккаунт администратора создан!";
                }
                else
                    return "Аккаунт  администратора не создан...";
            }

            catch (Exception ex)
            {
                using (StreamWriter sw = File.AppendText("Log.txt"))
                {
                    sw.WriteLine(ex.Message);
                }

                return "";

            }

        }
        public string DeleteAdmin(int Id)
        {
            try {
                Repository repository = new Repository(Path);
                var result = repository.DeleteUser(Id);

                if (repository != null)
                {
                    return "Аккаунт удален!";
                }
                else
                {
                    return "Аккаун не получилось удалить";
                }

            }
            catch(Exception ex)
            {
                using (StreamWriter sw = File.AppendText("Log.txt"))
                {
                    sw.WriteLine(ex.Message);
                }
                return "";
            }
            }
        public List<RegistrationTemplate> GetRegistrationTemplates()
        {
            try
            {
                Repository repository = new Repository(Path);
              
                List<RegistrationTemplate> result = repository.registrationTemplates();

                    return result;
               

               
               
            }
            catch (Exception ex)
            {
                using (StreamWriter sw = File.AppendText("Log.txt"))
                {
                    sw.WriteLine("Error in GetRegistrationTemplates(): " + ex.Message);
                }
                return null;
            }
        }

    }
}