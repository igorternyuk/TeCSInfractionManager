using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using model;

namespace View
{
    public partial class MainWindow : Form
    {
        private Data data;
        public MainWindow()
        {
            InitializeComponent();
            data = new Data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableInfractions.DataSource = data.ReadAll();
        }
    }
}
