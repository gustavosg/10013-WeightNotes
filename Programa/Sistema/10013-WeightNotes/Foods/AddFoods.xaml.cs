using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace _10013_WeightWatchersNotes.Foods
{
    public partial class AddFoods : PhoneApplicationPage
    {
        public AddFoods()
        {
            InitializeComponent();

            String[] list = new String[]{
             "", 
             "1", 
             "2"
            };

            listBox1.ItemsSource = list;
            
        }
    }
}