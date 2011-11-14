namespace $Namespace$$safeprojectname$.Views
{
    using System;
    using DotNetNuke.UI.Skins;
    using DotNetNuke.UI.Skins.Controls;
    using DotNetNuke.Web.Mvp;
    using Models;
    using Presenters;
    using WebFormsMvp;

    [PresenterBinding(typeof(EditPresenter))]
    public partial class Edit : ModuleView<EditModel>, IEditView
    {
        public event EventHandler<SaveClickEventArgs> SaveClick;

        protected override void OnLoad(EventArgs e)
        {
            this.SaveButton.Click += SaveButtonClick;
        }

        public void SaveButtonClick(object sender, EventArgs e)
        {
            // validate the page
            if (!Page.IsValid)
                return;

            // pluck off the values we need from the form
            var args = new SaveClickEventArgs
            {
                //Property = this.FormField.Text
            };

            // send over to the presenter
            if (SaveClick != null)
            {
                SaveClick(this, args);
            }

            // alter the view based on the updated model
            if (this.Model.Success)
            {
                Skin.AddModuleMessage(this, "Success!!", this.Model.Message, ModuleMessage.ModuleMessageType.GreenSuccess);
            }
        }
    }
}