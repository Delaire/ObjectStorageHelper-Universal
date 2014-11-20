using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using ObjectStorageHelper_Universal.Annotations;

namespace ObjectStorageHelper_Universal.Model
{
    public class ApplicationSettings : INotifyPropertyChanged
    {
        public void InitData()
        {
            this.RunCount = 0;
            this.IsInitialized = true;
        }

        private Boolean _isInitialized { get; set; }
       
        private Int32 _runCount { get; set; }

        public Boolean IsInitialized
        {
            get
            {
                return this._isInitialized;
            }
            set
            {
                if (this._isInitialized != value)
                {
                    this._isInitialized = value;
                    OnPropertyChanged("IsInitialized");
                }
            }
        }

       
        public Int32 RunCount
        {
            get
            {
                return this._runCount;
            }
            set
            {
                if (this._runCount != value)
                {
                    this._runCount = value;
                    OnPropertyChanged("RunCount");
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}