using System;
using System.Drawing;
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

        string[] colors = new string[] { "Siyah", "Kahverengi", "Kırmızı", "Turuncu", "Sarı", "Yeşil", "Mavi", "Mor", "Gri", "Beyaz", "Altın", "Gümüş", "Renksiz" };
        string[] colorCodes = new string[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "purple", "gray", "white", "#FFD700", "#C0C0C0", "none" };
        string defaultComboboxText = "Renk Seçiniz";
        public frm_resstanceCalculator()
        {
            InitializeComponent();

        }

        private void btn_fourBandRes_Click(object sender, EventArgs e)
        {
            clearElements();
            pnl_color3Band.Visible = false;
            pnl_temperatureBand.Visible = false;

            gbxBand3.Visible = false;
            gbxBandTeperature.Visible = false;

            gbxTemperatureResult.Visible = false;
        }

        private void btn_fiveBandRes_Click(object sender, EventArgs e)
        {
            clearElements();
            pnl_color3Band.Visible = true;
            pnl_temperatureBand.Visible = false;

            gbxBand3.Visible = true;
            gbxBandTeperature.Visible = false;

            gbxTemperatureResult.Visible = false;
        }

        private void btn_sixBandRes_Click(object sender, EventArgs e)
        {
            clearElements();
            pnl_color3Band.Visible = true;
            pnl_temperatureBand.Visible = true;

            gbxBand3.Visible = true;
            gbxBandTeperature.Visible = true;

            gbxTemperatureResult.Visible = true;
        }

        private void frm_resstanceCalculator_Load(object sender, EventArgs e)
        {
            btn_fourBandRes.PerformClick();
            timer1.Enabled = true;

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
            int a = Array.IndexOf(colors, cbx_resBand1.SelectedItem.ToString());
            pnl_color1Band.BackColor = ColorTranslator.FromHtml(colorCodes[a]);
        }

        private void cbx_resBand2_SelectedIndexChanged(object sender, EventArgs e)
        {
            resistanceValueArray[1] = resBandValueArray[1, cbx_resBand2.SelectedIndex];
            int a = Array.IndexOf(colors, cbx_resBand2.SelectedItem.ToString());
            pnl_color2Band.BackColor = ColorTranslator.FromHtml(colorCodes[a]);
        }

        private void cbx_resBand3_SelectedIndexChanged(object sender, EventArgs e)
        {
            resistanceValueArray[2] = resBandValueArray[1, cbx_resBand3.SelectedIndex];
            int a = Array.IndexOf(colors, cbx_resBand3.SelectedItem.ToString());
            pnl_color3Band.BackColor = ColorTranslator.FromHtml(colorCodes[a]);
        }

        private void cbx_multiplierBand_SelectedIndexChanged(object sender, EventArgs e)
        {
            resistanceValueArray[3] = multiplierBandValueArray[1, cbx_multiplierBand.SelectedIndex];
            int a = Array.IndexOf(colors, cbx_multiplierBand.SelectedItem.ToString());
            pnl_multiplierBand.BackColor = ColorTranslator.FromHtml(colorCodes[a]);
        }

        private void btn_calculateResistance_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbx_resBand1.Text == defaultComboboxText || cbx_resBand2.Text == defaultComboboxText || ( gbxBand3.Visible == true && cbx_resBand3.Text == defaultComboboxText) || cbx_multiplierBand.Text == defaultComboboxText || cbx_toleranceBand.Text == defaultComboboxText || (gbxBandTeperature.Visible == true && cbx_temperatureBand.Text == defaultComboboxText))
                {
                    MessageBox.Show("Tüm alanları seçtiğinizden emin olunuz!", "Hata Bilgilendirmesi");
                }
                else
                {
                    lbl_resistanceResult.Text = resistanceValueArray[0] + resistanceValueArray[1] + resistanceValueArray[2] + resistanceValueArray[3];
                    lbl_toleranceResult.Text = resistanceTolerance;
                    lbl_temperatureResult.Text = resistanceTeperature;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "System Error");
            }
        }

        private void cbx_toleranceBand_SelectedIndexChanged(object sender, EventArgs e)
        {
            resistanceTolerance = toleranceBandValueArray[1, cbx_toleranceBand.SelectedIndex];
            int a = Array.IndexOf(colors, cbx_toleranceBand.SelectedItem.ToString());
            pnl_toleranceBand.BackColor = ColorTranslator.FromHtml(colorCodes[a]);
        }

        private void cbx_temperatureBand_SelectedIndexChanged(object sender, EventArgs e)
        {
            resistanceTeperature = temperacureBandValueArray[1, cbx_temperatureBand.SelectedIndex];
            int a = Array.IndexOf(colors, cbx_temperatureBand.SelectedItem.ToString());
            pnl_temperatureBand.BackColor = ColorTranslator.FromHtml(colorCodes[a]);
        }
        
        private void clearElements()
        {
            string defaultColorHexCode = "#E0E0E0";

            lbl_resistanceResult.Text = "";
            lbl_toleranceResult.Text = "";
            lbl_temperatureResult.Text = "";
            pnl_color1Band.BackColor = ColorTranslator.FromHtml(defaultColorHexCode);
            pnl_color2Band.BackColor = ColorTranslator.FromHtml(defaultColorHexCode);
            pnl_color3Band.BackColor = ColorTranslator.FromHtml(defaultColorHexCode);
            pnl_multiplierBand.BackColor = ColorTranslator.FromHtml(defaultColorHexCode);
            pnl_toleranceBand.BackColor = ColorTranslator.FromHtml(defaultColorHexCode);
            pnl_temperatureBand.BackColor = ColorTranslator.FromHtml(defaultColorHexCode);
            cbx_resBand1.Text = defaultComboboxText;
            cbx_resBand2.Text = defaultComboboxText;
            cbx_resBand3.Text = defaultComboboxText;
            cbx_multiplierBand.Text = defaultComboboxText;
            cbx_toleranceBand.Text = defaultComboboxText;
            cbx_temperatureBand.Text = defaultComboboxText;
        }

        private void btn_resistanceColorCodes_Click(object sender, EventArgs e)
        {
            frm_resistanceColorCodes f2 = new frm_resistanceColorCodes();
            f2.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            linkLabel1.Text = linkLabel1.Text.Substring(1) + linkLabel1.Text.Substring(0, 1);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://mustafaer.net");
        }
    }
}
