using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpLauncher.Source;

namespace SharpLauncher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Set Form
            this.Text = Global.windowName;

            this.Width = Global.windowWidth;
            this.Height = Global.windowHeight;

            if (Global.centerOnStart) this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
