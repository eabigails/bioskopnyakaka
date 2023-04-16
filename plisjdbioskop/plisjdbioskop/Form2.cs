using System;
using System.Drawing;
using System.Windows.Forms;

namespace plisjdbioskop
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // 1st movie
            PictureBox picture = new PictureBox();
            picture.Location = new Point(28, 36);
            picture.Size = new Size(100, 120);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.Image = Image.FromFile(@"C:\Users\surab\source\repos\plisjdbioskop\plisjdbioskop\Poster\ponyo.jpg");
            this.Controls.Add(picture);

            Label label = new Label();
            label.Text = "Ponyo";
            label.Location = new Point(55, 165);
            label.AutoSize = true;
            this.Controls.Add(label);

            Button button = new Button();
            button.Text = "Book movie";
            button.Location = new Point(40, 180);
            button.Size = new Size(75, 23);
            button.Visible = true;
            button.BackColor = Color.White;
            button.Click += new EventHandler(button_click);
            this.Controls.Add(button);

            // 2nd movie

            PictureBox picture1 = new PictureBox();
            picture1.Location = new Point(150, 36);
            picture1.Size = new Size(100, 120);
            picture1.SizeMode = PictureBoxSizeMode.StretchImage;
            picture1.Image = Image.FromFile(@"C:\Users\surab\source\repos\plisjdbioskop\plisjdbioskop\Poster\kiki.jpg");
            this.Controls.Add(picture1);


            Label label1 = new Label();
            label1.Text = "Kiki Delivery Service";
            label1.Location = new Point(150, 165);
            label1.AutoSize = true;
            this.Controls.Add(label1);


            Button button1 = new Button();
            button1.Text = "Book movie";
            button1.Location = new Point(160, 180);
            button1.Size = new Size(75, 23);
            button1.Visible = true;
            button1.BackColor = Color.White;
            button1.Click += new EventHandler(button1_click);
            this.Controls.Add(button1);

            // 3rd movie
            PictureBox picture2 = new PictureBox();
            picture2.Location = new Point(272, 36);
            picture2.Size = new Size(100, 120);
            picture2.SizeMode = PictureBoxSizeMode.StretchImage;
            picture2.Image = Image.FromFile(@"C:\Users\surab\source\repos\plisjdbioskop\plisjdbioskop\Poster\whisperoftheheart.jpg");
            this.Controls.Add(picture2);


            Label label2 = new Label();
            label2.Text = "Whisper of the heart";
            label2.Location = new Point(272, 165);
            label2.AutoSize = true;
            this.Controls.Add(label2);


            Button button2 = new Button();
            button2.Text = "Book movie";
            button2.Location = new Point(280, 180);
            button2.Size = new Size(75, 23);
            button2.Visible = true;
            button2.BackColor = Color.White;
            button2.Click += new EventHandler(button2_click);
            this.Controls.Add(button2);


            // 4th movie

            PictureBox picture3 = new PictureBox();
            picture3.Location = new Point(394, 36);
            picture3.Size = new Size(100, 120);
            picture3.SizeMode = PictureBoxSizeMode.StretchImage;
            picture3.Image = Image.FromFile(@"C:\Users\surab\source\repos\plisjdbioskop\plisjdbioskop\Poster\zeldaghibliposter3.jpg");
            this.Controls.Add(picture3);


            Label label3 = new Label();
            label3.Text = "Zelda";
            label3.Location = new Point(430, 165);
            label3.AutoSize = true;
            this.Controls.Add(label3);


            Button button3 = new Button();
            button3.Text = "Book movie";
            button3.Location = new Point(410, 180);
            button3.Size = new Size(75, 23);
            button3.Visible = true;
            button3.Click += new EventHandler(button3_click);
            button3.BackColor = Color.White;
            this.Controls.Add(button3);

            // 5th movie


            PictureBox picture4 = new PictureBox();
            picture4.Location = new Point(28, 220);
            picture4.Size = new Size(100, 120);
            picture4.SizeMode = PictureBoxSizeMode.StretchImage;
            picture4.Image = Image.FromFile(@"C:\Users\surab\source\repos\plisjdbioskop\plisjdbioskop\Poster\PorcoRosso_250x375_R2.jpg");
            this.Controls.Add(picture4);


            Label label4 = new Label();
            label4.Text = "Porco Rosso";
            label4.Location = new Point(45, 350);
            label4.AutoSize = true;
            this.Controls.Add(label4);


            Button button4 = new Button();
            button4.Text = "Book movie";
            button4.Location = new Point(42, 365);
            button4.Size = new Size(75, 23);
            button4.Visible = true;
            button4.BackColor = Color.White;
            button4.Click += new EventHandler(button4_click);
            this.Controls.Add(button4);

            // 6th movie


            PictureBox picture5 = new PictureBox();
            picture5.Location = new Point(150, 220);
            picture5.Size = new Size(100, 120);
            picture5.SizeMode = PictureBoxSizeMode.StretchImage;
            picture5.Image = Image.FromFile(@"C:\Users\surab\source\repos\plisjdbioskop\plisjdbioskop\Poster\e96b650f0c9d3a9b5eec2bf12725f447.jpg");
            this.Controls.Add(picture5);


            Label label5 = new Label();
            label5.Text = "Spirited Away";
            label5.Location = new Point(158, 350);
            label5.AutoSize = true;
            this.Controls.Add(label5);


            Button button5 = new Button();
            button5.Text = "Book movie";
            button5.Location = new Point(155, 365);
            button5.Size = new Size(75, 23);
            button5.Visible = true;
            button5.BackColor = Color.White;
            button5.Click += new EventHandler(button5_click);
            this.Controls.Add(button5);


            // 7th movie


            PictureBox picture6 = new PictureBox();
            picture6.Location = new Point(272, 220);
            picture6.Size = new Size(100, 120);
            picture6.SizeMode = PictureBoxSizeMode.StretchImage;
            picture6.Image = Image.FromFile(@"C:\Users\surab\source\repos\plisjdbioskop\plisjdbioskop\Poster\My-Neighbor-Totoro-Vintage-Movie-Poster-Original-Japanese-1-Panel-20x29-8302.jpg");
            this.Controls.Add(picture6);


            Label label6 = new Label();
            label6.Text = "Totoro";
            label6.Location = new Point(300, 350);
            label6.AutoSize = true;
            this.Controls.Add(label6);


            Button button6 = new Button();
            button6.Text = "Book movie";
            button6.Location = new Point(285, 365);
            button6.Size = new Size(75, 23);
            button6.Visible = true;
            button6.BackColor = Color.White;
            button6.Click += new EventHandler(button6_click);
            this.Controls.Add(button6);

            // 8th movie


            PictureBox picture7 = new PictureBox();
            picture7.Location = new Point(394, 220);
            picture7.Size = new Size(100, 120);
            picture7.SizeMode = PictureBoxSizeMode.StretchImage;
            picture7.Image = Image.FromFile(@"C:\Users\surab\source\repos\plisjdbioskop\plisjdbioskop\Poster\Howl_sMovingCastle-StudioGhibliJapanaeseAnimatedMoviePoster_d8591a61-9240-4a5e-8d80-682378e655f3.jpg");
            this.Controls.Add(picture7);


            Label label7 = new Label();
            label7.Text = "Howl Moving Castle";
            label7.Location = new Point(394, 350);
            label7.AutoSize = true;
            this.Controls.Add(label7);


            Button button7 = new Button();
            button7.Text = "Book movie";
            button7.Location = new Point(410, 365);
            button7.Size = new Size(75, 23);
            button7.Visible = true;
            button7.BackColor = Color.White;
            button7.Click += new EventHandler(button7_click);
            this.Controls.Add(button7);


        }
        private void button_click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGreen;

            ponyo ponyo = new ponyo();
            ponyo.Dock = DockStyle.Fill;
            ponyo.FormBorderStyle = FormBorderStyle.None;
            ponyo.TopLevel = false;
            panel1.Controls.Clear();
            ponyo.Show();
            this.panel1.Controls.Add(ponyo);



        }
        private void button1_click(object sender, EventArgs e)
        {
            this.BackColor = Color.Olive;
            kiki kiki = new kiki();
            kiki.Dock = DockStyle.Fill;
            kiki.FormBorderStyle = FormBorderStyle.None;
            kiki.TopLevel = false;
            panel1.Controls.Clear();
            kiki.Show();
            this.panel1.Controls.Add(kiki);
        }
        private void button2_click(object sender, EventArgs e)
        {
            this.BackColor = Color.PaleGreen;
            whisperoftheheart ws = new whisperoftheheart();
            ws.Dock = DockStyle.Fill;
            ws.FormBorderStyle = FormBorderStyle.None;
            ws.TopLevel = false;
            panel1.Controls.Clear();
            ws.Show();
            this.panel1.Controls.Add(ws);

        }
        private void button3_click(object sender, EventArgs e)
        {
            this.BackColor = Color.MediumVioletRed;
            zelda z = new zelda();
            z.Dock = DockStyle.Fill;
            z.FormBorderStyle = FormBorderStyle.None;
            z.TopLevel = false;
            panel1.Controls.Clear();
            z.Show();
            this.panel1.Controls.Add(z);
        }
        private void button4_click(object sender, EventArgs e)
        {
            this.BackColor = Color.PeachPuff;
            porcorosso p = new porcorosso();
            p.Dock = DockStyle.Fill;
            p.FormBorderStyle = FormBorderStyle.None;
            p.TopLevel = false;
            panel1.Controls.Clear();
            p.Show();
            this.panel1.Controls.Add(p);
        }
        private void button5_click(object sender, EventArgs e)
        {
            this.BackColor = Color.FloralWhite;
            spiritaway s = new spiritaway();
            s.Dock = DockStyle.Fill;
            s.FormBorderStyle = FormBorderStyle.None;
            s.TopLevel = false;
            panel1.Controls.Clear();
            s.Show();
            this.panel1.Controls.Add(s);
        }
        private void button6_click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightYellow;
            totoro to = new totoro();
            to.Dock = DockStyle.Fill;
            to.FormBorderStyle = FormBorderStyle.None;
            to.TopLevel = false;
            panel1.Controls.Clear();
            to.Show();
            this.panel1.Controls.Add(to);
        }
        private void button7_click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightSkyBlue;
            howl howl = new howl();
            howl.Dock = DockStyle.Fill;
            howl.FormBorderStyle = FormBorderStyle.None;
            howl.TopLevel = false;
            panel1.Controls.Clear();
            howl.Show();
            this.panel1.Controls.Add(howl);

        }
    }

}
