using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private static List<Customer> customer = new List<Customer>();

        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void Submit_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(FirstName.Text) && !string.IsNullOrEmpty(LastName.Text) && !string.IsNullOrEmpty(Email.Text))
            {
                customer.Add(new Customer
                {
                    Id = Guid.NewGuid(),
                    FirstName = FirstName.Text,
                    LastName = LastName.Text,
                    Email = Email.Text,
                    Wishes = Wishes.Text ?? ""
                });
            }
                 
                    
        }
    }
}
