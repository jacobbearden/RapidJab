using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace RapidJab.Views
{
  public partial class SettingsView : Page
  {
    public SettingsView()
    {
      InitializeComponent();
    }

    private void HandleLinkClick(object sender, RoutedEventArgs e)
    {
      Hyperlink link = (Hyperlink)sender;
      String url = link.NavigateUri.ToString();

      ProcessStartInfo process = new ProcessStartInfo
      {
        FileName = url,
        UseShellExecute = true
      };

      Process.Start(process);
      e.Handled = true;
    }
  }
}

