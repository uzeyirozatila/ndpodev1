using OyunKutuphanesi.Enum;
//Özeyir Özatila B171200014
namespace OyunKutuphanesi.Interface
{
    internal interface IOyun
    {
        bool Acikmi { get; }
        void Baslat();
        void Duraklat();
        void Firlat();
        void Haraket(Yon yon);
    }
}
