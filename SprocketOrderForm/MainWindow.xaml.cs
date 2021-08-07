using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace SprocketOrderForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SprocketOrder spo = new SprocketOrder();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            txtCity.Visibility = Visibility.Visible;
            lblCity.Visibility = Visibility.Visible;
            txtState.Visibility = Visibility.Visible;
            lblState.Visibility = Visibility.Visible;
            txtZipCode.Visibility = Visibility.Visible;
            lblZipCode.Visibility = Visibility.Visible;
            lblStreet.Visibility = Visibility.Visible;
            txtStreet.Visibility = Visibility.Visible;

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            txtCity.Visibility = Visibility.Hidden;
            lblCity.Visibility = Visibility.Hidden;
            txtState.Visibility = Visibility.Hidden;
            lblState.Visibility = Visibility.Hidden;
            txtZipCode.Visibility = Visibility.Hidden;
            lblZipCode.Visibility = Visibility.Hidden;
            lblStreet.Visibility = Visibility.Hidden;
            txtStreet.Visibility = Visibility.Hidden;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            SprocketForm sf = new SprocketForm();
            Sprocket sp;

            sf.ShowDialog();
            if (sf.DialogResult == true)
            {
                sp = sf.GetSprocket();
                MessageBox.Show("Student " + sp.GetType() + " Added!");
                if (sp is SteelSprocket)
                {
                    sp = (SteelSprocket)sp;
                }
                else if (sp is AluminumSprocket)
                {
                    sp = (AluminumSprocket)sp;
                }
                else if (sp is PlasticSprocket)
                {
                    sp = (PlasticSprocket)sp;
                }
                Address address = new Address();
                if (!(bool)cboxLocalPickup.IsChecked)
                {
                    address.City = txtCity.Text;
                    address.State = txtState.Text;
                    address.Street = txtStreet.Text;
                    address.Zipcode = txtZipCode.Text;
                }
                else
                {
                    address = null;
                }
                lboxItems.Items.Add(sp);
                spo.address = address;
                spo.CustomerName = txtCustomerName.Text;
                spo.items.Add(sp);

            }
            else
            {
                MessageBox.Show("Dialog Cancelled!");
            }
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            Confirm cm = new Confirm();
            cm.ShowDialog();

            if (cm.DialogResult == true)
            {
                spo.items.RemoveAt(lboxItems.SelectedIndex);
                lboxItems.Items.Remove(lboxItems.SelectedItem);
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            //I could not figure out how this works :(
            //StreamWriter myStream;
            //SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            //saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            //saveFileDialog1.FilterIndex = 2;
            //saveFileDialog1.RestoreDirectory = true;

            //if (saveFileDialog1.ShowDialog() == true)
            //{
            //    if ((myStream = saveFileDialog1.OpenFile()) != null)
            //    {
            //        myStream.
            //        myStream.Close();
            //    }
            //}
        }
    }
}
