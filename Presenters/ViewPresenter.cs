namespace WebFormsMvpModule.Presenters
{
    using System;
    using DotNetNuke.Web.Mvp;
    using Views;

    public class ViewPresenter : ModulePresenter<IViewView, Models.ViewModel>
    {
        public ViewPresenter(IViewView view) : base(view)
        {
            this.View.Load += Load;
        }

        private void Load(object sender, EventArgs eventArgs)
        {
            base.OnLoad();
        }
    }
}