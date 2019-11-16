namespace sinemaprojesiiiiiii
{
    partial class Seans
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.combofilm = new System.Windows.Forms.ComboBox();
            this.comboseans = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.circularButton1 = new sinemaprojesiiiiiii.CircularButton();
            this.txtdateekle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtseansekle = new System.Windows.Forms.TextBox();
            this.buttonseansekle = new sinemaprojesiiiiiii.CircularButton();
            this.combotarih = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(292, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "SESSIONS";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "See Film";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "See Seans";
            // 
            // combofilm
            // 
            this.combofilm.FormattingEnabled = true;
            this.combofilm.Location = new System.Drawing.Point(22, 110);
            this.combofilm.Name = "combofilm";
            this.combofilm.Size = new System.Drawing.Size(167, 21);
            this.combofilm.TabIndex = 6;
            this.combofilm.SelectedIndexChanged += new System.EventHandler(this.combofilm_SelectedIndexChanged);
            // 
            // comboseans
            // 
            this.comboseans.FormattingEnabled = true;
            this.comboseans.Location = new System.Drawing.Point(341, 110);
            this.comboseans.Name = "comboseans";
            this.comboseans.Size = new System.Drawing.Size(121, 21);
            this.comboseans.TabIndex = 7;
            this.comboseans.SelectedIndexChanged += new System.EventHandler(this.comboseans_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(637, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "See Date";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.circularButton1);
            this.groupBox1.Controls.Add(this.txtdateekle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtseansekle);
            this.groupBox1.Controls.Add(this.buttonseansekle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(1, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(796, 198);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // circularButton1
            // 
            this.circularButton1.Location = new System.Drawing.Point(601, 85);
            this.circularButton1.Name = "circularButton1";
            this.circularButton1.Size = new System.Drawing.Size(100, 94);
            this.circularButton1.TabIndex = 17;
            this.circularButton1.Text = "Delete Seance";
            this.circularButton1.UseVisualStyleBackColor = true;
            this.circularButton1.Click += new System.EventHandler(this.circularButton1_Click);
            // 
            // txtdateekle
            // 
            this.txtdateekle.Location = new System.Drawing.Point(263, 38);
            this.txtdateekle.Multiline = true;
            this.txtdateekle.Name = "txtdateekle";
            this.txtdateekle.Size = new System.Drawing.Size(198, 31);
            this.txtdateekle.TabIndex = 16;
            this.txtdateekle.TextChanged += new System.EventHandler(this.txtdateekle_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Seans Time";
            // 
            // txtseansekle
            // 
            this.txtseansekle.Location = new System.Drawing.Point(21, 38);
            this.txtseansekle.Multiline = true;
            this.txtseansekle.Name = "txtseansekle";
            this.txtseansekle.Size = new System.Drawing.Size(198, 31);
            this.txtseansekle.TabIndex = 13;
            // 
            // buttonseansekle
            // 
            this.buttonseansekle.Location = new System.Drawing.Point(185, 85);
            this.buttonseansekle.Name = "buttonseansekle";
            this.buttonseansekle.Size = new System.Drawing.Size(100, 94);
            this.buttonseansekle.TabIndex = 12;
            this.buttonseansekle.Text = "Add Seance";
            this.buttonseansekle.UseVisualStyleBackColor = true;
            this.buttonseansekle.Click += new System.EventHandler(this.buttonseansekle_Click);
            // 
            // combotarih
            // 
            this.combotarih.FormattingEnabled = true;
            this.combotarih.Location = new System.Drawing.Point(619, 110);
            this.combotarih.Name = "combotarih";
            this.combotarih.Size = new System.Drawing.Size(121, 21);
            this.combotarih.TabIndex = 14;
            this.combotarih.SelectedIndexChanged += new System.EventHandler(this.combotarih_SelectedIndexChanged);
            // 
            // Seans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.combotarih);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboseans);
            this.Controls.Add(this.combofilm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Seans";
            this.Text = "Seans";
            this.Load += new System.EventHandler(this.Seans_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combofilm;
        private System.Windows.Forms.ComboBox comboseans;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combotarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtseansekle;
        private CircularButton buttonseansekle;
        private System.Windows.Forms.TextBox txtdateekle;
        private CircularButton circularButton1;
    }
}