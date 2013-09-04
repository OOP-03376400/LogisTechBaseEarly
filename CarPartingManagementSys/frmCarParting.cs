using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CarPartingManagementSys
{
    public partial class frmCarParting : Form
    {

        int totalCount = 10;
        int usedCount = 0;
        int canbeUsedCount = 10;

        public frmCarParting()
        {
            InitializeComponent();
            this.initial();
        }
        void initial()
        {
            this.lblTotalCount.Text = totalCount.ToString();
            this.lblUsedCount.Text = usedCount.ToString();
            this.lblCanbeUsedCount.Text = canbeUsedCount.ToString();
        }
        void updateHistory(string h)
        {
            this.textBox1.Text = h + "\r\n" + this.textBox1.Text;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //发卡
        //可用数减一，已用数加一。如果大于总数，提示无车位
        private void button1_Click(object sender, EventArgs e)
        {
            usedCount++;
            if (usedCount > totalCount)
            {
                usedCount--;
                MessageBox.Show("这里没有更多车位了，请到别处停车吧！");
                this.updateHistory("没有更多的停车位 " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                return;
            }
            else
            {
                canbeUsedCount--;
                this.initial();
                this.updateHistory("一个停车位被使用 " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            }
        }
        //收卡
        //可用数加1，已用数减一
        private void button3_Click(object sender, EventArgs e)
        {
            if (usedCount > 0)
            {
                usedCount--;
                canbeUsedCount++;
                this.initial();
                this.updateHistory("一个停车位空出 " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            }
            else
            {
                MessageBox.Show("是不是搞错了，我这里没有这么多车位啊？");
            }
        }
    }
}
