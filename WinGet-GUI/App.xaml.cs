﻿using System;
using System.Windows;
using HandyControl.Data;
using HandyControl.Tools;
using WinGet_GUI.Views;
using Prism.Ioc;
namespace WinGet_GUI
{
    public partial class App
    {

        protected override Window CreateShell()
        {
            
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
        internal void UpdateSkin(SkinType skin)
        {
            ResourceHelper.GetTheme("HandyTheme", Resources).Skin = skin;
            Current.MainWindow?.OnApplyTemplate();
        }
    }
}
