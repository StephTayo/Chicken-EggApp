using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChickenOrEgg
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // user selected chicken
        private void rdoChicken_CheckedChanged(object sender, EventArgs e)
        {
            picAnswer.Image = Image.FromFile(@"..\..\Images\chicken.jpg");
        }

        // user selected egg
        private void rdoEgg_CheckedChanged(object sender, EventArgs e)
        {
            picAnswer.Image = Image.FromFile("../../Images/egg.jpg");
        }

        // start with no selection
        

        // no answer
        private void rdoNeither_CheckedChanged(object sender, EventArgs e)
        {
            picAnswer.Image = null; // no value
        }

        // user selected from combo box
        // items in combo box are indexed 0, 1, ...
        private void cboAnswer_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cboAnswer.SelectedIndex)
            {
                case 0: // Chicken
                    picAnswer.Image = Image.FromFile(@"..\..\Images\chicken.jpg");
                    break;
                case 1: // Egg
                    picAnswer.Image = Image.FromFile(@"..\..\Images\egg.jpg");
                    break;
                default: 
                    picAnswer.Image = null;
                    break;
            }
        }
    }
}
