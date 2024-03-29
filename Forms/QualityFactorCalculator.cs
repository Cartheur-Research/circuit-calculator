using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;

namespace CircuitCalculator.Forms
{
    public partial class QualityFactorCalculator : Form
    {
        private Form owner;

        public QualityFactorCalculator(Form mOwner)
        {
            InitializeComponent();
            owner = mOwner;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            StartPosition = FormStartPosition.CenterParent;
            ShowInTaskbar = false;
            ControlBox = false;
            Instance = true;
        }
        public QualityFactorCalculator()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            StartPosition = FormStartPosition.CenterParent;
            ShowInTaskbar = false;
            ControlBox = false;
            Instance = true;
        }

        private void QualityFactorCalculator_Load(object sender, EventArgs e)
        {
            currentFactor.SelectedItem = "A";
            voltageFactor.SelectedItem = "V";

            var toolTip = new ToolTip
            {
                AutoPopDelay = 10000,
                InitialDelay = 400,
                ReshowDelay = 250,
                ShowAlways = true
            };
            toolTip.SetToolTip(infoLabel, "Physically speaking, Q is 2 * pi times the ratio of the total " + 
            "energy stored divided by the energy lost in a single cycle or equivalently the ratio of the stored " +
            "energy to the energy dissipated per one radian of the oscillation. It is a dimensionless parameter " +
            "that compares the time constant for decay of an oscillating physical system's amplitude to its " +
            "oscillation period. Equivalently, it compares the frequency at which a system oscillates to the rate at which it dissipates its energy.");
            toolTip.SetToolTip(lossesCalculatorButton, "Resistive and Radiative Losses Calculator");
            toolTip.SetToolTip(parallelCaseQualityWikipediaRyneWang, "This is an oversimplified version of Ruye Wang (see 'quality factor' in literature survey), pushed onto Wikipedia.");
            toolTip.SetToolTip(zeirhoferCaseQuality, "Zierhofer's quality equation.");
            toolTip.SetToolTip(qualityEquationWPC, "Brought to you by the arrogant geniuses at WPC.");
        }

        /// <summary>
        /// Checks the instance of the form.
        /// </summary>
        public static bool Instance { get; set; }
        /// <summary>
        /// Calculates the energy stored.
        /// </summary>
        public double CalculateEnergyStored()
        {
            double result = 0;
            double inductance = 0;
            double capacitance = 0;
            double current = Convert.ToDouble(currentValueBox.Text);
            double voltage = Convert.ToDouble(voltageValueBox.Text);
            double tempInductance = Convert.ToDouble(inductance2ValueBox.Text);
            double tempCapacitance = Convert.ToDouble(capacitanceValueBox.Text);

            if (inductance2Factor.Text == "H")
            {
                inductance = tempInductance * 1;
            }
            if (inductance2Factor.Text == "mH")
            {
                inductance = tempInductance * 1E-3;
            }
            if (inductance2Factor.Text == "uH")
            {
                inductance = tempInductance * 1E-6;
            }
            if (inductance2Factor.Text == "nH")
            {
                inductance = tempInductance * 1E-9;
            }
            if (inductance2Factor.Text == "pH")
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

            double uL = inductance * Math.Pow(current, 2);
            double uC = capacitance * Math.Pow(voltage, 2);
            double total = uL + uC;
            resultBoxEnergyInductances.Text = uL.ToString();
            resultBoxEnergyCapacitances.Text = uC.ToString();
            totalEnergyResultBox.Text = total.ToString();

            return result;
        }
        /// <summary>
        /// Closes the form.
        /// </summary>
        private void closeButton_Click(object sender, EventArgs e)
        {
            Instance = false;
            Close();
        }
        /// <summary>
        /// Calls the resistive and radiative losses calculator.
        /// </summary>
        private void lossesCalculatorButton_Click(object sender, EventArgs e)
        {
            if (ResistiveRadiativeLossesCalculator.Instance == false)
            {
                ResistiveRadiativeLossesCalculator form = new ResistiveRadiativeLossesCalculator(this);
                form.Show(this);
                ResistiveRadiativeLossesCalculator.Instance = true;
            }
            else if (ResistiveRadiativeLossesCalculator.Instance == true)
            {
                // Do nothing.
            }
        }

        #region Calculate WPC Quality
        /// <summary>
        /// Handles the Click event of the calculateButtonWPC control.
        /// </summary>
        private void calculateButtonWPC_Click(object sender, EventArgs e)
        {
            CalculateWpcQuality();
        }
        /// <summary>
        /// Calculates the WPC quality.
        /// </summary>
        public double CalculateWpcQuality()
        {
            double result = 0;
            double frequency = 0;
            double inductance = 0;

            double tempFrequency = Convert.ToDouble(frequencyValueBox.Text);
            double tempInductance = Convert.ToDouble(inductanceValueBox.Text);
            double resistance = Convert.ToDouble(resistanceValueBox.Text);

            if (frequencyFactor.Text == "MHz")
            {
                frequency = tempFrequency * 1E6;
            }
            if (frequencyFactor.Text == "kHz")
            {
                frequency = tempFrequency * 1E3;
            }
            if (frequencyFactor.Text == "Hz")
            {
                frequency = tempFrequency;
            }
            if (inductanceFactor.Text == "H")
            {
                inductance = tempInductance;
            }
            if (inductanceFactor.Text == "mH")
            {
                inductance = tempInductance * 1E-3;
            }
            if (inductanceFactor.Text == "uH")
            {
                inductance = tempInductance * 1E-6;
            }
            // Perform the calculation.
            result = (((2 * Math.PI) * frequency) * inductance) / resistance;
            resultBoxWPC.Text = result.ToString();

            return result;
        }
        #endregion

        #region Calculate Sum Quality
        /// <summary>
        /// Calculates the sum quality.
        /// </summary>
        protected double CalculateQuality()
        {
            double result = 0;
            double resistance = 0;
            double inductance = 0;
            double capacitance = 0;

            double tempResistance = Convert.ToDouble(currentValueBox.Text);
            double tempInductance = Convert.ToDouble(inductance2ValueBox.Text);
            double tempCapacitance = Convert.ToDouble(capacitanceValueBox.Text);

            if (currentFactor.Text == "Ω")
            {
                resistance = tempResistance;
            }
            if (currentFactor.Text == "kΩ")
            {
                resistance = tempResistance * 1E3;
            }
            if (currentFactor.Text == "MΩ")
            {
                resistance = tempResistance * 1E6;
            }
            if (inductance2Factor.Text == "H")
            {
                inductance = tempInductance * 1;
            }
            if (inductance2Factor.Text == "mH")
            {
                inductance = tempInductance * 1E-3;
            }
            if (inductance2Factor.Text == "uH")
            {
                inductance = tempInductance * 1E-6;
            }
            if (inductance2Factor.Text == "nH")
            {
                inductance = tempInductance * 1E-9;
            }
            if (inductance2Factor.Text == "pH")
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
            resultBoxEnergyInductances.Text = result.ToString();

            return result;
        }
        
        /// <summary>
        /// Call the Wiki Quality calculation.
        /// </summary>
        private void calculateButtonWiki_Click(object sender, EventArgs e)
        {
            //CalculateQuality();
            CalculateEnergyStored();
        }
        #endregion

        #region Calculate Equivalent Quality
        /// <summary>
        /// Calculates the Zeirhofer quality from 1996 paper compared to that for a parallel circuit.
        /// </summary>
        public void CalculateAllQuality()
        {
            double resistance = 0;
            double inductance = 0;
            double capacitance = 0;

            double tempResistance = Convert.ToDouble(resistance3ValueBox.Text);
            double tempInductance = Convert.ToDouble(inductance3ValueBox.Text);
            double tempCapacitance = Convert.ToDouble(capacitance2ValueBox.Text);

            if (resistance2Factor.Text == "Ω")
            {
                resistance = tempResistance;
            }
            if (resistance2Factor.Text == "kΩ")
            {
                resistance = tempResistance * 1E3;
            }
            if (resistance2Factor.Text == "MΩ")
            {
                resistance = tempResistance * 1E6;
            }
            if (inductance3Factor.Text == "H")
            {
                inductance = tempInductance * 1;
            }
            if (inductance3Factor.Text == "mH")
            {
                inductance = tempInductance * 1E-3;
            }
            if (inductance3Factor.Text == "uH")
            {
                inductance = tempInductance * 1E-6;
            }
            if (inductance3Factor.Text == "nH")
            {
                inductance = tempInductance * 1E-9;
            }
            if (inductance3Factor.Text == "pH")
            {
                inductance = tempInductance * 1E-12;
            }
            if (capacitance2Factor.Text == "uF")
            {
                capacitance = tempCapacitance * 1E-6;
            }
            if (capacitance2Factor.Text == "nF")
            {
                capacitance = tempCapacitance * 1E-9;
            }
            if (capacitance2Factor.Text == "pF")
            {
                capacitance = tempCapacitance * 1E-12;
            }
            // Perform the calculations
            CalculateParallelQuality(resistance, inductance, capacitance);
            CalculateZeirhoferQuality(resistance, inductance, capacitance);
        }
        /// <summary>
        /// Calculates the parallel quality.
        /// </summary>
        /// <param name="resistance">The resistance.</param>
        /// <param name="inductance">The inductance.</param>
        /// <param name="capacitance">The capacitance.</param>
        /// <returns>The calculation of quality for a parallel circuit.</returns>
        public double CalculateParallelQuality(double resistance, double inductance, double capacitance)
        {
            double result = 0;
            double sqrt = Math.Sqrt(capacitance / inductance);
            result = resistance * sqrt;
            resultBoxMyneEquivalent.Text = result.ToString();
            return result;
        }
        /// <summary>
        /// Calculates the Zierhofer quality.
        /// </summary>
        /// <param name="resistance">The resistance.</param>
        /// <param name="inductance">The inductance.</param>
        /// <param name="capacitance">The capacitance.</param>
        /// <returns>The calculation of quality for a series circuit, with an reciprocal Q.</returns>
        public double CalculateZeirhoferQuality(double resistance, double inductance, double capacitance)
        {
            var sqrt = Math.Sqrt(inductance / capacitance);
            var reciprocal = (1 / resistance) * sqrt;
            var result = 1 / reciprocal;
            resultBoxZeirhoferEquivalent.Text = result.ToString(CultureInfo.InvariantCulture);
            return result;
        }
        /// <summary>
        /// Calculates the equivilancy of two equations.
        /// </summary>
        private void calculateButtonEquivalent_Click(object sender, EventArgs e)
        {
            CalculateAllQuality();
        }

        #endregion

        #region Check Reciprocals
        /// <summary>
        /// Checks if fields are reciprocals.
        /// </summary>
        private void reciprocalsButton_Click(object sender, EventArgs e)
        {
            CheckReciprocals();
        }
        /// <summary>
        /// Checks the reciprocals.
        /// </summary>
        public void CheckReciprocals()
        {
            double a, b, c = 0;
            //double result = 0;

            a = Convert.ToDouble(resultBoxMyneEquivalent.Text);
            b = Convert.ToDouble(resultBoxZeirhoferEquivalent.Text);
            c = 1 / b;
            if (Equals(a, c))
                reciprocalsReportingLabel.Text = "These values are reciprocals.";
            else
                reciprocalsReportingLabel.Text = "These values are not reciprocals.";
            
        }

        #endregion

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify that the link was visited.
            linkLabel1.LinkVisited = true;

            // Navigate to a URL.
            Process.Start("http://eculator.com/formula/calculator.do?equation=Quality-factor-%28Q-factor%29&id=93");

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify that the link was visited.
            linkLabel1.LinkVisited = true;

            // Navigate to a URL.
            Process.Start("http://en.wikipedia.org/wiki/Q-factor#RLC_circuits");
            
        }

    }
}