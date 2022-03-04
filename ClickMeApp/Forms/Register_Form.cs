using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickMeApp.Forms
{
    public partial class Register_Form : Form
    {
        DateTime dt = new DateTime();
        public Register_Form()
        {
            InitializeComponent();
           
        }

        private void dateTimePicker1_BindingContextChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dt = DateTime.Now;
            int age = dt.Year - dateTimePicker1.Value.Year;
            lbl_Age.Text = String.Format("Age:{0}", age.ToString());
        }
    }
}
