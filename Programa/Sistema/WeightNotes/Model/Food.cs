#region References

using System;
using Basis.BaseEntity;

#endregion

namespace WeightNotes.Model
{
    public class Food : BaseEntity
    {
        private String id;
        public String Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }

        private String name;
        public String Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        private Boolean isChecked;
        public Boolean IsChecked
        {
            get { return isChecked; }
            set
            {
                isChecked = value;
                OnPropertyChanged("IsChecked");
            }
        }
    }
}
