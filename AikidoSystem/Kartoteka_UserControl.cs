﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AikidoSystem
{
    public partial class Kartoteka_UserControl : UserControl
    {
        private static Kartoteka_UserControl instance = null;

        public static Kartoteka_UserControl Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Kartoteka_UserControl();
                }
                return instance;
            }
        }
        public Kartoteka_UserControl()
        {
            InitializeComponent();
        }

        private void button_M1_Click(object sender, EventArgs e)
        {

        }
    }
}
