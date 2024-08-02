namespace Memory_Matching_Game
{
    public partial class Form1 : Form
    {
        //Dictionary to store the images

        Dictionary<string, Image> CardImages = new Dictionary<string, Image>();

        //List to store the picture boxes

        List<PictureBox> CardsPictureBoxe = new List<PictureBox>();
        List<PictureBox> LifePictureBoxe = new List<PictureBox>();

        int previousIndexOpen;
        bool hasOpenCard = false;



        public Form1()
        {
            InitializeComponent();
            LoadImages();

            //we can call Randomize() method to randomize the images
            Randomize();
            Randomize();
            Randomize();

            CardsPictureBoxe.Add(pb1);
            CardsPictureBoxe.Add(pb2);
            CardsPictureBoxe.Add(pb3);
            CardsPictureBoxe.Add(pb4);
            CardsPictureBoxe.Add(pb5);
            CardsPictureBoxe.Add(pb6);
            CardsPictureBoxe.Add(pb7);
            CardsPictureBoxe.Add(pb8);
            CardsPictureBoxe.Add(pb9);
            CardsPictureBoxe.Add(pb10);
            CardsPictureBoxe.Add(pb11);
            CardsPictureBoxe.Add(pb12);

            LifePictureBoxe.Add(pbHeart6);
            LifePictureBoxe.Add(pbHeart5);
            LifePictureBoxe.Add(pbHeart4);
            LifePictureBoxe.Add(pbHeart3);
            LifePictureBoxe.Add(pbHeart2);
            LifePictureBoxe.Add(pbHeart1);






        }

        //Load the images into the dictionary

        private void LoadImages()
        {
            //in this game, we have 7 images, we will load 2 of each image
            CardImages.Add("im1", Properties.Resources.im1);
            CardImages.Add("im2", Properties.Resources.im2);
            CardImages.Add("im3", Properties.Resources.im3);
            CardImages.Add("im4", Properties.Resources.im4);
            CardImages.Add("im5", Properties.Resources.im5);
            CardImages.Add("im6", Properties.Resources.im6);

            //sinc we are creating memory game ti insert tawince of each image, but we need to change their ID

            CardImages.Add("im1_DUP", Properties.Resources.im1);
            CardImages.Add("im2_DUP", Properties.Resources.im2);
            CardImages.Add("im3_DUP", Properties.Resources.im3);
            CardImages.Add("im4_DUP", Properties.Resources.im4);
            CardImages.Add("im5_DUP", Properties.Resources.im5);
            CardImages.Add("im6_DUP", Properties.Resources.im6);


        }

        //Randomize the images

        private void Randomize()
        {
            //Let's random the images in that we wull use

            Dictionary<string, Image> imgTmp = new Dictionary<string, Image>();

            while (CardImages.Count > 0)
            {

                //select a random image
                Random rnd = new Random();
                int index = rnd.Next(0, CardImages.Count - 1);
                string key = CardImages.ElementAt(index).Key;
                imgTmp.Add(key, CardImages.ElementAt(index).Value);
                CardImages.Remove(key);

                //just add sleep of 20ms every loop
                System.Threading.Thread.Sleep(20);
            }

            foreach (var item in imgTmp)
            {
                CardImages.Add(item.Key, item.Value);

            }


        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Add code to handle the click event on pictureBox1
            MessageBox.Show("PictureBox1 clicked!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Add code to handle the click event on button1
            MessageBox.Show("Restart button clicked!");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Add code to handle the click event on label1
            MessageBox.Show("Label1 clicked!");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Add code to handle the click event on label4
            MessageBox.Show("Label4 clicked!");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Add code to handle the click event on label5
            MessageBox.Show("Label5 clicked!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Add code to handle the load event of the form
            MessageBox.Show("Form loaded!");
        }




        private void pb1_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;

            //0 means the pb is turn off, we will open it and check if user guessed the correct cards
            if (pb.Tag.ToString() == "0")
            {
                int index = CardsPictureBoxe.IndexOf(pb);
                //mean user has already selected the 1st image, need to compare  if thet are same

                if (hasOpenCard)
                {
                    string previouseImageId = CardImages.ElementAt(previousIndexOpen).Key;
                    string currentImageId = CardImages.ElementAt(index).Key;
                    bool isMatch = false;

                    //check if they have same ID
                    if (previouseImageId.Replace("_DUP", "") == currentImageId.Replace("_DUP", ""))
                    {
                        //remove _DUP  so they can match if they are same

                        isMatch = true;
                        pb.Tag = 1;
                        pb.Image = CardImages.ElementAt(index).Value;

                    }

                    if (isMatch)
                    {
                        //revert thr card
                        CardsPictureBoxe[previousIndexOpen].Image = CardsPictureBoxe[index].Image = Properties.Resources.Back_card;
                        CardsPictureBoxe[previousIndexOpen].Tag = 0;

                        //Visual show it ti user , we will add delay here so user can see the card before it revert back to back card
                        //achive this , we will use timer control


                    }



                }
                else
                {
                    //means this picturebox us already open, next time user click 
                    pb.Tag = "1";
                    previousIndexOpen = index;
                    pb.Image = CardImages.ElementAt(index).Value;


                }
                //reverse the vale of this flag
                hasOpenCard = !hasOpenCard;


            }
        }

    }
}



