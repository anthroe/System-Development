﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class filterList : Form
    {
        public static ListView filters;

        public filterList()
        {
            InitializeComponent();

            filters = filterListView;
        }

        private void filterList_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }
    }
}
