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
    public partial class Graphics : Form
    {
        public Graphics()
        {
            InitializeComponent();
        }

        private void Graphics_Load(object sender, EventArgs e)
        {
            CollectingData loadForm = new CollectingData();
            loadForm.Show();
            int adapterRAM = Convert.ToInt32(CPInfo.OutputResult(CPInfo.GetHardwareInfo("Win32_VideoController", "AdapterRAM"))) / 1000000000;
            textBox1.Text = CPInfo.OutputResult(CPInfo.GetHardwareInfo("Win32_VideoController", "Name"));
            textBox2.Text = CPInfo.OutputResult(CPInfo.GetHardwareInfo("Win32_VideoController", "VideoProcessor"));
            textBox3.Text = CPInfo.OutputResult(CPInfo.GetHardwareInfo("Win32_VideoController", "AdapterCompatibility"));
            textBox5.Text = CPInfo.OutputResult(CPInfo.GetHardwareInfo("Win32_VideoController", "AdapterDACType"));
            textBox6.Text = CPInfo.OutputResult(CPInfo.GetHardwareInfo("Win32_VideoController", "CurrentHorizontalResolution"));
            textBox7.Text = CPInfo.OutputResult(CPInfo.GetHardwareInfo("Win32_VideoController", "CurrentNumberOfColors"));
            textBox10.Text = CPInfo.OutputResult(CPInfo.GetHardwareInfo("Win32_VideoController", "CurrentVerticalResolution"));
            textBox9.Text = CPInfo.OutputResult(CPInfo.GetHardwareInfo("Win32_VideoController", "DriverVersion"));
            textBox4.Text = ""+adapterRAM+" Gb";
            textBox8.Text = MotherBoard.GetDate(CPInfo.OutputResult(CPInfo.GetHardwareInfo("Win32_VideoController", "DriverDate")));
            textBox11.Text = CPInfo.OutputResult(CPInfo.GetHardwareInfo("Win32_VideoController", "CurrentBitsPerPixel")) + " Kb";
            textBox13.Text = CPInfo.OutputResult(CPInfo.GetHardwareInfo("Win32_VideoController", "MaxRefreshRate")) + " fps";
            textBox12.Text = CPInfo.OutputResult(CPInfo.GetHardwareInfo("Win32_VideoController", "MinRefreshRate")) + " fps";
            loadForm.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            PCData main = new PCData();
            main.Show();
        }
    }
}
