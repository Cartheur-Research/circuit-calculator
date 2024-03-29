namespace CircuitCalculator.Forms
{
    partial class CouplingCoefficientCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CouplingCoefficientCalculator));
            this.label1 = new System.Windows.Forms.Label();
            this.k1PictureBox = new System.Windows.Forms.PictureBox();
            this.mutualInductanceValueBox = new System.Windows.Forms.TextBox();
            this.aInductanceValueBox = new System.Windows.Forms.TextBox();
            this.bInductanceValueBox = new System.Windows.Forms.TextBox();
            this.angularFrequencyValueBox = new System.Windows.Forms.TextBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.mutualInductanceFactor = new System.Windows.Forms.ComboBox();
            this.bInductanceFactor = new System.Windows.Forms.ComboBox();
            this.aInductanceFactor = new System.Windows.Forms.ComboBox();
            this.angularFrequencyUnit = new System.Windows.Forms.ComboBox();
            this.saveK1SelectionBox = new System.Windows.Forms.CheckBox();
            this.efficiencyCalculatorButton = new System.Windows.Forms.Button();
            this.MabPictureBox = new System.Windows.Forms.PictureBox();
            this.omega_zeroPictureBox = new System.Windows.Forms.PictureBox();
            this.LaPictureBox = new System.Windows.Forms.PictureBox();
            this.LbPictureBox = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.k1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MabPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.omega_zeroPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LbPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coupling coefficient for Two Coils";
            // 
            // k1PictureBox
            // 
            this.k1PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("k1PictureBox.Image")));
            this.k1PictureBox.Location = new System.Drawing.Point(16, 38);
            this.k1PictureBox.Name = "k1PictureBox";
            this.k1PictureBox.Size = new System.Drawing.Size(107, 56);
            this.k1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.k1PictureBox.TabIndex = 2;
            this.k1PictureBox.TabStop = false;
            // 
            // mutualInductanceValueBox
            // 
            this.mutualInductanceValueBox.Location = new System.Drawing.Point(53, 118);
            this.mutualInductanceValueBox.Name = "mutualInductanceValueBox";
            this.mutualInductanceValueBox.Size = new System.Drawing.Size(71, 20);
            this.mutualInductanceValueBox.TabIndex = 0;
            // 
            // aInductanceValueBox
            // 
            this.aInductanceValueBox.Location = new System.Drawing.Point(208, 118);
            this.aInductanceValueBox.Name = "aInductanceValueBox";
            this.aInductanceValueBox.Size = new System.Drawing.Size(66, 20);
            this.aInductanceValueBox.TabIndex = 4;
            // 
            // bInductanceValueBox
            // 
            this.bInductanceValueBox.Location = new System.Drawing.Point(209, 151);
            this.bInductanceValueBox.Name = "bInductanceValueBox";
            this.bInductanceValueBox.Size = new System.Drawing.Size(66, 20);
            this.bInductanceValueBox.TabIndex = 6;
            // 
            // angularFrequencyValueBox
            // 
            this.angularFrequencyValueBox.Location = new System.Drawing.Point(53, 151);
            this.angularFrequencyValueBox.Name = "angularFrequencyValueBox";
            this.angularFrequencyValueBox.Size = new System.Drawing.Size(57, 20);
            this.angularFrequencyValueBox.TabIndex = 2;
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(174, 239);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(133, 20);
            this.resultBox.TabIndex = 11;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(303, 207);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // mutualInductanceFactor
            // 
            this.mutualInductanceFactor.FormattingEnabled = true;
            this.mutualInductanceFactor.Items.AddRange(new object[] {
            "mH",
            "uH",
            "nH",
            "pH"});
            this.mutualInductanceFactor.Location = new System.Drawing.Point(128, 118);
            this.mutualInductanceFactor.Name = "mutualInductanceFactor";
            this.mutualInductanceFactor.Size = new System.Drawing.Size(40, 21);
            this.mutualInductanceFactor.TabIndex = 1;
            // 
            // bInductanceFactor
            // 
            this.bInductanceFactor.FormattingEnabled = true;
            this.bInductanceFactor.Items.AddRange(new object[] {
            "mH",
            "uH",
            "nH",
            "pH"});
            this.bInductanceFactor.Location = new System.Drawing.Point(279, 151);
            this.bInductanceFactor.Name = "bInductanceFactor";
            this.bInductanceFactor.Size = new System.Drawing.Size(40, 21);
            this.bInductanceFactor.TabIndex = 7;
            // 
            // aInductanceFactor
            // 
            this.aInductanceFactor.FormattingEnabled = true;
            this.aInductanceFactor.Items.AddRange(new object[] {
            "mH",
            "uH",
            "nH",
            "pH"});
            this.aInductanceFactor.Location = new System.Drawing.Point(279, 118);
            this.aInductanceFactor.Name = "aInductanceFactor";
            this.aInductanceFactor.Size = new System.Drawing.Size(40, 21);
            this.aInductanceFactor.TabIndex = 5;
            // 
            // angularFrequencyUnit
            // 
            this.angularFrequencyUnit.FormattingEnabled = true;
            this.angularFrequencyUnit.Items.AddRange(new object[] {
            "rad/s",
            "Hz"});
            this.angularFrequencyUnit.Location = new System.Drawing.Point(116, 151);
            this.angularFrequencyUnit.Name = "angularFrequencyUnit";
            this.angularFrequencyUnit.Size = new System.Drawing.Size(52, 21);
            this.angularFrequencyUnit.TabIndex = 3;
            // 
            // saveK1SelectionBox
            // 
            this.saveK1SelectionBox.AutoSize = true;
            this.saveK1SelectionBox.Location = new System.Drawing.Point(82, 179);
            this.saveK1SelectionBox.Name = "saveK1SelectionBox";
            this.saveK1SelectionBox.Size = new System.Drawing.Size(81, 17);
            this.saveK1SelectionBox.TabIndex = 26;
            this.saveK1SelectionBox.Text = "Save Value";
            this.saveK1SelectionBox.UseVisualStyleBackColor = true;
            // 
            // efficiencyCalculatorButton
            // 
            this.efficiencyCalculatorButton.Location = new System.Drawing.Point(17, 207);
            this.efficiencyCalculatorButton.Name = "efficiencyCalculatorButton";
            this.efficiencyCalculatorButton.Size = new System.Drawing.Size(75, 23);
            this.efficiencyCalculatorButton.TabIndex = 28;
            this.efficiencyCalculatorButton.Text = "Efficiency";
            this.efficiencyCalculatorButton.UseVisualStyleBackColor = true;
            this.efficiencyCalculatorButton.Click += new System.EventHandler(this.efficiencyCalculatorButton_Click);
            // 
            // MabPictureBox
            // 
            this.MabPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MabPictureBox.Image")));
            this.MabPictureBox.Location = new System.Drawing.Point(17, 111);
            this.MabPictureBox.Name = "MabPictureBox";
            this.MabPictureBox.Size = new System.Drawing.Size(30, 31);
            this.MabPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MabPictureBox.TabIndex = 29;
            this.MabPictureBox.TabStop = false;
            // 
            // omega_zeroPictureBox
            // 
            this.omega_zeroPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("omega_zeroPictureBox.Image")));
            this.omega_zeroPictureBox.Location = new System.Drawing.Point(17, 147);
            this.omega_zeroPictureBox.Name = "omega_zeroPictureBox";
            this.omega_zeroPictureBox.Size = new System.Drawing.Size(30, 31);
            this.omega_zeroPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.omega_zeroPictureBox.TabIndex = 30;
            this.omega_zeroPictureBox.TabStop = false;
            // 
            // LaPictureBox
            // 
            this.LaPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LaPictureBox.Image")));
            this.LaPictureBox.Location = new System.Drawing.Point(174, 111);
            this.LaPictureBox.Name = "LaPictureBox";
            this.LaPictureBox.Size = new System.Drawing.Size(30, 31);
            this.LaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LaPictureBox.TabIndex = 31;
            this.LaPictureBox.TabStop = false;
            // 
            // LbPictureBox
            // 
            this.LbPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LbPictureBox.Image")));
            this.LbPictureBox.Location = new System.Drawing.Point(174, 147);
            this.LbPictureBox.Name = "LbPictureBox";
            this.LbPictureBox.Size = new System.Drawing.Size(30, 31);
            this.LbPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LbPictureBox.TabIndex = 32;
            this.LbPictureBox.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(17, 236);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(107, 23);
            this.closeButton.TabIndex = 33;
            this.closeButton.Text = "Close Window";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "all values in uH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "uH";
            // 
            // CouplingCoefficientCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 274);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.LbPictureBox);
            this.Controls.Add(this.LaPictureBox);
            this.Controls.Add(this.omega_zeroPictureBox);
            this.Controls.Add(this.MabPictureBox);
            this.Controls.Add(this.efficiencyCalculatorButton);
            this.Controls.Add(this.saveK1SelectionBox);
            this.Controls.Add(this.angularFrequencyUnit);
            this.Controls.Add(this.aInductanceFactor);
            this.Controls.Add(this.bInductanceFactor);
            this.Controls.Add(this.mutualInductanceFactor);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.angularFrequencyValueBox);
            this.Controls.Add(this.bInductanceValueBox);
            this.Controls.Add(this.aInductanceValueBox);
            this.Controls.Add(this.mutualInductanceValueBox);
            this.Controls.Add(this.k1PictureBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CouplingCoefficientCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Coupling Coefficient";
            this.Load += new System.EventHandler(this.CouplingCoefficientCalculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.k1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MabPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.omega_zeroPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LbPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox k1PictureBox;
        private System.Windows.Forms.TextBox mutualInductanceValueBox;
        private System.Windows.Forms.TextBox aInductanceValueBox;
        private System.Windows.Forms.TextBox bInductanceValueBox;
        private System.Windows.Forms.TextBox angularFrequencyValueBox;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.ComboBox mutualInductanceFactor;
        private System.Windows.Forms.ComboBox bInductanceFactor;
        private System.Windows.Forms.ComboBox aInductanceFactor;
        private System.Windows.Forms.ComboBox angularFrequencyUnit;
        private System.Windows.Forms.CheckBox saveK1SelectionBox;
        private System.Windows.Forms.Button efficiencyCalculatorButton;
        private System.Windows.Forms.PictureBox MabPictureBox;
        private System.Windows.Forms.PictureBox omega_zeroPictureBox;
        private System.Windows.Forms.PictureBox LaPictureBox;
        private System.Windows.Forms.PictureBox LbPictureBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}