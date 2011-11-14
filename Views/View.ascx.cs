namespace WebFormsMvpModule.Views
{
    using DotNetNuke.Entities.Modules;
    using DotNetNuke.Entities.Modules.Actions;
    using DotNetNuke.Security;
    using DotNetNuke.Web.Mvp;
    using Models;
    using Presenters;
    using WebFormsMvp;

    [PresenterBinding(typeof(ViewPresenter))]
    public partial class View : ModuleView<ViewModel>, IViewView, IActionable
    {
        public ModuleActionCollection ModuleActions
        {
            get
            {
                return new ModuleActionCollection
                {
                    // Add the edit action item for people with edit permissions
                    {
                        this.ModuleContext.GetNextActionID(), LocalizeString("Edit Menu Title"),
                        string.Empty, string.Empty, string.Empty, this.ModuleContext.EditUrl(), false, SecurityAccessLevel.Edit, true, false
                    },
                    //Add another action item
                    {
                        this.ModuleContext.GetNextActionID(), LocalizeString("Go To Google"),
                        string.Empty, string.Empty, string.Empty, "http://www.google.com", false, SecurityAccessLevel.Edit, true, false
                    }
                };
            }
        }
    }
}