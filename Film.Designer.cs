namespace sinemaprojesiiiiiii
{
    partial class Film
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txttur = new System.Windows.Forms.TextBox();
            this.txtsure = new System.Windows.Forms.TextBox();
            this.txtyonetmen = new System.Windows.Forms.TextBox();
            this.txticerik = new System.Windows.Forms.TextBox();
            this.txtcast = new System.Windows.Forms.TextBox();
            this.txtfragman = new System.Windows.Forms.TextBox();
            this.txtaciklama = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtresim = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbo_sinemaDataSet = new sinemaprojesiiiiiii.dbo_sinemaDataSet();
            this.filmAciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmFragmanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmCastDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmIcerikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmYonetmenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmSureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmTurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblFilmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbo_sinemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFilmBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film ekle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Film Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Film içerik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Film yönetmen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Film süre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(343, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Film tür";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(343, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Film cast";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(341, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Film fragman";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(343, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Film açıklama";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(413, 64);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 20);
            this.txtad.TabIndex = 9;
            // 
            // txttur
            // 
            this.txttur.Location = new System.Drawing.Point(413, 90);
            this.txttur.Name = "txttur";
            this.txttur.Size = new System.Drawing.Size(100, 20);
            this.txttur.TabIndex = 10;
            // 
            // txtsure
            // 
            this.txtsure.Location = new System.Drawing.Point(413, 115);
            this.txtsure.Name = "txtsure";
            this.txtsure.Size = new System.Drawing.Size(100, 20);
            this.txtsure.TabIndex = 11;
            // 
            // txtyonetmen
            // 
            this.txtyonetmen.Location = new System.Drawing.Point(413, 141);
            this.txtyonetmen.Name = "txtyonetmen";
            this.txtyonetmen.Size = new System.Drawing.Size(100, 20);
            this.txtyonetmen.TabIndex = 12;
            // 
            // txticerik
            // 
            this.txticerik.Location = new System.Drawing.Point(413, 167);
            this.txticerik.Name = "txticerik";
            this.txticerik.Size = new System.Drawing.Size(100, 20);
            this.txticerik.TabIndex = 13;
            // 
            // txtcast
            // 
            this.txtcast.Location = new System.Drawing.Point(413, 194);
            this.txtcast.Name = "txtcast";
            this.txtcast.Size = new System.Drawing.Size(100, 20);
            this.txtcast.TabIndex = 14;
            // 
            // txtfragman
            // 
            this.txtfragman.Location = new System.Drawing.Point(413, 218);
            this.txtfragman.Name = "txtfragman";
            this.txtfragman.Size = new System.Drawing.Size(100, 20);
            this.txtfragman.TabIndex = 15;
            // 
            // txtaciklama
            // 
            this.txtaciklama.Location = new System.Drawing.Point(413, 250);
            this.txtaciklama.Name = "txtaciklama";
            this.txtaciklama.Size = new System.Drawing.Size(100, 20);
            this.txtaciklama.TabIndex = 16;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(413, 38);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(343, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Film id";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(341, 282);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Film resim";
            // 
            // txtresim
            // 
            this.txtresim.Location = new System.Drawing.Point(413, 282);
            this.txtresim.Name = "txtresim";
            this.txtresim.Size = new System.Drawing.Size(100, 20);
            this.txtresim.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 34);
            this.button1.TabIndex = 21;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(594, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Kaydet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(693, 279);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(594, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filmIDDataGridViewTextBoxColumn,
            this.filmAdDataGridViewTextBoxColumn,
            this.filmTurDataGridViewTextBoxColumn,
            this.filmSureDataGridViewTextBoxColumn,
            this.filmYonetmenDataGridViewTextBoxColumn,
            this.filmIcerikDataGridViewTextBoxColumn,
            this.filmCastDataGridViewTextBoxColumn,
            this.filmFragmanDataGridViewTextBoxColumn,
            this.filmAciklamaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblFilmBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(104, 324);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(632, 150);
            this.dataGridView1.TabIndex = 25;
            // 
            // dbo_sinemaDataSet
            // 
            this.dbo_sinemaDataSet.DataSetName = "dbo_sinemaDataSet";
            this.dbo_sinemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmAciklamaDataGridViewTextBoxColumn
            // 
            this.filmAciklamaDataGridViewTextBoxColumn.DataPropertyName = "FilmAciklama";
            this.filmAciklamaDataGridViewTextBoxColumn.HeaderText = "FilmAciklama";
            this.filmAciklamaDataGridViewTextBoxColumn.Name = "filmAciklamaDataGridViewTextBoxColumn";
            // 
            // filmFragmanDataGridViewTextBoxColumn
            // 
            this.filmFragmanDataGridViewTextBoxColumn.DataPropertyName = "FilmFragman";
            this.filmFragmanDataGridViewTextBoxColumn.HeaderText = "FilmFragman";
            this.filmFragmanDataGridViewTextBoxColumn.Name = "filmFragmanDataGridViewTextBoxColumn";
            // 
            // filmCastDataGridViewTextBoxColumn
            // 
            this.filmCastDataGridViewTextBoxColumn.DataPropertyName = "FilmCast";
            this.filmCastDataGridViewTextBoxColumn.HeaderText = "FilmCast";
            this.filmCastDataGridViewTextBoxColumn.Name = "filmCastDataGridViewTextBoxColumn";
            // 
            // filmIcerikDataGridViewTextBoxColumn
            // 
            this.filmIcerikDataGridViewTextBoxColumn.DataPropertyName = "FilmIcerik";
            this.filmIcerikDataGridViewTextBoxColumn.HeaderText = "FilmIcerik";
            this.filmIcerikDataGridViewTextBoxColumn.Name = "filmIcerikDataGridViewTextBoxColumn";
            // 
            // filmYonetmenDataGridViewTextBoxColumn
            // 
            this.filmYonetmenDataGridViewTextBoxColumn.DataPropertyName = "FilmYonetmen";
            this.filmYonetmenDataGridViewTextBoxColumn.HeaderText = "FilmYonetmen";
            this.filmYonetmenDataGridViewTextBoxColumn.Name = "filmYonetmenDataGridViewTextBoxColumn";
            // 
            // filmSureDataGridViewTextBoxColumn
            // 
            this.filmSureDataGridViewTextBoxColumn.DataPropertyName = "FilmSure";
            this.filmSureDataGridViewTextBoxColumn.HeaderText = "FilmSure";
            this.filmSureDataGridViewTextBoxColumn.Name = "filmSureDataGridViewTextBoxColumn";
            // 
            // filmTurDataGridViewTextBoxColumn
            // 
            this.filmTurDataGridViewTextBoxColumn.DataPropertyName = "FilmTur";
            this.filmTurDataGridViewTextBoxColumn.HeaderText = "FilmTur";
            this.filmTurDataGridViewTextBoxColumn.Name = "filmTurDataGridViewTextBoxColumn";
            // 
            // filmAdDataGridViewTextBoxColumn
            // 
            this.filmAdDataGridViewTextBoxColumn.DataPropertyName = "FilmAd";
            this.filmAdDataGridViewTextBoxColumn.HeaderText = "FilmAd";
            this.filmAdDataGridViewTextBoxColumn.Name = "filmAdDataGridViewTextBoxColumn";
            // 
            // filmIDDataGridViewTextBoxColumn
            // 
            this.filmIDDataGridViewTextBoxColumn.DataPropertyName = "FilmID";
            this.filmIDDataGridViewTextBoxColumn.HeaderText = "FilmID";
            this.filmIDDataGridViewTextBoxColumn.Name = "filmIDDataGridViewTextBoxColumn";
            this.filmIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblFilmBindingSource
            // 
            this.tblFilmBindingSource.DataMember = "tbl_Film";
            this.tblFilmBindingSource.DataSource = this.dbo_sinemaDataSet;
            // 
            // Film
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 476);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtresim);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtaciklama);
            this.Controls.Add(this.txtfragman);
            this.Controls.Add(this.txtcast);
            this.Controls.Add(this.txticerik);
            this.Controls.Add(this.txtyonetmen);
            this.Controls.Add(this.txtsure);
            this.Controls.Add(this.txttur);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Film";
            this.Text = "Film";
            this.Load += new System.EventHandler(this.Film_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbo_sinemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFilmBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txttur;
        private System.Windows.Forms.TextBox txtsure;
        private System.Windows.Forms.TextBox txtyonetmen;
        private System.Windows.Forms.TextBox txticerik;
        private System.Windows.Forms.TextBox txtcast;
        private System.Windows.Forms.TextBox txtfragman;
        private System.Windows.Forms.TextBox txtaciklama;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtresim;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmTurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmSureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmYonetmenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmIcerikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmCastDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmFragmanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmAciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblFilmBindingSource;
        private dbo_sinemaDataSet dbo_sinemaDataSet;
    }
}