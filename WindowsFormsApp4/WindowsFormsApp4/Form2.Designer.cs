namespace WindowsFormsApp4
{
    partial class Form2
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
            this.rbMerge = new System.Windows.Forms.RadioButton();
            this.rbBubble = new System.Windows.Forms.RadioButton();
            this.rbSelect = new System.Windows.Forms.RadioButton();
            this.rbHeap = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.labelVrijeme = new System.Windows.Forms.Label();
            this.btnUzlazno = new System.Windows.Forms.Button();
            this.btnPronadi = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtUnos = new System.Windows.Forms.TextBox();
            this.rtbTekst = new System.Windows.Forms.RichTextBox();
            this.rbInsertion = new System.Windows.Forms.RadioButton();
            this.btnPronadiIme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbMerge
            // 
            this.rbMerge.AutoSize = true;
            this.rbMerge.Location = new System.Drawing.Point(663, 123);
            this.rbMerge.Name = "rbMerge";
            this.rbMerge.Size = new System.Drawing.Size(97, 21);
            this.rbMerge.TabIndex = 0;
            this.rbMerge.TabStop = true;
            this.rbMerge.Text = "Merge sort";
            this.rbMerge.UseVisualStyleBackColor = true;
            // 
            // rbBubble
            // 
            this.rbBubble.AutoSize = true;
            this.rbBubble.Location = new System.Drawing.Point(663, 67);
            this.rbBubble.Name = "rbBubble";
            this.rbBubble.Size = new System.Drawing.Size(101, 21);
            this.rbBubble.TabIndex = 1;
            this.rbBubble.TabStop = true;
            this.rbBubble.Text = "Bubble sort";
            this.rbBubble.UseVisualStyleBackColor = true;
            // 
            // rbSelect
            // 
            this.rbSelect.AutoSize = true;
            this.rbSelect.Location = new System.Drawing.Point(663, 177);
            this.rbSelect.Name = "rbSelect";
            this.rbSelect.Size = new System.Drawing.Size(115, 21);
            this.rbSelect.TabIndex = 2;
            this.rbSelect.TabStop = true;
            this.rbSelect.Text = "Selection sort";
            this.rbSelect.UseVisualStyleBackColor = true;
            // 
            // rbHeap
            // 
            this.rbHeap.AutoSize = true;
            this.rbHeap.Location = new System.Drawing.Point(663, 150);
            this.rbHeap.Name = "rbHeap";
            this.rbHeap.Size = new System.Drawing.Size(91, 21);
            this.rbHeap.TabIndex = 3;
            this.rbHeap.TabStop = true;
            this.rbHeap.Text = "Heap sort";
            this.rbHeap.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(666, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vrijeme sortiranja:";
            // 
            // labelVrijeme
            // 
            this.labelVrijeme.AutoSize = true;
            this.labelVrijeme.Location = new System.Drawing.Point(666, 380);
            this.labelVrijeme.Name = "labelVrijeme";
            this.labelVrijeme.Size = new System.Drawing.Size(16, 17);
            this.labelVrijeme.TabIndex = 5;
            this.labelVrijeme.Text = "0";
            this.labelVrijeme.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnUzlazno
            // 
            this.btnUzlazno.Location = new System.Drawing.Point(663, 223);
            this.btnUzlazno.Name = "btnUzlazno";
            this.btnUzlazno.Size = new System.Drawing.Size(119, 62);
            this.btnUzlazno.TabIndex = 6;
            this.btnUzlazno.Text = "Sortiraj";
            this.btnUzlazno.UseVisualStyleBackColor = true;
            this.btnUzlazno.Click += new System.EventHandler(this.btnUzlazno_Click);
            // 
            // btnPronadi
            // 
            this.btnPronadi.Location = new System.Drawing.Point(39, 351);
            this.btnPronadi.Name = "btnPronadi";
            this.btnPronadi.Size = new System.Drawing.Size(182, 40);
            this.btnPronadi.TabIndex = 7;
            this.btnPronadi.Text = "Pronađi uzorak u tekstu";
            this.btnPronadi.UseVisualStyleBackColor = true;
            this.btnPronadi.Click += new System.EventHandler(this.btnPronadi_Click);
            // 
            // txtUnos
            // 
            this.txtUnos.Location = new System.Drawing.Point(120, 318);
            this.txtUnos.Name = "txtUnos";
            this.txtUnos.Size = new System.Drawing.Size(396, 22);
            this.txtUnos.TabIndex = 8;
            // 
            // rtbTekst
            // 
            this.rtbTekst.Location = new System.Drawing.Point(84, 22);
            this.rtbTekst.Name = "rtbTekst";
            this.rtbTekst.Size = new System.Drawing.Size(447, 263);
            this.rtbTekst.TabIndex = 9;
            this.rtbTekst.Text = "";
            // 
            // rbInsertion
            // 
            this.rbInsertion.AutoSize = true;
            this.rbInsertion.Location = new System.Drawing.Point(663, 96);
            this.rbInsertion.Name = "rbInsertion";
            this.rbInsertion.Size = new System.Drawing.Size(113, 21);
            this.rbInsertion.TabIndex = 10;
            this.rbInsertion.TabStop = true;
            this.rbInsertion.Text = "Insertion Sort";
            this.rbInsertion.UseVisualStyleBackColor = true;
            // 
            // btnPronadiIme
            // 
            this.btnPronadiIme.Location = new System.Drawing.Point(252, 351);
            this.btnPronadiIme.Name = "btnPronadiIme";
            this.btnPronadiIme.Size = new System.Drawing.Size(187, 40);
            this.btnPronadiIme.TabIndex = 11;
            this.btnPronadiIme.Text = "Pronađi index uzorka";
            this.btnPronadiIme.UseVisualStyleBackColor = true;
            this.btnPronadiIme.Click += new System.EventHandler(this.btnPronadiIme_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPronadiIme);
            this.Controls.Add(this.rbInsertion);
            this.Controls.Add(this.rtbTekst);
            this.Controls.Add(this.txtUnos);
            this.Controls.Add(this.btnPronadi);
            this.Controls.Add(this.btnUzlazno);
            this.Controls.Add(this.labelVrijeme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbHeap);
            this.Controls.Add(this.rbSelect);
            this.Controls.Add(this.rbBubble);
            this.Controls.Add(this.rbMerge);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbMerge;
        private System.Windows.Forms.RadioButton rbBubble;
        private System.Windows.Forms.RadioButton rbSelect;
        private System.Windows.Forms.RadioButton rbHeap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelVrijeme;
        private System.Windows.Forms.Button btnUzlazno;
        private System.Windows.Forms.Button btnPronadi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtUnos;
        private System.Windows.Forms.RadioButton rbInsertion;
        public System.Windows.Forms.RichTextBox rtbTekst;
        private System.Windows.Forms.Button btnPronadiIme;
    }
}