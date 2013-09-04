namespace ProducingManagementSys
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.amazingProgressBar4 = new GAW.AmazingProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblToProduceCount = new System.Windows.Forms.Label();
            this.lblProducedCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbltemp = new System.Windows.Forms.Label();
            this.lblHuminity = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.matrixCircularProgressControl1 = new logisTechBaseSys.MatrixCircularProgressControl();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // amazingProgressBar4
            // 
            this.amazingProgressBar4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.amazingProgressBar4.BorderColor = System.Drawing.SystemColors.Control;
            this.amazingProgressBar4.BorderGradient = true;
            this.amazingProgressBar4.BorderRoundCorners = false;
            this.amazingProgressBar4.BorderSize = 2;
            this.amazingProgressBar4.Gradient = GAW.AmazingProgressBar.GradientType.Flow;
            this.amazingProgressBar4.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.amazingProgressBar4.GradientStartColor = System.Drawing.Color.Red;
            this.amazingProgressBar4.Location = new System.Drawing.Point(15, 44);
            this.amazingProgressBar4.MazeStyle = GAW.AmazingProgressBar.MazeStyleType.SingleLeft;
            this.amazingProgressBar4.Name = "amazingProgressBar4";
            this.amazingProgressBar4.RowCount = 8;
            this.amazingProgressBar4.Size = new System.Drawing.Size(607, 83);
            this.amazingProgressBar4.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.amazingProgressBar4.TabIndex = 4;
            this.amazingProgressBar4.UnusedColor = System.Drawing.SystemColors.Control;
            this.amazingProgressBar4.Value = 100;
            this.amazingProgressBar4.WallColor = System.Drawing.Color.Black;
            this.amazingProgressBar4.WallSize = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(677, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStatus.Location = new System.Drawing.Point(287, 20);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(62, 16);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F);
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "待生产数量：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F);
            this.label2.Location = new System.Drawing.Point(677, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "正在检查新订单...";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(672, 432);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 10);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbltemp);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblHuminity);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Controls.Add(this.amazingProgressBar4);
            this.groupBox2.Location = new System.Drawing.Point(25, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(637, 170);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "生产车间";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F);
            this.label3.Location = new System.Drawing.Point(25, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "已生产数量：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(25, 271);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(637, 171);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "生产记录";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 17);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(631, 151);
            this.textBox1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(696, 458);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 25);
            this.button2.TabIndex = 9;
            this.button2.Text = "退出（&X)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblToProduceCount
            // 
            this.lblToProduceCount.AutoSize = true;
            this.lblToProduceCount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblToProduceCount.Location = new System.Drawing.Point(109, 29);
            this.lblToProduceCount.Name = "lblToProduceCount";
            this.lblToProduceCount.Size = new System.Drawing.Size(45, 17);
            this.lblToProduceCount.TabIndex = 10;
            this.lblToProduceCount.Text = "label4";
            // 
            // lblProducedCount
            // 
            this.lblProducedCount.AutoSize = true;
            this.lblProducedCount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblProducedCount.Location = new System.Drawing.Point(109, 59);
            this.lblProducedCount.Name = "lblProducedCount";
            this.lblProducedCount.Size = new System.Drawing.Size(45, 17);
            this.lblProducedCount.TabIndex = 10;
            this.lblProducedCount.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "温度：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "湿度：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(530, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "光照：";
            // 
            // lbltemp
            // 
            this.lbltemp.AutoSize = true;
            this.lbltemp.Location = new System.Drawing.Point(65, 138);
            this.lbltemp.Name = "lbltemp";
            this.lbltemp.Size = new System.Drawing.Size(23, 12);
            this.lbltemp.TabIndex = 7;
            this.lbltemp.Text = "0°";
            // 
            // lblHuminity
            // 
            this.lblHuminity.AutoSize = true;
            this.lblHuminity.Location = new System.Drawing.Point(319, 138);
            this.lblHuminity.Name = "lblHuminity";
            this.lblHuminity.Size = new System.Drawing.Size(23, 12);
            this.lblHuminity.TabIndex = 7;
            this.lblHuminity.Text = "50%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(568, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "100";
            // 
            // matrixCircularProgressControl1
            // 
            this.matrixCircularProgressControl1.BackColor = System.Drawing.Color.Transparent;
            this.matrixCircularProgressControl1.Interval = 60;
            this.matrixCircularProgressControl1.Location = new System.Drawing.Point(669, 1);
            this.matrixCircularProgressControl1.MinimumSize = new System.Drawing.Size(28, 28);
            this.matrixCircularProgressControl1.Name = "matrixCircularProgressControl1";
            this.matrixCircularProgressControl1.Rotation = logisTechBaseSys.MatrixCircularProgressControl.Direction.CLOCKWISE;
            this.matrixCircularProgressControl1.Size = new System.Drawing.Size(96, 72);
            this.matrixCircularProgressControl1.StartAngle = 270F;
            this.matrixCircularProgressControl1.TabIndex = 7;
            this.matrixCircularProgressControl1.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 502);
            this.Controls.Add(this.lblProducedCount);
            this.Controls.Add(this.lblToProduceCount);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.matrixCircularProgressControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "生产物流管理系统";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private GAW.AmazingProgressBar amazingProgressBar4;

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
        private logisTechBaseSys.MatrixCircularProgressControl matrixCircularProgressControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblToProduceCount;
        private System.Windows.Forms.Label lblProducedCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbltemp;
        private System.Windows.Forms.Label lblHuminity;
        private System.Windows.Forms.Label label7;
    }
}

