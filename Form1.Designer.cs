namespace Lab1IM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            HeightBox = new TextBox();
            AngleBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label4 = new Label();
            SpeedBox = new TextBox();
            SizeBox = new TextBox();
            WeightBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            EndSpeedLabel = new Label();
            TimeStepLabel = new Label();
            MaxHeightLabel = new Label();
            DistanceLabel = new Label();
            StartGroupButton = new Button();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(12, 36);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Тело в атмосфере";
            chart1.Series.Add(series1);
            chart1.Size = new Size(578, 299);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // HeightBox
            // 
            HeightBox.Location = new Point(596, 38);
            HeightBox.Name = "HeightBox";
            HeightBox.Size = new Size(137, 23);
            HeightBox.TabIndex = 2;
            // 
            // AngleBox
            // 
            AngleBox.Location = new Point(596, 90);
            AngleBox.Name = "AngleBox";
            AngleBox.Size = new Size(137, 23);
            AngleBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(596, 20);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 5;
            label2.Text = "Начальная высота";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(596, 72);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 6;
            label3.Text = "Начальный угол";
            // 
            // timer1
            // 
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(596, 125);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 8;
            label4.Text = "Начальная скорость";
            // 
            // SpeedBox
            // 
            SpeedBox.Location = new Point(596, 143);
            SpeedBox.Name = "SpeedBox";
            SpeedBox.Size = new Size(137, 23);
            SpeedBox.TabIndex = 9;
            // 
            // SizeBox
            // 
            SizeBox.Location = new Point(596, 194);
            SizeBox.Name = "SizeBox";
            SizeBox.Size = new Size(137, 23);
            SizeBox.TabIndex = 10;
            // 
            // WeightBox
            // 
            WeightBox.Location = new Point(596, 245);
            WeightBox.Name = "WeightBox";
            WeightBox.Size = new Size(137, 23);
            WeightBox.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(596, 176);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 12;
            label5.Text = "Размер тела";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(596, 227);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 13;
            label6.Text = "Масса тела";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(EndSpeedLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(TimeStepLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(MaxHeightLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(DistanceLabel, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 369);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(578, 178);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // EndSpeedLabel
            // 
            EndSpeedLabel.AutoSize = true;
            EndSpeedLabel.Dock = DockStyle.Fill;
            EndSpeedLabel.Location = new Point(4, 133);
            EndSpeedLabel.Name = "EndSpeedLabel";
            EndSpeedLabel.RightToLeft = RightToLeft.No;
            EndSpeedLabel.Size = new Size(222, 44);
            EndSpeedLabel.TabIndex = 18;
            EndSpeedLabel.Text = "Speed At The End Point";
            EndSpeedLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TimeStepLabel
            // 
            TimeStepLabel.AutoSize = true;
            TimeStepLabel.Dock = DockStyle.Fill;
            TimeStepLabel.Location = new Point(4, 1);
            TimeStepLabel.Name = "TimeStepLabel";
            TimeStepLabel.Size = new Size(222, 43);
            TimeStepLabel.TabIndex = 15;
            TimeStepLabel.Text = "Time Step";
            TimeStepLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MaxHeightLabel
            // 
            MaxHeightLabel.AutoSize = true;
            MaxHeightLabel.Dock = DockStyle.Fill;
            MaxHeightLabel.Location = new Point(4, 89);
            MaxHeightLabel.Name = "MaxHeightLabel";
            MaxHeightLabel.Size = new Size(222, 43);
            MaxHeightLabel.TabIndex = 17;
            MaxHeightLabel.Text = "Max Height";
            MaxHeightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DistanceLabel
            // 
            DistanceLabel.AutoSize = true;
            DistanceLabel.Dock = DockStyle.Fill;
            DistanceLabel.Location = new Point(4, 45);
            DistanceLabel.Name = "DistanceLabel";
            DistanceLabel.Size = new Size(222, 43);
            DistanceLabel.TabIndex = 16;
            DistanceLabel.Text = "Distance";
            DistanceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StartGroupButton
            // 
            StartGroupButton.Location = new Point(596, 274);
            StartGroupButton.Name = "StartGroupButton";
            StartGroupButton.Size = new Size(140, 61);
            StartGroupButton.TabIndex = 15;
            StartGroupButton.Text = "Начать моделирование для заполнения таблицы";
            StartGroupButton.UseVisualStyleBackColor = true;
            StartGroupButton.Click += StartGroupButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 559);
            Controls.Add(StartGroupButton);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(WeightBox);
            Controls.Add(SizeBox);
            Controls.Add(SpeedBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(AngleBox);
            Controls.Add(HeightBox);
            Controls.Add(chart1);
            Name = "Form1";
            Text = "Lab1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private TextBox HeightBox;
        private TextBox AngleBox;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private Label label4;
        private TextBox SpeedBox;
        private TextBox SizeBox;
        private TextBox WeightBox;
        private Label label5;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel1;
        private Label TimeStepLabel;
        private Label DistanceLabel;
        private Label MaxHeightLabel;
        private Label EndSpeedLabel;
        private Button StartGroupButton;
    }
}
