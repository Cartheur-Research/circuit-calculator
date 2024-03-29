using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace CircuitCalculator.Forms
{
    public partial class RLCNetworkCalculator : Form
    {
        DbProviderFactory fact = DbProviderFactories.GetFactory("System.Data.SQLite");

        private Form owner;
        private static bool instance = false;

        public RLCNetworkCalculator(Form mOwner)
        {
            InitializeComponent();
            using (DbConnection cnn = fact.CreateConnection())
            {
                cnn.ConnectionString = "Data Source=parameter.db";
                cnn.Open();
            }
            owner = mOwner;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.StartPosition = FormStartPosition.CenterParent;
            this.ShowInTaskbar = false;
            this.ControlBox = false;
            instance = true;
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void RLCNetworkCalculator_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 750;
            toolTip.ReshowDelay = 250;
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(this.inductanceValueBox, "The Value of the Inductor in the Circuit");
            toolTip.SetToolTip(this.inductanceFactor, "The Dimension of the Inductance");
            toolTip.SetToolTip(this.capacitanceValueBox, "The Value of the Capacitor in the Circuit");
            toolTip.SetToolTip(this.capacitanceFactor, "The Dimension of the Capacitance");
            toolTip.SetToolTip(this.resistanceValueBox, "The Value of the Resistor in the Circuit");
            toolTip.SetToolTip(this.resistanceFactor, "The Dimension of the Resistance");
            toolTip.SetToolTip(this.calculateButton, "Calculate the Result");
            toolTip.SetToolTip(this.attenuationResultBox, "The Attenuation of the Circuit");
            toolTip.SetToolTip(this.dampingFactorResultBox, "The Dampening Factor in the Circuit");
            toolTip.SetToolTip(this.resonanceFrequencyResultBox, "The Resonance Frequency of the Circuit");
            toolTip.SetToolTip(this.viewSeriesCircuitButton, "See an example of the series RLC circuit.");
            toolTip.SetToolTip(this.viewParallelCircuitButton, "See an example of the parallel RLC circuit.");
            toolTip.SetToolTip(this.qualityResultBox, "The Quality Factor of the Circuit");
            toolTip.SetToolTip(this.saveQualitySelectionBox, "Select if you want to calculate for efficiency later.");
            toolTip.SetToolTip(this.iQualitySelectionBox, "Select if the value is for the first loop in the system. (Applies only when saving.)");
            toolTip.SetToolTip(this.jQualitySelectionBox, "Select if the value is for the second loop in the system. (Applies only when saving.)");
            toolTip.SetToolTip(this.fractionalBandwidthResultBox, "The Fractional Bandwidth of the Circuit");
            toolTip.SetToolTip(this.efficiencyCalculatorButton, "Calculate the Efficiency.");
        }
        /// <summary>
        /// Checks the instance of the form.
        /// </summary>
        public static bool Instance { get { return instance; } set { instance = value; } }
        /// <summary>
        /// Calculates the attentuation.
        /// </summary>
        /// <param name="res">The resistance.</param>
        /// <param name="cap">The capacitance.</param>
        public double CalculateAttentuation(string res, string cap)
        {
            double result = 0;
            double resistance = 0;
            double capacitance = 0;

            double tempResistance = Convert.ToDouble(resistanceValueBox.Text);
            double tempCapacitance = Convert.ToDouble(capacitanceValueBox.Text);

            if (resistanceFactor.Text == "Ω")
            {
                resistance = tempResistance;
            }
            if (resistanceFactor.Text == "kΩ")
            {
                resistance = tempResistance * 1E3;
            }
            if (resistanceFactor.Text == "MΩ")
            {
                resistance = tempResistance * 1E6;
            }
            if (capacitanceFactor.Text == "uF")
            {
                capacitance = tempCapacitance * 1E-6;
            }
            if (capacitanceFactor.Text == "nF")
            {
                capacitance = tempCapacitance * 1E-9;
            }
            if (capacitanceFactor.Text == "pF")
            {
                capacitance = tempCapacitance * 1E-12;
            }
            // Perform the calculation.
            result = 1 / (2 * resistance * capacitance);
            attenuationResultBox.Text = result.ToString();
            return result;
        }
        /// <summary>
        /// Calculates the damping factor.
        /// </summary>
        /// <param name="res">The resistance.</param>
        /// <param name="ind">The inductance.</param>
        /// <param name="cap">The capacitance.</param>
        public double CalculateDampingFactor(string res, string ind, string cap)
        {
            double result = 0;
            double resistance = 0;
            double inductance = 0;
            double capacitance = 0;

            double tempResistance = Convert.ToDouble(resistanceValueBox.Text);
            double tempInductance = Convert.ToDouble(inductanceValueBox.Text);
            double tempCapacitance = Convert.ToDouble(capacitanceValueBox.Text);

            if (resistanceFactor.Text == "Ω")
            {
                resistance = tempResistance;
            }
            if (resistanceFactor.Text == "kΩ")
            {
                resistance = tempResistance * 1E3;
            }
            if (resistanceFactor.Text == "MΩ")
            {
                resistance = tempResistance * 1E6;
            }
            if (inductanceFactor.Text == "H")
            {
                inductance = tempInductance * 1;
            }
            if (inductanceFactor.Text == "mH")
            {
                inductance = tempInductance * 1E-3;
            }
            if (inductanceFactor.Text == "uH")
            {
                inductance = tempInductance * 1E-6;
            }
            if (inductanceFactor.Text == "nH")
            {
                inductance = tempInductance * 1E-9;
            }
            if (inductanceFactor.Text == "pH")
            {
                inductance = tempInductance * 1E-12;
            }
            if (capacitanceFactor.Text == "uF")
            {
                capacitance = tempCapacitance * 1E-6;
            }
            if (capacitanceFactor.Text == "nF")
            {
                capacitance = tempCapacitance * 1E-9;
            }
            if (capacitanceFactor.Text == "pF")
            {
                capacitance = tempCapacitance * 1E-12;
            }
            // Perform the calculation
            double sqrt = Math.Sqrt(inductance / capacitance);
            result = 1 / (2 * resistance) * sqrt;
            dampingFactorResultBox.Text = result.ToString();
            return result;
        }
        /// <summary>
        /// Calculates the resonance frequency.
        /// </summary>
        /// <param name="ind">The inductance.</param>
        /// <param name="cap">The capacitance.</param>
        public double CalculateResonanceFrequency(string ind, string cap)
        {
            double result = 0;
            double inductance = 0;
            double capacitance = 0;

            double tempInductance = Convert.ToDouble(inductanceValueBox.Text);
            double tempCapacitance = Convert.ToDouble(capacitanceValueBox.Text);

            if (inductanceFactor.Text == "H")
            {
                inductance = tempInductance * 1;
            }
            if (inductanceFactor.Text == "mH")
            {
                inductance = tempInductance * 1E-3;
            }
            if (inductanceFactor.Text == "uH")
            {
                inductance = tempInductance * 1E-6;
            }
            if (inductanceFactor.Text == "nH")
            {
                inductance = tempInductance * 1E-9;
            }
            if (inductanceFactor.Text == "pH")
            {
                inductance = tempInductance * 1E-12;
            }
            if (capacitanceFactor.Text == "uF")
            {
                capacitance = tempCapacitance * 1E-6;
            }
            if (capacitanceFactor.Text == "nF")
            {
                capacitance = tempCapacitance * 1E-9;
            }
            if (capacitanceFactor.Text == "pF")
            {
                capacitance = tempCapacitance * 1E-12;
            }
            // Perform the calculation
            double sqrt = Math.Sqrt(inductance * capacitance);
            result = 1 / sqrt;
            resonanceFrequencyResultBox.Text = result.ToString();
            return result;
        }
        /// <summary>
        /// Calculates the quality.
        /// </summary>
        /// <param name="res">The resistance.</param>
        /// <param name="ind">The inductance.</param>
        /// <param name="cap">The capacitance.</param>
        public double CalculateQuality(string res, string ind, string cap)
        {
            double result = 0;
            double resistance = 0;
            double inductance = 0;
            double capacitance = 0;

            double tempResistance = Convert.ToDouble(resistanceValueBox.Text);
            double tempInductance = Convert.ToDouble(inductanceValueBox.Text);
            double tempCapacitance = Convert.ToDouble(capacitanceValueBox.Text);

            if (resistanceFactor.Text == "Ω")
            {
                resistance = tempResistance;
            }
            if (resistanceFactor.Text == "kΩ")
            {
                resistance = tempResistance * 1E3;
            }
            if (resistanceFactor.Text == "MΩ")
            {
                resistance = tempResistance * 1E6;
            }
            if (inductanceFactor.Text == "H")
            {
                inductance = tempInductance * 1;
            }
            if (inductanceFactor.Text == "mH")
            {
                inductance = tempInductance * 1E-3;
            }
            if (inductanceFactor.Text == "uH")
            {
                inductance = tempInductance * 1E-6;
            }
            if (inductanceFactor.Text == "nH")
            {
                inductance = tempInductance * 1E-9;
            }
            if (inductanceFactor.Text == "pH")
            {
                inductance = tempInductance * 1E-12;
            }
            if (capacitanceFactor.Text == "uF")
            {
                capacitance = tempCapacitance * 1E-6;
            }
            if (capacitanceFactor.Text == "nF")
            {
                capacitance = tempCapacitance * 1E-9;
            }
            if (capacitanceFactor.Text == "pF")
            {
                capacitance = tempCapacitance * 1E-12;
            }
            // Perform the calculation
            double sqrt = Math.Sqrt(capacitance / inductance);
            result = resistance * sqrt;
            qualityResultBox.Text = result.ToString();

            if (saveQualitySelectionBox.Checked == true)
            {
                if (iQualitySelectionBox.Checked == true && jQualitySelectionBox.Checked == false)
                {
                    SaveParameterResult(result, "iQuality");
                }
                else if (iQualitySelectionBox.Checked == false && jQualitySelectionBox.Checked == true)
                {
                    SaveParameterResult(result, "jQuality");
                }
            }

            return result;
        }
        /// <summary>
        /// Calculates the fractional bandwidth.
        /// </summary>
        /// <param name="res">The resistance.</param>
        /// <param name="ind">The inductance.</param>
        /// <param name="cap">The capacitance.</param>
        public double CalculateFractionalBandwidth(string res, string ind, string cap)
        {
            double result = 0;
            double resistance = 0;
            double inductance = 0;
            double capacitance = 0;

            double tempResistance = Convert.ToDouble(resistanceValueBox.Text);
            double tempInductance = Convert.ToDouble(inductanceValueBox.Text);
            double tempCapacitance = Convert.ToDouble(capacitanceValueBox.Text);

            if (resistanceFactor.Text == "Ω")
            {
                resistance = tempResistance;
            }
            if (resistanceFactor.Text == "kΩ")
            {
                resistance = tempResistance * 1E3;
            }
            if (resistanceFactor.Text == "MΩ")
            {
                resistance = tempResistance * 1E6;
            }
            if (inductanceFactor.Text == "H")
            {
                inductance = tempInductance * 1;
            }
            if (inductanceFactor.Text == "mH")
            {
                inductance = tempInductance * 1E-3;
            }
            if (inductanceFactor.Text == "uH")
            {
                inductance = tempInductance * 1E-6;
            }
            if (inductanceFactor.Text == "nH")
            {
                inductance = tempInductance * 1E-9;
            }
            if (inductanceFactor.Text == "pH")
            {
                inductance = tempInductance * 1E-12;
            }
            if (capacitanceFactor.Text == "uF")
            {
                capacitance = tempCapacitance * 1E-6;
            }
            if (capacitanceFactor.Text == "nF")
            {
                capacitance = tempCapacitance * 1E-9;
            }
            if (capacitanceFactor.Text == "pF")
            {
                capacitance = tempCapacitance * 1E-12;
            }
            // Perform the calculation
            double sqrt = Math.Sqrt(inductance / capacitance);
            result = (1 / resistance) * sqrt;
            fractionalBandwidthResultBox.Text = result.ToString();
            return result;
        }

        #region Save the parameter into the SQLite database.
        /// <summary>
        /// Saves the parameter result.
        /// </summary>
        /// <param name="result">The returned result.</param>
        /// <param name="table">The table where the value is stored.</param>
        protected void SaveParameterResult(double result, string column)
        {
            string directory = MapPath(@"\db\parameters.db");
            string path = @"c:\Users\ctucker\aeonProjectDirectory\Monkey-Man\thesis\circuits\CircuitCalculator";

            SQLiteConnection conn = new SQLiteConnection(@"Data Source=" + path + directory);
            SQLiteCommand cmd = new SQLiteCommand();
            cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Parameter (" + column + ") VALUES ('" + result + "')";
            conn.Open();
            SQLiteTransaction trans = conn.BeginTransaction();
            cmd.ExecuteNonQuery();
            trans.Commit();
            conn.Close();
            trans.Dispose();
            cmd.Dispose();
            conn.Dispose();
        }
        /// <summary>
        /// Maps the path of the executing file.
        /// </summary>
        /// <param name="path">The path to map.</param>
        public virtual string MapPath(string path)
        {
            string location = System.Reflection.Assembly.GetEntryAssembly().Location;
            string zebra = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
            string local = Environment.CurrentDirectory;
            return Path.Combine(zebra, path);
        }
        protected void SaveParameterResults(double result, string table)
        {
            string resulting = result.ToString();
            SQLiteDatabase db = new SQLiteDatabase();
            Dictionary<String, String> data = new Dictionary<String, String>();
            data.Add("QUALITY", resulting);
            try
            {
                db.Insert(table, data);
            }
            catch (Exception crap)
            {
                MessageBox.Show(crap.Message);
            }

        }
        #endregion

        #region View Forms
        private void viewSeriesCircuitButton_Click(object sender, EventArgs e)
        {
            if (SeriesRLC.Instance == false)
            {
                SeriesRLC form = new SeriesRLC(this);
                form.Show(this);
                SeriesRLC.Instance = true;
            }
            else if (SeriesRLC.Instance == true)
            {
                //Do nothing.
            }
        }

        private void viewParallelCircuitButton_Click(object sender, EventArgs e)
        {
            if (ParallelRLC.Instance == false)
            {
                ParallelRLC form = new ParallelRLC(this);
                form.Show(this);
                ParallelRLC.Instance = true;
            }
            else if (ParallelRLC.Instance == true)
            {
                //Do nothing.
            }
        }
        #endregion

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (capacitanceValueBox.Text == "" | resistanceValueBox.Text == "" | inductanceValueBox.Text == "")
            {
                MessageBox.Show("Value boxes cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                CalculateAttentuation(resistanceValueBox.Text, capacitanceValueBox.Text);
                CalculateDampingFactor(resistanceValueBox.Text, inductanceValueBox.Text, capacitanceValueBox.Text);
                CalculateResonanceFrequency(inductanceValueBox.Text, capacitanceValueBox.Text);
                CalculateQuality(resistanceValueBox.Text, inductanceValueBox.Text, capacitanceValueBox.Text);
                CalculateFractionalBandwidth(resistanceValueBox.Text, inductanceValueBox.Text, capacitanceValueBox.Text);
            }
        }
        /// <summary>
        /// Opens an instance of the Efficiency Calculator.
        /// </summary>
        private void efficiencyCalculatorButton_Click(object sender, EventArgs e)
        {
            if (EfficiencyCalculator.Instance == false)
            {
                EfficiencyCalculator form = new EfficiencyCalculator(this);
                form.Show(this);
                EfficiencyCalculator.Instance = true;
            }
            else if (EfficiencyCalculator.Instance == true)
            {
                // Do nothing.
            }
        }
        /// <summary>
        /// Closes the form.
        /// </summary>
        private void closeButton_Click(object sender, EventArgs e)
        {
            instance = false;
            Close();
        }
    }
}