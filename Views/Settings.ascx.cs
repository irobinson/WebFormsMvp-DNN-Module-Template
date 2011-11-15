namespace $Namespace$$safeprojectname$.Views
{
    using System;
    using DotNetNuke.UI.Modules;
    using DotNetNuke.Web.Mvp;
    using Models;
    using Presenters;
    using WebFormsMvp;

    [PresenterBinding(typeof(SettingsPresenter))]
    public partial class Settings : ModuleView<SettingsModel>, ISettingsView, ISettingsControl
    {
        public event EventHandler GetSettings;
        public event EventHandler SaveSettings;

        public void LoadSettings()
        {
            // ensure the event is wired up before proceeding
            if (this.GetSettings == null)
                return;

            // defer to presenter to set the model with any needed information
            GetSettings(this, null);

            // update the view based on our model
            this.DescriptionTextBox.Text = this.Model.Description;
            this.NameTextBox.Text = this.Model.Title;
        }

        public void UpdateSettings()
        {
            // validate the page
            if (!Page.IsValid)
                return;

            // pull the values out of the form
            this.Model.Description = this.DescriptionTextBox.Text;
            this.Model.Title = this.NameTextBox.Text;

            // ensure the event is wired up before proceeding
            if (this.SaveSettings == null)
                return;

            // defer to the presenter to update the database based on our model
            SaveSettings(this, null);
        }
    }
}