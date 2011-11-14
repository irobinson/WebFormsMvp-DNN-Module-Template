namespace WebFormsMvpModule.Views
{
    using System;
    using DotNetNuke.Web.Mvp;
    using Models;
    using Presenters;
    using WebFormsMvp;

    [PresenterBinding(typeof(EditPresenter))]
    public partial class Edit : ModuleView<EditModel>, IEditView
    {
        public event EventHandler<SaveClickEventArgs> SaveClick;

        protected void PageLoad(object sender, EventArgs e)
        {
            this.SaveButton.Click += SaveButtonClick;
        }

        public void SaveButtonClick(object sender, EventArgs e)
        {
            if (!Page.IsValid)
                return;

            var args = new SaveClickEventArgs
            {
                //Property = this.FormField.Text
            };

            if (SaveClick != null)
            {
                SaveClick(this, args);
            }
        }
    }
}