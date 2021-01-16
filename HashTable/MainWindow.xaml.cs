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

namespace HashTable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Collections.Hashtable hashtable = new System.Collections.Hashtable();
        public MainWindow()
        {
            InitializeComponent();
        }

        void add(object sender, RoutedEventArgs e){
            try{
            hashtable.Add(key.Text, value.Text);
            MessageBox.Show(key.Text + " : " + value.Text + " has been add.");
            }
            catch{
                MessageBox.Show("Error\nkey: "+key.Text + " has been add.");
            }
        }

        void show(object sender, RoutedEventArgs e){
            string msg = "This is all data: \n";

            System.Collections.ICollection collction = hashtable.Keys;

            foreach(string key in collction){
                msg = msg + key.ToString() + "  :  " + hashtable[key].ToString() +"\n"; 
            }

            MessageBox.Show(msg);

        }

        void remove(object sender, RoutedEventArgs e){
            hashtable.Remove(key.Text);
            MessageBox.Show(key.Text + " has been remove.");
        }
    }
}
