namespace WebFormsMvpModule.Views
{
    using DotNetNuke.Entities.Modules;

    public partial class Settings : ModuleSettingsBase
    {
        public override void LoadSettings()
        {
            base.LoadSettings();

            // pull out settings for this module
            // this HashTable includes both ModuleSettings and TabModuleSettings
            var description = this.Settings["DescriptionText"];

            // it will be null if the setting hasn't been set before
            DescriptionTextBox.Text = description == null ? string.Empty : description.ToString();
        }

        public override void UpdateSettings()
        {
            base.UpdateSettings();
            var moduleController = new ModuleController();
 
            // ModuleSetting: save "sticky" settings, that stay around when a module is referenced
            moduleController.UpdateModuleSetting(this.ModuleId, "DescriptionText", this.DescriptionTextBox.Text);

            // TabModuleSetting: save settings unique to an instance of the module on a specific page
            moduleController.UpdateTabModuleSetting(this.TabModuleId, "DescriptionText", this.DescriptionTextBox.Text);
        }
    }
}