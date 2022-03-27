
namespace Problem01
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.uiButton1 = new Sunny.UI.UIButton();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.ucTest011 = new Problem01.UCTest01();
            this.SuspendLayout();
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Location = new System.Drawing.Point(442, 52);
            this.uiButton1.Margin = new System.Windows.Forms.Padding(5);
            this.uiButton1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(167, 61);
            this.uiButton1.TabIndex = 1;
            this.uiButton1.Text = "ABCabc123";
            this.uiButton1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // formsPlot1
            // 
            this.formsPlot1.Location = new System.Drawing.Point(14, 14);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(5);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(400, 277);
            this.formsPlot1.TabIndex = 2;
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Location = new System.Drawing.Point(442, 137);
            this.uiButton2.Margin = new System.Windows.Forms.Padding(5);
            this.uiButton2.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(167, 61);
            this.uiButton2.TabIndex = 3;
            this.uiButton2.Text = "测试按钮";
            this.uiButton2.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // ucTest011
            // 
            this.ucTest011.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucTest011.Location = new System.Drawing.Point(37, 314);
            this.ucTest011.Margin = new System.Windows.Forms.Padding(5);
            this.ucTest011.Name = "ucTest011";
            this.ucTest011.Size = new System.Drawing.Size(628, 137);
            this.ucTest011.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ucTest011);
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.formsPlot1);
            this.Controls.Add(this.uiButton1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton uiButton1;
        private ScottPlot.FormsPlot formsPlot1;
        private Sunny.UI.UIButton uiButton2;
        private UCTest01 ucTest011;
    }
}

