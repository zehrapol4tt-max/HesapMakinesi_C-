namespace HesapMakinesi_switchCase_combo_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            string ilk_sayi = txt_ilk.Text;
            string ikinci_sayi = txt_iki.Text;

            int sayi1, sayi2;

            if (!int.TryParse(ilk_sayi, out sayi1) || !int.TryParse(ikinci_sayi, out sayi2))
            {
                lblGecersiz.Text = "girilen sayi geçersizdir.";
                return;
            }

            switch (cmbİslem.Text)
            {
                case "+":
                    int toplama = sayi1 + sayi2;
                    lblSonuc.Text = toplama.ToString();
                    break;
                case "-":
                    int cikarma = sayi1 - sayi2;
                    lblSonuc.Text = cikarma.ToString();
                    break;
                case "*":
                    int carpma = sayi1 * sayi2;
                    lblSonuc.Text = carpma.ToString();
                    break;
                case "/":
                   
                    if (sayi2 == 0)
                    {
                        lblGecersiz.Text = "Payda 0 olmamalıdır.";
                    }
                    else
                    { 
                        double bolme = (double)sayi1 / (double)sayi2;
                        lblSonuc.Text = bolme.ToString();
                    }
                    break;
            }
        }
    }

}
