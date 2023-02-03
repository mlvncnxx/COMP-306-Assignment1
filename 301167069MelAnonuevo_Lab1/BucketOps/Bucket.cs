using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucketOps
{
    public class Bucket : INotifyPropertyChanged
    {
        private string _name;
        private DateTime _createdDate;

        public string Name 
        { get 
            { 
                return _name; 
            } 
          set 
            { 
                _name = value;
                NotifyPropertyChanged("Name");
            } 
        }
        public DateTime CreatedDate
        {
            get
            {
                return _createdDate;
            }
            set
            {
                _createdDate = value;
                NotifyPropertyChanged("CreatedDate");
            }
        }

        public Bucket(string bucketName, DateTime createdDate)
        {
            Name = bucketName;
            CreatedDate = createdDate;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

