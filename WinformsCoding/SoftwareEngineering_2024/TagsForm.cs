﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEngineering_2024
{
    public partial class TagsForm : Form
    {
        public TagsForm()
        {
            InitializeComponent();
            FbLink.Click += Opener.OpenFacebook;
            GmapLink.Click += Opener.OpenGoogleMaps;
            IgLink.Click += Opener.OpenInstagram;
            LogInLink.Click += LogInLink_Click; 
        }

        private void LogInLink_Click(object? sender, EventArgs e)
        {
            Opener.OpenDialog(typeof(LoginForm), "loginForm", this);
            throw new NotImplementedException();
        }
    }
}
