using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem01
{
    public partial class UCTest01 : UserControl
    {
        public UCTest01()
        {
            InitializeComponent();
        }

        private void uiTextBox1_Load(object sender, EventArgs e)
        {
            uiTextBox1.Text = "ABC abc 123 测试";
        }
    }
}
