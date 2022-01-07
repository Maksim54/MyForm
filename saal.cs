﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyVorm
{
    public partial class saal : Form
    {
        
        TableLayoutPanel tlp = new TableLayoutPanel();
        Button btn_tabel;
        public saal(int read, int kohad)
        {
            this.tlp.ColumnCount = kohad;
            this.tlp.RowCount = read;
            this.tlp.ColumnStyles.Clear();
            this.tlp.RowStyles.Clear();
            int i, j;
            for (i = 0; i < read; i++)
            {
                this.tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / read));
            }
            for (i = 0; i < kohad; i++)
            {
                this.tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / kohad));
            }
            this.Size = new System.Drawing.Size(kohad * 100, read * 100);
            for (int r = 0; r < read; r++)
            {
                for (int k = 0; k < kohad; k++)
                {
                    btn_tabel = new Button
                    {
                        Text = String.Format($"{r + 1}{k + 1}"),
                        Name = String.Format($"btn_{r}{k}"),
                        Dock = DockStyle.Fill
                    };
                    this.tlp.Controls.Add(btn_tabel, k, r);
                }
            }
            //btn_w = (int)(100 / kohad);
            //btn_h = (int)(100 / read);
            this.tlp.Dock = DockStyle.Fill;
            //this.tlp.Size = new System.Drawing.Size(tlp.ColumnCount*btn_w*3,tlp.RowCount * btn_h*2);
            this.Controls.Add(tlp);

        }
    }
}
