using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace MyFrmApp
{
    public class MyForm : Form
    {
        private Label label;
        private Button btn1;
        private Button btn2;
        private int count1 = 0;
        private int count2 = 0;

        public MyForm()
        {
            this.Width = 300;
            this.Height = 200;
            setupControls();
        }
        public void setupControls()
        {
            label = new Label();
            label.Text = "sleep:" + count1.ToString() + "   click:" + count2.ToString();
            label.Font = new Font("Geneva",12,FontStyle.Regular);
            label.Height = 30;
            label.Width = 300;
            this.Controls.Add(label);
            // box = new TextBox();
            // box.Width = 225;
            // box.Top = 50;
            // box.Left = 25;
            // this.Controls.Add(box);
            btn1 = new Button();
            btn1.Text = "sleep";
            btn1.Height = 30;
            btn1.Width = 100;
            btn1.Top = 100;
            btn1.Left = 100;
            btn1.Click += btn1_Click;
            this.Controls.Add(btn1);
            btn2 = new Button();
            btn2.Text = "click";
            btn2.Height = 30;
            btn2.Width = 100;
            btn2.Top = 100;
            btn2.Left = 300;
            btn2.Click += btn2_Click;
            this.Controls.Add(btn2);
        }

        private async void btn1_Click(object sender, System.EventArgs e)
        {
            await Task.Run(() => Thread.Sleep(3000));
            ++count1;
            label.Text = "sleep:" + count1.ToString() + "   click:" + count2.ToString();
        }

        private void btn2_Click(object sender, System.EventArgs e)
        {
            // this.btn.Enabled = false;
            // //Thread.Sleep(10);  // 何か長い処理
            // Task.Factory.StartNew(() => Thread.Sleep(3000)).ContinueWith(_ =>
            // {
            //     this.btn.Enabled = true;
            // }, TaskScheduler.FromCurrentSynchronizationContext());
            ++count2;
            label.Text = "sleep:" + count1.ToString() + "   click:" + count2.ToString();
            Thread.Sleep(100);

        }
    }
}