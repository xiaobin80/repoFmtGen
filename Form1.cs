using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using repoInfoLib;

namespace repoFmtGen
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            // clear TextBox
            edtAck.Text = "";
            edtInq.Text = "";

            
            repoInfoLib.RepoFmtClass report = new RepoFmtClass();
            Array retAck = report.getAckRepo((uint)Int32.Parse(edtStation.Text));

            foreach (Byte bt in retAck)
                edtAck.Text += "0x" + bt.ToString("X2") + " ";

            Array retInq = report.getInqRepo((uint)Int32.Parse(edtStation.Text));

            foreach (Byte bt in retInq)
                edtInq.Text += "0x" + bt.ToString("X2") + " ";
        }
    }
}