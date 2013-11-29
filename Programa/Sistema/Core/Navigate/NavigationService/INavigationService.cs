#region References

using System;

#endregion

namespace NavigationService
{
    public interface INavigationService 
    {
        void GoBack();

        void Navigate<TypeOfViewModel>(String page);

    }
}
