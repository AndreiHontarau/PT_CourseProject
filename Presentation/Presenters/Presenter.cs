using Ninject;

namespace Presentation
{
    public abstract class Presenter<TView> where TView : IView

    {
        protected TView _view;

        protected IKernel _Kernel { get; set; }

        public abstract void Run();
    }
}
