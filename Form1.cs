namespace Lab1IM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        double t, dt, x, y, v0, cosa, sina, S, m, k, vx, vy, maxY;
        int i = 0;
        const double g = 9.81;
        const double C = 0.15;
        const double rho = 1.29;
        private void Init()
        {
            t = 0;
            x = 0;
            y = Convert.ToDouble(HeightBox.Text);
            v0 = Convert.ToDouble(SpeedBox.Text);
            double a = Convert.ToDouble(AngleBox.Text) * Math.PI / 180;
            cosa = Math.Cos(a);
            sina = Math.Sin(a);
            S = Convert.ToDouble(SizeBox.Text);
            m = Convert.ToDouble(WeightBox.Text);
            k = 0.5 * C * rho * S / m;
            vx = v0 * cosa;
            vy = v0 * sina;
            dt = (double)1 / (double)(10 * (i+1));
            //chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(x, y);
            maxY = 0;
        }
        private void StartGroupButton_Click(object sender, EventArgs e)
        {
            Init();
            timer1.Start();
        }
        private void FillColumn()
        {
            Label StepLabel = new Label();
            tableLayoutPanel1.Controls.Add(StepLabel, i + 1, 0);
            StepLabel.TextAlign = ContentAlignment.MiddleCenter;
            StepLabel.Dock = DockStyle.Fill;
            StepLabel.Text = Double.Round(dt,3).ToString();
            Label Distance = new Label();
            tableLayoutPanel1.Controls.Add(Distance, i + 1, 1);
            Distance.TextAlign = ContentAlignment.MiddleCenter;
            Distance.Dock = DockStyle.Fill;
            Distance.Text = Double.Round(x,3).ToString();
            Label MaxHeight = new Label();
            tableLayoutPanel1.Controls.Add(MaxHeight, i + 1, 2);
            MaxHeight.TextAlign = ContentAlignment.MiddleCenter;
            MaxHeight.Dock = DockStyle.Fill;
            MaxHeight.Text = Double.Round(maxY,3).ToString();
            Label EndSpeed = new Label();
            tableLayoutPanel1.Controls.Add(EndSpeed, i + 1, 3);
            EndSpeed.TextAlign = ContentAlignment.MiddleCenter;
            EndSpeed.Dock = DockStyle.Fill;
            EndSpeed.Text = Double.Round(vx,3).ToString()+" "+ Double.Round(vy, 2).ToString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            t += dt;
            double v = Math.Sqrt((double)(vx * vx + vy * vy));
            vx = vx - k * vx * v * dt;
            vy = vy - (g + k * vy * v) * dt;
            if ((maxY == 0) && ((y+vy*dt)<y))
            {
                maxY = y;
            }
            x = x + vx * dt;
            y = y + vy * dt;
            chart1.Series[0].Points.AddXY(x, y);
            if (y <= 0)
            {
                FillColumn();
                i++;
                if (i == 6)
                    timer1.Stop();
                else
                    Init();
            }
        }
    }
}
