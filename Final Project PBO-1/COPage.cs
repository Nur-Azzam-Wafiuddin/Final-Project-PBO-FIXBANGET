﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_PBO_1
{
    public partial class COPage : Form
    {
        public COPage()
        {
            InitializeComponent();
        }

        private void COPage_Load(object sender, EventArgs e)
        {
            for(int i=0; i<18; i++)
            {
                CheckOut CheckList = new Final_Project_PBO_1.CheckOut();
                this.panel3.Controls.Add(CheckList);

                CheckList.Location = new System.Drawing.Point(93, 171+(i*50));
                CheckList.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
                CheckList.Name = "checkOut3";
                CheckList.Size = new System.Drawing.Size(596, 41);
                CheckList.TabIndex = i;
            }
            
        }

        private void checkOut1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
