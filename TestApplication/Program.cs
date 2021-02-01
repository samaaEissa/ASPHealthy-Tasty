using HealthyANDTastyDAL.Repositories;
using HealthyANDTastyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Start");

                //UnitOfWork unitOfWork = new UnitOfWork();
                //Admin admin = new Admin();
                //admin.UserName = "admin1";
                //admin.Password = "123";
                //unitOfWork.AdminRepository.Save(admin);
                //unitOfWork.Commit();
                //unitOfWork.Dispose();
                //var admins= unitOfWork.AdminRepository.GetAll();

                Console.WriteLine("Done");
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
