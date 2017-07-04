using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HybridCalculator;

namespace HybridGUI
{
    public partial class Main : Form
    {
        public string ChosenItem { get; set; }
        public int incEsTier { get; set; }
        public int altIncEsTier { get; set; }
        public Main()
		{
			InitializeComponent();
			FormatTextBoxes();
		}

		private void FormatTextBoxes()
		{
			this.stunRecoveryRollTextBox.Enabled = false;
			tabControl1.ItemSize = new Size(0, 1);
			tabControl1.SizeMode = TabSizeMode.Fixed;
			toolTip1.SetToolTip(this.flatEsRollTextBox, $"Enter a value from 3-145");
			toolTip1.SetToolTip(this.incEsRollTextBox, $"Enter a value from 11-188");
			toolTip1.SetToolTip(this.stunRecoveryRollTextBox, $"Enter a value from 6-17");
			flatEsRollTextBox.Select(0, textBox1.Text.Length);
			incEsRollTextBox.Select(0, textBox1.Text.Length);
			stunRecoveryRollTextBox.Select(0, textBox1.Text.Length);
		}

		private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            Armour item = new Regalia();
			item.FlatEsRoll = Int32.Parse(flatEsRollTextBox.Text);

			item.FlatTiers();
            item.IsHybrid = hasStunRecoveryCheckBox.Checked;
            if (item.IsHybrid ?? true)
            {
                item.StunRecoveryRoll = Int32.Parse(stunRecoveryRollTextBox.Text);
                item.StunRecoveryTiers();
            }
            item.IncEsRoll = Int32.Parse(incEsRollTextBox.Text);
            item.IncEsTiers();
            item.IncEsFromHybrid();

            MinMaxES.Calculate(item);
            if (item.AltItem)
            {

                tabControl1.SelectTab(1);

                Armour altItem = AffixTier.CreateAltItem(item);
                MinMaxES.Calculate(altItem);

                minEsResultTextBox2.Text = item.MinEsResult.ToString();
                maxEsResultTextBox2.Text = item.MaxEsResult.ToString();
                toolTip1.SetToolTip(this.progressBar2, $"Current ES is : {item.CurrentEsResult}");
                progressBar2.Minimum = item.MinEsResult;
                progressBar2.Maximum = item.MaxEsResult;
                progressBar2.Value = item.CurrentEsResult;

                minAltEsResultTextBox.Text = altItem.MinEsResult.ToString();
                maxAltEsResultTextBox.Text = altItem.MaxEsResult.ToString();
                toolTip1.SetToolTip(this.progressBar3, $"Current ES is : {altItem.CurrentEsResult}");
                progressBar3.Minimum = altItem.MinEsResult;
                progressBar3.Maximum = altItem.MaxEsResult;
                progressBar3.Value = item.CurrentEsResult;

                incEsTier = item.IncEsTier;
                altIncEsTier = item.AltIncEsTier;
                label4.Text = $"The Increased tier could be either Tier: {incEsTier} or Tier: {altIncEsTier}";
                label4.TextAlign = ContentAlignment.MiddleCenter;
            }
            else
            {
                tabControl1.SelectTab(0);
                minEsResultTextBox.Text = item.MinEsResult.ToString();
                maxEsResultTextBox.Text = item.MaxEsResult.ToString();
                toolTip1.SetToolTip(this.progressBar1, $"Current ES is : {item.CurrentEsResult}");
                progressBar1.Minimum = item.MinEsResult;
                progressBar1.Maximum = item.MaxEsResult;
                progressBar1.Value = item.CurrentEsResult;

                incEsTier = item.IncEsTier;
                label5.Text = $"The Increased Energy Shield is Tier: {incEsTier}";
                label5.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.stunRecoveryRollTextBox.Enabled = this.hasStunRecoveryCheckBox.Checked;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void resultsTextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void flatEsRollTextBox_ValueChanged(object sender, EventArgs e)
        {

		}

		private void flatEsRollTextBox_KeyUp(object sender, KeyEventArgs e)
		{
			if (flatEsRollTextBox.Value >= 10)
			{
				flatEsRollTextBox.Value = 0;
				MessageBox.Show("number must be less than 10!");
			}
		}

		private void flatEsRollTextBox_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == System.Windows.Forms.MouseButtons.Right)
			{
				if (flatEsRollTextBox.Value >= 10)
				{
					flatEsRollTextBox.Value = 0;
					MessageBox.Show("number must be less than 10!");
				}
			}
		}
		private void stunRecoveryRollTextBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void incEsRollTextBox_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(incEsRollTextBox.Value) > 132)
            {
                hasStunRecoveryCheckBox.Checked = true;
            }
            else
            {
                hasStunRecoveryCheckBox.Checked = false;
            }
        }
    }
}
