namespace WindowsFormsApp2
{
    partial class form_user_login_cs
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_doktor = new System.Windows.Forms.ComboBox();
            this.dtp_randevutarihi = new System.Windows.Forms.DateTimePicker();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_starting_update = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmb_durum = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.cmb_hasta = new System.Windows.Forms.ComboBox();
            this.btn_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(49, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "HASTA AD SOYAD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(49, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "DOKTOR AD SOYAD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(47, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "RANDEVU TARİHİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(47, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "RANDEVU DURUMU";
            // 
            // cmb_doktor
            // 
            this.cmb_doktor.FormattingEnabled = true;
            this.cmb_doktor.Location = new System.Drawing.Point(230, 341);
            this.cmb_doktor.Name = "cmb_doktor";
            this.cmb_doktor.Size = new System.Drawing.Size(156, 24);
            this.cmb_doktor.TabIndex = 5;
            // 
            // dtp_randevutarihi
            // 
            this.dtp_randevutarihi.Location = new System.Drawing.Point(230, 400);
            this.dtp_randevutarihi.Name = "dtp_randevutarihi";
            this.dtp_randevutarihi.Size = new System.Drawing.Size(156, 22);
            this.dtp_randevutarihi.TabIndex = 8;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Ivory;
            this.btn_save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_save.Location = new System.Drawing.Point(493, 240);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(192, 40);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "RANDEVU OLUŞTUR";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(768, 240);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(216, 37);
            this.btn_select.TabIndex = 10;
            this.btn_select.Text = "LİSTELE";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Beige;
            this.btn_delete.Location = new System.Drawing.Point(493, 358);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(192, 40);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "SİL";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_starting_update
            // 
            this.btn_starting_update.Location = new System.Drawing.Point(782, 358);
            this.btn_starting_update.Name = "btn_starting_update";
            this.btn_starting_update.Size = new System.Drawing.Size(202, 40);
            this.btn_starting_update.TabIndex = 12;
            this.btn_starting_update.Text = "GÜNCELLEME BAŞLAT";
            this.btn_starting_update.UseVisualStyleBackColor = true;
            this.btn_starting_update.Click += new System.EventHandler(this.btn_starting_update_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1302, 205);
            this.dataGridView1.TabIndex = 13;
            // 
            // cmb_durum
            // 
            this.cmb_durum.FormattingEnabled = true;
            this.cmb_durum.Location = new System.Drawing.Point(230, 456);
            this.cmb_durum.Name = "cmb_durum";
            this.cmb_durum.Size = new System.Drawing.Size(156, 24);
            this.cmb_durum.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(49, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "HASTA T.C";
            // 
            // txt_tc
            // 
            this.txt_tc.Location = new System.Drawing.Point(230, 288);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(156, 22);
            this.txt_tc.TabIndex = 16;
            // 
            // cmb_hasta
            // 
            this.cmb_hasta.FormattingEnabled = true;
            this.cmb_hasta.Location = new System.Drawing.Point(230, 232);
            this.cmb_hasta.Name = "cmb_hasta";
            this.cmb_hasta.Size = new System.Drawing.Size(155, 24);
            this.cmb_hasta.TabIndex = 17;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(1054, 288);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(196, 47);
            this.btn_update.TabIndex = 18;
            this.btn_update.Text = "GÜNCELLE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // form_user_login_cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1314, 540);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.cmb_hasta);
            this.Controls.Add(this.txt_tc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_durum);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_starting_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dtp_randevutarihi);
            this.Controls.Add(this.cmb_doktor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "form_user_login_cs";
            this.Text = "form_user_login_cs";
            this.Load += new System.EventHandler(this.form_user_login_cs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_doktor;
        private System.Windows.Forms.DateTimePicker dtp_randevutarihi;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_starting_update;
        private System.Windows.Forms.ComboBox cmb_durum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.ComboBox cmb_hasta;
        private System.Windows.Forms.Button btn_update;
        internal System.Windows.Forms.DataGridView dataGridView1;
    }
}