using Ninject;
using Presentation;
using Model;
using System.Windows.Forms;

namespace UI
{
    static class KernelBuilder
    {
        private static IKernel _kernel = new StandardKernel();

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

            _kernel.Bind<IMovieRegistrationView>().To<MovieRegistrationForm>();
            _kernel.Bind<MovieRegistrationPresenter>().ToSelf();
            //_kernel.Bind<IMovieRegistrationService>().To<MovieRegistrationService>();

            _kernel.Bind<ICategoriesManagementView>().To<CategoriesManagementForm>();
            _kernel.Bind<CategoriesManagementPresenter>().ToSelf();
            _kernel.Bind<ICategoriesManagementService>().To<CategoriesManagementService>();

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
            _kernel.Bind<IMoviesRepository>().To<MoviesDBManager>();
            _kernel.Bind<ICategoriesRepository>().To<CategoriesDBManager>();
        }
    }
}
