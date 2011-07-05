using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using Caliburn.Micro;

namespace MVVM.ViewModels
{
    [Export(typeof(IHaveDisplayName))]
    public class FirstTabViewModel : PropertyChangedBase, IFirstTab
    {
        private bool _canSendEvent = true;
        private IEventAggregator _eventAggregator;
        private int _eventsSent;

        [ImportingConstructor]
        public FirstTabViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }

        public bool CanSendEvent
        {
            get { return _canSendEvent; }
            set 
            { 
                _canSendEvent = value;
                NotifyOfPropertyChange(() => CanSendEvent);
            }
        }

        public string DisplayName
        {
            get
            {
                return "First Tab";
            }
            set { }
        }

        public void SendEvent()
        {
            _eventAggregator.Publish("Event from the first tab");
            if (++_eventsSent == 3)
                CanSendEvent = false;
        }
    }
}
