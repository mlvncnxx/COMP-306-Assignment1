using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLevelOps
{
    public class BucketObject : INotifyPropertyChanged
    {
        private string _objectName;
        private double _size;

        public string ObjectName
        {
            get
            {
                return _objectName;
            }
            set
            {
                _objectName = value;
                NotifyPropertyChanged("ObjectName"); //Added
            }
        }
        public double Size
        {
            get
            {
                return _size;
            }
            set
            {
                _size = value;
                NotifyPropertyChanged("Size"); //Added
            }
        }
        public BucketObject(string objectName, double size)
        {
            ObjectName = objectName;
            Size = size;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
