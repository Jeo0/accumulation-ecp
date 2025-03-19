using example5;
using lesson3___example3;
using New_POS_Application;
using Activity5;

namespace projectNamin
{
    internal static class Program
    {
        /// <summary>  
        ///  The main entry point for the application.  
        /// </summary>  
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,  
            // see https://aka.ms/applicationconfiguration.  
            ApplicationConfiguration.Initialize();

            //Application.Run(new Plesson3_form());  
            //Application.Run(new Pquiz1_form());    
            Application.Run(new Activity5.Activity5());

        }
    }
}