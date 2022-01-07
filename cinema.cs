using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyVorm
{
    public partial class cinema :Form
    {
        public cinema()
        {
            this.Size = new System.Drawing.Size(200,150);
            this.BackColor = Color.Crimson;
            Button room_btn = new Button
            {
                Text = "Choose any seat to rent it",
                Location = new System.Drawing.Point(20, 60),
                Size = new Size(85,40)
                
            };
            room_btn.BackColor = Color.White;
            room_btn.Click += Room_btn_Click;
            this.Controls.Add(room_btn);
            Label lbl = new Label()
            {
                Text = "Welcome to the cinema",
                Location = new System.Drawing.Point(20,20),
                Size = new Size(100, 40)
            };
            this.Controls.Add(lbl);

        }

        private void Room_btn_Click(object sender, EventArgs e)
        {
            room room = new room("Cinema", "Choose hall size", "Small", "Medium", "Huge");
            room.StartPosition = FormStartPosition.CenterScreen;
            room.ShowDialog();
        }
    }
}
