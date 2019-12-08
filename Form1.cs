using System;
using System.Windows.Forms;

namespace ResistanceCalculator
{
    public partial class frm_resstanceCalculator : Form
    {
        string[,] resBandValueArray = new string[,] { { "Siyah", "Kahverengi", "Kırmızı", "Turuncu", "Sarı", "Yeşil", "Mavi", "Mor", "Gri", "Beyaz" }, { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" } };
        string[,] multiplierBandValueArray = new string[,] { { "Siyah", "Kahverengi", "Kırmızı", "Turuncu", "Sarı", "Yeşil", "Mavi", "Mor", "Altın", "Gümüş" }, { " x 1", " x 10", " x 100", " x 10^3", " x 10^4", " x 10^5", " x 10^6", " x 10^7", " x 0.1", " x 0.01" } };
        string[,] toleranceBandValueArray = new string[,] { { "Kahverengi", "Kırmızı", "Yeşil", "Mavi", "Mor", "Gri", "Altın", "Gümüş", "Renksiz" }, { "± %1", "± %2", "± %0.5", "± %0.25", "± %0.10", "± %0.05", "± %5", "± %10", "± %20" } };
        string[,] temperacureBandValueArray = new string[,] { { "Kahverengi", "Kırmızı", "Turuncu", "Sarı" }, { "100 ppm", "50 ppm", "15 ppm", "25 ppm"} };
        string[] resistanceValueArray = new string[4] {"","","","" };
        string resistanceTolerance = "";
        string resistanceTeperature = "";

        public frm_resstanceCalculator()
        {
            InitializeComponent();

        }

        private void btn_fourBandRes_Click(object sender, EventArgs e)
        {
            pnl_color3Band.Visible = false;
            pnl_temperatureBand.Visible = false;
        }

        private void btn_fiveBandRes_Click(object sender, EventArgs e)
        {
            pnl_color3Band.Visible = true;
            pnl_temperatureBand.Visible = false;
        }

        private void btn_sixBandRes_Click(object sender, EventArgs e)
        {
            pnl_color3Band.Visible = true;
            pnl_temperatureBand.Visible = true;
        }

        private void frm_resstanceCalculator_Load(object sender, EventArgs e)
        {
            btn_fourBandRes.PerformClick();

            int loopCount = 0;
            int arrayIndex = 0;
            Array[] newArrayList= new Array[] {resBandValueArray, multiplierBandValueArray, toleranceBandValueArray, temperacureBandValueArray };
            for (int i = 0; i <= 5; i++)
            {
                int startIndex = 0;
                arrayIndex++;
                if (loopCount == 0 || loopCount ==1 || loopCount == 2)
                {
                    arrayIndex = 0;
                    if (loopCount == 2)
                    {
                        startIndex = 1;
                    }
                }

                for (int j = startIndex; j < newArrayList[arrayIndex].Length / 2; j++)
                {
                    switch (loopCount)
                    {
                        case 0:
                            cbx_resBand1.Items.Add(resBandValueArray[0, j]);
                            break;
                        case 1:
                            cbx_resBand2.Items.Add(resBandValueArray[0, j]);
                            break;
                        case 2:
                            cbx_resBand3.Items.Add(resBandValueArray[0, j]);
                            startIndex = 0;
                            break;
                        case 3:
                            cbx_multiplierBand.Items.Add(multiplierBandValueArray[0, j]);
                            break;
                        case 4:
                            cbx_toleranceBand.Items.Add(toleranceBandValueArray[0, j]);
                            break;
                        case 5:
                            cbx_temperatureBand.Items.Add(temperacureBandValueArray[0, j]);
                            break;
                    }
                }
                loopCount++;
            }
        }

        private void cbx_resBand1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetterOrDigit(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsNumber(e.KeyChar);
        }

        private void cbx_resBand2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetterOrDigit(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsNumber(e.KeyChar);
        }

        private void cbx_resBand3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetterOrDigit(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsNumber(e.KeyChar);
        }

        private void cbx_multiplierBand_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetterOrDigit(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsNumber(e.KeyChar);
        }

        private void cbx_toleranceBand_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetterOrDigit(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsNumber(e.KeyChar);
        }

        private void cbx_temperatureBand_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetterOrDigit(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsNumber(e.KeyChar);
        }

        private void cbx_resBand1_SelectedIndexChanged(object sender, EventArgs e)
        {
            resistanceValueArray[0] = resBandValueArray[1, cbx_resBand1.SelectedIndex];
        }

        private void cbx_resBand2_SelectedIndexChanged(object sender, EventArgs e)
        {
            resistanceValueArray[1] = resBandValueArray[1, cbx_resBand2.SelectedIndex];
        }

        private void cbx_resBand3_SelectedIndexChanged(object sender, EventArgs e)
        {
            resistanceValueArray[2] = resBandValueArray[1, cbx_resBand3.SelectedIndex];
        }

        private void cbx_multiplierBand_SelectedIndexChanged(object sender, EventArgs e)
        {
            resistanceValueArray[3] = multiplierBandValueArray[1, cbx_multiplierBand.SelectedIndex];
        }

        private void btn_calculateResistance_Click(object sender, EventArgs e)
        {
            lbl_resistanceResult.Text = resistanceValueArray[0]+ resistanceValueArray[1]+ resistanceValueArray[2]+ resistanceValueArray[3];
            lbl_toleranceResult.Text = resistanceTolerance;
            lbl_temperatureResult.Text = resistanceTeperature;
        }

        private void cbx_toleranceBand_SelectedIndexChanged(object sender, EventArgs e)
        {
            resistanceTolerance = toleranceBandValueArray[1, cbx_toleranceBand.SelectedIndex];
        }

        private void cbx_temperatureBand_SelectedIndexChanged(object sender, EventArgs e)
        {
            resistanceTeperature = temperacureBandValueArray[1, cbx_temperatureBand.SelectedIndex];
        }
    }
}
