namespace WeatherApp
{
    partial class FormWeather
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabelCity = new System.Windows.Forms.LinkLabel();
            this.linkLabelCountry = new System.Windows.Forms.LinkLabel();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBoxWeather = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.linkLabelCity);
            this.panel1.Controls.Add(this.linkLabelCountry);
            this.panel1.Controls.Add(this.comboBoxCity);
            this.panel1.Controls.Add(this.comboBoxCountry);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 100);
            this.panel1.TabIndex = 0;
            // 
            // linkLabelCity
            // 
            this.linkLabelCity.AutoSize = true;
            this.linkLabelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabelCity.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabelCity.Location = new System.Drawing.Point(242, 52);
            this.linkLabelCity.Name = "linkLabelCity";
            this.linkLabelCity.Size = new System.Drawing.Size(38, 20);
            this.linkLabelCity.TabIndex = 3;
            this.linkLabelCity.TabStop = true;
            this.linkLabelCity.Text = "City";
            this.linkLabelCity.Click += new System.EventHandler(this.linkLabelCity_Click);
            // 
            // linkLabelCountry
            // 
            this.linkLabelCountry.AutoSize = true;
            this.linkLabelCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabelCountry.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabelCountry.Location = new System.Drawing.Point(213, 21);
            this.linkLabelCountry.Name = "linkLabelCountry";
            this.linkLabelCountry.Size = new System.Drawing.Size(67, 20);
            this.linkLabelCountry.TabIndex = 2;
            this.linkLabelCountry.TabStop = true;
            this.linkLabelCountry.Text = "Country";
            this.linkLabelCountry.Click += new System.EventHandler(this.linkLabelCountry_Click);
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(292, 48);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(362, 24);
            this.comboBoxCity.TabIndex = 1;
            this.comboBoxCity.SelectedIndexChanged += new System.EventHandler(this.comboBoxCity_SelectedIndexChanged);
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(292, 17);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(362, 24);
            this.comboBoxCountry.TabIndex = 0;
            this.comboBoxCountry.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountry_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.richTextBoxWeather);
            this.panel2.Location = new System.Drawing.Point(13, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(677, 317);
            this.panel2.TabIndex = 1;
            // 
            // richTextBoxWeather
            // 
            this.richTextBoxWeather.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.richTextBoxWeather.Location = new System.Drawing.Point(4, 4);
            this.richTextBoxWeather.Name = "richTextBoxWeather";
            this.richTextBoxWeather.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxWeather.Size = new System.Drawing.Size(670, 310);
            this.richTextBoxWeather.TabIndex = 0;
            this.richTextBoxWeather.Text = "";
            // 
            // FormWeather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(702, 449);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormWeather";
            this.Text = "Weather Service";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabelCity;
        private System.Windows.Forms.LinkLabel linkLabelCountry;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBoxWeather;
    }
}

