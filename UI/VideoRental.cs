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

            kernel.Bind<IStorageManagementView>().To<StorageManagementForm>();
            kernel.Bind<StorageManagementPresenter>().ToSelf();
            kernel.Bind<IStorageManagementService>().To<StorageManagementService>();

            kernel.Bind<ICustomersManagementView>().To<CustomersManagementForm>();
            kernel.Bind<CustomersManagementPresenter>().ToSelf();
            kernel.Bind<ICustomersManagementService>().To<CustomersManagementService>();

            kernel.Bind<IUsersManagementView>().To<UsersManagementForm>();
            kernel.Bind<UsersManagementPresenter>().ToSelf();
            kernel.Bind<IUsersManagementService>().To<UsersManagementService>();

            kernel.Bind<IUserRegistrationView>().To<UserRegistrationForm>();
            kernel.Bind<UserRegistrationPresenter>().ToSelf();
            kernel.Bind<IUserRegistrationService>().To<UserRegistrationService>();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            kernel.Get<LoginPresenter>().Run();
            Application.Run(kernel.Get<ApplicationContext>());
        }
    }
}
