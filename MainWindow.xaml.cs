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
using Microsoft.Toolkit.Uwp.Notifications;
using Notifications.Wpf;


namespace WindowsNotificacions
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }


        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var notificationManager = new NotificationManager();

            notificationManager.Show(new NotificationContent
            {
                Title = "Control de Hojas de Ruta",
                Message = "Tiene 5 mensajes nuevos",
                Type = NotificationType.Warning
                
                //En el notification type controlas el color hay 4 tipos infomacion = celeste , error = naranja , Succes y warning
            });
        }

    }
}