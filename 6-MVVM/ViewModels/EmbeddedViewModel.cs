using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace MVVM.ViewModels
{
    [Export(typeof(IEmbeddedViewModel))]
    public class EmbeddedViewModel : IEmbeddedViewModel
    {
        public string Text
        {
            get { return "Text from view model"; }
            set { }
        }
    }
}
