using System.Windows.Forms;

namespace FlappyBird
{
    internal class Coin
    {
        public PictureBox coinPB;
        public bool isCheched;
        public Coin(PictureBox coin, bool isCheched)
        {
            this.coinPB = coin;
            this.isCheched = isCheched;
        }
        public void Check()
        {
            coinPB.Visible = false;
            isCheched = true;
        }
        public void UnCheck()
        {
            coinPB.Visible = true;
            isCheched = false;
        }
    }
}
