namespace $Namespace$$safeprojectname$.Views
{
    using System;
    using DotNetNuke.Web.Mvp;

    public interface IEditView : IModuleView<Models.EditModel>
    {
        event EventHandler<SaveClickEventArgs> SaveClick;
    }

    public class SaveClickEventArgs : EventArgs
    {
        
    }
}
