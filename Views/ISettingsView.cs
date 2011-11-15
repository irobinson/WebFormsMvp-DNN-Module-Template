namespace $Namespace$$safeprojectname$.Views
{
    using System;
    using DotNetNuke.Web.Mvp;

    public interface ISettingsView : IModuleView<Models.SettingsModel>
    {
        event EventHandler GetSettings;
        event EventHandler SaveSettings;
    }
}