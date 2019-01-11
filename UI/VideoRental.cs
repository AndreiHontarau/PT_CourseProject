﻿using System;
using System.Windows.Forms;
using Ninject;
using Ninject.Parameters;
using Presentation;

namespace UI
{
    static class VideoRental
    {
        /// <summary>
        /// The entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //try
            //{
                var kernel = KernelBuilder.GetKernel();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                kernel.Get<CustomersManagementPresenter>().Run();
                Application.Run(kernel.Get<ApplicationContext>());
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
