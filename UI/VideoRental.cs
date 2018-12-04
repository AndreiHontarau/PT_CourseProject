using System;
using System.Windows.Forms;
using Ninject;
using Presentation;
using Model;

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
            StandardKernel kernel = new StandardKernel();
            kernel.Bind<ApplicationContext>().ToConstant(new ApplicationContext());
            kernel.Bind<ILoginView>().To<LoginForm>();
            kernel.Bind<LoginPresenter>().ToSelf();
            kernel.Bind<ILoginService>().To<LoginService>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            kernel.Get<LoginPresenter>().Run();
            Application.Run(kernel.Get<ApplicationContext>());
        }
    }
}
