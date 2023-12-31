﻿namespace Calculator
{
    partial class Length
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Length));
            this.siderbarTimer = new System.Windows.Forms.Timer(this.components);
            this.btnScientificMode = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnStandardMode = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTemperatureMode = new System.Windows.Forms.Button();
            this.btnLengthMode = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.cbbConvertedUnits = new System.Windows.Forms.ComboBox();
            this.cbbConvertUnits = new System.Windows.Forms.ComboBox();
            this.btnBackSpace = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.panel1.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // siderbarTimer
            // 
            this.siderbarTimer.Interval = 1;
            this.siderbarTimer.Tick += new System.EventHandler(this.siderbarTimer_Tick);
            // 
            // btnScientificMode
            // 
            this.btnScientificMode.BackColor = System.Drawing.Color.Black;
            this.btnScientificMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnScientificMode.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScientificMode.ForeColor = System.Drawing.Color.Transparent;
            this.btnScientificMode.Image = ((System.Drawing.Image)(resources.GetObject("btnScientificMode.Image")));
            this.btnScientificMode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScientificMode.Location = new System.Drawing.Point(-4, -1);
            this.btnScientificMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnScientificMode.Name = "btnScientificMode";
            this.btnScientificMode.Size = new System.Drawing.Size(269, 65);
            this.btnScientificMode.TabIndex = 19;
            this.btnScientificMode.Text = "Scientific";
            this.btnScientificMode.UseVisualStyleBackColor = false;
            this.btnScientificMode.Click += new System.EventHandler(this.btnScientificMode_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnScientificMode);
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(4, 202);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(257, 59);
            this.panel3.TabIndex = 18;
            // 
            // btnStandardMode
            // 
            this.btnStandardMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStandardMode.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold);
            this.btnStandardMode.ForeColor = System.Drawing.Color.Transparent;
            this.btnStandardMode.Image = ((System.Drawing.Image)(resources.GetObject("btnStandardMode.Image")));
            this.btnStandardMode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStandardMode.Location = new System.Drawing.Point(-4, -14);
            this.btnStandardMode.Margin = new System.Windows.Forms.Padding(4);
            this.btnStandardMode.Name = "btnStandardMode";
            this.btnStandardMode.Size = new System.Drawing.Size(273, 78);
            this.btnStandardMode.TabIndex = 1;
            this.btnStandardMode.Text = "Standard";
            this.btnStandardMode.UseVisualStyleBackColor = true;
            this.btnStandardMode.Click += new System.EventHandler(this.btnStandardMode_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnStandardMode);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(4, 135);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 59);
            this.panel2.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(95, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "Calculator";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Black;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(0, 30);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(59, 47);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 15;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 123);
            this.panel1.TabIndex = 0;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.Black;
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.btnTemperatureMode);
            this.sidebar.Controls.Add(this.btnLengthMode);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Margin = new System.Windows.Forms.Padding(4);
            this.sidebar.MaximumSize = new System.Drawing.Size(261, 732);
            this.sidebar.MinimumSize = new System.Drawing.Size(68, 732);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(68, 732);
            this.sidebar.TabIndex = 41;
            // 
            // btnTemperatureMode
            // 
            this.btnTemperatureMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTemperatureMode.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold);
            this.btnTemperatureMode.ForeColor = System.Drawing.Color.Transparent;
            this.btnTemperatureMode.Image = ((System.Drawing.Image)(resources.GetObject("btnTemperatureMode.Image")));
            this.btnTemperatureMode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemperatureMode.Location = new System.Drawing.Point(4, 269);
            this.btnTemperatureMode.Margin = new System.Windows.Forms.Padding(4);
            this.btnTemperatureMode.Name = "btnTemperatureMode";
            this.btnTemperatureMode.Size = new System.Drawing.Size(273, 78);
            this.btnTemperatureMode.TabIndex = 1;
            this.btnTemperatureMode.Text = "Temperature";
            this.btnTemperatureMode.UseVisualStyleBackColor = true;
            this.btnTemperatureMode.Click += new System.EventHandler(this.btnTemperatureMode_Click);
            // 
            // btnLengthMode
            // 
            this.btnLengthMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLengthMode.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold);
            this.btnLengthMode.ForeColor = System.Drawing.Color.Transparent;
            this.btnLengthMode.Image = ((System.Drawing.Image)(resources.GetObject("btnLengthMode.Image")));
            this.btnLengthMode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLengthMode.Location = new System.Drawing.Point(4, 355);
            this.btnLengthMode.Margin = new System.Windows.Forms.Padding(4);
            this.btnLengthMode.Name = "btnLengthMode";
            this.btnLengthMode.Size = new System.Drawing.Size(273, 78);
            this.btnLengthMode.TabIndex = 19;
            this.btnLengthMode.Text = "Length";
            this.btnLengthMode.UseVisualStyleBackColor = true;
            this.btnLengthMode.Click += new System.EventHandler(this.btnLengthMode_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblType.ForeColor = System.Drawing.Color.White;
            this.lblType.Location = new System.Drawing.Point(80, 26);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(121, 39);
            this.lblType.TabIndex = 40;
            this.lblType.Text = "Length";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblOutput.ForeColor = System.Drawing.Color.White;
            this.lblOutput.Location = new System.Drawing.Point(123, 198);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 39);
            this.lblOutput.TabIndex = 39;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblInput.ForeColor = System.Drawing.Color.White;
            this.lblInput.Location = new System.Drawing.Point(123, 89);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(36, 39);
            this.lblInput.TabIndex = 38;
            this.lblInput.Text = "0";
            // 
            // cbbConvertedUnits
            // 
            this.cbbConvertedUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbConvertedUnits.FormattingEnabled = true;
            this.cbbConvertedUnits.Items.AddRange(new object[] {
            "Kilometers",
            "Meters",
            "Centimeters",
            "Milimeters",
            "Inches",
            "Miles",
            "Feet"});
            this.cbbConvertedUnits.Location = new System.Drawing.Point(88, 255);
            this.cbbConvertedUnits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbConvertedUnits.Name = "cbbConvertedUnits";
            this.cbbConvertedUnits.Size = new System.Drawing.Size(121, 24);
            this.cbbConvertedUnits.TabIndex = 36;
            this.cbbConvertedUnits.SelectedIndexChanged += new System.EventHandler(this.cbbConvertedUnits_SelectedIndexChanged);
            // 
            // cbbConvertUnits
            // 
            this.cbbConvertUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbConvertUnits.FormattingEnabled = true;
            this.cbbConvertUnits.Items.AddRange(new object[] {
            "Kilometers",
            "Meters",
            "Centimeters",
            "Milimeters",
            "Inches",
            "Miles",
            "Feet"});
            this.cbbConvertUnits.Location = new System.Drawing.Point(88, 134);
            this.cbbConvertUnits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbConvertUnits.Name = "cbbConvertUnits";
            this.cbbConvertUnits.Size = new System.Drawing.Size(121, 24);
            this.cbbConvertUnits.TabIndex = 35;
            this.cbbConvertUnits.SelectedIndexChanged += new System.EventHandler(this.cbbConvertUnits_SelectedIndexChanged);
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnBackSpace.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBackSpace.Image = ((System.Drawing.Image)(resources.GetObject("btnBackSpace.Image")));
            this.btnBackSpace.Location = new System.Drawing.Point(335, 300);
            this.btnBackSpace.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(124, 80);
            this.btnBackSpace.TabIndex = 34;
            this.btnBackSpace.TabStop = false;
            this.btnBackSpace.UseVisualStyleBackColor = false;
            this.btnBackSpace.Click += new System.EventHandler(this.btnBackSpace_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(204, 300);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 80);
            this.btnClear.TabIndex = 33;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnDecimal.Location = new System.Drawing.Point(335, 652);
            this.btnDecimal.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(124, 80);
            this.btnDecimal.TabIndex = 32;
            this.btnDecimal.TabStop = false;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = false;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn3.Location = new System.Drawing.Point(335, 565);
            this.btn3.Margin = new System.Windows.Forms.Padding(4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(124, 80);
            this.btn3.TabIndex = 22;
            this.btn3.TabStop = false;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.Length_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn6.Location = new System.Drawing.Point(335, 475);
            this.btn6.Margin = new System.Windows.Forms.Padding(4);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(124, 80);
            this.btn6.TabIndex = 23;
            this.btn6.TabStop = false;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.Length_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn9.Location = new System.Drawing.Point(335, 386);
            this.btn9.Margin = new System.Windows.Forms.Padding(4);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(124, 80);
            this.btn9.TabIndex = 24;
            this.btn9.TabStop = false;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.Length_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn0.Location = new System.Drawing.Point(204, 652);
            this.btn0.Margin = new System.Windows.Forms.Padding(4);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(124, 80);
            this.btn0.TabIndex = 25;
            this.btn0.TabStop = false;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.Length_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn2.Location = new System.Drawing.Point(204, 565);
            this.btn2.Margin = new System.Windows.Forms.Padding(4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(124, 80);
            this.btn2.TabIndex = 26;
            this.btn2.TabStop = false;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.Length_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn1.Location = new System.Drawing.Point(72, 565);
            this.btn1.Margin = new System.Windows.Forms.Padding(4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(124, 80);
            this.btn1.TabIndex = 27;
            this.btn1.TabStop = false;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.Length_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn5.Location = new System.Drawing.Point(204, 475);
            this.btn5.Margin = new System.Windows.Forms.Padding(4);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(124, 80);
            this.btn5.TabIndex = 28;
            this.btn5.TabStop = false;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.Length_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn4.Location = new System.Drawing.Point(72, 475);
            this.btn4.Margin = new System.Windows.Forms.Padding(4);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(124, 80);
            this.btn4.TabIndex = 29;
            this.btn4.TabStop = false;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.Length_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn8.Location = new System.Drawing.Point(204, 386);
            this.btn8.Margin = new System.Windows.Forms.Padding(4);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(124, 80);
            this.btn8.TabIndex = 30;
            this.btn8.TabStop = false;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.Length_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn7.Location = new System.Drawing.Point(72, 386);
            this.btn7.Margin = new System.Windows.Forms.Padding(4);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(124, 80);
            this.btn7.TabIndex = 31;
            this.btn7.TabStop = false;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.Length_Click);
            // 
            // Length
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(473, 734);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.cbbConvertedUnits);
            this.Controls.Add(this.cbbConvertUnits);
            this.Controls.Add(this.btnBackSpace);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(491, 781);
            this.Name = "Length";
            this.Text = "Length";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Length_FormClosing);
            this.Load += new System.EventHandler(this.Length_Load);
            this.Click += new System.EventHandler(this.Length_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Length_KeyDown);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.sidebar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer siderbarTimer;
        private System.Windows.Forms.Button btnScientificMode;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnStandardMode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Button btnTemperatureMode;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.ComboBox cbbConvertedUnits;
        private System.Windows.Forms.ComboBox cbbConvertUnits;
        private System.Windows.Forms.Button btnBackSpace;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnLengthMode;
    }
}