using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCData.Properties
{
    public partial class DynamicParams : Form
    {
        public DynamicParams()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox4.Text = CPInfo.OutputResult(CPInfo.GetHardwareInfo("Win32_Processor", "LoadPercentage")) + "%";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            textBox1.Text = CPInfo.OutputResult(CPInfo.GetHardwareInfo("Win32_Processor", "CurrentClockSpeed")) + " MHz";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DynamicParams_Load(object sender, EventArgs e)
        {
            textBox4.Text = CPInfo.OutputResult(CPInfo.GetHardwareInfo("Win32_Processor", "LoadPercentage")) + "%";
            textBox1.Text = CPInfo.OutputResult(CPInfo.GetHardwareInfo("Win32_Processor", "CurrentClockSpeed")) + " MHz";
        }
    }
}
