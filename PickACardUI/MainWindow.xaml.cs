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

namespace PickACardUI
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

        /* So this was pretty easy, but what is wrong with our card deck?
            HINT: Can you determine many cards are in this deck?
        */
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // p. 124 Review: What is going on with (int) here?
            string[] pickedCards = CardPicker.PickSomeCards((int)numberOfCards.Value);
            ListofCards.Items.Clear();
            foreach (string card in pickedCards)
            {
                ListofCards.Items.Add(card);
            }
        }
    }
}
