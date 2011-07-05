using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using Caliburn.Micro;

namespace MVVM.ViewModels
{
    [Export(typeof(IHaveDisplayName))]
    public class SecondTabViewModel : ISecondTab
    {
        IDialogViewModel _dialogViewModel;
        IWindowManager _windowsManager;

        [ImportingConstructor]
        public SecondTabViewModel(IDialogViewModel dialogViewModel, IWindowManager windowsManager)
        {
            _dialogViewModel = dialogViewModel;
            _windowsManager = windowsManager;
        }

        public string DisplayName
        {
            get
            {
                return "Second Tab";
            }
            set
            {
            }
        }
        
        public void OpenDialog()
        {
            _windowsManager.ShowDialog(_dialogViewModel);
        }
    }
}
