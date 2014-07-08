using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyFrmApp
{
    public class MyForm : Form
    {
        private Label label;
        CheckBox check;
        CheckBox check2;

        public MyForm()
        {
            this.Width = 300;
            this.Height = 200;
            setupControls();
        }

        public void setupControls()
        {
            label = new Label();
            label.Text = "type text:";
            label.Font = new Font("Geneva",12,FontStyle.Regular);
            label.Height = 30;
            label.Width = 300;
            this.Controls.Add(label);
            check = new CheckBox();
            check.Text = "check box";
            check.Top = 50;
            check.Left = 50;
            check.CheckedChanged += check_changed;
            this.Controls.Add(check);
            check2 = new CheckBox();
            check2.Text = "check box2";
            check2.Top = 100;
            check2.Left = 50;
            check2.CheckedChanged += check_changed;
            this.Controls.Add(check2);

        }

        private void check_changed(object sender, System.EventArgs e)
        {
             label.Text = "checked: " + check2.CheckState + "(" + check2.Checked + ")";
        }
    }
}