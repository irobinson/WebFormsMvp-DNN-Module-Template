namespace WebFormsMvpModule.Presenters
{
    using DotNetNuke.Web.Mvp;
    using Models;
    using Views;

    public class EditPresenter : ModulePresenter<IEditView, EditModel>
    {
        public EditPresenter(IEditView view) : base(view)
        {
            this.View.SaveClick += Save;
        }

        private void Save(object sender, SaveClickEventArgs args)
        {
            // pluck properties from args (save in database?)

            // update the view's model as appropriate (success or error message?)
        }
    }
}