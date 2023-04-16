using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plisjdbioskop
{
    public partial class spiritaway : Form
    {
        Panel spirit = new Panel();
        List<Button> buttonlistjam1 = new List<Button>();
        List<Button> buttonlistjam2 = new List<Button>();
        List<Button> buttonlistjam3 = new List<Button>();
        int nambah = 0;
        int b = 0;
        int c = 0;
        int chosen = 0;
        int chooseeat = 0;
        Random seat = new Random();
        Label seatnumbers = new Label();
        public spiritaway()
        {
            InitializeComponent();
        }

        private void spiritaway_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FloralWhite;
            spirit.Location = new Point(340, 25);
            spirit.Name = "panel1";
            spirit.Size = new Size(280, 300);
            spirit.TabIndex = 0;
            spirit.BackColor = Color.DarkRed;
            Controls.Add(spirit);

            Label movie1 = new Label();
            movie1.AutoSize = true;
            movie1.Location = new Point(28, 20);
            movie1.Text = "Spirited Away";
            movie1.Size = new Size(200, 200);
            movie1.TabIndex = 1;
            Controls.Add(movie1);


            PictureBox picture = new PictureBox();
            picture.Location = new Point(28, 36);
            picture.Size = new Size(200, 320);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.Image = Image.FromFile(@"C:\Users\surab\source\repos\plisjdbioskop\plisjdbioskop\Poster\e96b650f0c9d3a9b5eec2bf12725f447.jpg");
            this.Controls.Add(picture);


            seatnumbers.AutoSize = true;
            seatnumbers.Location = new Point(390, 380);
            seatnumbers.Name = "Seat Choose ";
            seatnumbers.Size = new Size(300, 300);
            seatnumbers.TabIndex = 1;
            seatnumbers.Text = "Seat Choose ";
            Controls.Add(seatnumbers);
            seatnumbers.Click += seats_Click;


            Button reset = new Button();
            reset.Location = new Point(390, 330);
            reset.Size = new Size(150, 24);
            reset.BackColor = Color.White;
            reset.TabIndex = 5;
            reset.Text = "OK";
            reset.UseVisualStyleBackColor = false;
            Controls.Add(reset);
            reset.Click += Reset_Click;


            Button oke = new Button();
            oke.Location = new Point(390, 350);
            oke.Size = new Size(150, 24);
            oke.BackColor = Color.White;
            oke.TabIndex = 5;
            oke.Text = "Reset";
            oke.UseVisualStyleBackColor = false;
            Controls.Add(oke);
            oke.Click += Oke_Click;

            Button jam1 = new Button();
            jam1.Location = new Point(260, 100);
            jam1.Size = new Size(50, 25);
            jam1.TabIndex = 2;
            jam1.Text = "11.00";
            jam1.UseVisualStyleBackColor = false;
            Controls.Add(jam1);
            jam1.Click += Jam1_Click;


            Button jam2 = new Button();
            jam2.Location = new Point(260, 160);
            jam2.Size = new Size(50, 25);
            jam2.TabIndex = 3;
            jam2.Text = "13.00";
            jam2.UseVisualStyleBackColor = false;
            Controls.Add(jam2);
            jam2.Click += Jam2_Click;


            Button jam3 = new Button();
            jam3.Location = new Point(260, 220);
            jam3.Size = new Size(50, 25);
            jam3.TabIndex = 4;
            jam3.Text = "15.00";
            jam3.UseVisualStyleBackColor = false;
            Controls.Add(jam3);
            jam3.Click += Jam3_Click;

            

            spirit.Controls.Clear();
            for (int i = 0; i < 10; i++)
            {
                for (int a = 0; a < 10; a++)
                {
                    Button button3 = new Button();
                    button3.Tag = "(" + a.ToString() + "," + i.ToString() + ") ";
                    button3.Size = new Size(27, 27);
                    button3.Location = new Point(4 + b, 8 + c);
                    button3.BackColor = Color.MediumSeaGreen;
                    button3.Click += Button3_Click;
                    buttonlistjam3.Add(button3);
                    nambah++;
                    b += 27;
                }
                b = 0;
                c += 27;
            }


            for (int i = 0; i < 70; i++)
            {
                int acak = seat.Next(0, 100);
                buttonlistjam3[acak].BackColor = Color.Red;
                buttonlistjam3[acak].Enabled = false;
            }


            b = 0;
            c = 0;
            spirit.Controls.Clear();
            for (int i = 0; i < 10; i++)
            {
                for (int a = 0; a < 10; a++)
                {
                    Button button2 = new Button();
                    button2.Tag = "(" + a.ToString() + "," + i.ToString() + ") ";
                    button2.Size = new Size(27, 27);
                    button2.Location = new Point(4 + b, 8 + c);
                    button2.BackColor = Color.MediumSeaGreen;
                    button2.Click += Button2_Click;
                    buttonlistjam2.Add(button2);
                    nambah++;
                    b += 27;
                }
                b = 0;
                c += 27;
            }


            for (int i = 0; i < 70; i++)
            {
                int acak = seat.Next(0, 100);
                buttonlistjam2[acak].BackColor = Color.Red;
                buttonlistjam2[acak].Enabled = false;
            }


            b = 0;
            c = 0;
            spirit.Controls.Clear();
            for (int i = 0; i < 10; i++)
            {
                for (int a = 0; a < 10; a++)
                {
                    Button button1 = new Button();
                    button1.Tag = "(" + a.ToString() + "," + i.ToString() + ") ";
                    button1.Size = new Size(27, 27);
                    button1.Location = new Point(4 + b, 8 + c);
                    button1.BackColor = Color.MediumSeaGreen;
                    button1.Click += Button1_Click;
                    buttonlistjam1.Add(button1);
                    nambah++;
                    b += 27;
                }
                b = 0;
                c += 27;
            }

            for (int i = 0; i < 70; i++)
            {
                int acak = seat.Next(0, 100);
                buttonlistjam1[acak].BackColor = Color.Red;
                buttonlistjam1[acak].Enabled = false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            spirit.Controls.Clear();

            foreach (Button seat in buttonlistjam1)
            {
                spirit.Controls.Add(seat);
            }
            Button button = sender as Button;
            if (button.BackColor == Color.MediumSeaGreen)
            {
                button.BackColor = Color.YellowGreen;
                seatnumbers.Text += button.Tag.ToString();
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            spirit.Controls.Clear();

            foreach (Button seat in buttonlistjam2)
            {
                spirit.Controls.Add(seat);
            }
            Button button = sender as Button;
            if (button.BackColor == Color.MediumSeaGreen)
            {
                button.BackColor = Color.YellowGreen;
                seatnumbers.Text += button.Tag.ToString();
            }
        }

        public void Button3_Click(object sender, EventArgs e)
        {
            spirit.Controls.Clear();

            foreach (Button seat in buttonlistjam3)
            {
                spirit.Controls.Add(seat);
            }
            Button button = sender as Button;
            if (button.BackColor == Color.MediumSeaGreen)
            {
                button.BackColor = Color.YellowGreen;
                seatnumbers.Text += button.Tag.ToString();
            }
        }

        private void Oke_Click(object sender, EventArgs e)
        {
            if (chooseeat == 1)
            {
                foreach (Button button in buttonlistjam1)
                {
                    if (button.BackColor == Color.YellowGreen)
                    {
                        button.BackColor = Color.MediumSeaGreen;

                    }
                    if (button.BackColor == Color.Red)
                    {

                        button.BackColor = Color.MediumSeaGreen;
                        button.Enabled = true;
                        seatnumbers.Text = "Seat Choose : ";
                    }
                }
            }

            if (chooseeat == 2)
            {
                foreach (Button button in buttonlistjam2)
                {
                    if (button.BackColor == Color.YellowGreen)
                    {
                        button.BackColor = Color.MediumSeaGreen;

                    }
                    if (button.BackColor == Color.Red)
                    {

                        button.BackColor = Color.MediumSeaGreen;
                        button.Enabled = true;
                        seatnumbers.Text = "Seat Choose : ";
                    }
                }
            }

            if (chooseeat == 3)
            {
                foreach (Button button in buttonlistjam3)
                {
                    if (button.BackColor == Color.YellowGreen)
                    {
                        button.BackColor = Color.MediumSeaGreen;

                    }
                    if (button.BackColor == Color.Red)
                    {

                        button.BackColor = Color.MediumSeaGreen;
                        button.Enabled = true;
                        seatnumbers.Text = "Seat Choose: ";
                    }
                }
            }

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            if (chosen == 1)
            {
                foreach (Button button in buttonlistjam1)
                {
                    if (button.BackColor == Color.YellowGreen)
                    {
                        button.BackColor = Color.Red;
                        button.Enabled = false;
                    }
                    else
                    if (button.BackColor == Color.YellowGreen)
                    {
                        button.BackColor = Color.MediumSeaGreen;
                    }
                }
            }
            if (chosen == 2)
            {
                foreach (Button button in buttonlistjam2)
                {
                    if (button.BackColor == Color.YellowGreen)
                    {
                        button.BackColor = Color.Red;
                        button.Enabled = false;
                    }
                }
            }
            if (chosen == 3)
            {
                foreach (Button button in buttonlistjam3)
                {
                    if (button.BackColor == Color.YellowGreen)
                    {
                        button.BackColor = Color.Red;
                        button.Enabled = false;
                    }
                }
            }
        }

        private void seats_Click(object sender, EventArgs e)
        {

        }



        public void Jam3_Click(object sender, EventArgs e)
        {
            spirit.Controls.Clear();
            chosen = 3;
            chooseeat = 3;
            foreach (Button seat in buttonlistjam3)
            {
                spirit.Controls.Add(seat);
                seatnumbers.Text = "Seat Choose : ";
            }
        }

        private void Jam2_Click(object sender, EventArgs e)
        {
            spirit.Controls.Clear();
            chosen = 2;
            chooseeat = 2;
            foreach (Button seat in buttonlistjam2)
            {
                spirit.Controls.Add(seat);
                seatnumbers.Text = "Seat Choose : ";
            }
        }

        private void Jam1_Click(object sender, EventArgs e)
        {
            spirit.Controls.Clear();
            chosen = 1;
            chooseeat = 1;
            foreach (Button seat in buttonlistjam1)
            {
                spirit.Controls.Add(seat);
                seatnumbers.Text = "Seat Choose : ";
            }
        }


    }
}
