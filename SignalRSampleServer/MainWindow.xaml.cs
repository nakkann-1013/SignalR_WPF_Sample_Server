using Microsoft.Owin.Hosting;
using System;
using System.Windows;

namespace SignalRSampleServer
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {

        private IDisposable _startup;

        public MainWindow()
        {
            InitializeComponent();
            _startup = WebApp.Start<AppStartup>("http://localhost:8080");
        }
    }
}
