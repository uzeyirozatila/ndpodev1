using System;
using OyunKutuphanesi.Concrete;
using OyunKutuphanesi.Enum;
using System.Windows.Forms;
//Özeyir Özatila B171200014
namespace KayısıAdamOyunu
{
    public partial class AnaEkran : Form
    {
        private readonly Oyun _oyun = new Oyun();
        public AnaEkran()
        {
            InitializeComponent();
        }
      
        private void AnaEkran_KeyDown(object sender,KeyEventArgs e)
        {
            MessageBox.Show(e.KeyCode.ToString());
           /*     switch(e.KeyCode)
            {
                case Keys.Enter:

                    _oyun.Baslat();
                    break;
                case Keys.Right:
                    _oyun.Haraket(Yon.Sag);
                    break;
                case Keys.Left:
                    _oyun.Haraket(Yon.Sol);
                    break;
                case Keys.Space:
                    _oyun.Firlat();
                    break;
                case Keys.CapsLock:
                    _oyun.Duraklat();
                    break;
            }*/
        }

     
    }
}
