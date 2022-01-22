namespace WindowsFormsApp4
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnPokreni = new System.Windows.Forms.Button();
            this.txtImeFirme = new System.Windows.Forms.TextBox();
            this.txtVrijednost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDetaljno = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(28, 24);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(521, 285);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // btnPokreni
            // 
            this.btnPokreni.Location = new System.Drawing.Point(507, 338);
            this.btnPokreni.Name = "btnPokreni";
            this.btnPokreni.Size = new System.Drawing.Size(129, 65);
            this.btnPokreni.TabIndex = 1;
            this.btnPokreni.Text = "Ubaci dionicu u sustav";
            this.btnPokreni.UseVisualStyleBackColor = true;
            this.btnPokreni.Click += new System.EventHandler(this.btnPokreni_Click);
            // 
            // txtImeFirme
            // 
            this.txtImeFirme.Location = new System.Drawing.Point(104, 380);
            this.txtImeFirme.Name = "txtImeFirme";
            this.txtImeFirme.Size = new System.Drawing.Size(151, 22);
            this.txtImeFirme.TabIndex = 2;
            this.txtImeFirme.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtVrijednost
            // 
            this.txtVrijednost.Location = new System.Drawing.Point(291, 380);
            this.txtVrijednost.Name = "txtVrijednost";
            this.txtVrijednost.Size = new System.Drawing.Size(151, 22);
            this.txtVrijednost.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Unesite ime tvrtke:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Unesite vrijednost dionice:";
            // 
            // btnDetaljno
            // 
            this.btnDetaljno.Location = new System.Drawing.Point(598, 54);
            this.btnDetaljno.Name = "btnDetaljno";
            this.btnDetaljno.Size = new System.Drawing.Size(174, 75);
            this.btnDetaljno.TabIndex = 6;
            this.btnDetaljno.Text = "Detaljniji prikaz dionica";
            this.btnDetaljno.UseVisualStyleBackColor = true;
            this.btnDetaljno.Click += new System.EventHandler(this.btnDetaljno_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(634, 172);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(112, 65);
            this.btnRandom.TabIndex = 7;
            this.btnRandom.Text = "Random vrijednosti";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnDetaljno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVrijednost);
            this.Controls.Add(this.txtImeFirme);
            this.Controls.Add(this.btnPokreni);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnPokreni;
        private System.Windows.Forms.TextBox txtImeFirme;
        private System.Windows.Forms.TextBox txtVrijednost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDetaljno;
        private System.Windows.Forms.Button btnRandom;
    }
}

