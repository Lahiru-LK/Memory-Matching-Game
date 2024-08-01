namespace Memory_Matching_Game
{
    public partial class Form1 : Form
    {
        //Dictionary to store the images

        Dictionary<string, Image> CardImages = new Dictionary<string, Image>();

        //List to store the picture boxes



        public Form1()
        {
            InitializeComponent();
            LoadImages();
            


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
                Random rand = new Random();
                int index = rand.Next(0, CardImages.Count);
                string key = CardImages.Keys.ElementAt(index);
                Image value = CardImages[key];

                //add the image to the temporary dictionary
                imgTmp.Add(key, value);

                //remove the image from the original dictionary
                CardImages.Remove(key);
            }

           
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
