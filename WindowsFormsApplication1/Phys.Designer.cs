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
    public class NumericUpDownEx : NumericUpDown
    {
        public NumericUpDownEx()
        {
        }
        public string unit = "";
        public void changeText()
        {
            this.Text = string.Format("{0:0.}", Value) + " " + unit;
        }
        public void changeText(int i)
        {
            this.Text = string.Format("{0:0.}", Value);
        }
        protected override void UpdateEditText()
        {
            // Append the units to the end of the numeric value
          //  this.Text = this.Value + " ";//+ unit;
        }
    }
    partial class Phys
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Phys));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button2 = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cBox1 = new System.Windows.Forms.ComboBox();
            this.cBox3 = new System.Windows.Forms.ComboBox();
            this.cBox2 = new System.Windows.Forms.ComboBox();
            this.cBox4 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.moll = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown19 = new WindowsFormsApplication1.NumericUpDownEx();
            this.numericUpDown20 = new WindowsFormsApplication1.NumericUpDownEx();
            this.numericUpDown18 = new WindowsFormsApplication1.NumericUpDownEx();
            this.numericUpDown17 = new WindowsFormsApplication1.NumericUpDownEx();
            this.numericUpDown11 = new WindowsFormsApplication1.NumericUpDownEx();
            this.numericUpDown10 = new WindowsFormsApplication1.NumericUpDownEx();
            this.numericUpDown8 = new WindowsFormsApplication1.NumericUpDownEx();
            this.numericUpDown7 = new WindowsFormsApplication1.NumericUpDownEx();
            this.numericUpDown15 = new WindowsFormsApplication1.NumericUpDownEx();
            this.numericUpDown14 = new WindowsFormsApplication1.NumericUpDownEx();
            this.numericUpDown13 = new WindowsFormsApplication1.NumericUpDownEx();
            this.numericUpDown12 = new WindowsFormsApplication1.NumericUpDownEx();
            this.numericUpDown9 = new WindowsFormsApplication1.NumericUpDownEx();
            this.numericUpDown6 = new WindowsFormsApplication1.NumericUpDownEx();
            this.numericUpDown5 = new WindowsFormsApplication1.NumericUpDownEx();
            this.numericUpDown4 = new WindowsFormsApplication1.NumericUpDownEx();
            this.numericUpDown3 = new WindowsFormsApplication1.NumericUpDownEx();
            this.numericUpDown2 = new WindowsFormsApplication1.NumericUpDownEx();
            this.numericUpDown1 = new WindowsFormsApplication1.NumericUpDownEx();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.chart1.Location = new System.Drawing.Point(499, 13);
            this.chart1.Margin = new System.Windows.Forms.Padding(0);
            this.chart1.Name = "chart1";
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(385, 301);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            this.chart1.Paint += new System.Windows.Forms.PaintEventHandler(this.chart1_Paint);
            this.chart1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseDown);
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            this.chart1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseUp);
            this.chart1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseWheel);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(49, 434);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Создать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chart2
            // 
            this.chart2.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.chart2.Location = new System.Drawing.Point(866, 12);
            this.chart2.Margin = new System.Windows.Forms.Padding(0);
            this.chart2.Name = "chart2";
            this.chart2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(390, 313);
            this.chart2.TabIndex = 9;
            this.chart2.Text = "chart2";
            this.chart2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            this.chart2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            this.chart2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chart2_MouseUp);
            this.chart2.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseWheel);
            // 
            // chart3
            // 
            this.chart3.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            this.chart3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.chart3.Location = new System.Drawing.Point(499, 317);
            this.chart3.Margin = new System.Windows.Forms.Padding(0);
            this.chart3.Name = "chart3";
            this.chart3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(356, 303);
            this.chart3.TabIndex = 10;
            this.chart3.Text = "chart3";
            this.chart3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseDown);
            this.chart3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            this.chart3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chart3_MouseUp);
            this.chart3.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseWheel);
            // 
            // chart4
            // 
            this.chart4.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea4.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea4);
            this.chart4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.chart4.Location = new System.Drawing.Point(837, 317);
            this.chart4.Margin = new System.Windows.Forms.Padding(0);
            this.chart4.Name = "chart4";
            this.chart4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart4.Series.Add(series4);
            this.chart4.Size = new System.Drawing.Size(390, 301);
            this.chart4.TabIndex = 11;
            this.chart4.Text = "chart4";
            this.chart4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseDown);
            this.chart4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            this.chart4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chart4_MouseUp);
            this.chart4.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseWheel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 534);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "Работа:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(49, 581);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "КПД(%)";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            1,
            2,
            3,
            4});
            this.comboBox1.Location = new System.Drawing.Point(265, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(38, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(144, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Количество графиков";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Создать процесс";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Изобара",
            "Изотерма",
            "Изохора"});
            this.comboBox2.Location = new System.Drawing.Point(130, 322);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(88, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "График 1";
            // 
            // cBox1
            // 
            this.cBox1.FormattingEnabled = true;
            this.cBox1.Items.AddRange(new object[] {
            "P(V)",
            "P(T)",
            "V(T)"});
            this.cBox1.Location = new System.Drawing.Point(21, 100);
            this.cBox1.Name = "cBox1";
            this.cBox1.Size = new System.Drawing.Size(44, 21);
            this.cBox1.TabIndex = 21;
            this.cBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // cBox3
            // 
            this.cBox3.FormattingEnabled = true;
            this.cBox3.Items.AddRange(new object[] {
            "P(V)",
            "P(T)",
            "V(T)"});
            this.cBox3.Location = new System.Drawing.Point(22, 209);
            this.cBox3.Name = "cBox3";
            this.cBox3.Size = new System.Drawing.Size(43, 21);
            this.cBox3.TabIndex = 22;
            this.cBox3.SelectedIndexChanged += new System.EventHandler(this.cBox3_SelectedIndexChanged);
            // 
            // cBox2
            // 
            this.cBox2.FormattingEnabled = true;
            this.cBox2.Items.AddRange(new object[] {
            "P(V)",
            "P(T)",
            "V(T)"});
            this.cBox2.Location = new System.Drawing.Point(262, 100);
            this.cBox2.Name = "cBox2";
            this.cBox2.Size = new System.Drawing.Size(45, 21);
            this.cBox2.TabIndex = 23;
            this.cBox2.SelectedIndexChanged += new System.EventHandler(this.cBox2_SelectedIndexChanged);
            // 
            // cBox4
            // 
            this.cBox4.FormattingEnabled = true;
            this.cBox4.Items.AddRange(new object[] {
            "P(V)",
            "P(T)",
            "V(T)"});
            this.cBox4.Location = new System.Drawing.Point(265, 209);
            this.cBox4.Name = "cBox4";
            this.cBox4.Size = new System.Drawing.Size(42, 21);
            this.cBox4.TabIndex = 24;
            this.cBox4.SelectedIndexChanged += new System.EventHandler(this.cBox4_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(168, 546);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 18);
            this.label13.TabIndex = 28;
            this.label13.Text = "-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(168, 581);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 18);
            this.label14.TabIndex = 29;
            this.label14.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(253, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Зависимость";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(477, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 20);
            this.label16.TabIndex = 31;
            this.label16.Text = "1";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(797, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 18);
            this.label17.TabIndex = 32;
            this.label17.Text = "2";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(449, 314);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 18);
            this.label18.TabIndex = 33;
            this.label18.Text = "3";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(797, 314);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 18);
            this.label19.TabIndex = 34;
            this.label19.Text = "4";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(169, 367);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(20, 13);
            this.label20.TabIndex = 35;
            this.label20.Text = "От";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 35);
            this.button1.TabIndex = 52;
            this.button1.Text = "Посчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(385, 567);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 55;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label28.Location = new System.Drawing.Point(45, 376);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(17, 16);
            this.label28.TabIndex = 56;
            this.label28.Text = "P";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(167, 402);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(22, 13);
            this.label29.TabIndex = 58;
            this.label29.Text = "До";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(201, 72);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(14, 13);
            this.label31.TabIndex = 67;
            this.label31.Text = "Y";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(121, 72);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(14, 13);
            this.label32.TabIndex = 68;
            this.label32.Text = "X";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(373, 593);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(87, 13);
            this.label33.TabIndex = 69;
            this.label33.Text = "Цикл не найден";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(23, 278);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(101, 13);
            this.label34.TabIndex = 70;
            this.label34.Text = "Количество молей";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(281, 377);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(38, 21);
            this.comboBox3.TabIndex = 72;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged_1);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Одноатомный",
            "Двухатомный",
            "Многоатомный"});
            this.comboBox4.Location = new System.Drawing.Point(330, 275);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(99, 21);
            this.comboBox4.TabIndex = 73;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            this.comboBox4.ValueMemberChanged += new System.EventHandler(this.comboBox4_ValueMemberChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "Газ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(347, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 78;
            this.label3.Text = "График 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 81;
            this.label4.Text = "до";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 82;
            this.label5.Text = "от";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(88, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 18);
            this.label12.TabIndex = 83;
            this.label12.Text = "График 3";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(346, 156);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(74, 18);
            this.label21.TabIndex = 88;
            this.label21.Text = "График 4";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(310, 94);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(18, 13);
            this.label27.TabIndex = 90;
            this.label27.Text = "от";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(310, 120);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(19, 13);
            this.label30.TabIndex = 89;
            this.label30.Text = "до";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(71, 201);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(18, 13);
            this.label35.TabIndex = 92;
            this.label35.Text = "от";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(70, 224);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(19, 13);
            this.label36.TabIndex = 91;
            this.label36.Text = "до";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(310, 197);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(18, 13);
            this.label37.TabIndex = 94;
            this.label37.Text = "от";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(310, 225);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(19, 13);
            this.label38.TabIndex = 93;
            this.label38.Text = "до";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 95;
            this.label10.Text = "Зависимость";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(357, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 97;
            this.label11.Text = "X";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(443, 72);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(14, 13);
            this.label22.TabIndex = 96;
            this.label22.Text = "Y";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(14, 180);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(75, 13);
            this.label23.TabIndex = 100;
            this.label23.Text = "Зависимость";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(121, 180);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(14, 13);
            this.label24.TabIndex = 99;
            this.label24.Text = "X";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(201, 180);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(14, 13);
            this.label25.TabIndex = 98;
            this.label25.Text = "Y";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(253, 180);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(75, 13);
            this.label26.TabIndex = 103;
            this.label26.Text = "Зависимость";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(357, 181);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(14, 13);
            this.label39.TabIndex = 102;
            this.label39.Text = "X";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(443, 179);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(14, 13);
            this.label40.TabIndex = 101;
            this.label40.Text = "Y";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(385, 534);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 104;
            this.button4.Text = "ReScale";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // moll
            // 
            this.moll.DecimalPlaces = 2;
            this.moll.Location = new System.Drawing.Point(130, 276);
            this.moll.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.moll.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.moll.Name = "moll";
            this.moll.Size = new System.Drawing.Size(46, 20);
            this.moll.TabIndex = 71;
            this.moll.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.moll.ValueChanged += new System.EventHandler(this.moll_ValueChanged);
            // 
            // numericUpDown19
            // 
            this.numericUpDown19.DecimalPlaces = 1;
            this.numericUpDown19.Location = new System.Drawing.Point(410, 197);
            this.numericUpDown19.Maximum = new decimal(new int[] {
            500000000,
            0,
            0,
            0});
            this.numericUpDown19.Name = "numericUpDown19";
            this.numericUpDown19.Size = new System.Drawing.Size(79, 20);
            this.numericUpDown19.TabIndex = 87;
            this.numericUpDown19.ValueChanged += new System.EventHandler(this.numericUpDown19_ValueChanged);
            this.numericUpDown19.Enter += new System.EventHandler(this.numericUpDown2_Enter);
            this.numericUpDown19.Leave += new System.EventHandler(this.numericUpDown2_Leave);
            // 
            // numericUpDown20
            // 
            this.numericUpDown20.DecimalPlaces = 1;
            this.numericUpDown20.Location = new System.Drawing.Point(330, 197);
            this.numericUpDown20.Maximum = new decimal(new int[] {
            500000000,
            0,
            0,
            0});
            this.numericUpDown20.Name = "numericUpDown20";
            this.numericUpDown20.Size = new System.Drawing.Size(74, 20);
            this.numericUpDown20.TabIndex = 86;
            this.numericUpDown20.ValueChanged += new System.EventHandler(this.numericUpDown20_ValueChanged);
            this.numericUpDown20.Enter += new System.EventHandler(this.numericUpDown2_Enter);
            this.numericUpDown20.Leave += new System.EventHandler(this.numericUpDown2_Leave);
            // 
            // numericUpDown18
            // 
            this.numericUpDown18.DecimalPlaces = 1;
            this.numericUpDown18.Location = new System.Drawing.Point(174, 199);
            this.numericUpDown18.Maximum = new decimal(new int[] {
            500000000,
            0,
            0,
            0});
            this.numericUpDown18.Name = "numericUpDown18";
            this.numericUpDown18.Size = new System.Drawing.Size(77, 20);
            this.numericUpDown18.TabIndex = 85;
            this.numericUpDown18.ValueChanged += new System.EventHandler(this.numericUpDown18_ValueChanged);
            this.numericUpDown18.Enter += new System.EventHandler(this.numericUpDown2_Enter);
            this.numericUpDown18.Leave += new System.EventHandler(this.numericUpDown2_Leave);
            // 
            // numericUpDown17
            // 
            this.numericUpDown17.DecimalPlaces = 1;
            this.numericUpDown17.Location = new System.Drawing.Point(91, 199);
            this.numericUpDown17.Maximum = new decimal(new int[] {
            500000000,
            0,
            0,
            0});
            this.numericUpDown17.Name = "numericUpDown17";
            this.numericUpDown17.Size = new System.Drawing.Size(78, 20);
            this.numericUpDown17.TabIndex = 84;
            this.numericUpDown17.ValueChanged += new System.EventHandler(this.numericUpDown17_ValueChanged);
            this.numericUpDown17.Enter += new System.EventHandler(this.numericUpDown2_Enter);
            this.numericUpDown17.Leave += new System.EventHandler(this.numericUpDown2_Leave);
            // 
            // numericUpDown11
            // 
            this.numericUpDown11.DecimalPlaces = 1;
            this.numericUpDown11.Location = new System.Drawing.Point(410, 92);
            this.numericUpDown11.Maximum = new decimal(new int[] {
            500000000,
            0,
            0,
            0});
            this.numericUpDown11.Name = "numericUpDown11";
            this.numericUpDown11.Size = new System.Drawing.Size(73, 20);
            this.numericUpDown11.TabIndex = 80;
            this.numericUpDown11.ValueChanged += new System.EventHandler(this.numericUpDown11_ValueChanged);
            this.numericUpDown11.Enter += new System.EventHandler(this.numericUpDown2_Enter);
            this.numericUpDown11.Leave += new System.EventHandler(this.numericUpDown2_Leave);
            // 
            // numericUpDown10
            // 
            this.numericUpDown10.DecimalPlaces = 1;
            this.numericUpDown10.Location = new System.Drawing.Point(330, 92);
            this.numericUpDown10.Maximum = new decimal(new int[] {
            500000000,
            0,
            0,
            0});
            this.numericUpDown10.Name = "numericUpDown10";
            this.numericUpDown10.Size = new System.Drawing.Size(74, 20);
            this.numericUpDown10.TabIndex = 79;
            this.numericUpDown10.ValueChanged += new System.EventHandler(this.numericUpDown10_ValueChanged);
            this.numericUpDown10.Enter += new System.EventHandler(this.numericUpDown2_Enter);
            this.numericUpDown10.Leave += new System.EventHandler(this.numericUpDown2_Leave);
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.DecimalPlaces = 1;
            this.numericUpDown8.Location = new System.Drawing.Point(172, 90);
            this.numericUpDown8.Maximum = new decimal(new int[] {
            500000000,
            0,
            0,
            0});
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(79, 20);
            this.numericUpDown8.TabIndex = 77;
            this.numericUpDown8.ValueChanged += new System.EventHandler(this.numericUpDown8_ValueChanged);
            this.numericUpDown8.Enter += new System.EventHandler(this.numericUpDown2_Enter);
            this.numericUpDown8.Leave += new System.EventHandler(this.numericUpDown2_Leave);
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.DecimalPlaces = 1;
            this.numericUpDown7.Location = new System.Drawing.Point(91, 90);
            this.numericUpDown7.Maximum = new decimal(new int[] {
            500000000,
            0,
            0,
            0});
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(78, 20);
            this.numericUpDown7.TabIndex = 76;
            this.numericUpDown7.ValueChanged += new System.EventHandler(this.numericUpDown7_ValueChanged);
            this.numericUpDown7.Enter += new System.EventHandler(this.numericUpDown2_Enter);
            this.numericUpDown7.Leave += new System.EventHandler(this.numericUpDown2_Leave);
            // 
            // numericUpDown15
            // 
            this.numericUpDown15.DecimalPlaces = 1;
            this.numericUpDown15.Location = new System.Drawing.Point(172, 115);
            this.numericUpDown15.Maximum = new decimal(new int[] {
            500000000,
            0,
            0,
            0});
            this.numericUpDown15.Name = "numericUpDown15";
            this.numericUpDown15.Size = new System.Drawing.Size(79, 20);
            this.numericUpDown15.TabIndex = 66;
            this.numericUpDown15.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown15.ValueChanged += new System.EventHandler(this.numericUpDown15_ValueChanged);
            this.numericUpDown15.Enter += new System.EventHandler(this.numericUpDown2_Enter);
            this.numericUpDown15.Leave += new System.EventHandler(this.numericUpDown2_Leave);
            // 
            // numericUpDown14
            // 
            this.numericUpDown14.DecimalPlaces = 1;
            this.numericUpDown14.Location = new System.Drawing.Point(410, 116);
            this.numericUpDown14.Maximum = new decimal(new int[] {
            500000000,
            0,
            0,
            0});
            this.numericUpDown14.Name = "numericUpDown14";
            this.numericUpDown14.Size = new System.Drawing.Size(73, 20);
            this.numericUpDown14.TabIndex = 65;
            this.numericUpDown14.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown14.ValueChanged += new System.EventHandler(this.numericUpDown14_ValueChanged);
            this.numericUpDown14.Enter += new System.EventHandler(this.numericUpDown2_Enter);
            this.numericUpDown14.Leave += new System.EventHandler(this.numericUpDown2_Leave);
            // 
            // numericUpDown13
            // 
            this.numericUpDown13.DecimalPlaces = 1;
            this.numericUpDown13.Location = new System.Drawing.Point(174, 225);
            this.numericUpDown13.Maximum = new decimal(new int[] {
            500000000,
            0,
            0,
            0});
            this.numericUpDown13.Name = "numericUpDown13";
            this.numericUpDown13.Size = new System.Drawing.Size(77, 20);
            this.numericUpDown13.TabIndex = 64;
            this.numericUpDown13.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown13.ValueChanged += new System.EventHandler(this.numericUpDown13_ValueChanged);
            this.numericUpDown13.Enter += new System.EventHandler(this.numericUpDown2_Enter);
            this.numericUpDown13.Leave += new System.EventHandler(this.numericUpDown2_Leave);
            // 
            // numericUpDown12
            // 
            this.numericUpDown12.DecimalPlaces = 1;
            this.numericUpDown12.Location = new System.Drawing.Point(410, 223);
            this.numericUpDown12.Maximum = new decimal(new int[] {
            500000000,
            0,
            0,
            0});
            this.numericUpDown12.Name = "numericUpDown12";
            this.numericUpDown12.Size = new System.Drawing.Size(79, 20);
            this.numericUpDown12.TabIndex = 63;
            this.numericUpDown12.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown12.ValueChanged += new System.EventHandler(this.numericUpDown12_ValueChanged);
            this.numericUpDown12.Enter += new System.EventHandler(this.numericUpDown2_Enter);
            this.numericUpDown12.Leave += new System.EventHandler(this.numericUpDown2_Leave);
            // 
            // numericUpDown9
            // 
            this.numericUpDown9.Location = new System.Drawing.Point(195, 400);
            this.numericUpDown9.Maximum = new decimal(new int[] {
            50000000,
            0,
            0,
            0});
            this.numericUpDown9.Name = "numericUpDown9";
            this.numericUpDown9.Size = new System.Drawing.Size(68, 20);
            this.numericUpDown9.TabIndex = 59;
            this.numericUpDown9.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.numericUpDown9.Enter += new System.EventHandler(this.numericUpDown2_Enter);
            this.numericUpDown9.Leave += new System.EventHandler(this.numericUpDown2_Leave);
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.DecimalPlaces = 1;
            this.numericUpDown6.Location = new System.Drawing.Point(330, 222);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            500000000,
            0,
            0,
            0});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(74, 20);
            this.numericUpDown6.TabIndex = 51;
            this.numericUpDown6.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown6.ValueChanged += new System.EventHandler(this.numericUpDown6_ValueChanged);
            this.numericUpDown6.Enter += new System.EventHandler(this.numericUpDown2_Enter);
            this.numericUpDown6.Leave += new System.EventHandler(this.numericUpDown2_Leave);
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.DecimalPlaces = 1;
            this.numericUpDown5.Location = new System.Drawing.Point(92, 225);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            500000000,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(77, 20);
            this.numericUpDown5.TabIndex = 50;
            this.numericUpDown5.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown5.ValueChanged += new System.EventHandler(this.numericUpDown5_ValueChanged);
            this.numericUpDown5.Enter += new System.EventHandler(this.numericUpDown2_Enter);
            this.numericUpDown5.Leave += new System.EventHandler(this.numericUpDown2_Leave);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.DecimalPlaces = 1;
            this.numericUpDown4.Location = new System.Drawing.Point(330, 116);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            500000000,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(74, 20);
            this.numericUpDown4.TabIndex = 49;
            this.numericUpDown4.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            this.numericUpDown4.Enter += new System.EventHandler(this.numericUpDown2_Enter);
            this.numericUpDown4.Leave += new System.EventHandler(this.numericUpDown2_Leave);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 1;
            this.numericUpDown3.Location = new System.Drawing.Point(91, 116);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            500000000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(78, 20);
            this.numericUpDown3.TabIndex = 48;
            this.numericUpDown3.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            this.numericUpDown3.Enter += new System.EventHandler(this.numericUpDown2_Enter);
            this.numericUpDown3.Leave += new System.EventHandler(this.numericUpDown2_Leave);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(195, 365);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            50000000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(68, 20);
            this.numericUpDown2.TabIndex = 38;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.numericUpDown2.Enter += new System.EventHandler(this.numericUpDown2_Enter);
            this.numericUpDown2.Leave += new System.EventHandler(this.numericUpDown2_Leave);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(69, 376);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            50000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(66, 20);
            this.numericUpDown1.TabIndex = 37;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.numericUpDown1.Enter += new System.EventHandler(this.numericUpDown2_Enter);
            this.numericUpDown1.Leave += new System.EventHandler(this.numericUpDown2_Leave);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1389, 662);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.numericUpDown19);
            this.Controls.Add(this.numericUpDown20);
            this.Controls.Add(this.numericUpDown18);
            this.Controls.Add(this.numericUpDown17);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown11);
            this.Controls.Add(this.numericUpDown10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown8);
            this.Controls.Add(this.numericUpDown7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.moll);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.numericUpDown15);
            this.Controls.Add(this.numericUpDown14);
            this.Controls.Add(this.numericUpDown13);
            this.Controls.Add(this.numericUpDown12);
            this.Controls.Add(this.numericUpDown9);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown6);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cBox4);
            this.Controls.Add(this.cBox2);
            this.Controls.Add(this.cBox3);
            this.Controls.Add(this.cBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart4);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Physics process maker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cBox1;
        private System.Windows.Forms.ComboBox cBox3;
        private System.Windows.Forms.ComboBox cBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private NumericUpDownEx numericUpDown1;
        private NumericUpDownEx numericUpDown2;
        private NumericUpDownEx numericUpDown3;
        private NumericUpDownEx numericUpDown4;
        private NumericUpDownEx numericUpDown5;
        private NumericUpDownEx numericUpDown6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private NumericUpDownEx numericUpDown9;
        private NumericUpDownEx numericUpDown12;
        private NumericUpDownEx numericUpDown13;
        private NumericUpDownEx numericUpDown14;
        private NumericUpDownEx numericUpDown15;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label2;
        private NumericUpDownEx numericUpDown7;
        private NumericUpDownEx numericUpDown8;
        private System.Windows.Forms.Label label3;
        private NumericUpDownEx numericUpDown10;
        private NumericUpDownEx numericUpDown11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private NumericUpDownEx numericUpDown17;
        private NumericUpDownEx numericUpDown18;
        private NumericUpDownEx numericUpDown19;
        private NumericUpDownEx numericUpDown20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        public ComboBox cBox4;
        private Button button4;
        private NumericUpDown moll;
    }
}

