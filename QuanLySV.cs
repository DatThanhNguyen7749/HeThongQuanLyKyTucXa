using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyKyTucXa
{
    public partial class QuanLySV : Form
    {
        Form formTruoc;
        public QuanLySV(Form formBefore)
        {
            InitializeComponent();
            formTruoc = formBefore;
        }

        private void QuanLySV_FormClosed(object sender, FormClosedEventArgs e)
        {
            formTruoc.Show();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxHoten.Clear();
            textBoxEmail.Clear();
            textBoxCCCD.Clear();
            textBoxDiachi.Clear();
            textBoxCha.Clear();
            textBoxMe.Clear();
            textBoxSDT.Clear();
            comboBoxSoPhong.ResetText();
            comboBoxTinhTrang.ResetText();
        }
    }
}
