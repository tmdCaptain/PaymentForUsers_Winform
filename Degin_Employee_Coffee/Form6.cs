﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degin_Employee_Coffee
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        int value;
        double giatri;

        private void btnOk_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(" Loại coffee mà bạn đã chọn là : " + "Espresso");
            value = int.Parse(txtSl.Text);
            listBox1.Items.Add(" Số lượng mà bạn đã chọn là : " + value.ToString());
            giatri = 30000 * value;
            listBox1.Items.Add(" Giá tiền bạn cần thanh toán : " + giatri.ToString() + "vnđ");
            listBox1.Items.Add(" Ngày đặt Coffe : " + DateTime.Now);
        }
    }
}