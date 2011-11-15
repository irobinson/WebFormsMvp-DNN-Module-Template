namespace WebFormsMvpModule.Presenters
{
    using System;
    using DotNetNuke.Entities.Modules;
    using DotNetNuke.Web.Mvp;

    public class SettingsPresenter : ModulePresenter<Views.ISettingsView, Models.SettingsModel>
    {
        public SettingsPresenter(Views.ISettingsView view) : base(view)
        {
            this.View.Load += Load;
            this.View.GetSettings += GetSettings;
            this.View.SaveSettings += SaveSettings;
        }

        private void Load(object sender, EventArgs e)
        {
            // page load equivalent
        }

        private void GetSettings(object sender, EventArgs eventArgs)
        {
            View.Model.Description = GetSetting("Description");
            View.Model.Title = GetSetting("Title");
        }

        private void SaveSettings(object sender, EventArgs eventArgs)
        {
            var moduleController = new ModuleController();
            moduleController.UpdateModuleSetting(this.ModuleId, "Description", this.View.Model.Description);
            moduleController.UpdateModuleSetting(this.ModuleId, "Title", this.View.Model.Title);
        }

        private string GetSetting(string settingKey)
        {
            return this.Settings.ContainsKey(settingKey) ? this.Settings[settingKey] : string.Empty;
        }
    }
}