using OyunKutuphanesi.Enum;
using OyunKutuphanesi.Interface;
using System.Windows.Forms;

namespace OyunKutuphanesi.Concrete
{
       public class Oyun : IOyun
    {
        public bool Acikmi { get; private set; }

        public void Baslat()
        {
            if (Acikmi)
            {
                MessageBox.Show("ibo");
                return;
            }
         //   MessageBox.Show("oyun başladı");
         //       Acikmi = true;                            
        }
        private void Bitir()
        {
            if (!Acikmi) return;
            Acikmi = false;
        }

        public void Duraklat()
        {
            throw new System.NotImplementedException();
        }

        public void Firlat()
        {
            throw new System.NotImplementedException();
        }

        public void Haraket(Yon yon)
        {
            throw new System.NotImplementedException();
        }
    }
}
