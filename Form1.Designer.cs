﻿namespace ResistanceCalculator
{
    partial class frm_resstanceCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_resstanceCalculator));
            this.pnl_Navigator = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_sixBandRes = new System.Windows.Forms.Button();
            this.btn_fiveBandRes = new System.Windows.Forms.Button();
            this.btn_fourBandRes = new System.Windows.Forms.Button();
            this.pnl_calculateResistance = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.cbx_temperatureBand = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbx_toleranceBand = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbx_multiplierBand = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_resBand3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_resBand2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_resBand1 = new System.Windows.Forms.ComboBox();
            this.pnl_mainResistanceBackground = new System.Windows.Forms.Panel();
            this.pnl_temperatureBand = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnl_resistance = new System.Windows.Forms.Panel();
            this.pnl_toleranceBand = new System.Windows.Forms.Panel();
            this.pnl_multiplierBand = new System.Windows.Forms.Panel();
            this.pnl_color3Band = new System.Windows.Forms.Panel();
            this.pnl_color2Band = new System.Windows.Forms.Panel();
            this.pnl_color1Band = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_calculateResistanceResult = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_resistanceResult = new System.Windows.Forms.Label();
            this.lbl_toleranceResult = new System.Windows.Forms.Label();
            this.lbl_temperatureResult = new System.Windows.Forms.Label();
            this.btn_calculateResistance = new System.Windows.Forms.Button();
            this.pnl_Navigator.SuspendLayout();
            this.pnl_calculateResistance.SuspendLayout();
            this.pnl_mainResistanceBackground.SuspendLayout();
            this.pnl_resistance.SuspendLayout();
            this.pnl_calculateResistanceResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Navigator
            // 
            this.pnl_Navigator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Navigator.Controls.Add(this.label3);
            this.pnl_Navigator.Controls.Add(this.label2);
            this.pnl_Navigator.Controls.Add(this.label1);
            this.pnl_Navigator.Controls.Add(this.button4);
            this.pnl_Navigator.Controls.Add(this.btn_sixBandRes);
            this.pnl_Navigator.Controls.Add(this.btn_fiveBandRes);
            this.pnl_Navigator.Controls.Add(this.btn_fourBandRes);
            this.pnl_Navigator.Location = new System.Drawing.Point(0, 0);
            this.pnl_Navigator.Name = "pnl_Navigator";
            this.pnl_Navigator.Size = new System.Drawing.Size(708, 94);
            this.pnl_Navigator.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(383, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "6 Bantlı Direnç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(206, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "5 Bantlı Direnç";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(30, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "4 Bantlı Direnç";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(531, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(170, 67);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btn_sixBandRes
            // 
            this.btn_sixBandRes.BackgroundImage = global::ResistanceCalculator.Properties.Resources.fa41d8476ebb5d898bd32f305883e1ce;
            this.btn_sixBandRes.Location = new System.Drawing.Point(355, 20);
            this.btn_sixBandRes.Name = "btn_sixBandRes";
            this.btn_sixBandRes.Size = new System.Drawing.Size(170, 67);
            this.btn_sixBandRes.TabIndex = 3;
            this.btn_sixBandRes.UseVisualStyleBackColor = true;
            this.btn_sixBandRes.Click += new System.EventHandler(this.btn_sixBandRes_Click);
            // 
            // btn_fiveBandRes
            // 
            this.btn_fiveBandRes.BackgroundImage = global::ResistanceCalculator.Properties.Resources.five;
            this.btn_fiveBandRes.Location = new System.Drawing.Point(179, 20);
            this.btn_fiveBandRes.Name = "btn_fiveBandRes";
            this.btn_fiveBandRes.Size = new System.Drawing.Size(170, 67);
            this.btn_fiveBandRes.TabIndex = 2;
            this.btn_fiveBandRes.UseVisualStyleBackColor = true;
            this.btn_fiveBandRes.Click += new System.EventHandler(this.btn_fiveBandRes_Click);
            // 
            // btn_fourBandRes
            // 
            this.btn_fourBandRes.BackgroundImage = global::ResistanceCalculator.Properties.Resources.Resistor_Color_Code_Manufacturers_typically_use_a_color_band_system_known_as_the_resistor_color_code_;
            this.btn_fourBandRes.Location = new System.Drawing.Point(3, 20);
            this.btn_fourBandRes.Name = "btn_fourBandRes";
            this.btn_fourBandRes.Size = new System.Drawing.Size(170, 67);
            this.btn_fourBandRes.TabIndex = 1;
            this.btn_fourBandRes.UseVisualStyleBackColor = true;
            this.btn_fourBandRes.Click += new System.EventHandler(this.btn_fourBandRes_Click);
            // 
            // pnl_calculateResistance
            // 
            this.pnl_calculateResistance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_calculateResistance.Controls.Add(this.btn_calculateResistance);
            this.pnl_calculateResistance.Controls.Add(this.label9);
            this.pnl_calculateResistance.Controls.Add(this.cbx_temperatureBand);
            this.pnl_calculateResistance.Controls.Add(this.label8);
            this.pnl_calculateResistance.Controls.Add(this.cbx_toleranceBand);
            this.pnl_calculateResistance.Controls.Add(this.label7);
            this.pnl_calculateResistance.Controls.Add(this.cbx_multiplierBand);
            this.pnl_calculateResistance.Controls.Add(this.label6);
            this.pnl_calculateResistance.Controls.Add(this.cbx_resBand3);
            this.pnl_calculateResistance.Controls.Add(this.label5);
            this.pnl_calculateResistance.Controls.Add(this.cbx_resBand2);
            this.pnl_calculateResistance.Controls.Add(this.label4);
            this.pnl_calculateResistance.Controls.Add(this.cbx_resBand1);
            this.pnl_calculateResistance.Controls.Add(this.pnl_mainResistanceBackground);
            this.pnl_calculateResistance.Location = new System.Drawing.Point(0, 100);
            this.pnl_calculateResistance.Name = "pnl_calculateResistance";
            this.pnl_calculateResistance.Size = new System.Drawing.Size(445, 323);
            this.pnl_calculateResistance.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(176, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Sıcaklık Katsayısı";
            // 
            // cbx_temperatureBand
            // 
            this.cbx_temperatureBand.FormattingEnabled = true;
            this.cbx_temperatureBand.Location = new System.Drawing.Point(179, 250);
            this.cbx_temperatureBand.Name = "cbx_temperatureBand";
            this.cbx_temperatureBand.Size = new System.Drawing.Size(145, 21);
            this.cbx_temperatureBand.TabIndex = 11;
            this.cbx_temperatureBand.Text = "Renk Seçiniz";
            this.cbx_temperatureBand.SelectedIndexChanged += new System.EventHandler(this.cbx_temperatureBand_SelectedIndexChanged);
            this.cbx_temperatureBand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbx_temperatureBand_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(176, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tolerans";
            // 
            // cbx_toleranceBand
            // 
            this.cbx_toleranceBand.FormattingEnabled = true;
            this.cbx_toleranceBand.Location = new System.Drawing.Point(179, 197);
            this.cbx_toleranceBand.Name = "cbx_toleranceBand";
            this.cbx_toleranceBand.Size = new System.Drawing.Size(145, 21);
            this.cbx_toleranceBand.TabIndex = 9;
            this.cbx_toleranceBand.Text = "Renk Seçiniz";
            this.cbx_toleranceBand.SelectedIndexChanged += new System.EventHandler(this.cbx_toleranceBand_SelectedIndexChanged);
            this.cbx_toleranceBand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbx_toleranceBand_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(176, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Çarpan";
            // 
            // cbx_multiplierBand
            // 
            this.cbx_multiplierBand.FormattingEnabled = true;
            this.cbx_multiplierBand.Location = new System.Drawing.Point(179, 143);
            this.cbx_multiplierBand.Name = "cbx_multiplierBand";
            this.cbx_multiplierBand.Size = new System.Drawing.Size(145, 21);
            this.cbx_multiplierBand.TabIndex = 7;
            this.cbx_multiplierBand.Text = "Renk Seçiniz";
            this.cbx_multiplierBand.SelectedIndexChanged += new System.EventHandler(this.cbx_multiplierBand_SelectedIndexChanged);
            this.cbx_multiplierBand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbx_multiplierBand_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(10, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "3. Bant";
            // 
            // cbx_resBand3
            // 
            this.cbx_resBand3.FormattingEnabled = true;
            this.cbx_resBand3.Location = new System.Drawing.Point(13, 250);
            this.cbx_resBand3.Name = "cbx_resBand3";
            this.cbx_resBand3.Size = new System.Drawing.Size(135, 21);
            this.cbx_resBand3.TabIndex = 5;
            this.cbx_resBand3.Text = "Renk Seçiniz";
            this.cbx_resBand3.SelectedIndexChanged += new System.EventHandler(this.cbx_resBand3_SelectedIndexChanged);
            this.cbx_resBand3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbx_resBand3_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(10, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "2. Bant";
            // 
            // cbx_resBand2
            // 
            this.cbx_resBand2.FormattingEnabled = true;
            this.cbx_resBand2.Location = new System.Drawing.Point(13, 197);
            this.cbx_resBand2.Name = "cbx_resBand2";
            this.cbx_resBand2.Size = new System.Drawing.Size(135, 21);
            this.cbx_resBand2.TabIndex = 3;
            this.cbx_resBand2.Text = "Renk Seçiniz";
            this.cbx_resBand2.SelectedIndexChanged += new System.EventHandler(this.cbx_resBand2_SelectedIndexChanged);
            this.cbx_resBand2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbx_resBand2_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(10, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "1. Bant";
            // 
            // cbx_resBand1
            // 
            this.cbx_resBand1.FormattingEnabled = true;
            this.cbx_resBand1.Location = new System.Drawing.Point(13, 143);
            this.cbx_resBand1.Name = "cbx_resBand1";
            this.cbx_resBand1.Size = new System.Drawing.Size(135, 21);
            this.cbx_resBand1.TabIndex = 1;
            this.cbx_resBand1.Text = "Renk Seçiniz";
            this.cbx_resBand1.SelectedIndexChanged += new System.EventHandler(this.cbx_resBand1_SelectedIndexChanged);
            this.cbx_resBand1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbx_resBand1_KeyPress);
            // 
            // pnl_mainResistanceBackground
            // 
            this.pnl_mainResistanceBackground.BackColor = System.Drawing.Color.White;
            this.pnl_mainResistanceBackground.Controls.Add(this.pnl_temperatureBand);
            this.pnl_mainResistanceBackground.Controls.Add(this.panel6);
            this.pnl_mainResistanceBackground.Controls.Add(this.panel4);
            this.pnl_mainResistanceBackground.Controls.Add(this.pnl_resistance);
            this.pnl_mainResistanceBackground.Location = new System.Drawing.Point(3, 36);
            this.pnl_mainResistanceBackground.Name = "pnl_mainResistanceBackground";
            this.pnl_mainResistanceBackground.Size = new System.Drawing.Size(435, 68);
            this.pnl_mainResistanceBackground.TabIndex = 0;
            // 
            // pnl_temperatureBand
            // 
            this.pnl_temperatureBand.BackColor = System.Drawing.Color.Silver;
            this.pnl_temperatureBand.Location = new System.Drawing.Point(322, 3);
            this.pnl_temperatureBand.Name = "pnl_temperatureBand";
            this.pnl_temperatureBand.Size = new System.Drawing.Size(33, 62);
            this.pnl_temperatureBand.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DimGray;
            this.panel6.Location = new System.Drawing.Point(399, 25);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(36, 22);
            this.panel6.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Location = new System.Drawing.Point(0, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(31, 22);
            this.panel4.TabIndex = 1;
            // 
            // pnl_resistance
            // 
            this.pnl_resistance.BackColor = System.Drawing.Color.BurlyWood;
            this.pnl_resistance.Controls.Add(this.pnl_toleranceBand);
            this.pnl_resistance.Controls.Add(this.pnl_multiplierBand);
            this.pnl_resistance.Controls.Add(this.pnl_color3Band);
            this.pnl_resistance.Controls.Add(this.pnl_color2Band);
            this.pnl_resistance.Controls.Add(this.pnl_color1Band);
            this.pnl_resistance.Controls.Add(this.panel5);
            this.pnl_resistance.Location = new System.Drawing.Point(30, 3);
            this.pnl_resistance.Name = "pnl_resistance";
            this.pnl_resistance.Size = new System.Drawing.Size(369, 62);
            this.pnl_resistance.TabIndex = 0;
            // 
            // pnl_toleranceBand
            // 
            this.pnl_toleranceBand.BackColor = System.Drawing.Color.Silver;
            this.pnl_toleranceBand.Location = new System.Drawing.Point(237, 0);
            this.pnl_toleranceBand.Name = "pnl_toleranceBand";
            this.pnl_toleranceBand.Size = new System.Drawing.Size(33, 62);
            this.pnl_toleranceBand.TabIndex = 3;
            // 
            // pnl_multiplierBand
            // 
            this.pnl_multiplierBand.BackColor = System.Drawing.Color.Silver;
            this.pnl_multiplierBand.Location = new System.Drawing.Point(185, 0);
            this.pnl_multiplierBand.Name = "pnl_multiplierBand";
            this.pnl_multiplierBand.Size = new System.Drawing.Size(33, 62);
            this.pnl_multiplierBand.TabIndex = 2;
            // 
            // pnl_color3Band
            // 
            this.pnl_color3Band.BackColor = System.Drawing.Color.Silver;
            this.pnl_color3Band.Location = new System.Drawing.Point(132, 0);
            this.pnl_color3Band.Name = "pnl_color3Band";
            this.pnl_color3Band.Size = new System.Drawing.Size(33, 62);
            this.pnl_color3Band.TabIndex = 2;
            // 
            // pnl_color2Band
            // 
            this.pnl_color2Band.BackColor = System.Drawing.Color.Silver;
            this.pnl_color2Band.Location = new System.Drawing.Point(82, 0);
            this.pnl_color2Band.Name = "pnl_color2Band";
            this.pnl_color2Band.Size = new System.Drawing.Size(33, 62);
            this.pnl_color2Band.TabIndex = 2;
            // 
            // pnl_color1Band
            // 
            this.pnl_color1Band.BackColor = System.Drawing.Color.Silver;
            this.pnl_color1Band.Location = new System.Drawing.Point(29, 0);
            this.pnl_color1Band.Name = "pnl_color1Band";
            this.pnl_color1Band.Size = new System.Drawing.Size(33, 62);
            this.pnl_color1Band.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(370, 22);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(31, 22);
            this.panel5.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(357, 429);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(351, 21);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(0, 429);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 21);
            this.panel2.TabIndex = 4;
            // 
            // pnl_calculateResistanceResult
            // 
            this.pnl_calculateResistanceResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_calculateResistanceResult.Controls.Add(this.lbl_temperatureResult);
            this.pnl_calculateResistanceResult.Controls.Add(this.lbl_toleranceResult);
            this.pnl_calculateResistanceResult.Controls.Add(this.lbl_resistanceResult);
            this.pnl_calculateResistanceResult.Controls.Add(this.label11);
            this.pnl_calculateResistanceResult.Controls.Add(this.label12);
            this.pnl_calculateResistanceResult.Controls.Add(this.label10);
            this.pnl_calculateResistanceResult.Location = new System.Drawing.Point(451, 100);
            this.pnl_calculateResistanceResult.Name = "pnl_calculateResistanceResult";
            this.pnl_calculateResistanceResult.Size = new System.Drawing.Size(252, 323);
            this.pnl_calculateResistanceResult.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Direnç :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Sıcaklık Katsayısı :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Tolerans :";
            // 
            // lbl_resistanceResult
            // 
            this.lbl_resistanceResult.AutoSize = true;
            this.lbl_resistanceResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resistanceResult.ForeColor = System.Drawing.Color.Red;
            this.lbl_resistanceResult.Location = new System.Drawing.Point(86, 41);
            this.lbl_resistanceResult.Name = "lbl_resistanceResult";
            this.lbl_resistanceResult.Size = new System.Drawing.Size(123, 18);
            this.lbl_resistanceResult.TabIndex = 4;
            this.lbl_resistanceResult.Text = "23 x 10^3 OHM";
            // 
            // lbl_toleranceResult
            // 
            this.lbl_toleranceResult.AutoSize = true;
            this.lbl_toleranceResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_toleranceResult.ForeColor = System.Drawing.Color.Red;
            this.lbl_toleranceResult.Location = new System.Drawing.Point(103, 85);
            this.lbl_toleranceResult.Name = "lbl_toleranceResult";
            this.lbl_toleranceResult.Size = new System.Drawing.Size(69, 18);
            this.lbl_toleranceResult.TabIndex = 5;
            this.lbl_toleranceResult.Text = "± %0.25";
            // 
            // lbl_temperatureResult
            // 
            this.lbl_temperatureResult.AutoSize = true;
            this.lbl_temperatureResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_temperatureResult.ForeColor = System.Drawing.Color.Red;
            this.lbl_temperatureResult.Location = new System.Drawing.Point(171, 134);
            this.lbl_temperatureResult.Name = "lbl_temperatureResult";
            this.lbl_temperatureResult.Size = new System.Drawing.Size(72, 18);
            this.lbl_temperatureResult.TabIndex = 6;
            this.lbl_temperatureResult.Text = "100 ppm";
            // 
            // btn_calculateResistance
            // 
            this.btn_calculateResistance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_calculateResistance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_calculateResistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calculateResistance.Location = new System.Drawing.Point(13, 277);
            this.btn_calculateResistance.Name = "btn_calculateResistance";
            this.btn_calculateResistance.Size = new System.Drawing.Size(311, 39);
            this.btn_calculateResistance.TabIndex = 13;
            this.btn_calculateResistance.Text = "Direnci Hesapla";
            this.btn_calculateResistance.UseVisualStyleBackColor = false;
            this.btn_calculateResistance.Click += new System.EventHandler(this.btn_calculateResistance_Click);
            // 
            // frm_resstanceCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 450);
            this.Controls.Add(this.pnl_calculateResistanceResult);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnl_calculateResistance);
            this.Controls.Add(this.pnl_Navigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_resstanceCalculator";
            this.Text = "Resistance Calculator";
            this.Load += new System.EventHandler(this.frm_resstanceCalculator_Load);
            this.pnl_Navigator.ResumeLayout(false);
            this.pnl_Navigator.PerformLayout();
            this.pnl_calculateResistance.ResumeLayout(false);
            this.pnl_calculateResistance.PerformLayout();
            this.pnl_mainResistanceBackground.ResumeLayout(false);
            this.pnl_resistance.ResumeLayout(false);
            this.pnl_calculateResistanceResult.ResumeLayout(false);
            this.pnl_calculateResistanceResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Navigator;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_sixBandRes;
        private System.Windows.Forms.Button btn_fiveBandRes;
        private System.Windows.Forms.Button btn_fourBandRes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_calculateResistance;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_calculateResistanceResult;
        private System.Windows.Forms.Panel pnl_mainResistanceBackground;
        private System.Windows.Forms.Panel pnl_resistance;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnl_multiplierBand;
        private System.Windows.Forms.Panel pnl_color3Band;
        private System.Windows.Forms.Panel pnl_color2Band;
        private System.Windows.Forms.Panel pnl_color1Band;
        private System.Windows.Forms.Panel pnl_temperatureBand;
        private System.Windows.Forms.Panel pnl_toleranceBand;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbx_temperatureBand;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbx_toleranceBand;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbx_multiplierBand;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_resBand3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_resBand2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_resBand1;
        private System.Windows.Forms.Label lbl_temperatureResult;
        private System.Windows.Forms.Label lbl_toleranceResult;
        private System.Windows.Forms.Label lbl_resistanceResult;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_calculateResistance;
    }
}

