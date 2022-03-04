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
    public delegate void SetParameterValueDelegate(string value);
    public partial class Child_Form : Form
    {
      
        public Child_Form()
        {
            InitializeComponent();
        }

        public void SetText(string value)
        {
            lbl_Message.Text = value;
        }
     

      

       
    }
}
