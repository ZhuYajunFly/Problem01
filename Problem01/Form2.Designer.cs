
namespace Problem01
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiButton2 = new Sunny.UI.UIButton();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.ucTest011 = new Problem01.UCTest01();
            this.SuspendLayout();
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Location = new System.Drawing.Point(496, 187);
            this.uiButton2.Margin = new System.Windows.Forms.Padding(5);
            this.uiButton2.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(167, 61);
            this.uiButton2.TabIndex = 5;
            this.uiButton2.Text = "测试按钮";
            this.uiButton2.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Location = new System.Drawing.Point(496, 102);
            this.uiButton1.Margin = new System.Windows.Forms.Padding(5);
            this.uiButton1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(167, 61);
            this.uiButton1.TabIndex = 4;
            this.uiButton1.Text = "ABCabc123";
            this.uiButton1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // formsPlot1
            // 
            this.formsPlot1.Location = new System.Drawing.Point(19, 54);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(400, 277);
            this.formsPlot1.TabIndex = 6;
            // 
            // ucTest011
            // 
            this.ucTest011.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucTest011.Location = new System.Drawing.Point(53, 360);
            this.ucTest011.Margin = new System.Windows.Forms.Padding(5);
            this.ucTest011.Name = "ucTest011";
            this.ucTest011.Size = new System.Drawing.Size(572, 109);
            this.ucTest011.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.ucTest011);
            this.Controls.Add(this.formsPlot1);
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.uiButton1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIButton uiButton1;
        private ScottPlot.FormsPlot formsPlot1;
        private UCTest01 ucTest011;
    }
}