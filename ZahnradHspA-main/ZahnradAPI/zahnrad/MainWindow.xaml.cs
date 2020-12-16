using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace zahnrad
{
    /// <summary>
    
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        

        private void Bt_calculate_Click(object sender, RoutedEventArgs e)
        {
            Double aModul, bZaehne, cTeilkr, dBreite, eKopf, hPar, fFußhoehe, gKpfhoehe, iTeil, jFußkr, kGrndkr, nKpfkr;
             
            try
            {    // Eingabe von Werten a - d in TextBoxen
                aModul = Convert.ToDouble(tb_aModul.Text.ToString());                          
                bZaehne = Convert.ToDouble(tb_bZaehne.Text.ToString());
                cTeilkr = Convert.ToDouble(tb_cTeilkr.Text.ToString());
                dBreite = Convert.ToDouble(tb_dBreite.Text.ToString());
            }
            catch
            {   // Konsole ploppt auf falls Buchstaben oder negative Werte eingegeben werden.
                MessageBox.Show("Bitte geben Sie nur positive und reale Werte ein");       
                return;
            }
                // Bedingungen an die Eingabewerte
            if (aModul < 0 || bZaehne < 5 || bZaehne > 100 || cTeilkr < 0 || cTeilkr != aModul * bZaehne || dBreite < 0)
            {
                MessageBox.Show("Bitte geben Sie nur positive und reale Werte ein");
                return;
            }
            
            

            

            if(radio_Geradzahnrad.IsChecked == true)

            {
                // Defienierung der Ausgabewerte
                eKopf = 0.167 * aModul;                                                                          
                hPar = 2 * aModul + eKopf;                                                     
                fFußhoehe = aModul + eKopf;                                                         
                gKpfhoehe = aModul;                                                             
                tb_eKopf.Text = eKopf.ToString();
                tb_fFußhoehe.Text = fFußhoehe.ToString();
                tb_gKpfhoehe.Text = gKpfhoehe.ToString();

                iTeil = Math.PI * aModul;
                tb_iTeil.Text = iTeil.ToString();
                jFußkr = cTeilkr - 2 * (aModul + eKopf);                                               
                nKpfkr = aModul * (bZaehne + 2);
                tb_jFußkr.Text = jFußkr.ToString();
                tb_nKpfkr.Text = nKpfkr.ToString();

                kGrndkr = aModul * bZaehne * Math.Cos(20 * Math.PI / 180);
                tb_kGrndkr.Text = kGrndkr.ToString();
            }
            else if(radio_Innenzahnrad.IsChecked == true)
            {
                aModul = Convert.ToDouble(tb_aModul.Text.ToString());
                bZaehne = Convert.ToDouble(tb_bZaehne.Text.ToString());
                cTeilkr = Convert.ToDouble(tb_cTeilkr.Text.ToString());
                dBreite = Convert.ToDouble(tb_dBreite.Text.ToString());


                eKopf = 0.167 * aModul;                                                                        
                hPar = 2 * aModul + eKopf;                                                     
                fFußhoehe = aModul + eKopf;                                                         
                gKpfhoehe = aModul;                                                              
                tb_eKopf.Text = eKopf.ToString();                                
                tb_fFußhoehe.Text = fFußhoehe.ToString();
                tb_gKpfhoehe.Text = gKpfhoehe.ToString();

                iTeil = Math.PI * aModul;
                tb_iTeil.Text = iTeil.ToString();
                jFußkr = cTeilkr + 2 * (aModul + eKopf);                                               
                nKpfkr = aModul *(bZaehne - 2);
                tb_jFußkr.Text = jFußkr.ToString();
                tb_nKpfkr.Text = nKpfkr.ToString();

                kGrndkr = aModul * bZaehne * Math.Cos(20 * Math.PI / 180);
              
                tb_kGrndkr.Text = kGrndkr.ToString();
            }
            

        }

        private void Radio_Geradzahnrad_Checked(object sender, RoutedEventArgs e)   
        {   // JPEG Stirnzahnrad
            Uri uri = new Uri(@"geradzahnrad.jpg", UriKind.Relative);
            image_kind.Source = new BitmapImage(uri);
        }

        private void Radio_Innenzahnrad_Checked(object sender, RoutedEventArgs e)
        {   // JPEG Innenzanhrad
            Uri uri = new Uri(@"innenzahnrad.jpg", UriKind.Relative);               
            image_kind.Source = new BitmapImage(uri);
 
        }


        private void Button_Click(object sender, RoutedEventArgs e)                 
        {   // Ende btn
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // Übertragung der Parameter an Catia
        }
        //Catia Part erstellen

        private void Button_Click_2(object sender, RoutedEventArgs e)

        {

            CatiaControl();

        }



        // // // // // // // // // // // // // // // //



        //CatiaControl





        public void CatiaControl()

        {

            try

            {



                CatiaConnection cc = new CatiaConnection();



                // Finde Catia Prozess

                if (cc.CATIALaeuft())

                {

                    //Console.WriteLine("0");



                    // Öffne ein neues Part

                    cc.ErzeugePart();

                    //Console.WriteLine("1");



                    //cc.Mittelpunktbestimmmung(av)



                    // Erstelle eine Skizze

                    //cc.ErstelleLeereSkizze();

                    //Console.WriteLine("2");



                    // Generiere ein Profil

                    //cc.ErzeugeProfil(20, 10);

                    //Console.WriteLine("3");



                    // Extrudiere Balken

                    //cc.ErzeugeBalken(300);

                    //Console.WriteLine("4");



                    cc.Geradzahnrad(Zahnrad);



                    cc.Geradzahnraddicke(Zahnrad);

                }

                else

                {

                    Console.WriteLine("Laufende Catia Application nicht gefunden");

                }

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message, "Exception aufgetreten");

            }

            Console.WriteLine("Fertig - Taste drücken.");



        }



        private void CB_Kopfspiel_Checked(object sender, RoutedEventArgs e)

        {

            TB_0167.IsEnabled = true;

            TB_0167.Clear();

        }



        private void CB_Kopfspiel_Unchecked(object sender, RoutedEventArgs e)

        {

            TB_0167.IsEnabled = false;

            TB_0167.Text = "0,167";

        }



        private void rtb_Gerad_Click(object sender, RoutedEventArgs e)

        {

            tb_Winkel.IsEnabled = false;

            sliderbeta.IsEnabled = false;

            lb_Winkeltext.IsEnabled = false;

        }



        private void rtb_Schräg_Click(object sender, RoutedEventArgs e)

        {

            tb_Winkel.IsEnabled = true;

            sliderbeta.IsEnabled = true;

            lb_Winkeltext.IsEnabled = true;

        }



        private void rtb_Innenzahnrad_Click(object sender, RoutedEventArgs e)

        {

            tb_Winkel.IsEnabled = false;

            sliderbeta.IsEnabled = false;

            lb_Winkeltext.IsEnabled = false;

        }

    }





}


































