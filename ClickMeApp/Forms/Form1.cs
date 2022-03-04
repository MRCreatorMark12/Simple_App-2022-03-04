using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClickMeApp.Forms;

namespace ClickMeApp
{
    public delegate void SetParameterValueDelegate(string value);
    public partial class Form1 : Form
    {
        public delegate void SetTextValueCallback(string value);
        public SetTextValueCallback SetTextValue;
        private Child_Form chForm;
        Register_Form rr;
      

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ShowForm_Click(object sender, EventArgs e)
        {
            if(chForm == null)
            {
                chForm = new Child_Form();
            }
                this.SetTextValue += new SetTextValueCallback(chForm.SetText);
                chForm.Show();
        }

        private void btn_Append_Click(object sender, EventArgs e)
        {
            AppendMessage();
        }

        private void txtB_Input_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                AppendMessage();
            }
        }

        private void AppendMessage()
        {
            SetTextValue(txtB_Input.Text);
        }

        private void btn_Register_Student_Click(object sender, EventArgs e)
        {
            rr = new Register_Form();
            rr.Show();
        }
    }
}
