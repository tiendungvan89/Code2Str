using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code2Str
{
    public partial class Code2Str : Form
    {
        private const char ROW_SEPARATOR = '\n';
        public Code2Str()
        {
            InitializeComponent();
        }

        private void tsConvert_Click(object sender, EventArgs e)
        {
            int maxLength = GetMaxLength() + 4;
            string prefix = "wSql.Append(\" ";
            string suffix = "\")";
            rtbDst.Clear();

            for (int i = 0; i < this.rtbSrc.Lines.Length; i++)
            {
                string row = this.rtbSrc.Lines[i];
                if (row != null)
                {
                    row = row.PadRight(maxLength, ' ');
                    rtbDst.AppendText(string.Format("{0}{1}{2}\n", prefix, row, suffix));
                }
            }
        }

        private int GetMaxLength()
        {
            int rs = 0;
            for (int i = 0; i < this.rtbSrc.Lines.Length; i++)
            {
                int rowLength = this.rtbSrc.Lines[i].Length;
                if (rowLength > rs)
                {
                    rs = rowLength;
                }
            }
            return rs;
        }

        private void tsClear_Click(object sender, EventArgs e)
        {
            rtbDst.Clear();
            rtbSrc.Clear();
        }
    }
}
