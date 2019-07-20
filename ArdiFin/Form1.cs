using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace RDPdemo
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string address = remoteConnectionAddressCB.Text;
            string username = remoteUsernameTB.Text;
            string password = remotePasswordTB.Text;
            string filename = rdpFileNameTB.Text.Trim()+".rdp";

            remoteConnectionAddressCB.Items.Add(address);

            var TemplateStr = RDPdemo.Properties.Resources.TemplateRDP;
            var pwstr = BitConverter.ToString(DataProtection.ProtectData(Encoding.Unicode.GetBytes(password), ""));
            pwstr = pwstr.Replace("-", "");
            var NewStr = TemplateStr.Replace("{#address}", address).Replace("{#username}", username).Replace("{#password}", pwstr);
            StreamWriter sw = new StreamWriter(filename);
            sw.Write(NewStr);
            sw.Close();
            ProcCmd(filename);
        }

        void ProcCmd(string rdpFilename)
        {
            // this will create the usual mstsc / rdp window
            // despite setting the parent window, it seems to be uncontrollable so far
            Process mstsc = new Process();
            mstsc.StartInfo = new ProcessStartInfo()
            {
                FileName = "mstsc.exe",
                WindowStyle = ProcessWindowStyle.Normal,
                Arguments = rdpFilename
            };

            mstsc.Start();
            mstsc.WaitForInputIdle(3333);

            SetParent(mstsc.MainWindowHandle, this.Handle);
        }
    }
}
