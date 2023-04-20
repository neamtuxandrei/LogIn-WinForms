using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using LoginProject.Repository;

namespace LoginProject
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IUserRepository userRepository = new UserTextRepository();
            IBookRepository bookRepository = new BookTextRepository();
            userRepository.LoadData();
            bookRepository.LoadData();
            Application.Run(new LoginForm(userRepository,bookRepository));
        }
    }



}
