using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.BussnessLogicLevel;
using Library.BussnessLogicLevel.BLL;
using Library.DataAccessLevel;
using Library.DataAccessLevel.Model;

namespace PetProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string Path = @"C:\Temp\Shop.db";
            Repository repository = new Repository(Path);
            ReturnAdmin Admin = new ReturnAdmin(Path);


            while (true)
            {
                Console.WriteLine("Меню");
                Console.WriteLine("1. Регистрация");
                Console.WriteLine("2. Удаление аккаунта");
                Console.WriteLine("3. Показать!");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int choice))
                {

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Email:");
                            string InputEmail = Console.ReadLine();
                            RegistrationTemplate newRegistrationTemplate = new RegistrationTemplate()
                            {
                                Name = InputEmail,
                                CreateTime = DateTime.Now,

                            };

                            Console.WriteLine(Admin.CreateAdmin(newRegistrationTemplate));

                            break;

                        case 2:
                            Console.WriteLine("Введите ID удаления");
                            int DeleteTemplate = Convert.ToInt32(Console.ReadLine());
                            
                            var result = Admin.DeleteAdmin(DeleteTemplate);

                            Console.WriteLine(result);
                            break;

                        case 3:
                            
                            var res = Admin.GetRegistrationTemplates();

                            foreach(var template in res)
                            {
                                Console.WriteLine("Id:" + template.Id+ "Name:" + template.Name+"Date:" + template.CreateTime);
                            }

                            break;
                         
                                
                    }


                }

                Console.ReadKey();
                Console.Clear();
            }
        }

    }
}