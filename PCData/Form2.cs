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
    public partial class GeneralInfo : Form
    {
        public GeneralInfo()
        {
            InitializeComponent();
        }

        private void GeneralInfo_Load(object sender, EventArgs e)
        {
            long ROM = 0;
            ROM = (long)Convert.ToUInt64(CPInfo.OutputResult(CPInfo.GetHardwareInfo("Win32_DiskDrive", "Size")));
            ROM = ROM / 1000000000;
            CollectingData loadForm = new CollectingData();
            loadForm.Show();
            textBox1.Text = ""+Environment.OSVersion;
            textBox2.Text = ""+Environment.MachineName;
            textBox3.Text = ""+Environment.ProcessorCount;
            textBox4.Text = ""+Environment.SystemDirectory;
            textBox5.Text = String.Join(", ", Environment.GetLogicalDrives())
              .TrimEnd(',', ' ')
              .Replace("\\", String.Empty);
            textBox6.Text = "" + ROM + " Gb";
            textBox7.Text = CPInfo.OutputResult(CPInfo.GetHardwareInfo("Win32_VideoController", "Name"));
            textBox8.Text = "" + GetTotalMemoryInBytes() + " GB";
            loadForm.Close();
        }
        static ulong GetTotalMemoryInBytes()
        {
            return new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory/1000000000;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            PCData main = new PCData();
            main.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
