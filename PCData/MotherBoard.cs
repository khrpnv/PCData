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
    public partial class MotherBoard : Form
    {
        public MotherBoard()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public static string GetDate(string date)
        {
            string cutDate = date.Substring(0, 8);
            string result = "" + cutDate[6] + "" + cutDate[7] + "/" + cutDate[4] + "" + cutDate[5] + "/" + cutDate[0] + "" + cutDate[1] + "" + cutDate[2] + "" + cutDate[3];
            return result;
        }

        private void MotherBoard_Load(object sender, EventArgs e)
        {
            CollectingData loadForm = new CollectingData();
            loadForm.Show();
            textBox6.Text = CPInfo.OutputResult(CPInfo.GetHardwareInfo("Win32_BaseBoard", "Manufacturer"));
            textBox5.Text = CPInfo.OutputResult(CPInfo.GetHardwareInfo("Win32_BaseBoard", "Product"));
            textBox4.Text = CPInfo.OutputResult(CPInfo.GetHardwareInfo("Win32_BaseBoard", "Version"));
            textBox11.Text = CPInfo.OutputResult(CPInfo.GetHardwareInfo("Win32_BaseBoard", "SerialNumber"));
            textBox9.Text = CPInfo.OutputResult(CPInfo.GetHardwareInfo("Win32_BIOS", "Manufacturer"));
            textBox8.Text = GetDate(CPInfo.OutputResult(CPInfo.GetHardwareInfo("Win32_BIOS", "ReleaseDate")));
            textBox7.Text = CPInfo.OutputResult(CPInfo.GetHardwareInfo("Win32_BIOS", "Description"));
            textBox10.Text = CPInfo.OutputResult(CPInfo.GetHardwareInfo("Win32_BIOS", "SerialNumber"));
            loadForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            PCData main = new PCData();
            main.Show();
        }
    }
}
