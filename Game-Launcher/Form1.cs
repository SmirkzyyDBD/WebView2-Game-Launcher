using System.Diagnostics;
using Microsoft.Web.WebView2.Core;

namespace Game_Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GUILoad();
        }

        private async void GUILoad()
        {
            await webView21.EnsureCoreWebView2Async();

            webView21.Source = new Uri("https://smirkzyy.xyz/example/launcher");

            /*string gui = "Assets\\launcher.html";
            string htmlPath = Path.Combine(Application.StartupPath, gui);
            webView21.Source = new Uri(htmlPath);*/ // optionally you can use a local html file

            webView21.CoreWebView2.WebMessageReceived += WebView21_WebMessageReceived;
        }

        private void WebView21_WebMessageReceived(object sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            string message = e.TryGetWebMessageAsString();

            if (message == "launch_game")
            {
                LaunchGame();
            }
        }

        private void LaunchGame()
        {
            string GameRoot = "path\\to\\game\\exe";
            string gamePath = Path.Combine(Application.StartupPath, GameRoot); // the path is relative to where the launcher exe is

            if (File.Exists(gamePath))
            {
                Process.Start(gamePath);
            }
            else
            {
                MessageBox.Show("Game not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
