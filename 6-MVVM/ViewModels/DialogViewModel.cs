using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace MVVM.ViewModels
{
    [Export(typeof(IDialogViewModel))]
    public class DialogViewModel:IDialogViewModel
    {
    }
}
