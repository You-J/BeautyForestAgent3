using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BeautyForestAgent
{
    public partial class FormOpinion : Form
    {
        public FormOpinion()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("건의사항이 보내졌습니다.", "건의사항 발송");
            this.Close();
        }

        private void TsbtnFont_Click(object sender, EventArgs e)
        {
            DialogResult result = this.fontDialog1.ShowDialog(); 
            switch (result)
            {

                case DialogResult.OK:
                    this.richTextBox1.SelectionFont = this.fontDialog1.Font;
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("폰트 변경이 취소 되었습니다.", "알림");
                    break;
            }

        }

        private void TsbtnColor_Click(object sender, EventArgs e)
        {
            DialogResult result = this.colorDialog1.ShowDialog();
            switch (result)
            {

                case DialogResult.OK:
                    this.richTextBox1.SelectionColor = this.colorDialog1.Color;
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("색상 변경이 취소 되었습니다.", "알림");
                    break;
            }
        }
    }
}
