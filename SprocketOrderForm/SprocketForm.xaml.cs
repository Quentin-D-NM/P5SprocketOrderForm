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
using System.Windows.Shapes;

namespace SprocketOrderForm
{
    /// <summary>
    /// Interaction logic for SprocketForm.xaml
    /// </summary>
    public partial class SprocketForm : Window
    {
        Sprocket sp;
        public SprocketForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            switch (cbboxItemType.SelectedIndex)
            {
                case 0:
                    sp = new SteelSprocket();
                    break;
                case 1:
                    sp = new AluminumSprocket();
                    break;
                case 2:
                    sp = new PlasticSprocket();
                    break;
            }
            sp.ItemID = int.Parse(txtItemID.Text);
            sp.NumItems = int.Parse(txtNumItems.Text);
            sp.NumTeeth = int.Parse(txtNumTeeth.Text);


            DialogResult = true;
        }

        public Sprocket GetSprocket()
        {
            return sp;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
