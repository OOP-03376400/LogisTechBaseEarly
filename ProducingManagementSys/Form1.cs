using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProducingManagementSys
{
    //  "0°";
    public partial class Form1 : Form
    {
        Timer __timer = new Timer();
        Timer __timerOrder = new Timer();
        int countToProduce = 0;
        int countProduced = 0;

        int getRandom(int max)
        {
            Random r = new Random();
            return r.Next(max);
        }
        public Form1()
        {
            InitializeComponent();

            this.amazingProgressBar4.Style = System.Windows.Forms.ProgressBarStyle.Blocks;
            __timer.Interval = 300;//30秒生产一个
            __timer.Tick += new EventHandler(__timer_Tick);
            countToProduce = 2;//每分钟最多产生4个

            __timerOrder.Interval = 60000;
            __timerOrder.Tick += new EventHandler(__timerOrder_Tick);

            this.Shown += new EventHandler(Form1_Shown);
        }

        void __timerOrder_Tick(object sender, EventArgs e)
        {
            int i = this.getRandom(4);
            countToProduce += i;
            if (i > 0)
            {
                this.textBox1.Text = string.Format("\r\n收到 {0}  个产品的订单 {1}", i.ToString(), DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")) + textBox1.Text;
            }
            this.refreshProducingProgress();
        }
        void refreshProducingProgress()
        {
            this.lblToProduceCount.Text = countToProduce.ToString();
            this.lblProducedCount.Text = countProduced.ToString();
        }
        void Form1_Shown(object sender, EventArgs e)
        {
            this.refreshProducingProgress();
            this.matrixCircularProgressControl1.Start();
            __timer.Enabled = true;
            __timerOrder.Enabled = true;
        }

        void __timer_Tick(object sender, EventArgs e)
        {
            if (amazingProgressBar4.Value <= 0)//开始下一轮生产
            {
                this.textBox1.Text = string.Format("\r\n生产完一个产品 {0}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))+textBox1.Text;

                countProduced++;//生产完成一个
                countToProduce--;
                this.amazingProgressBar4.Value = amazingProgressBar4.Maximum;
                this.refreshProducingProgress();
            }
            if (countToProduce > 0)
            {
                this.lblStatus.Text = "生产中...";

                SetValue(this.amazingProgressBar4.Value - 1);
            }
            else
            {
                this.lblStatus.Text = "生产完毕";
            }
        }
        private void SetValue(int value)
        {

            if (value >= this.amazingProgressBar4.Minimum && value <= amazingProgressBar4.Maximum)
            {
                amazingProgressBar4.Value = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.amazingProgressBar4.Value = amazingProgressBar4.Maximum;
            this.__timer.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
