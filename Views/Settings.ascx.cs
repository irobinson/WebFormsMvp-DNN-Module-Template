﻿namespace WebFormsMvpModule.Views
{
    using System;
    using DotNetNuke.Web.Mvp;
    using Models;
    using Presenters;
    using WebFormsMvp;

    [PresenterBinding(typeof(EditPresenter))]
    public partial class Settings : ModuleView<SettingsModel>, ISettingsView
    {
        protected override void OnInit(EventArgs e)
        {
            Load += PageLoad;
        }

        protected void PageLoad(object sender, EventArgs e)
        {
        }
    }
}