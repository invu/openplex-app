﻿using System.IO;
using System.Windows.Forms;
using WebCrunch;
using WebCrunch.Extensions;

namespace WebCrunch.Controls
{
    public partial class SplashScreen : UserControl
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timerCount_Tick(object sender, System.EventArgs e)
        {
            lblLoadingStuckRestart.Visible = true;
        }

        private void lblLoadingStuckRestart_Click(object sender, System.EventArgs e)
        {
            if (Directory.Exists(LocalExtensions.pathData)) { Directory.Delete(LocalExtensions.pathData, true); } Application.Restart();
        }
    }
}
