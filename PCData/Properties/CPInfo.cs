using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Timers;

namespace PCData.Properties
{
    public partial class CPInfo : Form
    {
        BackgroundWorker bw = new BackgroundWorker();
        public CPInfo()
        {
            InitializeComponent();
        }
        public static string OutputResult(List<string> result)
        {
            string infoString="";
            if (result.Count > 0)
            {
                for (int i = 0; i < result.Count; ++i)
                    infoString+=result[i]+"\n";
            }
            return infoString;
        }
        public static List<string> GetHardwareInfo(string WIN32_Class, string ClassItemField)
        {
            List<string> result = new List<string>();

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM " + WIN32_Class);

            try
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    result.Add(obj[ClassItemField].ToString().Trim());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }
        private static string GetData(String[] parametrs)
        {
            string result = "";
            for (int i = 0; i < parametrs.Length - 2; i++)
                result += parametrs[i] + " ";
            return result;
        }
        private void CPInfo_Load(object sender, EventArgs e)
        {
            CollectingData loadForm = new CollectingData();
            loadForm.Show();
            string cpName = OutputResult(GetHardwareInfo("Win32_Processor", "Name"));
            String[] parametrs = cpName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            textBox1.Text = GetData(parametrs);
            textBox2.Text = OutputResult(GetHardwareInfo("Win32_Processor", "Manufacturer"));
            textBox6.Text = OutputResult(GetHardwareInfo("Win32_Processor", "Name"));
            textBox5.Text = OutputResult(GetHardwareInfo("Win32_Processor", "MaxClockSpeed")) + " MHz";
            textBox3.Text = OutputResult(GetHardwareInfo("Win32_Processor", "CurrentVoltage")) + " B";
            if (OutputResult(GetHardwareInfo("Win32_Processor", "L1CacheSize")).Length < 1)
            {
                textBox7.Text = "-";
            }
            else textBox7.Text = OutputResult(GetHardwareInfo("Win32_Processor", "L1CacheSize"));
            textBox8.Text = OutputResult(GetHardwareInfo("Win32_Processor", "L2CacheSize")) + " Kb";
            textBox9.Text = OutputResult(GetHardwareInfo("Win32_Processor", "L3CacheSize")) + " Kb";
            textBox10.Text = OutputResult(GetHardwareInfo("Win32_Processor", "NumberOfCores"));
            textBox11.Text = OutputResult(GetHardwareInfo("Win32_Processor", "AddressWidth")) + " bits";
            textBox13.Text = OutputResult(GetHardwareInfo("Win32_Processor", "NumberOfLogicalProcessors"));
            textBox14.Text = OutputResult(GetHardwareInfo("Win32_Processor", "ExtClock")) + " MHz";
          
            loadForm.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            PCData main = new PCData();
            main.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DynamicParams dynamic_info = new DynamicParams();
            dynamic_info.Show();
        }
    }
}
