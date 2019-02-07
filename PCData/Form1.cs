using PCData.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCData
{
    public partial class PCData : Form
    {
        public PCData()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CPInfo cp_info = new CPInfo();
            cp_info.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MotherBoard motherBorad_info = new MotherBoard();
            motherBorad_info.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Graphics graphics_info = new Graphics();
            graphics_info.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            GeneralInfo general_info = new GeneralInfo();
            general_info.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Memory memory_info = new Memory();
            memory_info.Show();
        }
    }
}
