﻿namespace Calculator
{
    partial class Scientific
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scientific));
            this.lblType = new System.Windows.Forms.Label();
            this.btnTemperatureMode = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnScientificMode = new System.Windows.Forms.Button();
            this.btnStandardMode = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.siderbarTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.rtbHistory = new System.Windows.Forms.RichTextBox();
            this.btnHistory = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnFraction = new System.Windows.Forms.Button();
            this.btnSqrRoot = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnBackSpace = new System.Windows.Forms.Button();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.btnPercentage = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnAllClear = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPositiveNegative = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnLogarit = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnCotan = new System.Windows.Forms.Button();
            this.btnSinh = new System.Windows.Forms.Button();
            this.btnLN = new System.Windows.Forms.Button();
            this.btnCosh = new System.Windows.Forms.Button();
            this.btnTanh = new System.Windows.Forms.Button();
            this.btnEXP = new System.Windows.Forms.Button();
            this.btnCoth = new System.Windows.Forms.Button();
            this.btnLengthMode = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHistory)).BeginInit();
            this.sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblType.Location = new System.Drawing.Point(117, 19);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(134, 31);
            this.lblType.TabIndex = 53;
            this.lblType.Text = "Scientific";
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
            // btnScientificMode
            // 
            this.btnScientificMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnScientificMode.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold);
            this.btnScientificMode.ForeColor = System.Drawing.Color.Transparent;
            this.btnScientificMode.Image = ((System.Drawing.Image)(resources.GetObject("btnScientificMode.Image")));
            this.btnScientificMode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScientificMode.Location = new System.Drawing.Point(-4, -11);
            this.btnScientificMode.Margin = new System.Windows.Forms.Padding(4);
            this.btnScientificMode.Name = "btnScientificMode";
            this.btnScientificMode.Size = new System.Drawing.Size(273, 78);
            this.btnScientificMode.TabIndex = 19;
            this.btnScientificMode.Text = "Scientific";
            this.btnScientificMode.UseVisualStyleBackColor = true;
            this.btnScientificMode.Click += new System.EventHandler(this.btnScientificMode_Click);
            // 
            // btnStandardMode
            // 
            this.btnStandardMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStandardMode.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold);
            this.btnStandardMode.ForeColor = System.Drawing.Color.Transparent;
            this.btnStandardMode.Image = ((System.Drawing.Image)(resources.GetObject("btnStandardMode.Image")));
            this.btnStandardMode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStandardMode.Location = new System.Drawing.Point(-4, -12);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(95, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "Calculator";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 123);
            this.panel1.TabIndex = 0;
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
            // siderbarTimer
            // 
            this.siderbarTimer.Interval = 1;
            this.siderbarTimer.Tick += new System.EventHandler(this.siderbarTimer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(758, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 52;
            this.label2.Text = "History";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(680, 86);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(196, 25);
            this.lblStatus.TabIndex = 51;
            this.lblStatus.Text = "There\'s no history yet";
            // 
            // rtbHistory
            // 
            this.rtbHistory.BackColor = System.Drawing.Color.Silver;
            this.rtbHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.rtbHistory.ForeColor = System.Drawing.Color.Black;
            this.rtbHistory.Location = new System.Drawing.Point(714, 138);
            this.rtbHistory.Margin = new System.Windows.Forms.Padding(4);
            this.rtbHistory.Name = "rtbHistory";
            this.rtbHistory.ReadOnly = true;
            this.rtbHistory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rtbHistory.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbHistory.Size = new System.Drawing.Size(263, 571);
            this.rtbHistory.TabIndex = 50;
            this.rtbHistory.Text = "";
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnHistory.Image")));
            this.btnHistory.Location = new System.Drawing.Point(632, 25);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(4);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(29, 33);
            this.btnHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHistory.TabIndex = 49;
            this.btnHistory.TabStop = false;
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
            this.sidebar.TabIndex = 48;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.Silver;
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.txtResult.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtResult.Location = new System.Drawing.Point(88, 126);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtResult.Size = new System.Drawing.Size(584, 40);
            this.txtResult.TabIndex = 22;
            this.txtResult.TabStop = false;
            this.txtResult.Text = "0";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnFraction
            // 
            this.btnFraction.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnFraction.Image = ((System.Drawing.Image)(resources.GetObject("btnFraction.Image")));
            this.btnFraction.Location = new System.Drawing.Point(79, 186);
            this.btnFraction.Margin = new System.Windows.Forms.Padding(4);
            this.btnFraction.Name = "btnFraction";
            this.btnFraction.Size = new System.Drawing.Size(98, 80);
            this.btnFraction.TabIndex = 47;
            this.btnFraction.TabStop = false;
            this.btnFraction.UseVisualStyleBackColor = false;
            this.btnFraction.Click += new System.EventHandler(this.btnFraction_Click);
            // 
            // btnSqrRoot
            // 
            this.btnSqrRoot.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSqrRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnSqrRoot.Image = ((System.Drawing.Image)(resources.GetObject("btnSqrRoot.Image")));
            this.btnSqrRoot.Location = new System.Drawing.Point(180, 277);
            this.btnSqrRoot.Margin = new System.Windows.Forms.Padding(4);
            this.btnSqrRoot.Name = "btnSqrRoot";
            this.btnSqrRoot.Size = new System.Drawing.Size(102, 80);
            this.btnSqrRoot.TabIndex = 46;
            this.btnSqrRoot.TabStop = false;
            this.btnSqrRoot.UseVisualStyleBackColor = false;
            this.btnSqrRoot.Click += new System.EventHandler(this.btnSqrRoot_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnSquare.Image = ((System.Drawing.Image)(resources.GetObject("btnSquare.Image")));
            this.btnSquare.Location = new System.Drawing.Point(285, 277);
            this.btnSquare.Margin = new System.Windows.Forms.Padding(4);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(93, 80);
            this.btnSquare.TabIndex = 45;
            this.btnSquare.TabStop = false;
            this.btnSquare.UseVisualStyleBackColor = false;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBackSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnBackSpace.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBackSpace.Image = ((System.Drawing.Image)(resources.GetObject("btnBackSpace.Image")));
            this.btnBackSpace.Location = new System.Drawing.Point(381, 186);
            this.btnBackSpace.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(97, 80);
            this.btnBackSpace.TabIndex = 44;
            this.btnBackSpace.TabStop = false;
            this.btnBackSpace.UseVisualStyleBackColor = false;
            this.btnBackSpace.Click += new System.EventHandler(this.btnBackSpace_Click);
            // 
            // txtShow
            // 
            this.txtShow.BackColor = System.Drawing.Color.Silver;
            this.txtShow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.txtShow.ForeColor = System.Drawing.Color.DimGray;
            this.txtShow.Location = new System.Drawing.Point(88, 77);
            this.txtShow.Margin = new System.Windows.Forms.Padding(4);
            this.txtShow.Name = "txtShow";
            this.txtShow.ReadOnly = true;
            this.txtShow.Size = new System.Drawing.Size(584, 34);
            this.txtShow.TabIndex = 43;
            this.txtShow.TabStop = false;
            this.txtShow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPercentage
            // 
            this.btnPercentage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnPercentage.Location = new System.Drawing.Point(79, 277);
            this.btnPercentage.Margin = new System.Windows.Forms.Padding(4);
            this.btnPercentage.Name = "btnPercentage";
            this.btnPercentage.Size = new System.Drawing.Size(98, 80);
            this.btnPercentage.TabIndex = 42;
            this.btnPercentage.TabStop = false;
            this.btnPercentage.Text = "%";
            this.btnPercentage.UseVisualStyleBackColor = false;
            this.btnPercentage.Click += new System.EventHandler(this.btnPercentage_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.RosyBrown;
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnEqual.Location = new System.Drawing.Point(381, 627);
            this.btnEqual.Margin = new System.Windows.Forms.Padding(4);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(97, 80);
            this.btnEqual.TabIndex = 41;
            this.btnEqual.TabStop = false;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnDivision.Location = new System.Drawing.Point(381, 277);
            this.btnDivision.Margin = new System.Windows.Forms.Padding(4);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(97, 80);
            this.btnDivision.TabIndex = 39;
            this.btnDivision.TabStop = false;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnMinus.Location = new System.Drawing.Point(381, 363);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(97, 80);
            this.btnMinus.TabIndex = 38;
            this.btnMinus.TabStop = false;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnAllClear
            // 
            this.btnAllClear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAllClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnAllClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAllClear.Location = new System.Drawing.Point(285, 186);
            this.btnAllClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnAllClear.Name = "btnAllClear";
            this.btnAllClear.Size = new System.Drawing.Size(93, 80);
            this.btnAllClear.TabIndex = 40;
            this.btnAllClear.TabStop = false;
            this.btnAllClear.Text = "AC";
            this.btnAllClear.UseVisualStyleBackColor = false;
            this.btnAllClear.Click += new System.EventHandler(this.btnAllClear_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnMultiply.Location = new System.Drawing.Point(381, 540);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(4);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(97, 80);
            this.btnMultiply.TabIndex = 35;
            this.btnMultiply.TabStop = false;
            this.btnMultiply.Text = "x";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnPlus.Location = new System.Drawing.Point(381, 450);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(97, 80);
            this.btnPlus.TabIndex = 37;
            this.btnPlus.TabStop = false;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(180, 186);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 80);
            this.btnClear.TabIndex = 36;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnDecimal.Location = new System.Drawing.Point(285, 627);
            this.btnDecimal.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(93, 80);
            this.btnDecimal.TabIndex = 24;
            this.btnDecimal.TabStop = false;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = false;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn3.Location = new System.Drawing.Point(285, 540);
            this.btn3.Margin = new System.Windows.Forms.Padding(4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(93, 80);
            this.btn3.TabIndex = 25;
            this.btn3.TabStop = false;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.Scientific_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn6.Location = new System.Drawing.Point(285, 450);
            this.btn6.Margin = new System.Windows.Forms.Padding(4);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(93, 80);
            this.btn6.TabIndex = 26;
            this.btn6.TabStop = false;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.Scientific_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn9.Location = new System.Drawing.Point(285, 363);
            this.btn9.Margin = new System.Windows.Forms.Padding(4);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(93, 80);
            this.btn9.TabIndex = 27;
            this.btn9.TabStop = false;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.Scientific_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn0.Location = new System.Drawing.Point(180, 627);
            this.btn0.Margin = new System.Windows.Forms.Padding(4);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(102, 80);
            this.btn0.TabIndex = 28;
            this.btn0.TabStop = false;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.Scientific_Click);
            // 
            // btnPositiveNegative
            // 
            this.btnPositiveNegative.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPositiveNegative.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnPositiveNegative.Location = new System.Drawing.Point(79, 627);
            this.btnPositiveNegative.Margin = new System.Windows.Forms.Padding(4);
            this.btnPositiveNegative.Name = "btnPositiveNegative";
            this.btnPositiveNegative.Size = new System.Drawing.Size(98, 80);
            this.btnPositiveNegative.TabIndex = 33;
            this.btnPositiveNegative.TabStop = false;
            this.btnPositiveNegative.Text = "-/+";
            this.btnPositiveNegative.UseVisualStyleBackColor = false;
            this.btnPositiveNegative.Click += new System.EventHandler(this.btnPositiveNegative_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn2.Location = new System.Drawing.Point(180, 540);
            this.btn2.Margin = new System.Windows.Forms.Padding(4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(102, 80);
            this.btn2.TabIndex = 29;
            this.btn2.TabStop = false;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.Scientific_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn1.Location = new System.Drawing.Point(79, 540);
            this.btn1.Margin = new System.Windows.Forms.Padding(4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(98, 80);
            this.btn1.TabIndex = 30;
            this.btn1.TabStop = false;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.Scientific_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn5.Location = new System.Drawing.Point(180, 450);
            this.btn5.Margin = new System.Windows.Forms.Padding(4);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(102, 80);
            this.btn5.TabIndex = 31;
            this.btn5.TabStop = false;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.Scientific_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn4.Location = new System.Drawing.Point(79, 450);
            this.btn4.Margin = new System.Windows.Forms.Padding(4);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(98, 80);
            this.btn4.TabIndex = 32;
            this.btn4.TabStop = false;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.Scientific_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn8.Location = new System.Drawing.Point(180, 363);
            this.btn8.Margin = new System.Windows.Forms.Padding(4);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(102, 80);
            this.btn8.TabIndex = 34;
            this.btn8.TabStop = false;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.Scientific_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn7.Location = new System.Drawing.Point(79, 363);
            this.btn7.Margin = new System.Windows.Forms.Padding(4);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(98, 80);
            this.btn7.TabIndex = 23;
            this.btn7.TabStop = false;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.Scientific_Click);
            // 
            // btnSin
            // 
            this.btnSin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnSin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSin.Location = new System.Drawing.Point(481, 186);
            this.btnSin.Margin = new System.Windows.Forms.Padding(4);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(97, 80);
            this.btnSin.TabIndex = 59;
            this.btnSin.TabStop = false;
            this.btnSin.Text = "sin";
            this.btnSin.UseVisualStyleBackColor = false;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnLogarit
            // 
            this.btnLogarit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogarit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnLogarit.Location = new System.Drawing.Point(481, 627);
            this.btnLogarit.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogarit.Name = "btnLogarit";
            this.btnLogarit.Size = new System.Drawing.Size(97, 80);
            this.btnLogarit.TabIndex = 58;
            this.btnLogarit.TabStop = false;
            this.btnLogarit.Text = "log";
            this.btnLogarit.UseVisualStyleBackColor = false;
            this.btnLogarit.Click += new System.EventHandler(this.btnLogarit_Click);
            // 
            // btnCos
            // 
            this.btnCos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnCos.Location = new System.Drawing.Point(481, 277);
            this.btnCos.Margin = new System.Windows.Forms.Padding(4);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(97, 80);
            this.btnCos.TabIndex = 57;
            this.btnCos.TabStop = false;
            this.btnCos.Text = "cos";
            this.btnCos.UseVisualStyleBackColor = false;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnTan
            // 
            this.btnTan.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnTan.Location = new System.Drawing.Point(481, 363);
            this.btnTan.Margin = new System.Windows.Forms.Padding(4);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(97, 80);
            this.btnTan.TabIndex = 56;
            this.btnTan.TabStop = false;
            this.btnTan.Text = "tan";
            this.btnTan.UseVisualStyleBackColor = false;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnMod.Location = new System.Drawing.Point(481, 540);
            this.btnMod.Margin = new System.Windows.Forms.Padding(4);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(97, 80);
            this.btnMod.TabIndex = 54;
            this.btnMod.TabStop = false;
            this.btnMod.Text = "mod";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnCotan
            // 
            this.btnCotan.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCotan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnCotan.Location = new System.Drawing.Point(481, 450);
            this.btnCotan.Margin = new System.Windows.Forms.Padding(4);
            this.btnCotan.Name = "btnCotan";
            this.btnCotan.Size = new System.Drawing.Size(97, 80);
            this.btnCotan.TabIndex = 55;
            this.btnCotan.TabStop = false;
            this.btnCotan.Text = "cot";
            this.btnCotan.UseVisualStyleBackColor = false;
            this.btnCotan.Click += new System.EventHandler(this.btnCotan_Click);
            // 
            // btnSinh
            // 
            this.btnSinh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnSinh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSinh.Location = new System.Drawing.Point(581, 186);
            this.btnSinh.Margin = new System.Windows.Forms.Padding(4);
            this.btnSinh.Name = "btnSinh";
            this.btnSinh.Size = new System.Drawing.Size(100, 80);
            this.btnSinh.TabIndex = 65;
            this.btnSinh.TabStop = false;
            this.btnSinh.Text = "sinh";
            this.btnSinh.UseVisualStyleBackColor = false;
            this.btnSinh.Click += new System.EventHandler(this.btnSinh_Click);
            // 
            // btnLN
            // 
            this.btnLN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnLN.Location = new System.Drawing.Point(581, 627);
            this.btnLN.Margin = new System.Windows.Forms.Padding(4);
            this.btnLN.Name = "btnLN";
            this.btnLN.Size = new System.Drawing.Size(100, 80);
            this.btnLN.TabIndex = 64;
            this.btnLN.TabStop = false;
            this.btnLN.Text = "ln";
            this.btnLN.UseVisualStyleBackColor = false;
            this.btnLN.Click += new System.EventHandler(this.btnLN_Click);
            // 
            // btnCosh
            // 
            this.btnCosh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCosh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnCosh.Location = new System.Drawing.Point(581, 277);
            this.btnCosh.Margin = new System.Windows.Forms.Padding(4);
            this.btnCosh.Name = "btnCosh";
            this.btnCosh.Size = new System.Drawing.Size(100, 80);
            this.btnCosh.TabIndex = 63;
            this.btnCosh.TabStop = false;
            this.btnCosh.Text = "cosh";
            this.btnCosh.UseVisualStyleBackColor = false;
            this.btnCosh.Click += new System.EventHandler(this.btnCosh_Click);
            // 
            // btnTanh
            // 
            this.btnTanh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnTanh.Location = new System.Drawing.Point(581, 363);
            this.btnTanh.Margin = new System.Windows.Forms.Padding(4);
            this.btnTanh.Name = "btnTanh";
            this.btnTanh.Size = new System.Drawing.Size(100, 80);
            this.btnTanh.TabIndex = 62;
            this.btnTanh.TabStop = false;
            this.btnTanh.Text = "tanh";
            this.btnTanh.UseVisualStyleBackColor = false;
            this.btnTanh.Click += new System.EventHandler(this.btnTanh_Click);
            // 
            // btnEXP
            // 
            this.btnEXP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEXP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnEXP.Location = new System.Drawing.Point(581, 540);
            this.btnEXP.Margin = new System.Windows.Forms.Padding(4);
            this.btnEXP.Name = "btnEXP";
            this.btnEXP.Size = new System.Drawing.Size(100, 80);
            this.btnEXP.TabIndex = 60;
            this.btnEXP.TabStop = false;
            this.btnEXP.Text = "exp";
            this.btnEXP.UseVisualStyleBackColor = false;
            this.btnEXP.Click += new System.EventHandler(this.btnEXP_Click);
            // 
            // btnCoth
            // 
            this.btnCoth.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCoth.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnCoth.Location = new System.Drawing.Point(581, 450);
            this.btnCoth.Margin = new System.Windows.Forms.Padding(4);
            this.btnCoth.Name = "btnCoth";
            this.btnCoth.Size = new System.Drawing.Size(100, 80);
            this.btnCoth.TabIndex = 61;
            this.btnCoth.TabStop = false;
            this.btnCoth.Text = "coth";
            this.btnCoth.UseVisualStyleBackColor = false;
            this.btnCoth.Click += new System.EventHandler(this.btnCoth_Click);
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
            // Scientific
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(990, 712);
            this.Controls.Add(this.btnSinh);
            this.Controls.Add(this.btnLN);
            this.Controls.Add(this.btnCosh);
            this.Controls.Add(this.btnTanh);
            this.Controls.Add(this.btnEXP);
            this.Controls.Add(this.btnCoth);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btnLogarit);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnCotan);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.rtbHistory);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnFraction);
            this.Controls.Add(this.btnSqrRoot);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.btnBackSpace);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.btnPercentage);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnAllClear);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnPositiveNegative);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.KeyPreview = true;
            this.Name = "Scientific";
            this.Text = "Scientific";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Scientific_FormClosing);
            this.Click += new System.EventHandler(this.Scientific_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Scientific_KeyDown);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHistory)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnTemperatureMode;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnStandardMode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Timer siderbarTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.RichTextBox rtbHistory;
        private System.Windows.Forms.PictureBox btnHistory;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnFraction;
        private System.Windows.Forms.Button btnSqrRoot;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnBackSpace;
        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.Button btnPercentage;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnAllClear;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPositiveNegative;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnScientificMode;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnLogarit;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnCotan;
        private System.Windows.Forms.Button btnSinh;
        private System.Windows.Forms.Button btnLN;
        private System.Windows.Forms.Button btnCosh;
        private System.Windows.Forms.Button btnTanh;
        private System.Windows.Forms.Button btnEXP;
        private System.Windows.Forms.Button btnCoth;
        private System.Windows.Forms.Button btnLengthMode;
    }
}