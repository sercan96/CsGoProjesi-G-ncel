using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace CsGoProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MashineGun mashineGun = new MashineGun("Seri"); // sadece Mashine silahına özel bir bilgi
        Knife knife = new Knife("Karambit");
        KF1500 kf1500 = new KF1500();
        Pistol pistol = new Pistol("Glock G22");
        RPG rpg = new RPG("Özel");
        ShotGun shotgun = new ShotGun();
        private int a = 0;
        
        
        private void Form1_Load(object sender, EventArgs e)
        {

  
        }
        void MermiBilgisi(Atesli silah)
        {

            lbl_mermiSayisi.Text = silah.mermiSayisi.ToString();

        }

        private void btn_atesEt_Click_1(object sender, EventArgs e)
        {
            #region Switch a
            switch (a)
            {
                case 1:
                    mashineGun.AtesEt();   
                    ProgressBar(20);
                    break;
                case 2:
                    kf1500.AtesEt();                  
                    ProgressBar(100);
                    break;
                case 3:
                    rpg.AtesEt();
                    ProgressBar(50);  
                    break;
                case 4:
                    pistol.AtesEt();
                    ProgressBar(25);
                    break;
                case 5:
                    shotgun.AtesEt();
                    ProgressBar(10);
                    break;

            }
            #endregion 

        }
        void ProgressBar(int value)
        {    
            if(pgb_mermi.Value == 0)      
                MessageBox.Show("Mermi Yok");
            else
                pgb_mermi.Value -= value;
        }
        private void btn_Reload_Click_1(object sender, EventArgs e)
        {
            switch (a)
            {
                case 1:
                    mashineGun.Reload(5);  // Mermi doldurma sayıları
                    ProgressBar(20);
                    break;
                case 2:
                   
                    kf1500.KF_Reload(1);
                    ProgressBar(100);
                    break;
                case 3:
                    rpg.RPG_Reload(2);
                    ProgressBar(50);  
                    break;
                case 4:
                   
                    pistol.P_Reload(4);
                    ProgressBar(25);
                    break;
                case 5:
                   
                    shotgun.S_Reload(10);
                    ProgressBar(10);
                    break;

            }

          
            pgb_mermi.Value = 100;
            //MermiBilgisi();
            //kf1500.KF_Reload(1);
            //rpg.RPG_Reload(2);
            //pistol.P_Reload(4);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        { 
            try
            {
                switch (e.KeyChar.ToString())
                {
                    //try-catch gerekli.
                    case "1":           
                        pb_Csgo.Image = Image.FromFile(@"C:\Users\Toshiba\source\repos\CsGoProjesi\CsGoProjesi\resimler\MachineGun.gif");                
                        grp_atesli.Visible = true;
                        grp_atesli2.Visible = true;
                        grp_kesici.Visible = false;
                        a = 1;

                        break;
                    case "2":
                        pb_Csgo.Image = Image.FromFile(@"C:\Users\Toshiba\source\repos\CsGoProjesi\CsGoProjesi\resimler\KF1500.jpg");
                        grp_atesli.Visible = true;
                        grp_atesli2.Visible = false;
                        grp_kesici.Visible = false;
                        a = 2;
                        break;
                    case "3":
                        pb_Csgo.Image = Image.FromFile(@"C:\Users\Toshiba\source\repos\CsGoProjesi\CsGoProjesi\resimler\RPG.jpg");
                        grp_atesli.Visible = true;
                        grp_atesli2.Visible = false;
                        grp_kesici.Visible = false;
                        a = 3;

                        break;
                    case "4":
                        pb_Csgo.Image = Image.FromFile(@"C:\Users\Toshiba\source\repos\CsGoProjesi\CsGoProjesi\resimler\Pistol.jpg");
                        grp_atesli.Visible = true;
                        grp_atesli2.Visible = false;
                        grp_kesici.Visible = false;
                        a = 4;
                        break;
                    case "5":
                        pb_Csgo.Image = Image.FromFile(@"C:\Users\Toshiba\source\repos\CsGoProjesi\CsGoProjesi\resimler\ShotGun.jpg");
                        grp_atesli.Visible = true;
                        grp_atesli2.Visible = false;
                        grp_kesici.Visible = false;
                        a = 5;
                        break;
                    case "6":
                        pb_Csgo.Image = Image.FromFile(@"C:\Users\Toshiba\source\repos\CsGoProjesi\CsGoProjesi\resimler\Knife.jpg");
                        grp_kesici.Visible = true;
                        grp_atesli.Visible = false;
                        grp_atesli2.Visible = false;
                        grp_Mermi.Visible = false;
                        a = 6;
                        break;

                    default:
                        MessageBox.Show("Lütfen 1 ila 6 arası bir rakam giriniz");
                        break;
                }
            }
            catch (OverflowException oe)
            {
                MessageBox.Show(oe.Message);
            }
        }

        private void btn_yakinlastir_Click_1(object sender, EventArgs e)
        {
            if (mashineGun.durbunluMu == true)
                MessageBox.Show("Durbun Yakınlastırıldı");
            else
                MessageBox.Show("Durbun Uzklaştırıldı");
        }

        private void btn_kes_Click_1(object sender, EventArgs e)
        {
            knife.Ses(@"..\..\..\Sesler\StabKnife.wav");
        }
        private void btn_bileyle_Click_1(object sender, EventArgs e)
        {
            knife.Ses(@"..\..\..\Sesler\SharpenKnife.wav");
        }




        private void btn_bilgiler_Click(object sender, EventArgs e)
        {
            MessageBox.Show(mashineGun.silahIsmi + "\n" + mashineGun.rengi + "\n" + mashineGun.mermiTipi + "\n" + mashineGun.AteslemeTuru + "\n" + mashineGun.durbunluMu);
            MessageBox.Show(kf1500.silahIsmi + "\n" + kf1500.rengi + "\n" + kf1500.mermiTipi + "\n" + kf1500.durbunluMu);
        }

        private void btn_uzaklastir_Click(object sender, EventArgs e)
        {

        }


    }
}

