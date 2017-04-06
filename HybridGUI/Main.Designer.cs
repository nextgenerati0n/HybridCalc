namespace HybridGUI
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.hasStunRecoveryCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flatEsRollTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.incEsRollTextBox = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stunRecoveryRollTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.minEsResultTextBox = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.maxEsResultTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.minAltEsResultTextBox = new System.Windows.Forms.TextBox();
            this.maxAltEsResultTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.minEsResultTextBox2 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.maxEsResultTextBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // hasStunRecoveryCheckBox
            // 
            this.hasStunRecoveryCheckBox.AccessibleDescription = "Does the item have a stun recovery roll?";
            this.hasStunRecoveryCheckBox.AutoSize = true;
            this.hasStunRecoveryCheckBox.Location = new System.Drawing.Point(23, 183);
            this.hasStunRecoveryCheckBox.Name = "hasStunRecoveryCheckBox";
            this.hasStunRecoveryCheckBox.Size = new System.Drawing.Size(125, 17);
            this.hasStunRecoveryCheckBox.TabIndex = 0;
            this.hasStunRecoveryCheckBox.Text = "Has Stun Recovery?";
            this.hasStunRecoveryCheckBox.UseVisualStyleBackColor = true;
            this.hasStunRecoveryCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "+# to maximum Energy Shield";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flatEsRollTextBox
            // 
            this.flatEsRollTextBox.Location = new System.Drawing.Point(182, 126);
            this.flatEsRollTextBox.Name = "flatEsRollTextBox";
            this.flatEsRollTextBox.Size = new System.Drawing.Size(57, 20);
            this.flatEsRollTextBox.TabIndex = 2;
            this.flatEsRollTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "#% increased Energy Shield";
            // 
            // incEsRollTextBox
            // 
            this.incEsRollTextBox.Location = new System.Drawing.Point(182, 153);
            this.incEsRollTextBox.Name = "incEsRollTextBox";
            this.incEsRollTextBox.Size = new System.Drawing.Size(57, 20);
            this.incEsRollTextBox.TabIndex = 4;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Old English Text MT", 24F);
            this.richTextBox1.Location = new System.Drawing.Point(130, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(239, 40);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "Hybrid Calculator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "#% increased Stun Recovery";
            // 
            // stunRecoveryRollTextBox
            // 
            this.stunRecoveryRollTextBox.Location = new System.Drawing.Point(183, 209);
            this.stunRecoveryRollTextBox.Name = "stunRecoveryRollTextBox";
            this.stunRecoveryRollTextBox.Size = new System.Drawing.Size(57, 20);
            this.stunRecoveryRollTextBox.TabIndex = 7;
            this.stunRecoveryRollTextBox.TextChanged += new System.EventHandler(this.stunRecoveryRollTextBox_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Hubris Circlet",
            "Sorcerer Boots",
            "Sorcerer Gloves",
            "Titanium Spirit Shield",
            "Vaal Regalia"});
            this.comboBox1.Location = new System.Drawing.Point(290, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 52);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(44, 251);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(404, 203);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.minEsResultTextBox);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.maxEsResultTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(396, 177);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Results";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(242, 47);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(67, 13);
            this.textBox3.TabIndex = 13;
            this.textBox3.Text = "Maximum ES";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(81, 92);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(239, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 15;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click_1);
            // 
            // minEsResultTextBox
            // 
            this.minEsResultTextBox.Location = new System.Drawing.Point(81, 66);
            this.minEsResultTextBox.Name = "minEsResultTextBox";
            this.minEsResultTextBox.Size = new System.Drawing.Size(100, 20);
            this.minEsResultTextBox.TabIndex = 11;
            this.minEsResultTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(97, 47);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(67, 13);
            this.textBox4.TabIndex = 14;
            this.textBox4.Text = "Minimum ES";
            // 
            // maxEsResultTextBox
            // 
            this.maxEsResultTextBox.Location = new System.Drawing.Point(220, 66);
            this.maxEsResultTextBox.Name = "maxEsResultTextBox";
            this.maxEsResultTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxEsResultTextBox.TabIndex = 12;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.progressBar3);
            this.tabPage2.Controls.Add(this.minAltEsResultTextBox);
            this.tabPage2.Controls.Add(this.maxAltEsResultTextBox);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.progressBar2);
            this.tabPage2.Controls.Add(this.minEsResultTextBox2);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.maxEsResultTextBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(396, 177);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alternate Values";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(81, 148);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(239, 23);
            this.progressBar3.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar3.TabIndex = 23;
            // 
            // minAltEsResultTextBox
            // 
            this.minAltEsResultTextBox.Location = new System.Drawing.Point(81, 122);
            this.minAltEsResultTextBox.Name = "minAltEsResultTextBox";
            this.minAltEsResultTextBox.Size = new System.Drawing.Size(100, 20);
            this.minAltEsResultTextBox.TabIndex = 21;
            // 
            // maxAltEsResultTextBox
            // 
            this.maxAltEsResultTextBox.Location = new System.Drawing.Point(220, 122);
            this.maxAltEsResultTextBox.Name = "maxAltEsResultTextBox";
            this.maxAltEsResultTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxAltEsResultTextBox.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(242, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 13);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "Maximum ES";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(81, 84);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(239, 23);
            this.progressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar2.TabIndex = 20;
            // 
            // minEsResultTextBox2
            // 
            this.minEsResultTextBox2.Location = new System.Drawing.Point(81, 58);
            this.minEsResultTextBox2.Name = "minEsResultTextBox2";
            this.minEsResultTextBox2.Size = new System.Drawing.Size(100, 20);
            this.minEsResultTextBox2.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(97, 39);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(67, 13);
            this.textBox5.TabIndex = 19;
            this.textBox5.Text = "Minimum ES";
            // 
            // maxEsResultTextBox2
            // 
            this.maxEsResultTextBox2.Location = new System.Drawing.Point(220, 58);
            this.maxEsResultTextBox2.Name = "maxEsResultTextBox2";
            this.maxEsResultTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maxEsResultTextBox2.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(299, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "The Increased tier could be either Tier: # or Tier: #";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 466);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stunRecoveryRollTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.incEsRollTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flatEsRollTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hasStunRecoveryCheckBox);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox hasStunRecoveryCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox flatEsRollTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox incEsRollTextBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stunRecoveryRollTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox minEsResultTextBox;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox maxEsResultTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.TextBox minEsResultTextBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox maxEsResultTextBox2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.TextBox minAltEsResultTextBox;
        private System.Windows.Forms.TextBox maxAltEsResultTextBox;
        private System.Windows.Forms.Label label4;
    }
}

