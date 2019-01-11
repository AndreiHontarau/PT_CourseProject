using Ninject;

namespace Presentation
{
    public abstract class Presenter<TView> where TView : IView

    {
        protected TView _view { get; set; }

        protected IKernel _kernel { get; set; }

        public abstract void Run();
    }
}
