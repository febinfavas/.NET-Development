using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Casino
{
    public partial class Default : System.Web.UI.Page
    {
        string[] images = new string[3] { "dhoni", "kohli", "sanju" };

        Random random = new Random();

        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void Button1_Click(object sender, EventArgs e) {

            int bid = 0;
            
            if (!int.TryParse(TextBox1.Text, out bid))
            {
                LabelResult.Text = "Only Integers Allowed";
                return;
            }

            LabelResult.Text = "";
            LabelPrice.Text = "";

            PullLeverAndPlay(bid);
        }

        public void PullLeverAndPlay(int bid) {
            int imgSlot1 = random.Next(0, 3);
            int imgSlot2 = random.Next(0, 3);
            int imgSlot3 = random.Next(0, 3);

            int winMul = 0;
            int result = 0;

            Image1.ImageUrl = "/images/" + images[imgSlot1] + ".jpg";
            Image2.ImageUrl = "/images/" + images[imgSlot2] + ".jpg";
            Image3.ImageUrl = "/images/" + images[imgSlot3] + ".jpg";

            winMul = Winning(imgSlot1, imgSlot2, imgSlot3);

            result = winMul * bid;
            LabelPrice.Text = "Your Bet is "+ bid.ToString("C")+ "and you Won " + result.ToString("C");
        }

        public int Winning(int s1,int s2,int s3) {
            int win = 0;
            if (s1 == 1 && s2 == 1 && s3 == 1)
            {
                LabelResult.Text = "Three Kohli's Picture";
                win = 4;
            }
            else if ((s1 == 1 && s2 != 1 && s3 != 1) ||
                (s1 != 1 && s2 == 1 && s3 != 1) ||
                (s1 != 1 && s2 != 1 && s3 == 1))
            {
                LabelResult.Text = "Only One Kohli's Picture";
                win = 2;
            }
            else if ((s1 == 1 && s2 == 1) ||
                     (s1 == 1 && s3 == 1) ||
                     (s2 == 1 && s3 == 1))
            {
                LabelResult.Text = "Two Kohli's Picture";
                win = 3;
            }
            else if (s1 == 0 && s2 == 0 && s3 == 0)
            {
                LabelResult.Text = "Three Dhoni's Picture!!! JACKPOT!!!";
                win = 100;
            }
            else
            {
                LabelResult.Text = "Sorry!! You Lost!!!";
                win = 0;
            }
            return win;
        }

    }
}