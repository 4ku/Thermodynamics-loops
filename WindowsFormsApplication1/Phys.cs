using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace WindowsFormsApplication1
{


    public partial class Phys : Form
    {
        bool loopFound = false;
        double realX = 0; double realY = 0;
        double oX = 0, oY = 100;
        double endX = 100, endY = 0;
        double MaxValX = 100, MaxValY = 100;

        int countOfIntervals = 10;

   
        public Phys()
        {
          //  this.FormBorderStyle = FormBorderStyle.None;
          //  this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedItem = "Изобара";
            cBox1.SelectedIndex = 0;
            cBox2.SelectedIndex = 1;
            cBox3.SelectedIndex = 2;
            cBox4.SelectedIndex = 0;
            
            
           
            numericUpDown1.unit = "кПа";
            numericUpDown2.unit = "л";
            numericUpDown9.unit = "л";
            numericUpDown1.changeText();
            numericUpDown2.changeText();
            numericUpDown9.changeText();

            chart1.Enabled = false;
            chart1.ChartAreas[0].AxisX.TitleFont = new Font("Arial Black", 10f);
            chart1.ChartAreas[0].AxisY.TitleFont = new Font("Arial Black", 10f);

            chart1.ChartAreas[0].IsSameFontSizeForAllAxes = true;
            chart1.ChartAreas[0].AxisX.IsLabelAutoFit = false;
            chart1.ChartAreas[0].AxisX.LabelAutoFitStyle = LabelAutoFitStyles.None;
             //ls = new LabelStyle();
          //  ls.Format="{ 0.}";
          
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = MaxValX;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = MaxValY;
            chart1.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chart1.ChartAreas[0].AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chart1.Series[0].BorderWidth = 2;
            chart1.Series[0]["LineTension"] = "0.0";
            chart1.Series[0].MarkerStyle = MarkerStyle.Circle;
            chart1.Series[0].Points.AddXY(0, 0);
            chart1.Series[0].Points[0].IsEmpty = true;
            chart1.ChartAreas[0].AxisX.Interval = MaxValX / countOfIntervals;
            chart1.ChartAreas[0].AxisY.Interval = MaxValY / countOfIntervals;
            chart1.ChartAreas[0].AxisX.IsMarksNextToAxis = false;

            chart2.ChartAreas[0].AxisX.TitleFont = new Font("Arial Black", 10f);
            chart2.ChartAreas[0].AxisY.TitleFont = new Font("Arial Black", 10f);
            chart2.ChartAreas[0].AxisX.Minimum = 0;
            chart2.ChartAreas[0].AxisX.Maximum = MaxValX;
            chart2.ChartAreas[0].AxisY.Minimum = 0;
            chart2.ChartAreas[0].AxisY.Maximum = MaxValY;
            chart2.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chart2.ChartAreas[0].AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chart2.Series[0].BorderWidth = 2;
            chart2.Series[0]["LineTension"] = "0.0";
            chart2.Series[0].MarkerStyle = MarkerStyle.Circle;
            chart2.Series[0].Points.AddXY(0, 0);
            chart2.Series[0].Points[0].IsEmpty = true;
            chart2.ChartAreas[0].AxisX.Interval = MaxValX / countOfIntervals;
            chart2.ChartAreas[0].AxisY.Interval = MaxValY / countOfIntervals;
          //  chart2.ChartAreas[0].AxisX.LabelStyle = ls;
          //  chart2.ChartAreas[0].AxisY.LabelStyle = ls;

            chart3.ChartAreas[0].AxisX.TitleFont = new Font("Arial Black", 10f);
            chart3.ChartAreas[0].AxisY.TitleFont = new Font("Arial Black", 10f);
            chart3.ChartAreas[0].AxisX.Minimum = 0;
            chart3.ChartAreas[0].AxisX.Maximum = MaxValX;
            chart3.ChartAreas[0].AxisY.Minimum = 0;
            chart3.ChartAreas[0].AxisY.Maximum = MaxValY;
            chart3.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chart3.ChartAreas[0].AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chart3.Series[0].BorderWidth = 2;
            chart3.Series[0]["LineTension"] = "0.0";
            chart3.Series[0].MarkerStyle = MarkerStyle.Circle;
            chart3.Series[0].Points.AddXY(0, 0);
            chart3.Series[0].Points[0].IsEmpty = true;
            chart3.ChartAreas[0].AxisX.Interval = MaxValX / countOfIntervals;
            chart3.ChartAreas[0].AxisY.Interval = MaxValY / countOfIntervals;
            //chart3.ChartAreas[0].AxisX.LabelStyle = ls;
           // chart3.ChartAreas[0].AxisY.LabelStyle = ls;

            chart4.ChartAreas[0].AxisX.TitleFont = new Font("Arial Black", 10f);
            chart4.ChartAreas[0].AxisY.TitleFont = new Font("Arial Black", 10f);
            chart4.ChartAreas[0].AxisX.Minimum = 0;
            chart4.ChartAreas[0].AxisX.Maximum = MaxValX;
            chart4.ChartAreas[0].AxisY.Minimum = 0;
            chart4.ChartAreas[0].AxisY.Maximum = MaxValY;
            chart4.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chart4.ChartAreas[0].AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chart4.Series[0]["LineTension"] = "0.0";
            chart4.Series[0].MarkerStyle = MarkerStyle.Circle;
            chart4.Series[0].BorderWidth = 2;
            chart4.Series[0].Points.AddXY(0, 0);
            chart4.Series[0].Points[0].IsEmpty = true;
            chart4.ChartAreas[0].AxisX.Interval = MaxValX / countOfIntervals;
            chart4.ChartAreas[0].AxisY.Interval = MaxValY / countOfIntervals;

            moll.Value = 1;
            comboBox4.SelectedIndex = 0;
            // chart4.ChartAreas[0].AxisX.LabelStyle = ls;
            //  chart4.ChartAreas[0].AxisY.LabelStyle = ls;
            //  ls.Dispose();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            chart1.Series[0].Points.AddXY(0, 2);
            chart1.Series[0].Points.AddXY(2, 1);
            chart1.Series[0].Points.AddXY(0.5, 1);
            chart1.Series[0].Points.AddXY(0.25, 1.25);
            chart1.Series[0].Points[0].BorderColor = Color.Red;
            chart1.Series[0].Points[0].BorderWidth = 3;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                if (loopFound) return;
                Chart chart = (Chart)sender;
                MaxValX = chart.ChartAreas[0].AxisX.Maximum;
                MaxValY = chart.ChartAreas[0].AxisY.Maximum;

                oX = chart.ChartAreas[0].AxisX.ValueToPixelPosition(0);
                oY = chart.ChartAreas[0].AxisY.ValueToPixelPosition(0);
                endX = chart.ChartAreas[0].AxisX.ValueToPixelPosition(MaxValX);
                endY = chart.ChartAreas[0].AxisY.ValueToPixelPosition(MaxValY);

                if (e.X >= oX && e.X <= endX && e.Y >= endY && e.Y <= oY)
                {
                    if (chart.Series[0].Points.Count > 1)
                    {
                        double prevX = (endX - oX) * chart1.Series[0].Points[chart1.Series[0].Points.Count - 1].XValue / MaxValX;
                        double prevY = (oY - endY) * chart1.Series[0].Points[chart1.Series[0].Points.Count - 1].YValues[0] / MaxValY;
                        if (Math.Abs(prevX - (e.X - oX)) <= 3.0 && Math.Abs(prevY - (oY - e.Y)) <= 3.0) return;
                    }

                    //if((e.X - oX)-)
                    DataPoint dp = new DataPoint();

                    /*  dp.Color = Color.DodgerBlue;
                      if (chart.Series[0].Points.Count == 1)
                      {
                          dp.Color = Color.Red;
                          dp.MarkerStyle = MarkerStyle.Circle;
                          dp.MarkerSize = 8;
                      }*/
                    realX = (e.X - oX) * MaxValX / (endX - oX);
                    realY = (oY - e.Y) * MaxValY / (oY - endY);
                    dp.XValue = realX;
                    dp.YValues[0] = realY;

                    int ind = 0;
                    if (chart.Name == "chart1") ind = cBox1.SelectedIndex;
                    else if (chart.Name == "chart2") ind = cBox2.SelectedIndex;
                    else if (chart.Name == "chart3") ind = cBox3.SelectedIndex;
                    else if (chart.Name == "chart4") ind = cBox4.SelectedIndex;

                    if (chart.Series[0].Points.Count >= 4)
                    {
                        double pixx = (endX - oX) * (realX - chart.Series[0].Points[1].XValue) / MaxValX;
                        double pixy = (endY - oY) * (realY - chart.Series[0].Points[1].YValues[0]) / MaxValY;
                        double r = Math.Sqrt(pixx * pixx + pixy * pixy);
                        if (r <= 5.0)
                        {
                            loopFound = true;
                            label33.Text = "Цикл найден";
                        }
                    }

                    addPoint(dp, ind);
                   
                    


                }



            }

        }

        private void chart1_MouseDown(object sender, MouseEventArgs e)
        {


            chart1_MouseMove(sender, e);

        }









        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        string ces1(int index)
        {
            if (index == 0) return "P, кПа";
            if (index == 1) return "P, кПа";
            if (index == 2) return "V, л";
            return "";
        }
        string ces2(int index)
        {
            if (index == 0) return "V, л";
            if (index == 1) return "T, К";
            if (index == 2) return "T, К";
            return "";
        }

        double c = 0.355;        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            switch ((int)comboBox1.SelectedItem)
            {
                case 1:
                    cBox1.Enabled = true;
                    cBox2.Enabled = false;
                    cBox3.Enabled = false;
                    cBox4.Enabled = false;
                    numericUpDown3.Enabled = true;
                    numericUpDown4.Enabled = false;
                    numericUpDown5.Enabled = false;
                    numericUpDown6.Enabled = false;
                    numericUpDown15.Enabled = true;
                    numericUpDown14.Enabled = false;
                    numericUpDown13.Enabled = false;
                    numericUpDown12.Enabled = false;

                    numericUpDown7.Enabled = true;
                    numericUpDown10.Enabled = false;
                    numericUpDown17.Enabled = false;
                    numericUpDown20.Enabled = false;
                    numericUpDown8.Enabled = true;
                    numericUpDown11.Enabled = false;
                    numericUpDown18.Enabled = false;
                    numericUpDown19.Enabled = false;

                    chart1.Enabled = true; chart1.Visible = true;
                    chart1.Location = new Point((int)(Width* c), 5);
                    label16.Location = chart1.Location; label16.Visible = true;
                    chart1.Width =(int)((1- c) * Width-15);
                    chart1.Height = Height-50;                    
                    chart2.Visible = false; label17.Visible = false; chart2.Enabled = false;
                    chart3.Visible = false; label18.Visible = false; chart3.Enabled = false;
                    chart4.Visible = false; label19.Visible = false; chart4.Enabled = false;

                    

                    break;

                case 2:
                    cBox1.Enabled = true;
                    cBox2.Enabled = true;
                    cBox3.Enabled = false;
                    cBox4.Enabled = false;
                    numericUpDown3.Enabled = true;
                    numericUpDown4.Enabled = true;
                    numericUpDown5.Enabled = false;
                    numericUpDown6.Enabled = false;
                    numericUpDown15.Enabled = true;
                    numericUpDown14.Enabled = true;
                    numericUpDown13.Enabled = false;
                    numericUpDown12.Enabled = false;

                    numericUpDown7.Enabled = true;
                    numericUpDown10.Enabled = true;
                    numericUpDown17.Enabled = false;
                    numericUpDown20.Enabled = false;
                    numericUpDown8.Enabled = true;
                    numericUpDown11.Enabled = true;
                    numericUpDown18.Enabled = false;
                    numericUpDown19.Enabled = false;

                    chart1.Enabled = true; chart1.Visible = true;
                    chart2.Enabled = true; chart2.Visible = true;

                    chart1.Location = new Point((int)(Width * c), 5);
                    label16.Location = chart1.Location; label16.Visible = true;
                    chart1.Width = (int)((1 - c) / 2 * Width);
                    chart1.Height = Height-50;

                    chart2.Location = new Point((int)(Width * (c + (1 - c) / 2)),5);
                    label17.Location = chart2.Location; label17.Visible = true;
                    chart2.Width = (int)((1 - c) / 2 * Width);
                    chart2.Height = Height-50;
                  
                    chart3.Visible = false; label18.Visible = false; chart3.Enabled = false;
                    chart4.Visible = false; label19.Visible = false; chart4.Enabled = false;
                    break;
                case 3:
                    cBox1.Enabled = true;
                    cBox2.Enabled = true;
                    cBox3.Enabled = true;
                    cBox4.Enabled = false;
                    numericUpDown3.Enabled = true;
                    numericUpDown4.Enabled = true;
                    numericUpDown5.Enabled = true;
                    numericUpDown6.Enabled = false;
                    numericUpDown15.Enabled = true;
                    numericUpDown14.Enabled = true;
                    numericUpDown13.Enabled = true;
                    numericUpDown12.Enabled = false;

                    numericUpDown7.Enabled = true;
                    numericUpDown10.Enabled = true;
                    numericUpDown17.Enabled = true;
                    numericUpDown20.Enabled = false;
                    numericUpDown8.Enabled = true;
                    numericUpDown11.Enabled = true;
                    numericUpDown18.Enabled = true;
                    numericUpDown19.Enabled = false;

                    chart1.Enabled = true; chart1.Visible = true;
                    chart2.Enabled = true; chart2.Visible = true;
                    chart3.Enabled = true; chart3.Visible = true;

                    chart1.Location = new Point((int)(Width * c), 0);
                    label16.Location = chart1.Location; label16.Visible = true;
                    chart1.Width = (int)((1 - c) * Width/2);
                    chart1.Height = (Height-10)/2 - 10;

                    chart2.Location = new Point((int)(Width * (c + (1 - c) / 2)), 0);
                    label17.Location = chart2.Location; label17.Visible = true;
                    chart2.Width = (int)((1 - c) * Width/2);
                    chart2.Height = (Height - 10) / 2 - 10;

                    chart3.Location = new Point((int)(Width * c), chart2.Height);
                    label18.Location = chart3.Location; label18.Visible = true;
                    chart3.Width = (int)((1 - c) * Width)-15;
                    chart3.Height = Height - chart2.Height - 25;

                    chart4.Visible = false; label19.Visible = false; chart4.Enabled = false;
                    break;
                case 4:
                    cBox1.Enabled = true;
                    cBox2.Enabled = true;
                    cBox3.Enabled = true;
                    cBox4.Enabled = true;
                    numericUpDown3.Enabled = true;
                    numericUpDown4.Enabled = true;
                    numericUpDown5.Enabled = true;
                    numericUpDown6.Enabled = true;
                    numericUpDown15.Enabled = true;
                    numericUpDown14.Enabled = true;
                    numericUpDown13.Enabled = true;
                    numericUpDown12.Enabled = true;

                    numericUpDown7.Enabled = true;
                    numericUpDown10.Enabled = true;
                    numericUpDown17.Enabled = true;
                    numericUpDown20.Enabled = true;
                    numericUpDown8.Enabled = true;
                    numericUpDown11.Enabled = true;
                    numericUpDown18.Enabled = true;
                    numericUpDown19.Enabled = true;

                    chart1.Enabled = true; chart1.Visible = true;
                    chart2.Enabled = true; chart2.Visible = true;
                    chart3.Enabled = true; chart3.Visible = true;
                    chart4.Enabled = true; chart4.Visible = true;

                    chart1.Location = new Point((int)(Width * c), 0);
                    label16.Location = chart1.Location; label16.Visible = true;
                    chart1.Width = (int)((1 - c) / 2 * Width);
                    chart1.Height = (Height - 10) / 2 - 10;

                    chart2.Location = new Point((int)(Width * (c + (1 - c) / 2))-4, 0);
                    label17.Location = chart2.Location; label17.Visible = true;
                    chart2.Width = (int)((1 - c) / 2 * Width);
                    chart2.Height = (Height - 10) / 2 - 10;

                    chart3.Location = new Point((int)(Width * c)-5, chart2.Height);
                    label18.Location = chart3.Location; label18.Visible = true;
                    chart3.Width = (int)((1 - c) / 2 * Width) ;
                    chart3.Height = (Height - 10) / 2 - 10;

                    chart4.Location = new Point((int)(Width * (c + (1 - c) / 2))-10, chart2.Height);
                    label19.Location = chart4.Location; label19.Visible = true;
                    chart4.Width = (int)((1 - c) / 2 * Width)-4;
                    chart4.Height = (Height - 10) / 2 - 14;


                    break;

            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
         //   int i = (double)comboBox1.SelectedItem;
        }
        public string getU(int index)
        {
            if (index == 0) return "кПа";
            if (index == 1) return "л";
            if (index == 2) return "K";
            return "";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {


            if ((string)comboBox2.SelectedItem == "Изобара")
            {
                label28.Text = "P";
                numericUpDown1.unit = getU(0);
                numericUpDown1.changeText();
              comboBox3.Items.Clear();
                comboBox3.Items.AddRange(new object[] { "V", "T" });
                comboBox3.SelectedIndex = 0;

            }
            else if ((string)comboBox2.SelectedItem == "Изотерма")
            {
                label28.Text = "T";
                numericUpDown1.unit = getU(2);
                numericUpDown1.changeText();
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(new object[] { "P", "V" });
                comboBox3.SelectedIndex = 0;
            }
            else if ((string)comboBox2.SelectedItem == "Изохора")
            {
                label28.Text = "V";
                numericUpDown1.unit = getU(1);
                numericUpDown1.changeText();
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(new object[] { "P", "T" });
                comboBox3.SelectedIndex = 0;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(0, 0);
            chart1.Series[0].Points[0].IsEmpty = true;

            chart2.Series[0].Points.Clear();
            chart2.Series[0].Points.AddXY(0, 0);
            chart2.Series[0].Points[0].IsEmpty = true;

            chart3.Series[0].Points.Clear();
            chart3.Series[0].Points.AddXY(0, 0);
            chart3.Series[0].Points[0].IsEmpty = true;

            chart4.Series[0].Points.Clear();
            chart4.Series[0].Points.AddXY(0, 0);
            chart4.Series[0].Points[0].IsEmpty = true;
            label33.Text = "Цикл не найден"; loopFound = false;
            label13.Text = "-"; label14.Text = "-";
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDownEx numUD = (NumericUpDownEx)sender;
            chart1.ChartAreas[0].AxisX.Maximum =(double) numUD.Value;
            numericUpDown7.Maximum = numUD.Value;
            if (numUD.ContainsFocus) numUD.changeText(0);
            else numUD.changeText();
            rerere(chart1);
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDownEx numUD = (NumericUpDownEx)sender;
            chart2.ChartAreas[0].AxisX.Maximum = (double)numUD.Value; rerere(chart2);
            if (numUD.ContainsFocus) numUD.changeText(0);
            else numUD.changeText();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDownEx numUD = (NumericUpDownEx)sender;
            chart3.ChartAreas[0].AxisX.Maximum = (double)numUD.Value; rerere(chart3);
            if (numUD.ContainsFocus) numUD.changeText(0);
            else numUD.changeText();
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDownEx numUD = (NumericUpDownEx)sender;
            chart4.ChartAreas[0].AxisX.Maximum = (double)numUD.Value; rerere(chart4);
            if (numUD.ContainsFocus) numUD.changeText(0);
            else numUD.changeText();
        }

        private void numericUpDown15_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDownEx numUD = (NumericUpDownEx)sender;
            chart1.ChartAreas[0].AxisY.Maximum = (double)numUD.Value;
            if (numUD.ContainsFocus) numUD.changeText(0);
            else numUD.changeText();
            rerere(chart1);
        }

        private void numericUpDown14_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDownEx numUD = (NumericUpDownEx)sender;
            chart2.ChartAreas[0].AxisY.Maximum = (double)numUD.Value; rerere(chart2);
            if (numUD.ContainsFocus) numUD.changeText(0);
            else numUD.changeText();
        }

        private void numericUpDown13_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDownEx numUD = (NumericUpDownEx)sender;
            chart3.ChartAreas[0].AxisY.Maximum = (double)numUD.Value; rerere(chart3);
            if (numUD.ContainsFocus) numUD.changeText(0);
            else numUD.changeText();
        }

        private void numericUpDown12_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDownEx numUD = (NumericUpDownEx)sender;
            chart4.ChartAreas[0].AxisY.Maximum = (double)numUD.Value; rerere(chart4);
            if (numUD.ContainsFocus) numUD.changeText(0);
            else numUD.changeText();
        }

        private void chart1_Paint(object sender, PaintEventArgs e)
        {
            if (!chart1.Enabled) {
                chart1.Enabled = true;
               LabelStyle ls1 = new LabelStyle();
                ls1.Format = "{ 0.}";
                LabelStyle ls2 = new LabelStyle();
                ls2.Format = "{ 0.}";

                LabelStyle ls3 = new LabelStyle();
                ls3.Format = "{ 0.}";
                LabelStyle ls4 = new LabelStyle();
                ls4.Format = "{ 0.}";
                LabelStyle ls5 = new LabelStyle();
                ls5.Format = "{ 0.}";
                LabelStyle ls6 = new LabelStyle();
                ls6.Format = "{ 0.}";
                LabelStyle ls7 = new LabelStyle();
                ls7.Format = "{ 0.}";
                LabelStyle ls8 = new LabelStyle();
                ls8.Format = "{ 0.}";
                chart1.ChartAreas[0].AxisX.LabelStyle = ls1;
                chart1.ChartAreas[0].AxisY.LabelStyle = ls5;
                chart2.ChartAreas[0].AxisX.LabelStyle = ls2;
                chart2.ChartAreas[0].AxisY.LabelStyle = ls6;
                chart3.ChartAreas[0].AxisX.LabelStyle = ls3;
                chart3.ChartAreas[0].AxisY.LabelStyle = ls7;
                chart4.ChartAreas[0].AxisX.LabelStyle = ls4;
                chart4.ChartAreas[0].AxisY.LabelStyle = ls8;
            }
           
        }
        DataPoint transform(DataPoint p, int from,int to)
        {
            DataPoint n = new DataPoint();
            n.MarkerImage = p.MarkerImage;
            n.MarkerStyle = p.MarkerStyle;
            n.Color = p.Color;
            n.MarkerSize = p.MarkerSize;
            if (from == 0)
            {
                double t = (p.XValue* p.YValues[0]) / ((double)moll.Value * 8.3144598);
                switch (to)
                {
                    case 0:
                        //n = p;
                        n.XValue = p.XValue;
                        n.YValues[0] = p.YValues[0];
                        break;
                    case 1:
                        n.YValues[0] = p.YValues[0];n.XValue = t;
                        break;
                    case 2:
                        n.YValues[0] = p.XValue;n.XValue = t;
                        break;
                    case 3:

                        break;
                }
            } else if (from == 1)
            {
                double V = ((double)moll.Value * 8.3144598*p.XValue)/(p.YValues[0]);
                switch (to)
                {
                    case 0:
                        n.YValues[0] = p.YValues[0];
                        n.XValue = V;
                        break;
                    case 1:
                        n.XValue = p.XValue;
                        n.YValues[0] = p.YValues[0];
                        break;
                    case 2:
                        n.XValue = p.XValue;
                        n.YValues[0] = V;
                        break;
                    case 3:
                        break;
                }
            }
            else if (from == 2)
            {
                double P = ((double)moll.Value * 8.3144598 * p.XValue) / (p.YValues[0]);
                switch (to)
                {
                    case 0:
                        n.YValues[0] = P;
                        n.XValue = p.YValues[0];
                        break;
                    case 1:
                        n.YValues[0] = P;
                        n.XValue = p.XValue;
                        break;
                    case 2:
                        n.XValue = p.XValue;
                        n.YValues[0] = p.YValues[0];
                        break;
                    case 3:
                        break;
                }
            } else if (from == 3)
            {
                switch (to)
                {
                    case 0:

                        break;
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        n.XValue = p.XValue;
                        n.YValues[0] = p.YValues[0];
                        break;
                }
            }
           
            return n;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (chart1.Series[0].Points.Count <= 2) return;
            List<DataPoint> list = new List<DataPoint>();
             
            for (int i=1;i<chart1.Series[0].Points.Count;i++)
            {
                DataPoint p = chart1.Series[0].Points[i];              
                list.Add(transform(p, cBox1.SelectedIndex, 0));               
            }

            double Q = 0, A = 0, Qminus = 0;
            DataPoint prev= list[0];
            double dq;
           
            for (int i = 1; i < list.Count; i++)
            {
                DataPoint p=list[i];
                dq= (p.XValue - prev.XValue) * ((p.YValues[0] + prev.YValues[0])/ 2);
                A += dq;
                dq += I /2* (p.XValue*p.YValues[0]-prev.XValue*prev.YValues[0]);
                if(dq>0)Q +=dq; else Qminus += dq;
                prev = p;
            }

            label13.Text = string.Format("{0:0.}", A) + " Дж";
           // label13.Text = string.Format("{0:0.00}", A);

            if (loopFound)
            {
                dq = (prev.XValue - list[list.Count - 1].XValue) * ((list[list.Count - 1].YValues[0] + prev.YValues[0])/ 2);
                A += dq;
                dq += I / 2 * (prev.XValue * prev.YValues[0] - list[list.Count - 1].XValue * list[list.Count - 1].YValues[0]);
                if (dq > 0) Q += dq; else Qminus += dq;

                if (A >= 0) {
                    label6.Text = "КПД(%):";
                    label6.Location = new Point(label1.Location.X + 15, label1.Location.Y + 40);                   
                    label14.Text = string.Format("{0:0.00}", (A / Q) * 100);
                }
                else
                {
                    label6.Text = "Хол. коэф.:";
                    label6.Location = new Point(label1.Location.X-10, label1.Location.Y + 40);
                    label14.Text = string.Format("{0:0.00}", (Qminus / A) );
                }
            }

        }

        void setUnits(NumericUpDownEx n1,NumericUpDownEx n2,int ind)
        {
            if (ind == 0)
            {
                n1.unit = n2.unit=getU(0);
               
            } else if (ind == 1)
            {
                n1.unit = n2.unit = getU(1);
            }
            else if (ind == 2)
            {
                n1.unit = n2.unit = getU(2);
            }
            n1.changeText(); n2.changeText();
        }
        int chart1PastInd = 0;
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisY.Title = ces1(cBox1.SelectedIndex);
            chart1.ChartAreas[0].AxisX.Title = ces2(cBox1.SelectedIndex);

            chart1.ChartAreas[0].AxisX.TitleAlignment = StringAlignment.Far;

            if (cBox1.SelectedIndex == 0)
            {
                setUnits(numericUpDown7, numericUpDown3, 1);
                setUnits(numericUpDown8, numericUpDown15, 0);
            } else if(cBox1.SelectedIndex == 1)
            {
                setUnits(numericUpDown7, numericUpDown3, 2);
                setUnits(numericUpDown8, numericUpDown15, 0);
            }
            else if (cBox1.SelectedIndex == 2)
            {
                setUnits(numericUpDown7, numericUpDown3, 2);
                setUnits(numericUpDown8, numericUpDown15, 1);
            }

            if (chart1.Series[0].Points.Count <=1) return;
            List<DataPoint> list = new List<DataPoint>();
           

            double maxX = 0, maxY=0;
            for (int i = 1; i < chart1.Series[0].Points.Count; i++)
            {
                DataPoint p =transform(chart1.Series[0].Points[i], chart1PastInd, cBox1.SelectedIndex);
                if (maxX < p.XValue) maxX = p.XValue;
                if (maxY < p.YValues[0]) maxY = p.YValues[0];
                list.Add(p);
            }
            maxX *= 1.01;maxY *= 1.01;

            chart1PastInd = cBox1.SelectedIndex;
            numericUpDown3.Value =(decimal) maxX;
           numericUpDown15.Value = (decimal)maxY;
           /* chart1.ChartAreas[0].AxisX.Maximum = maxX;
            chart1.ChartAreas[0].AxisY.Maximum = maxY;
            chart1.ChartAreas[0].AxisX.Interval = maxX / countOfIntervals;
            chart1.ChartAreas[0].AxisY.Interval = maxY / countOfIntervals;*/
            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(0, 0);
            chart1.Series[0].Points[0].IsEmpty = true;
            for (int i = 0; i < list.Count; i++)
            {
                chart1.Series[0].Points.Add(list[i]);
            }
            chart1.Series[0].Points[1].Color = Color.Red;
            chart1.Series[0].Points[1].MarkerStyle = MarkerStyle.Circle;
            chart1.Series[0].Points[1].MarkerSize = 8;
        }

        int chart4PastInd = 0;
        private void cBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart4.ChartAreas[0].AxisY.Title = ces1(cBox4.SelectedIndex);
            chart4.ChartAreas[0].AxisX.Title = ces2(cBox4.SelectedIndex);
            chart4.ChartAreas[0].AxisX.TitleAlignment = StringAlignment.Far;

            if (cBox4.SelectedIndex == 0)
            {
                setUnits(numericUpDown20, numericUpDown6, 1);
                setUnits(numericUpDown19, numericUpDown12, 0);
            }
            else if (cBox4.SelectedIndex == 1)
            {
                setUnits(numericUpDown20, numericUpDown6, 2);
                setUnits(numericUpDown19, numericUpDown12, 0);
            }
            else if (cBox4.SelectedIndex == 2)
            {
                setUnits(numericUpDown20, numericUpDown6, 2);
                setUnits(numericUpDown19, numericUpDown12, 1);
            }


            if (chart4.Series[0].Points.Count <= 1) return;
            List<DataPoint> list = new List<DataPoint>();

            double maxX = 0, maxY = 0;
            for (int i = 1; i < chart4.Series[0].Points.Count; i++)
            {
                DataPoint p = transform(chart4.Series[0].Points[i], chart4PastInd, cBox4.SelectedIndex);
                if (maxX < p.XValue) maxX = p.XValue;
                if (maxY < p.YValues[0]) maxY = p.YValues[0];
                list.Add(p);
            }

            maxX *= 1.01; maxY *= 1.01;
            chart4PastInd = cBox4.SelectedIndex;
            numericUpDown6.Value = (decimal)maxX;
            numericUpDown12.Value = (decimal)maxY;
            /*chart4.ChartAreas[0].AxisX.Maximum = maxX;
            chart4.ChartAreas[0].AxisY.Maximum = maxY;
            chart4.ChartAreas[0].AxisX.Interval = maxX / countOfIntervals;
            chart4.ChartAreas[0].AxisY.Interval = maxY / countOfIntervals;*/
            chart4.Series[0].Points.Clear();
            chart4.Series[0].Points.AddXY(0, 0);
            chart4.Series[0].Points[0].IsEmpty = true;
            for (int i = 0; i < list.Count; i++)
            {
                chart4.Series[0].Points.Add(list[i]);
            }
            chart4.Series[0].Points[1].Color = Color.Red;
            chart4.Series[0].Points[1].MarkerStyle = MarkerStyle.Circle;
            chart4.Series[0].Points[1].MarkerSize = 8;
        }

        int chart2PastInd = 1;
        private void cBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart2.ChartAreas[0].AxisY.Title = ces1(cBox2.SelectedIndex);
            chart2.ChartAreas[0].AxisX.Title = ces2(cBox2.SelectedIndex);
            chart2.ChartAreas[0].AxisX.TitleAlignment = StringAlignment.Far;

            if (cBox2.SelectedIndex == 0)
            {
                setUnits(numericUpDown10, numericUpDown4, 1);
                setUnits(numericUpDown11, numericUpDown14, 0);
            }
            else if (cBox2.SelectedIndex == 1)
            {
                setUnits(numericUpDown10, numericUpDown4, 2);
                setUnits(numericUpDown11, numericUpDown14, 0);
            }
            else if (cBox2.SelectedIndex == 2)
            {
                setUnits(numericUpDown10, numericUpDown4, 2);
                setUnits(numericUpDown11, numericUpDown14, 1);
            }

            if (chart2.Series[0].Points.Count <= 1) return;
            List<DataPoint> list = new List<DataPoint>();

            double maxX = 0, maxY = 0;
            for (int i = 1; i < chart2.Series[0].Points.Count; i++)
            {
                DataPoint p = transform(chart2.Series[0].Points[i], chart2PastInd, cBox2.SelectedIndex);
                if (maxX < p.XValue) maxX = p.XValue;
                if (maxY < p.YValues[0]) maxY = p.YValues[0];
                list.Add(p);
            }
            maxX *= 1.01; maxY *= 1.01;
            chart2PastInd = cBox2.SelectedIndex;
            numericUpDown4.Value = (decimal)maxX;
            numericUpDown14.Value = (decimal)maxY;
            /*chart2.ChartAreas[0].AxisX.Maximum = maxX;
            chart2.ChartAreas[0].AxisY.Maximum = maxY;
            chart2.ChartAreas[0].AxisX.Interval = maxX / countOfIntervals;
            chart2.ChartAreas[0].AxisY.Interval = maxY / countOfIntervals;*/
            chart2.Series[0].Points.Clear();
            chart2.Series[0].Points.AddXY(0, 0);
            chart2.Series[0].Points[0].IsEmpty = true;
            for (int i = 0; i < list.Count; i++)
            {
                chart2.Series[0].Points.Add(list[i]);
            }
            chart2.Series[0].Points[1].Color = Color.Red;
            chart2.Series[0].Points[1].MarkerStyle = MarkerStyle.Circle;
            chart2.Series[0].Points[1].MarkerSize = 8;
        }

        int chart3PastInd = 2;
        private void cBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart3.ChartAreas[0].AxisY.Title = ces1(cBox3.SelectedIndex);
            chart3.ChartAreas[0].AxisX.Title = ces2(cBox3.SelectedIndex);
            chart3.ChartAreas[0].AxisX.TitleAlignment = StringAlignment.Far;

            if (cBox3.SelectedIndex == 0)
            {
                setUnits(numericUpDown17, numericUpDown5, 1);
                setUnits(numericUpDown18, numericUpDown13, 0);
            }
            else if (cBox3.SelectedIndex == 1)
            {
                setUnits(numericUpDown17, numericUpDown5, 2);
                setUnits(numericUpDown18, numericUpDown13, 0);
            }
            else if (cBox3.SelectedIndex == 2)
            {
                setUnits(numericUpDown17, numericUpDown5, 2);
                setUnits(numericUpDown18, numericUpDown13, 1);
            }
            if (chart3.Series[0].Points.Count <= 1) return;
            List<DataPoint> list = new List<DataPoint>();

            double maxX = 0, maxY = 0;
            for (int i = 1; i < chart3.Series[0].Points.Count; i++)
            {
                DataPoint p = transform(chart3.Series[0].Points[i], chart3PastInd, cBox3.SelectedIndex);
                if (maxX < p.XValue) maxX = p.XValue;
                if (maxY < p.YValues[0]) maxY = p.YValues[0];
                list.Add(p);
            }
            maxX *= 1.01; maxY *= 1.01;
            chart3PastInd = cBox3.SelectedIndex;
            numericUpDown5.Value = (decimal)maxX;
            numericUpDown13.Value = (decimal)maxY;
           /* chart3.ChartAreas[0].AxisX.Maximum = maxX;
            chart3.ChartAreas[0].AxisY.Maximum = maxY;
            chart3.ChartAreas[0].AxisX.Interval = maxX / countOfIntervals;
            chart3.ChartAreas[0].AxisY.Interval = maxY / countOfIntervals;*/
            chart3.Series[0].Points.Clear();
            chart3.Series[0].Points.AddXY(0, 0);
            chart3.Series[0].Points[0].IsEmpty = true;
            for (int i = 0; i < list.Count; i++)
            {
                chart3.Series[0].Points.Add(list[i]);
            }
            chart3.Series[0].Points[1].Color = Color.Red;
            chart3.Series[0].Points[1].MarkerStyle = MarkerStyle.Circle;
            chart3.Series[0].Points[1].MarkerSize = 8;
        }
       
        void addPoint(DataPoint dp,int ind)
        {
            //dp.Color = Color.DodgerBlue;
            //    RotateImage(Image.FromFile("arrow.png"), 100f).Save("arrow1.png");
            // Image img = Image.FromFile(" ");
            //  img.
            //dp.MarkerImag
            
            if (chart1.Series[0].Points.Count == 1)
            {
                dp.Color = Color.Red;
                dp.MarkerStyle = MarkerStyle.Circle;
                dp.MarkerSize = 8;
            }
           
           
            {
                DataPoint dp2 = new DataPoint();
                dp2 = transform(dp, ind, cBox1.SelectedIndex);
                if (dp2.XValue > chart1.ChartAreas[0].AxisX.Maximum)
                {
                    MaxValX = dp2.XValue *1.01;
                    //numericUpDown3.Value = MaxValX;
                    chart1.ChartAreas[0].AxisX.Maximum = MaxValX;
                    chart1.ChartAreas[0].AxisX.Interval = MaxValX / countOfIntervals;
                    
                }
                if (dp2.YValues[0] > chart1.ChartAreas[0].AxisY.Maximum)
                {
                    MaxValY = dp2.YValues[0] *1.01;
                    chart1.ChartAreas[0].AxisY.Maximum =  MaxValY;
                    chart1.ChartAreas[0].AxisY.Interval =  MaxValY / countOfIntervals;
                }

                if (chart1.Series[0].Points.Count > 1)
                {                   
                    double prevX = (endX - oX) * chart1.Series[0].Points[chart1.Series[0].Points.Count - 1].XValue / MaxValX;
                    double prevY = (oY - endY) * chart1.Series[0].Points[chart1.Series[0].Points.Count - 1].YValues[0] / MaxValY;
                    double nowX = (endX - oX) * dp2.XValue / MaxValX;
                    double nowY = (oY - endY) * dp2.YValues[0] / MaxValY;
                    double sin = (nowY- prevY)/Math.Sqrt((nowY- prevY)*(nowY- prevY)+(nowX- prevX)*(nowX- prevX));
                    double cos = (nowX - prevX) / Math.Sqrt((nowY - prevY) * (nowY - prevY) + (nowX - prevX) * (nowX - prevX));
                    double pp = Math.Sqrt(2) / 2;
                    if (sin <= pp && sin > (-pp) && cos > 0)
                    {
                        //right
                        dp2.MarkerImage = "Right.png";
                    } else if(sin < pp && sin >= (-pp) && cos < 0)
                    {
                        //left
                        dp2.MarkerImage = "Left.png";
                    } else if (cos < pp && cos >= (-pp) && sin > 0)
                    {
                        //up
                        dp2.MarkerImage = "Up.png";
                    }
                    else
                    {
                        dp2.MarkerImage = "Down.png";
                    }
                   
                }
                chart1.Series[0].Points.Add(dp2);
            }



            {
                DataPoint dp2 = new DataPoint();
                dp2 = transform(dp, ind, cBox2.SelectedIndex);
                if (dp2.XValue > chart2.ChartAreas[0].AxisX.Maximum)
                {
                    MaxValX = dp2.XValue *1.01;
                    chart2.ChartAreas[0].AxisX.Maximum =  MaxValX;
                    chart2.ChartAreas[0].AxisX.Interval =  MaxValX / countOfIntervals;

                }
                if (dp2.YValues[0] > chart2.ChartAreas[0].AxisY.Maximum)
                {
                    MaxValY = dp2.YValues[0] *1.01;
                    chart2.ChartAreas[0].AxisY.Maximum =  MaxValY;
                    chart2.ChartAreas[0].AxisY.Interval =  MaxValY / countOfIntervals;
                }

                if (chart2.Series[0].Points.Count > 1)
                {

                    double prevX = (endX - oX) * chart2.Series[0].Points[chart2.Series[0].Points.Count - 1].XValue / MaxValX;
                    double prevY = (oY - endY) * chart2.Series[0].Points[chart2.Series[0].Points.Count - 1].YValues[0] / MaxValY;
                    double nowX = (endX - oX) * dp2.XValue / MaxValX;
                    double nowY = (oY - endY) * dp2.YValues[0] / MaxValY;
                    double sin = (nowY - prevY) / Math.Sqrt((nowY - prevY) * (nowY - prevY) + (nowX - prevX) * (nowX - prevX));
                    double cos = (nowX - prevX) / Math.Sqrt((nowY - prevY) * (nowY - prevY) + (nowX - prevX) * (nowX - prevX));
                    double pp = Math.Sqrt(2) / 2;
                    if (sin <= pp && sin > (-pp) && cos > 0)
                    {
                        //right
                        dp2.MarkerImage = "Right.png";
                    }
                    else if (sin < pp && sin >= (-pp) && cos < 0)
                    {
                        //left
                        dp2.MarkerImage = "Left.png";
                    }
                    else if (cos < pp && cos >= (-pp) && sin > 0)
                    {
                        //up
                        dp2.MarkerImage = "Up.png";
                    }
                    else
                    {
                        dp2.MarkerImage = "Down.png";
                    }

                }
                chart2.Series[0].Points.Add(dp2);
            }



            {
                DataPoint dp2 = new DataPoint();
                dp2 = transform(dp, ind, cBox3.SelectedIndex);
                if (dp2.XValue > chart3.ChartAreas[0].AxisX.Maximum)
                {
                    MaxValX = dp2.XValue *1.01;
                    chart3.ChartAreas[0].AxisX.Maximum =  MaxValX;
                    chart3.ChartAreas[0].AxisX.Interval =  MaxValX / countOfIntervals;

                }
                if (dp2.YValues[0] > chart3.ChartAreas[0].AxisY.Maximum)
                {
                    MaxValY = dp2.YValues[0] *1.01;
                    chart3.ChartAreas[0].AxisY.Maximum =  MaxValY;
                    chart3.ChartAreas[0].AxisY.Interval =  MaxValY / countOfIntervals;
                }

                if (chart3.Series[0].Points.Count > 1)
                {
                    double prevX = (endX - oX) * chart3.Series[0].Points[chart3.Series[0].Points.Count - 1].XValue / MaxValX;
                    double prevY = (oY - endY) * chart3.Series[0].Points[chart3.Series[0].Points.Count - 1].YValues[0] / MaxValY;
                    double nowX = (endX - oX) * dp2.XValue / MaxValX;
                    double nowY = (oY - endY) * dp2.YValues[0] / MaxValY;
                    double sin = (nowY - prevY) / Math.Sqrt((nowY - prevY) * (nowY - prevY) + (nowX - prevX) * (nowX - prevX));
                    double cos = (nowX - prevX) / Math.Sqrt((nowY - prevY) * (nowY - prevY) + (nowX - prevX) * (nowX - prevX));
                    double pp = Math.Sqrt(2) / 2;
                    if (sin <= pp && sin > (-pp) && cos > 0)
                    {
                        //right
                        dp2.MarkerImage = "Right.png";
                    }
                    else if (sin < pp && sin >= (-pp) && cos < 0)
                    {
                        //left
                        dp2.MarkerImage = "Left.png";
                    }
                    else if (cos < pp && cos >= (-pp) && sin > 0)
                    {
                        //up
                        dp2.MarkerImage = "Up.png";
                    }
                    else
                    {
                        dp2.MarkerImage = "Down.png";
                    }

                }
                chart3.Series[0].Points.Add(dp2);
            }




            {
                DataPoint dp2 = new DataPoint();
                dp2 = transform(dp, ind, cBox4.SelectedIndex);
                if (dp2.XValue > chart4.ChartAreas[0].AxisX.Maximum)
                {
                    MaxValX = dp2.XValue *1.01;
                    chart4.ChartAreas[0].AxisX.Maximum =  MaxValX;
                    chart4.ChartAreas[0].AxisX.Interval =  MaxValX / countOfIntervals;

                }
                if (dp2.YValues[0] > chart4.ChartAreas[0].AxisY.Maximum)
                {
                    MaxValY = dp2.YValues[0] *1.01;
                    chart4.ChartAreas[0].AxisY.Maximum =  MaxValY;
                    chart4.ChartAreas[0].AxisY.Interval =  MaxValY / countOfIntervals;
                }

                if (chart4.Series[0].Points.Count > 1)
                {
                    double prevX = (endX - oX) * chart4.Series[0].Points[chart4.Series[0].Points.Count - 1].XValue / MaxValX;
                    double prevY = (oY - endY) * chart4.Series[0].Points[chart4.Series[0].Points.Count - 1].YValues[0] / MaxValY;
                    double nowX = (endX - oX) * dp2.XValue / MaxValX;
                    double nowY = (oY - endY) * dp2.YValues[0] / MaxValY;
                    double sin = (nowY - prevY) / Math.Sqrt((nowY - prevY) * (nowY - prevY) + (nowX - prevX) * (nowX - prevX));
                    double cos = (nowX - prevX) / Math.Sqrt((nowY - prevY) * (nowY - prevY) + (nowX - prevX) * (nowX - prevX));
                    double pp = Math.Sqrt(2) / 2;
                    if (sin <= pp && sin > (-pp) && cos > 0)
                    {
                        //right
                        dp2.MarkerImage = "Right.png";
                    }
                    else if (sin < pp && sin >= (-pp) && cos < 0)
                    {
                        //left
                        dp2.MarkerImage = "Left.png";
                    }
                    else if (cos < pp && cos >= (-pp) && sin > 0)
                    {
                        //up
                        dp2.MarkerImage = "Up.png";
                    }
                    else
                    {
                        dp2.MarkerImage = "Down.png";
                    }

                }
                chart4.Series[0].Points.Add(dp2);
            }

       
        }
     
        int countOfPoints = 30;
        private void button2_Click(object sender, EventArgs e)
        {
            double mm = (double)numericUpDown2.Value;
            double step = ((double)numericUpDown9.Value - mm) / countOfPoints;
            DataPoint dp;
            if (loopFound == true) return;


            MaxValX = chart1.ChartAreas[0].AxisX.Maximum;
            MaxValY = chart1.ChartAreas[0].AxisY.Maximum;

            oX = chart1.ChartAreas[0].AxisX.ValueToPixelPosition(0);
            oY = chart1.ChartAreas[0].AxisY.ValueToPixelPosition(0);
            endX = chart1.ChartAreas[0].AxisX.ValueToPixelPosition(MaxValX);
            endY = chart1.ChartAreas[0].AxisY.ValueToPixelPosition(MaxValY);

            if ((string)comboBox2.SelectedItem == "Изобара")
            {
                for (int i = 0; i <= countOfPoints; i++)
                {
                    dp = new DataPoint();
                    dp.YValues[0] = (double)numericUpDown1.Value;
                    dp.XValue = mm + step * i;
                    if (comboBox3.SelectedIndex == 0) addPoint(dp, 0);
                    else addPoint(dp, 1);

                    double pixx = (endX - oX) * (dp.XValue - chart1.Series[0].Points[1].XValue) / MaxValX;
                    double pixy = (endY - oY) * (dp.YValues[0] - chart1.Series[0].Points[1].YValues[0]) / MaxValY;
                    double r = Math.Sqrt(pixx * pixx + pixy * pixy);
                    if (r <= 5.0 && i>10)
                    {
                        loopFound = true;
                        label33.Text = "Цикл найден";
                        return;
                    }
                }

               /* int ind = 0;
                if (chart.Name == "chart1") ind = cBox1.SelectedIndex;
                else if (chart.Name == "chart2") ind = cBox2.SelectedIndex;
                else if (chart.Name == "chart3") ind = cBox3.SelectedIndex;
                else if (chart.Name == "chart4") ind = cBox4.SelectedIndex;

                if (chart.Series[0].Points.Count >= 4)
                {
                    double pixx = (endX - oX) * (realX - chart.Series[0].Points[1].XValue) / MaxValX;
                    double pixy = (endY - oY) * (realY - chart.Series[0].Points[1].YValues[0]) / MaxValY;
                    double r = Math.Sqrt(pixx * pixx + pixy * pixy);
                    if (r <= 5.0)
                    {
                        loopFound = true;
                        label33.Text = "Цикл найден";
                    }
                }*/

            }
            else if ((string)comboBox2.SelectedItem == "Изотерма")
            {
             //   dp.YValues[0] = mm;
             //   dp.XValue = (double)numericUpDown1.Value;
             //   if (comboBox3.SelectedIndex == 0) addPoint(dp, 1); else addPoint(dp, 2);
                for (int i = 0; i <= countOfPoints; i++)
                {
                    dp = new DataPoint();
                    dp.YValues[0] = mm + step * i;
                    dp.XValue = (double)numericUpDown1.Value;
                    if (comboBox3.SelectedIndex == 0) addPoint(dp, 1);
                    else addPoint(dp, 2);

                    double pixx = (endX - oX) * (dp.XValue - chart1.Series[0].Points[1].XValue) / MaxValX;
                    double pixy = (endY - oY) * (dp.YValues[0] - chart1.Series[0].Points[1].YValues[0]) / MaxValY;
                    double r = Math.Sqrt(pixx * pixx + pixy * pixy);
                    if (r <= 5.0 && i > 10)
                    {
                        loopFound = true;
                        label33.Text = "Цикл найден";
                        return;
                    }
                }
            }
            else if ((string)comboBox2.SelectedItem == "Изохора")
            {
               
               /* if (comboBox3.SelectedIndex == 0)
                {
                    dp.YValues[0] = mm;
                    dp.XValue = (double)numericUpDown1.Value;
                    addPoint(dp, 0);
                }
                else {
                    dp.YValues[0] = (double)numericUpDown1.Value;
                    dp.XValue =mm;
                    addPoint(dp, 2);
                }*/
                for (int i = 0; i <= countOfPoints; i++)
                {
                    dp = new DataPoint();

                    if (comboBox3.SelectedIndex == 0)
                    {
                        dp.YValues[0] = mm+step*i;
                        dp.XValue = (double)numericUpDown1.Value;
                        addPoint(dp, 0);
                    }
                    else {
                        dp.YValues[0] = (double)numericUpDown1.Value;
                        dp.XValue = mm+step*i;
                        addPoint(dp, 2);
                    }

                    double pixx = (endX - oX) * (dp.XValue - chart1.Series[0].Points[1].XValue) / MaxValX;
                    double pixy = (endY - oY) * (dp.YValues[0] - chart1.Series[0].Points[1].YValues[0]) / MaxValY;
                    double r = Math.Sqrt(pixx * pixx + pixy * pixy);
                    if (r <= 5.0 && i > 10)
                    {
                        loopFound = true;
                        label33.Text = "Цикл найден";
                        return;
                    }
                }
            }
        }
        private void chart1_MouseWheel(object sender, MouseEventArgs e)
        {
            Chart chart = (Chart)sender;
            NumericUpDown Xmi=new NumericUpDown(); NumericUpDown Xma = new NumericUpDown();
            NumericUpDown Ymi = new NumericUpDown(); NumericUpDown Yma = new NumericUpDown();
            if (chart.Name == "chart1")
            {
                Xmi = numericUpDown7; Xma = numericUpDown3; Ymi = numericUpDown8; Yma = numericUpDown15;
            }
            else if (chart.Name == "chart2")
            {
                Xmi = numericUpDown10; Xma = numericUpDown4; Ymi = numericUpDown11; Yma = numericUpDown14;
            }
            else if (chart.Name == "chart3")
            {
                Xmi = numericUpDown17; Xma = numericUpDown5; Ymi = numericUpDown18; Yma = numericUpDown13;
            }
            else if (chart.Name == "chart4")
            {
                Xmi = numericUpDown20; Xma = numericUpDown6; Ymi = numericUpDown19; Yma = numericUpDown12;
            }
            if (e.Delta > 0)
            {
               Xma.Value*= (decimal)1.05;
               Yma.Value *= (decimal)1.05;
                Xmi.Value/= (decimal)1.05;
                Ymi.Value /= (decimal)1.05;
            }
            else
            {
                if ((double)Xma.Value /1.05 > (double)Xmi.Value * 1.05)
                {
                    Xma.Value /= (decimal)1.05;
                    Xmi.Value *= (decimal)1.05;
                }
                if ((double)Yma.Value / 1.05 > (double)Ymi.Value * 1.05)
                {
                    Yma.Value /= (decimal)1.05;
                    Ymi.Value *= (decimal)1.05;
                }
               
            }
            

        }
        private void chart1_MouseUp(object sender, MouseEventArgs e)
        {
            numericUpDown3.Value = (decimal)chart1.ChartAreas[0].AxisX.Maximum;
            numericUpDown15.Value = (decimal)chart1.ChartAreas[0].AxisY.Maximum;

            numericUpDown4.Value = (decimal)chart2.ChartAreas[0].AxisX.Maximum;
            numericUpDown14.Value = (decimal)chart2.ChartAreas[0].AxisY.Maximum;

            numericUpDown5.Value = (decimal)chart3.ChartAreas[0].AxisX.Maximum;
            numericUpDown13.Value = (decimal)chart3.ChartAreas[0].AxisY.Maximum;

            numericUpDown6.Value = (decimal)chart4.ChartAreas[0].AxisX.Maximum;
            numericUpDown12.Value = (decimal)chart4.ChartAreas[0].AxisY.Maximum;
        }

        private void chart2_MouseUp(object sender, MouseEventArgs e)
        {
            numericUpDown3.Value = (decimal)chart1.ChartAreas[0].AxisX.Maximum;
            numericUpDown15.Value = (decimal)chart1.ChartAreas[0].AxisY.Maximum;

            numericUpDown4.Value = (decimal)chart2.ChartAreas[0].AxisX.Maximum;
            numericUpDown14.Value = (decimal)chart2.ChartAreas[0].AxisY.Maximum;

            numericUpDown5.Value = (decimal)chart3.ChartAreas[0].AxisX.Maximum;
            numericUpDown13.Value = (decimal)chart3.ChartAreas[0].AxisY.Maximum;

            numericUpDown6.Value = (decimal)chart4.ChartAreas[0].AxisX.Maximum;
            numericUpDown12.Value = (decimal)chart4.ChartAreas[0].AxisY.Maximum;
        }

        private void chart3_MouseUp(object sender, MouseEventArgs e)
        {
            numericUpDown3.Value = (decimal)chart1.ChartAreas[0].AxisX.Maximum;
            numericUpDown15.Value = (decimal)chart1.ChartAreas[0].AxisY.Maximum;

            numericUpDown4.Value = (decimal)chart2.ChartAreas[0].AxisX.Maximum;
            numericUpDown14.Value = (decimal)chart2.ChartAreas[0].AxisY.Maximum;

            numericUpDown5.Value = (decimal)chart3.ChartAreas[0].AxisX.Maximum;
            numericUpDown13.Value = (decimal)chart3.ChartAreas[0].AxisY.Maximum;

            numericUpDown6.Value = (decimal)chart4.ChartAreas[0].AxisX.Maximum;
            numericUpDown12.Value = (decimal)chart4.ChartAreas[0].AxisY.Maximum;
        }

        private void chart4_MouseUp(object sender, MouseEventArgs e)
        {
            numericUpDown3.Value = (decimal)chart1.ChartAreas[0].AxisX.Maximum;
            numericUpDown15.Value = (decimal)chart1.ChartAreas[0].AxisY.Maximum;

            numericUpDown4.Value = (decimal)chart2.ChartAreas[0].AxisX.Maximum;
            numericUpDown14.Value = (decimal)chart2.ChartAreas[0].AxisY.Maximum;

            numericUpDown5.Value = (decimal)chart3.ChartAreas[0].AxisX.Maximum;
            numericUpDown13.Value = (decimal)chart3.ChartAreas[0].AxisY.Maximum;

            numericUpDown6.Value = (decimal)chart4.ChartAreas[0].AxisX.Maximum;
            numericUpDown12.Value = (decimal)chart4.ChartAreas[0].AxisY.Maximum;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
        int I = 3;
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == 0) I = 3;
            else if (comboBox4.SelectedIndex == 1) I = 5;
            else if (comboBox4.SelectedIndex == 2) I = 6;
         
        }

        void rerere(Chart chart)
        {
            chart.ChartAreas[0].AxisX.Interval = ((chart.ChartAreas[0].AxisX.Maximum - chart.ChartAreas[0].AxisX.Minimum )/ countOfIntervals);
            chart.ChartAreas[0].AxisY.Interval = ((chart.ChartAreas[0].AxisY.Maximum - chart.ChartAreas[0].AxisY.Minimum)/ countOfIntervals);
        }
        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDownEx numUD = (NumericUpDownEx)sender;
          //  if((double)numUD.Value< chart1.ChartAreas[0].AxisX.Maximum)
            chart1.ChartAreas[0].AxisX.Minimum = (double)numUD.Value;
            numericUpDown3.Minimum = numUD.Value;

            if (numUD.ContainsFocus) numUD.changeText(0);
            else numUD.changeText();
            rerere(chart1);
        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDownEx numUD = (NumericUpDownEx)sender;
            chart1.ChartAreas[0].AxisY.Minimum = (double)numUD.Value;
            numericUpDown15.Minimum = numUD.Value;
            if (numUD.ContainsFocus) numUD.changeText(0);
            else numUD.changeText();
            rerere(chart1);
        }

        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDownEx numUD = (NumericUpDownEx)sender;
            chart2.ChartAreas[0].AxisX.Minimum = (double)numUD.Value;
            numericUpDown4.Minimum = numUD.Value;
            if (numUD.ContainsFocus) numUD.changeText(0);
            else numUD.changeText();
            rerere(chart2);
        }

        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDownEx numUD = (NumericUpDownEx)sender;
            chart2.ChartAreas[0].AxisY.Minimum = (double)numUD.Value; rerere(chart2);
            numericUpDown14.Minimum = numUD.Value;
            if (numUD.ContainsFocus) numUD.changeText(0);
            else numUD.changeText();
        }

        private void numericUpDown17_ValueChanged(object sender, EventArgs e)
        {
           NumericUpDownEx numUD = (NumericUpDownEx)sender;
            chart3.ChartAreas[0].AxisX.Minimum = (double)numUD.Value; rerere(chart3);
            numericUpDown5.Minimum = numUD.Value;
            if (numUD.ContainsFocus) numUD.changeText(0);
            else numUD.changeText();
        }

        private void numericUpDown18_ValueChanged(object sender, EventArgs e)
        {
           NumericUpDownEx numUD = (NumericUpDownEx)sender;
            chart3.ChartAreas[0].AxisY.Minimum = (double)numUD.Value; rerere(chart3);
            numericUpDown13.Minimum = numUD.Value;
            if (numUD.ContainsFocus) numUD.changeText(0);
            else numUD.changeText();
        }

        private void numericUpDown20_ValueChanged(object sender, EventArgs e)
        {
           NumericUpDownEx numUD = (NumericUpDownEx)sender;
            chart4.ChartAreas[0].AxisX.Minimum = (double)numUD.Value; rerere(chart4);
            numericUpDown6.Minimum = numUD.Value;
            if (numUD.ContainsFocus) numUD.changeText(0);
            else numUD.changeText();
        }

        private void numericUpDown19_ValueChanged(object sender, EventArgs e)
        {
           NumericUpDownEx numUD = (NumericUpDownEx)sender;
            chart4.ChartAreas[0].AxisY.Minimum = (double)numUD.Value; rerere(chart4);
            numericUpDown12.Minimum = numUD.Value;
            if (numUD.ContainsFocus) numUD.changeText(0);
            else numUD.changeText();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDownEx numUD = (NumericUpDownEx)sender;
            if (numUD.ContainsFocus) numUD.changeText(0);
            else numUD.changeText();
        }

        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if ((string)comboBox3.SelectedItem == "V")
            {
                numericUpDown2.unit = getU(1);
                numericUpDown2.changeText();
                numericUpDown9.unit = getU(1);
                numericUpDown9.changeText();
            }
            else if ((string)comboBox3.SelectedItem == "P")
            {
                numericUpDown2.unit = getU(0);
                numericUpDown2.changeText();
                numericUpDown9.unit = getU(0);
                numericUpDown9.changeText();
            }
            else if ((string)comboBox3.SelectedItem == "T")
            {
                numericUpDown2.unit = getU(2);
                numericUpDown2.changeText();
                numericUpDown9.unit = getU(2);
                numericUpDown9.changeText();
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown2.changeText();
        }

        private void numericUpDown2_Enter(object sender, EventArgs e)
        {
            NumericUpDownEx n = (NumericUpDownEx)sender;
            n.changeText(0);       
        }
        void reScale(Chart chart,NumericUpDown Xmi, NumericUpDown Xma, NumericUpDown Ymi, NumericUpDown Yma)
        {

            if (chart.Series[0].Points.Count == 1)
            {
                Xmi.Value = 0;
                Xma.Value = 100;
                Ymi.Value = 0;
                Yma.Value = 100;
                return;

            }
            double MaxX, MinX, MaxY, MinY;
            MaxX = MinX = chart.Series[0].Points[1].XValue;
            MaxY = MinY = chart.Series[0].Points[1].YValues[0];
            for (int i=2;i< chart.Series[0].Points.Count; i++)
            {
                MaxX = Math.Max(chart.Series[0].Points[i].XValue, MaxX);
                MaxY = Math.Max(chart.Series[0].Points[i].YValues[0], MaxY);
                MinX = Math.Min(chart.Series[0].Points[i].XValue, MinX);
                MinY = Math.Min(chart.Series[0].Points[i].YValues[0], MinY);

            }
            //chart.ChartAreas[0].AxisX.Maximum = MaxX * 1.01+1;
            //chart.ChartAreas[0].AxisY.Maximum = MaxY * 1.01+1;
            //chart.ChartAreas[0].AxisX.Minimum = MinX / 1.01;
            //chart.ChartAreas[0].AxisY.Minimum = MinY / 1.01;
            //chart.ChartAreas[0].AxisX.Interval = (((chart.ChartAreas[0].AxisX.Maximum - chart.ChartAreas[0].AxisX.Minimum) / countOfIntervals));
            //chart.ChartAreas[0].AxisY.Interval = (((chart.ChartAreas[0].AxisY.Maximum - chart.ChartAreas[0].AxisY.Minimum) / countOfIntervals));

            MaxX = MaxX * 1.01;
            MaxY = MaxY * 1.01;
            MinX/= 1.01;
            MinY/= 1.01;
            if (MinX > (double)Xma.Value)
            {
                Xma.Value = (decimal)Math.Round(MaxX);
                Xmi.Value = (decimal)Math.Floor(MinX);
            }
            else
            {
                Xmi.Value = (decimal)Math.Floor(MinX);
                Xma.Value = (decimal)Math.Round(MaxX);
              
            }
            if (MinY > (double)Yma.Value)
            {
                Yma.Value = (decimal)Math.Round(MaxY);
                Ymi.Value = (decimal)Math.Floor(MinY);              
            }
            else
            {
                Ymi.Value = (decimal)Math.Floor(MinY);
                Yma.Value = (decimal)Math.Round(MaxY);
            }         
           
            

        }
        private void button4_Click(object sender, EventArgs e)
        {
            reScale(chart1,numericUpDown7, numericUpDown3, numericUpDown8, numericUpDown15);
            reScale(chart2, numericUpDown10, numericUpDown4, numericUpDown11, numericUpDown14);
            reScale(chart3, numericUpDown17, numericUpDown5, numericUpDown18, numericUpDown13);
            reScale(chart4, numericUpDown20, numericUpDown6, numericUpDown19, numericUpDown12);
        }

        private void numericUpDown7_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_Leave(object sender, EventArgs e)
        {
            NumericUpDownEx n = (NumericUpDownEx)sender;
            n.changeText();
            
        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown9.changeText();
        }

        void reDraw(Chart chart)
        {
            int ind = 0;           
            if (chart.Name == "chart2") ind = cBox2.SelectedIndex;
            else if (chart.Name == "chart3") ind = cBox3.SelectedIndex;
            else if (chart.Name == "chart4") ind = cBox4.SelectedIndex;
            List<DataPoint> list = new List<DataPoint>();
            for (int i = 1; i < chart1.Series[0].Points.Count; i++)
            {
                list.Add(transform(chart1.Series[0].Points[i], cBox1.SelectedIndex, ind));
            }
            chart.Series[0].Points.Clear();
            chart.Series[0].Points.AddXY(0, 0);
            chart.Series[0].Points[0].IsEmpty = true;
            for (int i = 0; i < list.Count; i++)
            {
                chart.Series[0].Points.Add(list[i]);
            }

        }
        private void moll_ValueChanged(object sender, EventArgs e)
        {
            reDraw(chart2); reDraw(chart3);
            reDraw(chart4);
        }

        private void comboBox4_ValueMemberChanged(object sender, EventArgs e)
        {

        }



        /*  private void numericUpDown7_Click(object sender, EventArgs e)
          {
              NumericUpDownEx n = (NumericUpDownEx)sender;
              n.changeText(0);
          }*/

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
