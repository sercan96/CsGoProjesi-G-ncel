
namespace CsGoProjesi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pb_Csgo = new System.Windows.Forms.PictureBox();
            this.pgb_mermi = new System.Windows.Forms.ProgressBar();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_mermiSayisi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_mermiKolonu = new System.Windows.Forms.PictureBox();
            this.grp_Mermi = new System.Windows.Forms.GroupBox();
            this.btn_bilgiler = new System.Windows.Forms.Button();
            this.btn_atesEt = new System.Windows.Forms.Button();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.grp_atesli = new System.Windows.Forms.GroupBox();
            this.grp_atesli2 = new System.Windows.Forms.GroupBox();
            this.btn_yakinlastir = new System.Windows.Forms.Button();
            this.btn_uzaklastir = new System.Windows.Forms.Button();
            this.grp_kesici = new System.Windows.Forms.GroupBox();
            this.btn_kes = new System.Windows.Forms.Button();
            this.btn_bileyle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Csgo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_mermiKolonu)).BeginInit();
            this.grp_Mermi.SuspendLayout();
            this.grp_atesli.SuspendLayout();
            this.grp_atesli2.SuspendLayout();
            this.grp_kesici.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_Csgo
            // 
            this.pb_Csgo.Location = new System.Drawing.Point(12, 21);
            this.pb_Csgo.Name = "pb_Csgo";
            this.pb_Csgo.Size = new System.Drawing.Size(706, 295);
            this.pb_Csgo.TabIndex = 0;
            this.pb_Csgo.TabStop = false;
            // 
            // pgb_mermi
            // 
            this.pgb_mermi.Location = new System.Drawing.Point(99, 41);
            this.pgb_mermi.MarqueeAnimationSpeed = 5;
            this.pgb_mermi.Name = "pgb_mermi";
            this.pgb_mermi.Size = new System.Drawing.Size(125, 29);
            this.pgb_mermi.Step = 20;
            this.pgb_mermi.TabIndex = 6;
            this.pgb_mermi.Value = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mermi Sayisi :";
            // 
            // lbl_mermiSayisi
            // 
            this.lbl_mermiSayisi.AutoSize = true;
            this.lbl_mermiSayisi.Location = new System.Drawing.Point(205, 73);
            this.lbl_mermiSayisi.Name = "lbl_mermiSayisi";
            this.lbl_mermiSayisi.Size = new System.Drawing.Size(0, 20);
            this.lbl_mermiSayisi.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Atesliler";
            // 
            // pb_mermiKolonu
            // 
            this.pb_mermiKolonu.Image = ((System.Drawing.Image)(resources.GetObject("pb_mermiKolonu.Image")));
            this.pb_mermiKolonu.Location = new System.Drawing.Point(6, 41);
            this.pb_mermiKolonu.Name = "pb_mermiKolonu";
            this.pb_mermiKolonu.Size = new System.Drawing.Size(74, 39);
            this.pb_mermiKolonu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_mermiKolonu.TabIndex = 15;
            this.pb_mermiKolonu.TabStop = false;
            // 
            // grp_Mermi
            // 
            this.grp_Mermi.Controls.Add(this.pb_mermiKolonu);
            this.grp_Mermi.Controls.Add(this.pgb_mermi);
            this.grp_Mermi.Controls.Add(this.label2);
            this.grp_Mermi.Controls.Add(this.lbl_mermiSayisi);
            this.grp_Mermi.Location = new System.Drawing.Point(468, 348);
            this.grp_Mermi.Name = "grp_Mermi";
            this.grp_Mermi.Size = new System.Drawing.Size(250, 125);
            this.grp_Mermi.TabIndex = 16;
            this.grp_Mermi.TabStop = false;
            this.grp_Mermi.Text = "MermiKolonu";
            // 
            // btn_bilgiler
            // 
            this.btn_bilgiler.Location = new System.Drawing.Point(474, 456);
            this.btn_bilgiler.Name = "btn_bilgiler";
            this.btn_bilgiler.Size = new System.Drawing.Size(94, 29);
            this.btn_bilgiler.TabIndex = 17;
            this.btn_bilgiler.Text = "button1";
            this.btn_bilgiler.UseVisualStyleBackColor = true;
            this.btn_bilgiler.Visible = false;
            this.btn_bilgiler.Click += new System.EventHandler(this.btn_bilgiler_Click);
            // 
            // btn_atesEt
            // 
            this.btn_atesEt.Location = new System.Drawing.Point(12, 26);
            this.btn_atesEt.Name = "btn_atesEt";
            this.btn_atesEt.Size = new System.Drawing.Size(94, 29);
            this.btn_atesEt.TabIndex = 18;
            this.btn_atesEt.Text = "Ates Et";
            this.btn_atesEt.UseVisualStyleBackColor = true;
            this.btn_atesEt.Click += new System.EventHandler(this.btn_atesEt_Click_1);
            // 
            // btn_Reload
            // 
            this.btn_Reload.Location = new System.Drawing.Point(12, 80);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(94, 29);
            this.btn_Reload.TabIndex = 19;
            this.btn_Reload.Text = "Reload";
            this.btn_Reload.UseVisualStyleBackColor = true;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click_1);
            // 
            // grp_atesli
            // 
            this.grp_atesli.Controls.Add(this.btn_atesEt);
            this.grp_atesli.Controls.Add(this.btn_Reload);
            this.grp_atesli.Location = new System.Drawing.Point(35, 348);
            this.grp_atesli.Name = "grp_atesli";
            this.grp_atesli.Size = new System.Drawing.Size(121, 125);
            this.grp_atesli.TabIndex = 22;
            this.grp_atesli.TabStop = false;
            this.grp_atesli.Text = "atesli";
            this.grp_atesli.Visible = false;
            // 
            // grp_atesli2
            // 
            this.grp_atesli2.Controls.Add(this.btn_yakinlastir);
            this.grp_atesli2.Controls.Add(this.btn_uzaklastir);
            this.grp_atesli2.Location = new System.Drawing.Point(162, 348);
            this.grp_atesli2.Name = "grp_atesli2";
            this.grp_atesli2.Size = new System.Drawing.Size(126, 125);
            this.grp_atesli2.TabIndex = 23;
            this.grp_atesli2.TabStop = false;
            this.grp_atesli2.Text = "atesli2";
            this.grp_atesli2.Visible = false;
            // 
            // btn_yakinlastir
            // 
            this.btn_yakinlastir.Location = new System.Drawing.Point(24, 26);
            this.btn_yakinlastir.Name = "btn_yakinlastir";
            this.btn_yakinlastir.Size = new System.Drawing.Size(94, 29);
            this.btn_yakinlastir.TabIndex = 22;
            this.btn_yakinlastir.Text = "Yakınlaştır";
            this.btn_yakinlastir.UseVisualStyleBackColor = true;
            this.btn_yakinlastir.Click += new System.EventHandler(this.btn_yakinlastir_Click_1);
            // 
            // btn_uzaklastir
            // 
            this.btn_uzaklastir.Location = new System.Drawing.Point(24, 80);
            this.btn_uzaklastir.Name = "btn_uzaklastir";
            this.btn_uzaklastir.Size = new System.Drawing.Size(94, 29);
            this.btn_uzaklastir.TabIndex = 21;
            this.btn_uzaklastir.Text = "Uzaklaştır";
            this.btn_uzaklastir.UseVisualStyleBackColor = true;
            this.btn_uzaklastir.Click += new System.EventHandler(this.btn_uzaklastir_Click);
            // 
            // grp_kesici
            // 
            this.grp_kesici.Controls.Add(this.btn_kes);
            this.grp_kesici.Controls.Add(this.btn_bileyle);
            this.grp_kesici.Location = new System.Drawing.Point(305, 348);
            this.grp_kesici.Name = "grp_kesici";
            this.grp_kesici.Size = new System.Drawing.Size(126, 125);
            this.grp_kesici.TabIndex = 24;
            this.grp_kesici.TabStop = false;
            this.grp_kesici.Text = "kesici";
            this.grp_kesici.Visible = false;
            // 
            // btn_kes
            // 
            this.btn_kes.Location = new System.Drawing.Point(15, 26);
            this.btn_kes.Name = "btn_kes";
            this.btn_kes.Size = new System.Drawing.Size(94, 29);
            this.btn_kes.TabIndex = 20;
            this.btn_kes.Text = "Kes";
            this.btn_kes.UseVisualStyleBackColor = true;
            this.btn_kes.Click += new System.EventHandler(this.btn_kes_Click_1);
            // 
            // btn_bileyle
            // 
            this.btn_bileyle.Location = new System.Drawing.Point(15, 80);
            this.btn_bileyle.Name = "btn_bileyle";
            this.btn_bileyle.Size = new System.Drawing.Size(94, 29);
            this.btn_bileyle.TabIndex = 21;
            this.btn_bileyle.Text = "Bileyle";
            this.btn_bileyle.UseVisualStyleBackColor = true;
            this.btn_bileyle.Click += new System.EventHandler(this.btn_bileyle_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 497);
            this.Controls.Add(this.grp_kesici);
            this.Controls.Add(this.grp_atesli2);
            this.Controls.Add(this.grp_atesli);
            this.Controls.Add(this.btn_bilgiler);
            this.Controls.Add(this.grp_Mermi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_Csgo);
            this.Name = "Form1";
            this.Text = "1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Csgo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_mermiKolonu)).EndInit();
            this.grp_Mermi.ResumeLayout(false);
            this.grp_Mermi.PerformLayout();
            this.grp_atesli.ResumeLayout(false);
            this.grp_atesli2.ResumeLayout(false);
            this.grp_kesici.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Csgo;
        private System.Windows.Forms.ProgressBar pgb_mermi;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_mermiSayisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_mermiKolonu;
        private System.Windows.Forms.GroupBox grp_Mermi;
        private System.Windows.Forms.Button btn_bilgiler;
        private System.Windows.Forms.Button btn_atesEt;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.GroupBox grp_atesli;
        private System.Windows.Forms.GroupBox grp_atesli2;
        private System.Windows.Forms.Button btn_uzaklastir;
        private System.Windows.Forms.GroupBox grp_kesici;
        private System.Windows.Forms.Button btn_kes;
        private System.Windows.Forms.Button btn_bileyle;
        private System.Windows.Forms.Button btn_yakinlastir;
    }
}

