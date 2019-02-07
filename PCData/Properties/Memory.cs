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
    public partial class Memory : Form
    {
        public Memory()
        {
            InitializeComponent();
        }
        private void Memory_Load(object sender, EventArgs e)
        {
            CollectingData loadForm = new CollectingData();
            loadForm.Show();
            int slotCount = CPInfo.GetHardwareInfo("Win32_PhysicalMemory", "MaxVoltage").Count;
            textBox1.Text = "" + slotCount;
            richTextBox1.Height = 21 * slotCount;
            richTextBox1.Text = GenerateResult(CPInfo.GetHardwareInfo("Win32_PhysicalMemory", "Capacity"), "bytes");
            richTextBox2.Height = 21 * slotCount;
            richTextBox2.Text = GenerateResult(CPInfo.GetHardwareInfo("Win32_PhysicalMemory", "ConfiguredClockSpeed"), "MHz");
            richTextBox3.Height = 21 * slotCount;
            richTextBox3.Text = GenerateResult(CPInfo.GetHardwareInfo("Win32_PhysicalMemory", "MinVoltage"), "B");
            richTextBox4.Height = 21 * slotCount;
            richTextBox4.Text = GenerateResult(CPInfo.GetHardwareInfo("Win32_PhysicalMemory", "MaxVoltage"), "B");
            richTextBox5.Height = 21 * slotCount;
            richTextBox5.Text = GenerateResult(CPInfo.GetHardwareInfo("Win32_PhysicalMemory", "DeviceLocator"), "");
            richTextBox6.Height = 21 * slotCount;
            richTextBox6.Text = GenerateResult(CPInfo.GetHardwareInfo("Win32_PhysicalMemory", "Manufacturer"), "");
            richTextBox7.Height = 21 * slotCount;
            richTextBox7.Text = GenerateResult(CPInfo.GetHardwareInfo("Win32_PhysicalMemory", "SerialNumber"), "");
            richTextBox8.Height = 21 * slotCount;
            richTextBox8.Text = GenerateResult(CPInfo.GetHardwareInfo("Win32_PhysicalMemory", "FormFactor"), "");
            loadForm.Close();
        }
        private string GenerateResult(List<string> result, string data)
        {
            string output = "";
            if (result.Count > 1)
            {
                for (int i = 0; i < result.Count; i++)
                    output += $"Slot #{i+1} - {result[i]} {data}\n";
            }
            else output = result[0];
            return output;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            PCData main = new PCData();
            main.Show();
        }
    }
}
