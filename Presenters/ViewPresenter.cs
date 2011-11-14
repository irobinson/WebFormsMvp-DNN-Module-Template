namespace WebFormsMvpModule.Presenters
{
    using DotNetNuke.Web.Mvp;
    using Views;

    public class ViewPresenter : ModulePresenter<IViewView, Models.ViewModel>
    {
        public ViewPresenter(IViewView view) : base(view)
        {
        }
    }
}