using Ninject;

namespace Presentation
{
    public abstract class Presenter<TView> where TView : IView

    {
        protected TView _view;

        protected IKernel _Kernel { get; set; }

        protected const string SqlExceptionDataWouldBeTruncatedMessage = "String or binary data would be truncated. The statement has been terminated.";

        public abstract void Run();
    }
}
