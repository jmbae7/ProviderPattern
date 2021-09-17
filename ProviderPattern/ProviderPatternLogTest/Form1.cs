using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProviderPatternLogTest.LogProvider;
using System.Configuration;

namespace ProviderPatternLogTest
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbLogType.SelectedIndex = 0;
        }

        private void btnDefaultProvider_Click(object sender, EventArgs e)
        {
            MessageBox.Show(LogProviderManager.Default.Name);
        }

        private void btnTotalProvider_Click(object sender, EventArgs e)
        {
            MessageBox.Show(LogProviderManager.Providers.Count.ToString());
        }

        private void btnGetAllDetail_Click(object sender, EventArgs e)
        {

            StringBuilder str = new StringBuilder();

            foreach (ProviderSettings setting in LogProviderManager.ProviderSettings)
            {
                var setStr = GetSetting(setting);

                str.AppendLine(setStr);
            }
           
            MessageBox.Show(str.ToString());
        
        }

        private void btnDefaultDetail_Click(object sender, EventArgs e)
        {
            var defaultName = LogProviderManager.Default.Name;

            var setting = LogProviderManager.ProviderSettings[defaultName];
            var setStr = GetSetting(setting);

            MessageBox.Show(setStr);

        }

        private void btnDefaultFilePath_Click(object sender, EventArgs e)
        {
            var defaultName = LogProviderManager.Default.Name;

            var setting = LogProviderManager.ProviderSettings[defaultName];

            var setStr = setting.Parameters["fileLocation"];

            MessageBox.Show(setStr);
        }

        private void btnStAdd_Click(object sender, EventArgs e)
        {
            LogType logType = (LogType)cmbLogType.SelectedIndex;
         
            LogProviderManager.Default.WriteLog(logType, txtMessage.Text);

            MessageBox.Show("Log Saved");

        }

        private string GetSetting(ProviderSettings setting)
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine(string.Format("Default Provider name: {0}", setting.Name));
            str.AppendLine(string.Format("Default Provider type: {0}", setting.Type));
            str.AppendLine("------------------Parameters--------------------");
            foreach (String s in setting.Parameters)
            {

                str.AppendLine(string.Format("Parameter: {0} -> {1}", s, setting.Parameters.Get(s)));
            }
            str.AppendLine("---------------------------------------");
            str.AppendLine("");

            return str.ToString();
        }

    }
}
