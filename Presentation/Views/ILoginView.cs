using System;

namespace Presentation
{
    public interface ILoginView : IView
    {
        string UserName { get; }
        string Password { get; }
        event EventHandler Login;
        void ShowError(string message);
    }
}
