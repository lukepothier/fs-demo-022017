﻿using Demo.AdvancedPCL;
using Demo.Plugin.AlertDialog;
using MvvmCross.Core.ViewModels;

namespace Demo.Core.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {

        readonly IMvxAlertDialog _mvxAlertDialog;

        public HomeViewModel(IMvxAlertDialog mvxAlertDialog)
        {
            _mvxAlertDialog = mvxAlertDialog;
        }

        #region Commands

        IMvxCommand _vectorCommand;
        public IMvxCommand VectorCommand =>
            _vectorCommand ?? (_vectorCommand = new MvxCommand(GoToVector));

        IMvxCommand _rasterCommand;
        public IMvxCommand RasterCommand =>
            _rasterCommand ?? (_rasterCommand = new MvxCommand(GoToRaster));

        IMvxCommand _fluentLayoutCommand;
        public IMvxCommand FluentLayoutCommand =>
            _fluentLayoutCommand ?? (_fluentLayoutCommand = new MvxCommand(GoToFluentLayout));

        IMvxCommand _delegateFunctionsCommand;
        public IMvxCommand DelegateFunctionsCommand =>
            _delegateFunctionsCommand ?? (_delegateFunctionsCommand = new MvxCommand(GoToDelegateFunctions));

        IMvxCommand _pluginAlertCommand;
        public IMvxCommand PluginAlertCommand =>
            _pluginAlertCommand ?? (_pluginAlertCommand = new MvxCommand(ShowPluginAlertDialog));

        IMvxCommand _baitSwitchAlertCommand;
        public IMvxCommand BaitSwitchAlertCommand =>
            _baitSwitchAlertCommand ?? (_baitSwitchAlertCommand = new MvxCommand(ShowBaitSwitchAlertDialog));

        #endregion

        #region Navigation

        void GoToVector() => ShowViewModel<VectorViewModel>();

        void GoToRaster() => ShowViewModel<RasterViewModel>();

        void GoToFluentLayout() => ShowViewModel<FluentLayoutViewModel>();

        void GoToDelegateFunctions() => ShowViewModel<DelegateFunctionsViewModel>();

        #endregion

        #region Command Execution

        void ShowPluginAlertDialog()
        {
            _mvxAlertDialog.ShowDialog(Constants.ALERT_MESSAGE, Constants.ALERT_TITLE, Constants.ALERT_BUTTON);
        }

        void ShowBaitSwitchAlertDialog()
        {
            var dialog = new AlertDialog();
            dialog.ShowDialog(Constants.ALERT_BAITSWITCH_MESSAGE, Constants.ALERT_BAITSWITCH_TITLE, Constants.ALERT_BUTTON);
        }

        #endregion

    }
}
