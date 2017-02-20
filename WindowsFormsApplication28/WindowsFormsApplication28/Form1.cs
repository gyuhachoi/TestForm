using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication28
{
    public class Dummy
    {
        public int dummy1 = 0;
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        void Form1_Load(object sender, EventArgs e)
        {
            // struct, value
            // class, reference
            int value = 0;

            ChangeValue(value);
            Debug.WriteLine("value: " + value); // 0

            Dummy dummy = new Dummy();
            ChangeValue2(dummy);
            Debug.WriteLine("dummy.dummy1: " + dummy.dummy1); // 10
        }

        public void ChangeValue(int param)
        {
            param = 10;
        }

        public void ChangeValue2(Dummy param)
        {
            param.dummy1 = 10;
        }
    }
}
