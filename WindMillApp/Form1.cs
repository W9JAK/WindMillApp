using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindMillApp
{
    public partial class Form1 : Form
    {
        private bool isRunning = false;
        private bool direction = true;
        private int speed = 5; // Начальная скорость теперь берется из начального значения trackBar1
        private Timer timer1;
        private float currentAngle = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            try
            {
                pictureBoxMill.Image = Properties.Resources.WindMillWithoutBlades;
                pictureBoxBlades.Image = Properties.Resources.WindmillBlades;
                pictureBoxMill.BackColor = pictureBoxBlades.BackColor = Color.Transparent;
                pictureBoxMill.SizeMode = pictureBoxBlades.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBoxBlades.Parent = pictureBoxMill;
                pictureBoxBlades.Location = new Point(0, 0);

                // Настройка TrackBar
                trackBar1.Minimum = 3;
                trackBar1.Maximum = 17;
                trackBar1.Value = 10;
                trackBar1.TickFrequency = 1;
                trackBar1.ValueChanged += TrackBar1_ValueChanged; // Подписка на событие изменения значения

                // Настройка таймера
                timer1 = new Timer { Interval = 100 };
                timer1.Tick += timer1_Tick;

                btnStart.Click += btnStart_Click;
                btnChangeDirection.Click += btnChangeDirection_Click;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void TrackBar1_ValueChanged(object sender, EventArgs e)
        {
            speed = trackBar1.Value; // Обновление скорости в соответствии с положением ползунка
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            isRunning = !isRunning;
            btnStart.Text = isRunning ? "Остановить" : "Запустить";
            timer1.Enabled = isRunning;
        }

        private void btnChangeDirection_Click(object sender, EventArgs e)
        {
            direction = !direction;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentAngle += (direction ? speed : -speed);
            pictureBoxBlades.Image = RotateImage(Properties.Resources.WindmillBlades, currentAngle);
        }

        private Bitmap RotateImage(Image image, float angle)
        {
            Bitmap bmp = new Bitmap(image.Width, image.Height);
            bmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Transparent);
                g.TranslateTransform(image.Width / 2f, image.Height / 2f);
                g.RotateTransform(angle);
                g.TranslateTransform(-image.Width / 2f, -image.Height / 2f);
                g.DrawImage(image, new Point(0, 0));
            }
            return bmp;
        }
    }
}
