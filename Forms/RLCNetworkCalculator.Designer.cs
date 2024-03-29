namespace CircuitCalculator.Forms
{
    partial class RLCNetworkCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RLCNetworkCalculator));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.viewSeriesCircuitButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.jQualitySelectionBox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iQualitySelectionBox = new System.Windows.Forms.CheckBox();
            this.efficiencyCalculatorButton = new System.Windows.Forms.Button();
            this.saveQualitySelectionBox = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.fractionalBandwidthResultBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.qualityResultBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.resonanceFrequencyResultBox = new System.Windows.Forms.TextBox();
            this.dampingFactorResultBox = new System.Windows.Forms.TextBox();
            this.attenuationResultBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.capacitanceFactor = new System.Windows.Forms.ComboBox();
            this.inductanceFactor = new System.Windows.Forms.ComboBox();
            this.resistanceFactor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.capacitanceValueBox = new System.Windows.Forms.TextBox();
            this.inductanceValueBox = new System.Windows.Forms.TextBox();
            this.resistanceValueBox = new System.Windows.Forms.TextBox();
            this.viewParallelCircuitButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.viewSeriesCircuitButton);
            this.groupBox1.Location = new System.Drawing.Point(13, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Series RLC";
            // 
            // viewSeriesCircuitButton
            // 
            this.viewSeriesCircuitButton.Location = new System.Drawing.Point(419, 42);
            this.viewSeriesCircuitButton.Name = "viewSeriesCircuitButton";
            this.viewSeriesCircuitButton.Size = new System.Drawing.Size(75, 23);
            this.viewSeriesCircuitButton.TabIndex = 0;
            this.viewSeriesCircuitButton.Text = "Circuit";
            this.viewSeriesCircuitButton.UseVisualStyleBackColor = true;
            this.viewSeriesCircuitButton.Click += new System.EventHandler(this.viewSeriesCircuitButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.jQualitySelectionBox);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.iQualitySelectionBox);
            this.groupBox2.Controls.Add(this.efficiencyCalculatorButton);
            this.groupBox2.Controls.Add(this.saveQualitySelectionBox);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.fractionalBandwidthResultBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.qualityResultBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.resonanceFrequencyResultBox);
            this.groupBox2.Controls.Add(this.dampingFactorResultBox);
            this.groupBox2.Controls.Add(this.attenuationResultBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.calculateButton);
            this.groupBox2.Controls.Add(this.capacitanceFactor);
            this.groupBox2.Controls.Add(this.inductanceFactor);
            this.groupBox2.Controls.Add(this.resistanceFactor);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.capacitanceValueBox);
            this.groupBox2.Controls.Add(this.inductanceValueBox);
            this.groupBox2.Controls.Add(this.resistanceValueBox);
            this.groupBox2.Controls.Add(this.viewParallelCircuitButton);
            this.groupBox2.Location = new System.Drawing.Point(13, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 156);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parallel RLC";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(371, 92);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // jQualitySelectionBox
            // 
            this.jQualitySelectionBox.AutoSize = true;
            this.jQualitySelectionBox.Location = new System.Drawing.Point(350, 102);
            this.jQualitySelectionBox.Name = "jQualitySelectionBox";
            this.jQualitySelectionBox.Size = new System.Drawing.Size(15, 14);
            this.jQualitySelectionBox.TabIndex = 29;
            this.jQualitySelectionBox.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(313, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // iQualitySelectionBox
            // 
            this.iQualitySelectionBox.AutoSize = true;
            this.iQualitySelectionBox.Location = new System.Drawing.Point(292, 102);
            this.iQualitySelectionBox.Name = "iQualitySelectionBox";
            this.iQualitySelectionBox.Size = new System.Drawing.Size(15, 14);
            this.iQualitySelectionBox.TabIndex = 27;
            this.iQualitySelectionBox.UseVisualStyleBackColor = true;
            // 
            // efficiencyCalculatorButton
            // 
            this.efficiencyCalculatorButton.Location = new System.Drawing.Point(419, 129);
            this.efficiencyCalculatorButton.Name = "efficiencyCalculatorButton";
            this.efficiencyCalculatorButton.Size = new System.Drawing.Size(75, 23);
            this.efficiencyCalculatorButton.TabIndex = 26;
            this.efficiencyCalculatorButton.Text = "Efficiency";
            this.efficiencyCalculatorButton.UseVisualStyleBackColor = true;
            this.efficiencyCalculatorButton.Click += new System.EventHandler(this.efficiencyCalculatorButton_Click);
            // 
            // saveQualitySelectionBox
            // 
            this.saveQualitySelectionBox.AutoSize = true;
            this.saveQualitySelectionBox.Location = new System.Drawing.Point(327, 133);
            this.saveQualitySelectionBox.Name = "saveQualitySelectionBox";
            this.saveQualitySelectionBox.Size = new System.Drawing.Size(86, 17);
            this.saveQualitySelectionBox.TabIndex = 25;
            this.saveQualitySelectionBox.Text = "Save Quality";
            this.saveQualitySelectionBox.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(195, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "b";
            // 
            // fractionalBandwidthResultBox
            // 
            this.fractionalBandwidthResultBox.Location = new System.Drawing.Point(215, 122);
            this.fractionalBandwidthResultBox.Name = "fractionalBandwidthResultBox";
            this.fractionalBandwidthResultBox.Size = new System.Drawing.Size(70, 20);
            this.fractionalBandwidthResultBox.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(186, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "F";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(288, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "rad / s";
            // 
            // qualityResultBox
            // 
            this.qualityResultBox.Location = new System.Drawing.Point(215, 100);
            this.qualityResultBox.Name = "qualityResultBox";
            this.qualityResultBox.Size = new System.Drawing.Size(70, 20);
            this.qualityResultBox.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(182, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Q";
            // 
            // resonanceFrequencyResultBox
            // 
            this.resonanceFrequencyResultBox.Location = new System.Drawing.Point(215, 73);
            this.resonanceFrequencyResultBox.Name = "resonanceFrequencyResultBox";
            this.resonanceFrequencyResultBox.Size = new System.Drawing.Size(70, 20);
            this.resonanceFrequencyResultBox.TabIndex = 18;
            // 
            // dampingFactorResultBox
            // 
            this.dampingFactorResultBox.Location = new System.Drawing.Point(215, 50);
            this.dampingFactorResultBox.Name = "dampingFactorResultBox";
            this.dampingFactorResultBox.Size = new System.Drawing.Size(70, 20);
            this.dampingFactorResultBox.TabIndex = 17;
            // 
            // attenuationResultBox
            // 
            this.attenuationResultBox.Location = new System.Drawing.Point(215, 27);
            this.attenuationResultBox.Name = "attenuationResultBox";
            this.attenuationResultBox.Size = new System.Drawing.Size(70, 20);
            this.attenuationResultBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(181, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "ω";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(181, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "ζ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(180, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "α";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(78, 100);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 11;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // capacitanceFactor
            // 
            this.capacitanceFactor.FormattingEnabled = true;
            this.capacitanceFactor.Items.AddRange(new object[] {
            "uF",
            "nF",
            "pF"});
            this.capacitanceFactor.Location = new System.Drawing.Point(109, 73);
            this.capacitanceFactor.Name = "capacitanceFactor";
            this.capacitanceFactor.Size = new System.Drawing.Size(44, 21);
            this.capacitanceFactor.TabIndex = 10;
            // 
            // inductanceFactor
            // 
            this.inductanceFactor.FormattingEnabled = true;
            this.inductanceFactor.Items.AddRange(new object[] {
            "H",
            "mH",
            "uH",
            "nH",
            "pH"});
            this.inductanceFactor.Location = new System.Drawing.Point(109, 50);
            this.inductanceFactor.Name = "inductanceFactor";
            this.inductanceFactor.Size = new System.Drawing.Size(44, 21);
            this.inductanceFactor.TabIndex = 9;
            // 
            // resistanceFactor
            // 
            this.resistanceFactor.FormattingEnabled = true;
            this.resistanceFactor.Items.AddRange(new object[] {
            "Ω",
            "kΩ",
            "MΩ"});
            this.resistanceFactor.Location = new System.Drawing.Point(109, 26);
            this.resistanceFactor.Name = "resistanceFactor";
            this.resistanceFactor.Size = new System.Drawing.Size(44, 21);
            this.resistanceFactor.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "L";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "R";
            // 
            // capacitanceValueBox
            // 
            this.capacitanceValueBox.Location = new System.Drawing.Point(36, 74);
            this.capacitanceValueBox.Name = "capacitanceValueBox";
            this.capacitanceValueBox.Size = new System.Drawing.Size(67, 20);
            this.capacitanceValueBox.TabIndex = 4;
            // 
            // inductanceValueBox
            // 
            this.inductanceValueBox.Location = new System.Drawing.Point(36, 50);
            this.inductanceValueBox.Name = "inductanceValueBox";
            this.inductanceValueBox.Size = new System.Drawing.Size(67, 20);
            this.inductanceValueBox.TabIndex = 3;
            // 
            // resistanceValueBox
            // 
            this.resistanceValueBox.Location = new System.Drawing.Point(36, 27);
            this.resistanceValueBox.Name = "resistanceValueBox";
            this.resistanceValueBox.Size = new System.Drawing.Size(67, 20);
            this.resistanceValueBox.TabIndex = 2;
            // 
            // viewParallelCircuitButton
            // 
            this.viewParallelCircuitButton.Location = new System.Drawing.Point(419, 38);
            this.viewParallelCircuitButton.Name = "viewParallelCircuitButton";
            this.viewParallelCircuitButton.Size = new System.Drawing.Size(75, 23);
            this.viewParallelCircuitButton.TabIndex = 1;
            this.viewParallelCircuitButton.Text = "Circuit";
            this.viewParallelCircuitButton.UseVisualStyleBackColor = true;
            this.viewParallelCircuitButton.Click += new System.EventHandler(this.viewParallelCircuitButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 292);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(102, 23);
            this.closeButton.TabIndex = 19;
            this.closeButton.Text = "Close Window";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // RLCNetworkCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 321);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RLCNetworkCalculator";
            this.Text = "RLC Network Calculator";
            this.Load += new System.EventHandler(this.RLCNetworkCalculator_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button viewSeriesCircuitButton;
        private System.Windows.Forms.Button viewParallelCircuitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox capacitanceValueBox;
        private System.Windows.Forms.TextBox inductanceValueBox;
        private System.Windows.Forms.TextBox resistanceValueBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox capacitanceFactor;
        private System.Windows.Forms.ComboBox inductanceFactor;
        private System.Windows.Forms.ComboBox resistanceFactor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox resonanceFrequencyResultBox;
        private System.Windows.Forms.TextBox dampingFactorResultBox;
        private System.Windows.Forms.TextBox attenuationResultBox;
        private System.Windows.Forms.TextBox qualityResultBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox fractionalBandwidthResultBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox saveQualitySelectionBox;
        private System.Windows.Forms.Button efficiencyCalculatorButton;
        private System.Windows.Forms.CheckBox iQualitySelectionBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox jQualitySelectionBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button closeButton;
    }
}