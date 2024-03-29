namespace CircuitCalculator.Forms
{
    partial class ResistiveRadiativeLossesCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResistiveRadiativeLossesCalculator));
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kursEquationBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.factsLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.omega_zeroPictureBox = new System.Windows.Forms.PictureBox();
            this.angularFrequencyUnit = new System.Windows.Forms.ComboBox();
            this.angularFrequencyValueBox = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.permeabilityAnalyticMethod = new System.Windows.Forms.ComboBox();
            this.relativePermeabilityMediumTextBox = new System.Windows.Forms.TextBox();
            this.conductivityMaterialSelection = new System.Windows.Forms.ComboBox();
            this.conductivityMaterialValue = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.wireRadiusPictureBox = new System.Windows.Forms.PictureBox();
            this.lengthValueBox = new System.Windows.Forms.TextBox();
            this.wireRadiusValueBox = new System.Windows.Forms.TextBox();
            this.lengthFactor = new System.Windows.Forms.ComboBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numberOfTurnsValueBox = new System.Windows.Forms.TextBox();
            this.numberOfTurnsPictureBox = new System.Windows.Forms.PictureBox();
            this.radiusFactor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.kursEquationBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.omega_zeroPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wireRadiusPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfTurnsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(488, 311);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(102, 23);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Close Window";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ohmic Resistance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Radiation Resistance";
            // 
            // kursEquationBox1
            // 
            this.kursEquationBox1.Image = ((System.Drawing.Image)(resources.GetObject("kursEquationBox1.Image")));
            this.kursEquationBox1.Location = new System.Drawing.Point(12, 39);
            this.kursEquationBox1.Name = "kursEquationBox1";
            this.kursEquationBox1.Size = new System.Drawing.Size(207, 65);
            this.kursEquationBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kursEquationBox1.TabIndex = 24;
            this.kursEquationBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(333, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(257, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // factsLabel
            // 
            this.factsLabel.AutoSize = true;
            this.factsLabel.Location = new System.Drawing.Point(557, 15);
            this.factsLabel.Name = "factsLabel";
            this.factsLabel.Size = new System.Drawing.Size(33, 13);
            this.factsLabel.TabIndex = 28;
            this.factsLabel.Text = "Facts";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(358, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // omega_zeroPictureBox
            // 
            this.omega_zeroPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("omega_zeroPictureBox.Image")));
            this.omega_zeroPictureBox.Location = new System.Drawing.Point(13, 144);
            this.omega_zeroPictureBox.Name = "omega_zeroPictureBox";
            this.omega_zeroPictureBox.Size = new System.Drawing.Size(27, 27);
            this.omega_zeroPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.omega_zeroPictureBox.TabIndex = 33;
            this.omega_zeroPictureBox.TabStop = false;
            // 
            // angularFrequencyUnit
            // 
            this.angularFrequencyUnit.FormattingEnabled = true;
            this.angularFrequencyUnit.Items.AddRange(new object[] {
            "Hz"});
            this.angularFrequencyUnit.Location = new System.Drawing.Point(190, 144);
            this.angularFrequencyUnit.Name = "angularFrequencyUnit";
            this.angularFrequencyUnit.Size = new System.Drawing.Size(52, 21);
            this.angularFrequencyUnit.TabIndex = 32;
            // 
            // angularFrequencyValueBox
            // 
            this.angularFrequencyValueBox.Location = new System.Drawing.Point(52, 145);
            this.angularFrequencyValueBox.Name = "angularFrequencyValueBox";
            this.angularFrequencyValueBox.Size = new System.Drawing.Size(85, 20);
            this.angularFrequencyValueBox.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(13, 116);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // permeabilityAnalyticMethod
            // 
            this.permeabilityAnalyticMethod.FormattingEnabled = true;
            this.permeabilityAnalyticMethod.Items.AddRange(new object[] {
            "Standard Value",
            "Nonlinear Media"});
            this.permeabilityAnalyticMethod.Location = new System.Drawing.Point(143, 115);
            this.permeabilityAnalyticMethod.Name = "permeabilityAnalyticMethod";
            this.permeabilityAnalyticMethod.Size = new System.Drawing.Size(99, 21);
            this.permeabilityAnalyticMethod.TabIndex = 35;
            this.permeabilityAnalyticMethod.SelectedIndexChanged += new System.EventHandler(this.permeabilityAnalyticMethod_SelectedIndexChanged);
            // 
            // relativePermeabilityMediumTextBox
            // 
            this.relativePermeabilityMediumTextBox.Location = new System.Drawing.Point(52, 116);
            this.relativePermeabilityMediumTextBox.Name = "relativePermeabilityMediumTextBox";
            this.relativePermeabilityMediumTextBox.Size = new System.Drawing.Size(85, 20);
            this.relativePermeabilityMediumTextBox.TabIndex = 36;
            // 
            // conductivityMaterialSelection
            // 
            this.conductivityMaterialSelection.FormattingEnabled = true;
            this.conductivityMaterialSelection.Items.AddRange(new object[] {
            "Copper",
            "Aluminum",
            "Silver",
            "Gold",
            "Air"});
            this.conductivityMaterialSelection.Location = new System.Drawing.Point(167, 176);
            this.conductivityMaterialSelection.Name = "conductivityMaterialSelection";
            this.conductivityMaterialSelection.Size = new System.Drawing.Size(75, 21);
            this.conductivityMaterialSelection.TabIndex = 1;
            this.conductivityMaterialSelection.SelectedIndexChanged += new System.EventHandler(this.conductivityMaterialSelection_SelectedIndexChanged);
            // 
            // conductivityMaterialValue
            // 
            this.conductivityMaterialValue.Location = new System.Drawing.Point(52, 177);
            this.conductivityMaterialValue.Name = "conductivityMaterialValue";
            this.conductivityMaterialValue.Size = new System.Drawing.Size(85, 20);
            this.conductivityMaterialValue.TabIndex = 37;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(13, 177);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 27);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 39;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "H/m";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "S/m @ 20C";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(13, 210);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(27, 27);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 42;
            this.pictureBox5.TabStop = false;
            // 
            // wireRadiusPictureBox
            // 
            this.wireRadiusPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("wireRadiusPictureBox.Image")));
            this.wireRadiusPictureBox.Location = new System.Drawing.Point(13, 243);
            this.wireRadiusPictureBox.Name = "wireRadiusPictureBox";
            this.wireRadiusPictureBox.Size = new System.Drawing.Size(27, 27);
            this.wireRadiusPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wireRadiusPictureBox.TabIndex = 43;
            this.wireRadiusPictureBox.TabStop = false;
            // 
            // lengthValueBox
            // 
            this.lengthValueBox.Location = new System.Drawing.Point(52, 213);
            this.lengthValueBox.Name = "lengthValueBox";
            this.lengthValueBox.Size = new System.Drawing.Size(85, 20);
            this.lengthValueBox.TabIndex = 2;
            // 
            // wireRadiusValueBox
            // 
            this.wireRadiusValueBox.Location = new System.Drawing.Point(52, 249);
            this.wireRadiusValueBox.Name = "wireRadiusValueBox";
            this.wireRadiusValueBox.Size = new System.Drawing.Size(85, 20);
            this.wireRadiusValueBox.TabIndex = 3;
            // 
            // lengthFactor
            // 
            this.lengthFactor.FormattingEnabled = true;
            this.lengthFactor.Items.AddRange(new object[] {
            "cm",
            "mm",
            "m"});
            this.lengthFactor.Location = new System.Drawing.Point(201, 210);
            this.lengthFactor.Name = "lengthFactor";
            this.lengthFactor.Size = new System.Drawing.Size(41, 21);
            this.lengthFactor.TabIndex = 46;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(236, 311);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(52, 314);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(142, 20);
            this.resultBox.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(200, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 17);
            this.label6.TabIndex = 50;
            this.label6.Text = "Ω";
            // 
            // numberOfTurnsValueBox
            // 
            this.numberOfTurnsValueBox.Location = new System.Drawing.Point(52, 282);
            this.numberOfTurnsValueBox.Name = "numberOfTurnsValueBox";
            this.numberOfTurnsValueBox.Size = new System.Drawing.Size(85, 20);
            this.numberOfTurnsValueBox.TabIndex = 4;
            // 
            // numberOfTurnsPictureBox
            // 
            this.numberOfTurnsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("numberOfTurnsPictureBox.Image")));
            this.numberOfTurnsPictureBox.Location = new System.Drawing.Point(13, 276);
            this.numberOfTurnsPictureBox.Name = "numberOfTurnsPictureBox";
            this.numberOfTurnsPictureBox.Size = new System.Drawing.Size(27, 27);
            this.numberOfTurnsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.numberOfTurnsPictureBox.TabIndex = 51;
            this.numberOfTurnsPictureBox.TabStop = false;
            // 
            // radiusFactor
            // 
            this.radiusFactor.FormattingEnabled = true;
            this.radiusFactor.Items.AddRange(new object[] {
            "cm",
            "mm",
            "m"});
            this.radiusFactor.Location = new System.Drawing.Point(201, 249);
            this.radiusFactor.Name = "radiusFactor";
            this.radiusFactor.Size = new System.Drawing.Size(41, 21);
            this.radiusFactor.TabIndex = 53;
            // 
            // ResistiveRadiativeLossesCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 350);
            this.Controls.Add(this.radiusFactor);
            this.Controls.Add(this.numberOfTurnsValueBox);
            this.Controls.Add(this.numberOfTurnsPictureBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.lengthFactor);
            this.Controls.Add(this.wireRadiusValueBox);
            this.Controls.Add(this.lengthValueBox);
            this.Controls.Add(this.wireRadiusPictureBox);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.conductivityMaterialSelection);
            this.Controls.Add(this.conductivityMaterialValue);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.relativePermeabilityMediumTextBox);
            this.Controls.Add(this.permeabilityAnalyticMethod);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.omega_zeroPictureBox);
            this.Controls.Add(this.angularFrequencyUnit);
            this.Controls.Add(this.angularFrequencyValueBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.factsLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.kursEquationBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.Name = "ResistiveRadiativeLossesCalculator";
            this.Text = "Resistive-Radiative Losses Calculator";
            this.Load += new System.EventHandler(this.ResistiveRadiativeLossesCalculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kursEquationBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.omega_zeroPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wireRadiusPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfTurnsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox kursEquationBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label factsLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox omega_zeroPictureBox;
        private System.Windows.Forms.ComboBox angularFrequencyUnit;
        private System.Windows.Forms.TextBox angularFrequencyValueBox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox permeabilityAnalyticMethod;
        private System.Windows.Forms.TextBox relativePermeabilityMediumTextBox;
        private System.Windows.Forms.ComboBox conductivityMaterialSelection;
        private System.Windows.Forms.TextBox conductivityMaterialValue;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox wireRadiusPictureBox;
        private System.Windows.Forms.TextBox lengthValueBox;
        private System.Windows.Forms.TextBox wireRadiusValueBox;
        private System.Windows.Forms.ComboBox lengthFactor;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox numberOfTurnsValueBox;
        private System.Windows.Forms.PictureBox numberOfTurnsPictureBox;
        private System.Windows.Forms.ComboBox radiusFactor;
    }
}