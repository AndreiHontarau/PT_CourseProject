using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Presentation;
using Model;
using System.Windows.Forms;

namespace UI
{
    class KernelBuilder
    {
        private static readonly IKernel _kernel = new StandardKernel();

        public static IKernel GetKernel()
        {
            BuildKernel();
            return _kernel;
        }

        private static void BuildKernel()
        {
            _kernel.Bind<ApplicationContext>().ToConstant(new ApplicationContext());

            _kernel.Bind<ILoginView>().To<LoginForm>();
            _kernel.Bind<LoginPresenter>().ToSelf();
            _kernel.Bind<ILoginService>().To<LoginService>();

            _kernel.Bind<IStorageManagementView>().To<StorageManagementForm>();
            _kernel.Bind<StorageManagementPresenter>().ToSelf();
            _kernel.Bind<IStorageManagementService>().To<StorageManagementService>();

            _kernel.Bind<ICustomersManagementView>().To<CustomersManagementForm>();
            _kernel.Bind<CustomersManagementPresenter>().ToSelf();
            _kernel.Bind<ICustomersManagementService>().To<CustomersManagementService>();

            _kernel.Bind<IUsersManagementView>().To<UsersManagementForm>();
            _kernel.Bind<UsersManagementPresenter>().ToSelf();
            _kernel.Bind<IUsersManagementService>().To<UsersManagementService>();

            _kernel.Bind<IUserRegistrationView>().To<UserRegistrationForm>();
            _kernel.Bind<UserRegistrationPresenter>().ToSelf();
            _kernel.Bind<IUserRegistrationService>().To<UserRegistrationService>();

            _kernel.Bind<IUsersRepository>().To<UsersDBManager>();
        }
    }
}
