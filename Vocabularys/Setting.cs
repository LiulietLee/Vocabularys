using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vocabularys
{
    public partial class Setting : Form
    {
        private int chineseTimeLeft;
        private int englishTimeLeft;

        public Setting()
        {
            InitializeComponent();

            Encoding.GetEncoding("gb2312");
            String[] lines = System.IO.File.ReadAllLines(@"texts/Setting.txt", Encoding.Default);

            chineseTimeLeft = Int16.Parse(lines[0]);
            englishTimeLeft = Int16.Parse(lines[1]);

            ChineseNumericUpDown.Value = chineseTimeLeft;
            EnglishNumericUpDown.Value = englishTimeLeft;

            ChineseNumericUpDown.Minimum = 3;
            EnglishNumericUpDown.Minimum = 3;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            chineseTimeLeft = Convert.ToInt16(ChineseNumericUpDown.Value);
            englishTimeLeft = Convert.ToInt16(EnglishNumericUpDown.Value);

            string[] setting = { chineseTimeLeft.ToString(), englishTimeLeft.ToString() };
            System.IO.File.WriteAllLines(@"texts/Setting.txt", setting);
            this.Close();
        }
    }
}
