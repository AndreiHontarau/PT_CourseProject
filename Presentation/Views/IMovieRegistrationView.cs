using System;
using System.Collections.Generic;
using Model;

namespace Presentation
{
    public interface IMovieRegistrationView : IView
    {
        string Title { get; }
        string Producer { get; }
        short YearOfProduction { get; }
        string CategoryName { get; }
        string Carrier { get; }
        short AmountOfCopies { get; }
        string Country { get; }
        string ActorsList { get; }
        string Language { get; }
        string Description { get; }
        bool AgeRestriction { get; }

        event EventHandler Registrate;
        event EventHandler UploadImage;
        event EventHandler LoadCategories;

        void RecieveCategories(List<CategoryRecord> categories);
        void ShowError(string massege);
    }
}
