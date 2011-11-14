namespace WebFormsMvpModule.Presenters
{
    using DotNetNuke.Web.Mvp;
    using Models;
    using Views;

    public class EditPresenter : ModulePresenter<IEditView, EditModel>
    {
        public EditPresenter(IEditView view) : base(view)
        {
        }
    }
}