using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using MovieDbApp.WpfClient;
using server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace Frontend
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindowViewModel : ObservableRecipient
    {
        
        public MainWindowViewModel()
        {
            sendMsg = new RelayCommand(() =>
            {
                Msgs.Add(new Message()
                {
                    //Text = 
                });
            });
        }
            public RestCollection<Message> Msgs { get; set; }
        public ICommand sendMsg { get; set; }
        
    }
}
