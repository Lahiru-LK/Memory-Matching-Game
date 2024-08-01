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
        }

        //Load the images into the dictionary

        private void LoadImages()
        {
            //in this game, we have 7 images, so we will load 2 of each image
            CardImages.Add("A", Properties.Resources.im1);
            CardImages.Add("B", Properties.Resources.im2);
            CardImages.Add("C", Properties.Resources.im3);
            CardImages.Add("D", Properties.Resources.im4);
            CardImages.Add("E", Properties.Resources.im5);
            CardImages.Add("F", Properties.Resources.im5);
            CardImages.Add("G", Properties.Resources.im6);
            
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
