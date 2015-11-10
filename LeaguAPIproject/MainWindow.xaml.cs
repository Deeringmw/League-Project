using MahApps.Metro.Controls;
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
using RiotApi.Net.RestClient;
using RiotApi.Net.RestClient.Configuration;
using System.Diagnostics;

namespace LeaguAPIproject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        IRiotClient riotClient = new RiotClient(Constants.ApiKey);

        public MainWindow()
        {
            InitializeComponent();

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var search = searchBox.Text + " " + txtRole.Text + " guide";


            Process.Start($"https://www.google.com/search?q={search}&btnI=/");
        }

        private void searchBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void searchBox_GotFocus(object sender, RoutedEventArgs e)
        {
            searchBox.Text = "";
        }

        private void profileButton_Click(object sender, RoutedEventArgs e)
        {
            var elo = txtEloSearch.Text;
            Process.Start($"http://www.elophant.com/league-of-legends/search?query={elo}");
        }


        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("http://na.leagueoflegends.com/en/news/");
        }

        private void btnRune_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("http://leaguecraft.com/masteries/");
        }

        private void btnCredits_Click(object sender, RoutedEventArgs e)
        { 
            MessageBox.Show("Credit to J.T, for bearing with me while learning how to use, and not use, C#.\n" + "To Google, for being there for me when no one else was." + "\n" + "And most importantly, to my wonderful Girlfriend, Ashley Lawrence, for dealing with my negclect while working.");
        }

        private void profileButton_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void txtEloSearch_GotFocus(object sender, RoutedEventArgs e)
        {
            txtEloSearch.Text = "";
        }
    }
}

// = dictionary["apple"];