using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

using LearningAndTrainingTasks.ViewModels;

namespace LearningAndTrainingTasks.Views
{
    public class AppBootstrapper: BootstrapperBase
    {
        public AppBootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}
