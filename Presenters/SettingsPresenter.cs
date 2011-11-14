namespace WebFormsMvpModule.Presenters
{
    using DotNetNuke.Web.Mvp;
    using Models;
    
    public class SettingsPresenter : ModulePresenter<Views.ISettingsView, SettingsModel>
    {
        public SettingsPresenter(Views.ISettingsView view) : base(view)
        {
        }
    }
}