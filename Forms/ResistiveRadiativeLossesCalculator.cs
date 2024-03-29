using System;
using System.Globalization;
using System.Windows.Forms;
using CircuitCalculator.Numbers;

namespace CircuitCalculator.Forms
{
    public partial class ResistiveRadiativeLossesCalculator : Form
    {
        private Form _owner;

        public ResistiveRadiativeLossesCalculator(Form mOwner)
        {
            InitializeComponent();
            _owner = mOwner;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            StartPosition = FormStartPosition.CenterParent;
            ShowInTaskbar = false;
            ControlBox = false;
            Instance = true;
            StartPosition = FormStartPosition.CenterParent;
        }
        public ResistiveRadiativeLossesCalculator()
        {
            InitializeComponent();
            ComputeScheme();
        }

        private void ResistiveRadiativeLossesCalculator_Load(object sender, EventArgs e)
        {
            //numberOfTurnsPictureBox.Visible = false;
            //numberOfTurnsValueBox.Visible = false;
            angularFrequencyUnit.SelectedItem = "Hz";
            permeabilityAnalyticMethod.SelectedItem = "Standard Value";
            lengthFactor.SelectedItem = "cm";
            radiusFactor.SelectedItem = "cm";

            var toolTip = new ToolTip {AutoPopDelay = 20000, InitialDelay = 400, ReshowDelay = 250, ShowAlways = true};
            toolTip.SetToolTip(factsLabel, "When electrons are accelerated, as occurs when an AC electrical field is impressed on an antenna, " +
                "they will radiate electromagnetic waves. These waves carry energy that is taken from the electrons. The loss of energy of the electrons " +
                "appears as an effective resistance to the movement of the electrons, analogous to the ohmic resistance caused by scattering of the electrons " +
                "in the crystal lattice of the metallic conductor.While the energy lost by ohmic resistance is converted to heat, the energy lost by radiation " +
                "resistance is converted to electromagnetic radiation.");
            toolTip.SetToolTip(angularFrequencyUnit, "The resonance frequency of the circuit since it is designed to operate at this omega.");
            toolTip.SetToolTip(wireRadiusPictureBox, "The wire radius.");

        }
        /// <summary>
        /// Checks the instance of the form.
        /// </summary>
        public static bool Instance { get; set; }
        private void ComputeScheme()
        {
            angularFrequencyValueBox.Text = @"30";
            lengthValueBox.Text = @"10";
            wireRadiusValueBox.Text = @"0.029";
            numberOfTurnsValueBox.Text = @"3";
            relativePermeabilityMediumTextBox.Text = Constants.RelativePermeability.ToString(CultureInfo.InvariantCulture);
            conductivityMaterialValue.Text = @"1.0045";
            permeabilityAnalyticMethod.SelectedItem = "Standard Value";
            angularFrequencyUnit.SelectedItem = "Hz";
            conductivityMaterialSelection.SelectedItem = "Copper";
            lengthFactor.SelectedItem = "m";
            CalculateOhmicResistance();
        }
        /// <summary>
        /// Calculates the ohmic resistance.
        /// </summary>
        public double CalculateOhmicResistance()
        {
            double wireLength = 0;
            double angularFrequency = 0;
            const double relativePermeability = 12.56637E-7;

            var tempWireLength = Convert.ToDouble(lengthValueBox.Text);
            var loopRadius = Convert.ToDouble(wireRadiusValueBox.Text) * 1E-3;
            var resonanceFrequency = Convert.ToDouble(angularFrequencyValueBox.Text);
            var materialConductivity = Convert.ToDouble(conductivityMaterialValue.Text);
            var numberOfTurns = Convert.ToDouble(numberOfTurnsValueBox.Text);

            if (lengthFactor.SelectedItem.ToString() == "m")
            {
                wireLength = tempWireLength;
            }
            if (lengthFactor.SelectedItem.ToString() == "cm")
            {
                wireLength = tempWireLength * 1E-2;
            }
            if (lengthFactor.SelectedItem.ToString() == "mm")
            {
                wireLength = tempWireLength * 1E-3;
            }
            if (angularFrequencyUnit.SelectedItem.ToString() == "rad/s")
            {
                angularFrequency = resonanceFrequency;
            }
            if (angularFrequencyUnit.SelectedItem.ToString() == "Hz")
            {
                angularFrequency = resonanceFrequency * (2 * Math.PI);
            }

            var firstTerm = Math.Sqrt((relativePermeability * angularFrequency) / (2 * materialConductivity));
            var secondTerm = numberOfTurns;
            var thirdTerm = (wireLength * wireLength) / ((4 * Math.PI) * loopRadius);
            var result = firstTerm * secondTerm * thirdTerm;

            resultBox.Text = result.ToString(CultureInfo.InvariantCulture);

            return result;
        }

        #region Events
        /// <summary>
        /// Closes the form.
        /// </summary>
        private void closeButton_Click(object sender, EventArgs e)
        {
            Instance = false;
            Close();
        }
        /// <summary>
        /// Inputs the permability based on the media selection.
        /// </summary>
        private void permeabilityAnalyticMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (permeabilityAnalyticMethod.SelectedItem.ToString() == "Standard Value")
            {
                relativePermeabilityMediumTextBox.Text = @"4π * 10E-7";
            }
            if (permeabilityAnalyticMethod.SelectedItem.ToString() == "Nonlinear Media")
            {
                relativePermeabilityMediumTextBox.Text = @"Enter the value";
            }
        }
        /// <summary>
        /// Inputs the conductivity based on the material selection.
        /// </summary>
        private void conductivityMaterialSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (conductivityMaterialSelection.SelectedItem.ToString() == "Copper")
            {
                conductivityMaterialValue.Text = @"5.96E7";
            }
            if (conductivityMaterialSelection.SelectedItem.ToString() == "Aluminum")
            {
                conductivityMaterialValue.Text = @"3.50E7";
            }
            if (conductivityMaterialSelection.SelectedItem.ToString() == "Silver")
            {
                conductivityMaterialValue.Text = @"6.30E7";
            }
            if (conductivityMaterialSelection.SelectedItem.ToString() == "Gold")
            {
                conductivityMaterialValue.Text = @"4.52E7";
            }
            if (conductivityMaterialSelection.SelectedItem.ToString() == "Air")
            {
                conductivityMaterialValue.Text = @"3.8E-15";
            }
        }
        /// <summary>
        /// Starts the calculation sequence.
        /// </summary>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (angularFrequencyValueBox.Text == "" | lengthValueBox.Text == "" | wireRadiusValueBox.Text == "" | relativePermeabilityMediumTextBox.Text == "" | conductivityMaterialValue.Text == "")
            {
                MessageBox.Show(@"Value boxes are empty. Unless you have checked to load from the database and there are values stored, a set example will be shown.", @"Input Information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                angularFrequencyValueBox.Text = @"30";
                lengthValueBox.Text = @"10";
                wireRadiusValueBox.Text = @"0.029";
                numberOfTurnsValueBox.Text = @"3";
                relativePermeabilityMediumTextBox.Text = Constants.RelativePermeability.ToString(CultureInfo.InvariantCulture);
                conductivityMaterialValue.Text = @"1.0045";
                permeabilityAnalyticMethod.SelectedItem = "Standard Value";
                angularFrequencyUnit.SelectedItem = "Hz";
                conductivityMaterialSelection.SelectedItem = "Copper";
                lengthFactor.SelectedItem = "m";

                CalculateOhmicResistance();
            }
            else
            {
                CalculateOhmicResistance();
            }
        }
        #endregion

    }
}
