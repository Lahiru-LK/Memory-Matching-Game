using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Media;
using WMPLib; // Add this using directive for Windows Media Player

namespace Memory_Matching_Game
{
    public partial class Form1 : Form
    {
        // Dictionary to store the images
        Dictionary<string, Image> CardImages = new Dictionary<string, Image>();

        // List to store the picture boxes
        List<PictureBox> CardsPictureBoxes = new List<PictureBox>();
        List<PictureBox> LifePictureBoxes = new List<PictureBox>();

        int previousIndexOpen;
        bool hasOpenCard = false;
        int LifeUsed = 0;
        int UserPoints = 0;
        int cardSelectedIndex;

        int timeLeft = 60; // Add this line
        System.Windows.Forms.Timer gameTimer; // Declare the timer with full namespace

        WindowsMediaPlayer backgroundMusicPlayer; // Use WindowsMediaPlayer for background music

        public Form1()
        {
            InitializeComponent();
            LoadImages();

            // Call Randomize() method to randomize the images
            Randomize();

            // Add picture boxes to the list
            CardsPictureBoxes.Add(pb1);
            CardsPictureBoxes.Add(pb2);
            CardsPictureBoxes.Add(pb3);
            CardsPictureBoxes.Add(pb4);
            CardsPictureBoxes.Add(pb5);
            CardsPictureBoxes.Add(pb6);
            CardsPictureBoxes.Add(pb7);
            CardsPictureBoxes.Add(pb8);
            CardsPictureBoxes.Add(pb9);
            CardsPictureBoxes.Add(pb10);
            CardsPictureBoxes.Add(pb11);
            CardsPictureBoxes.Add(pb12);

            LifePictureBoxes.Add(pbHeart6);
            LifePictureBoxes.Add(pbHeart5);
            LifePictureBoxes.Add(pbHeart4);
            LifePictureBoxes.Add(pbHeart3);
            LifePictureBoxes.Add(pbHeart2);
            LifePictureBoxes.Add(pbHeart1);

            // Initialize the timer
            gameTimer = new System.Windows.Forms.Timer();
            gameTimer.Interval = 1000; // 1 second intervals
            gameTimer.Tick += timer_Left_Tick;
            gameTimer.Start();

            // Initialize the TimeLeftCount label
            TimeLeftCount.Text = timeLeft.ToString();

            // Initialize and start the background music player
            backgroundMusicPlayer = new WindowsMediaPlayer();
            backgroundMusicPlayer.URL = "C:\\Users\\PC\\Desktop\\Memory-Matching-Game\\Memory Matching Game\\Resources\\background_music.wav";
            backgroundMusicPlayer.settings.setMode("loop", true);
            backgroundMusicPlayer.controls.play();
        }

        // Load the images into the dictionary
        private void LoadImages()
        {
            // In this game, we have 6 images, we will load 2 of each image
            CardImages.Add("im1", Properties.Resources.im1);
            CardImages.Add("im2", Properties.Resources.im2);
            CardImages.Add("im3", Properties.Resources.im3);
            CardImages.Add("im4", Properties.Resources.im4);
            CardImages.Add("im5", Properties.Resources.im5);
            CardImages.Add("im6", Properties.Resources.im6);

            // Insert duplicates for each image
            CardImages.Add("im1_DUP", Properties.Resources.im1);
            CardImages.Add("im2_DUP", Properties.Resources.im2);
            CardImages.Add("im3_DUP", Properties.Resources.im3);
            CardImages.Add("im4_DUP", Properties.Resources.im4);
            CardImages.Add("im5_DUP", Properties.Resources.im5);
            CardImages.Add("im6_DUP", Properties.Resources.im6);
        }

        // Randomize the images
        private void Randomize()
        {
            // Temporarily store images in a new dictionary
            Dictionary<string, Image> imgTmp = new Dictionary<string, Image>();

            Random rnd = new Random();
            var keys = CardImages.Keys.ToList();

            while (keys.Count > 0)
            {
                // Select a random image
                int index = rnd.Next(keys.Count);
                string key = keys[index];
                imgTmp.Add(key, CardImages[key]);
                keys.RemoveAt(index);
            }

            CardImages = imgTmp;
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }

        private void label4_Click(object sender, EventArgs e) { }

        private void label5_Click(object sender, EventArgs e) { }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            if (tmrHeart.Enabled)
                return;

            PictureBox pb = (PictureBox)sender;

            // Play the click sound using a new SoundPlayer instance
            using (SoundPlayer clickSoundPlayer = new SoundPlayer("C:\\Users\\PC\\Desktop\\Memory-Matching-Game\\Memory Matching Game\\Resources\\click_sound_01.wav"))
            {
                clickSoundPlayer.Play();
            }

            // 0 means the pb is turned off, we will open it and check if the user guessed the correct cards
            if (pb.Tag.ToString() == "0")
            {
                int index = CardsPictureBoxes.IndexOf(pb);

                // Means the user has already selected the 1st image, need to compare if they are the same
                if (hasOpenCard)
                {
                    string previousImageId = CardImages.ElementAt(previousIndexOpen).Key;
                    string currentImageId = CardImages.ElementAt(index).Key;
                    bool isMatch = false;

                    // Check if they have the same ID
                    if (previousImageId.Replace("_DUP", "") == currentImageId.Replace("_DUP", ""))
                    {
                        // Remove _DUP so they can match if they are the same
                        isMatch = true;
                        pb.Tag = "1";
                        pb.Image = CardImages.ElementAt(index).Value;
                        UserPoints++;
                        lblPoints.Text = UserPoints.ToString();

                        // Play the match sound using a new SoundPlayer instance
                        using (SoundPlayer matchSoundPlayer = new SoundPlayer("C:\\Users\\PC\\Desktop\\Memory-Matching-Game\\Memory Matching Game\\Resources\\match_image.wav"))
                        {
                            matchSoundPlayer.Play();
                        }

                        // Validate if the user has guessed all the cards
                        if (UserPoints == 6)
                        {

                            // Play the match sound using a new SoundPlayer instance
                            using (SoundPlayer matchSoundPlayer = new SoundPlayer("C:\\Users\\PC\\Desktop\\Memory-Matching-Game\\Memory Matching Game\\Resources\\gameOver_sound.wav"))
                            {
                                gameTimer.Stop(); // Stop the timer
                                matchSoundPlayer.Play();
                                MessageBox.Show("Congratulations! You Finished this game");
                            }
                            
                            
                            LifeUsed = 0;
                            UserPoints = 0;
                            lblPoints.Text = "0";
                            TimeLeftCount.Text = "60";
                            ResetLife();
                            ShuffleImages();
                            ResetCards();
                            
                        }
                    }
                    cardSelectedIndex = index;

                    if (!isMatch)
                    {
                        // Show the card and start the timer to revert back if not matched
                        pb.Tag = "1";
                        pb.Image = CardImages.ElementAt(index).Value;
                        tmrHeart.Enabled = true;
                        tmrDelay.Enabled = true;
                    }
                }
                else
                {
                    // Means this picturebox is already open, next time the user clicks
                    pb.Tag = "1";
                    previousIndexOpen = index;
                    pb.Image = CardImages.ElementAt(index).Value;
                }

                // Reverse the value of this flag
                hasOpenCard = !hasOpenCard;
            }
        }

        private void tmrDelay_Tick(object sender, EventArgs e)
        {
            // One tick is disabled, we will revert the card
            tmrDelay.Enabled = false;

            if (CardsPictureBoxes[previousIndexOpen].Tag.ToString() == "1" && CardsPictureBoxes[cardSelectedIndex].Tag.ToString() == "1")
            {
                // Revert the cards if they don't match
                CardsPictureBoxes[previousIndexOpen].Image = Properties.Resources.Back_card;
                CardsPictureBoxes[cardSelectedIndex].Image = Properties.Resources.Back_card;
                CardsPictureBoxes[previousIndexOpen].Tag = "0";
                CardsPictureBoxes[cardSelectedIndex].Tag = "0";

                // Play the not match sound using a new SoundPlayer instance
                using (SoundPlayer notMatchSoundPlayer = new SoundPlayer("C:\\Users\\PC\\Desktop\\Memory-Matching-Game\\Memory Matching Game\\Resources\\notMatch_image.wav"))
                {
                    notMatchSoundPlayer.Play();
                }

                // Inform the user that the cards do not match
                MessageBox.Show("The cards do not match!");

                // Increase the life used if the cards do not match
                LifePictureBoxes[LifeUsed].Visible = false;
                LifeUsed++;
                if (LifeUsed == 6)
                {
                    // Play the game over sound using a new SoundPlayer instance
                    using (SoundPlayer gameOverSoundPlayer = new SoundPlayer("C:\\Users\\PC\\Desktop\\Memory-Matching-Game\\Memory Matching Game\\Resources\\gameTimeEnd.wav"))
                    {
                        gameOverSoundPlayer.Play();
                    }

                    MessageBox.Show("Game Over! You have used all your lives");
                    Application.Exit();
                }
            }
        }

        int heartTimer = 10;

        private void tmrHeart_Tick(object sender, EventArgs e)
        {
            // This will make the heart blinking effect
            LifePictureBoxes[LifeUsed].Visible = !LifePictureBoxes[LifeUsed].Visible;

            heartTimer--;
            if (heartTimer < 0)
            {
                tmrHeart.Enabled = false;
                heartTimer = 10;
                LifePictureBoxes[LifeUsed].Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Play the time end sound using a new SoundPlayer instance
            using (SoundPlayer timeEndSoundPlayer = new SoundPlayer("C:\\Users\\PC\\Desktop\\Memory-Matching-Game\\Memory Matching Game\\Resources\\game_restart.wav"))
            {
                timeEndSoundPlayer.Play();
                MessageBox.Show("Game Restart!");
                LifeUsed = 0;
                UserPoints = 0;
                lblPoints.Text = "0";
                TimeLeftCount.Text = "60";
                ResetLife();
                ShuffleImages();
                ResetCards();
                timeLeft = 60; // Reset the timer
                TimeLeftCount.Text = timeLeft.ToString();
                gameTimer.Start(); // Restart the timer
                                   //music callings
                backgroundMusicPlayer.controls.play();
            }

            
        }

        private void ResetCards()
        {
            foreach (var pb in CardsPictureBoxes)
            {
                pb.Tag = "0";
                pb.Image = Properties.Resources.Back_card;
            }
        }

        private void ResetLife()
        {
            foreach (var item in LifePictureBoxes)
            {
                item.Visible = true;
            }
        }

        private void ShuffleImages()
        {
            Randomize();
            AssignImagesToCards();
        }

        private void AssignImagesToCards()
        {
            int index = 0;
            foreach (var pb in CardsPictureBoxes)
            {
                pb.Tag = CardImages.ElementAt(index).Key;
                pb.Image = Properties.Resources.Back_card; // Initially, all images are set to the back card image
                index++;
            }
        }

        private void timer_Left_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                TimeLeftCount.Text = timeLeft.ToString();
            }
            else
            {
                gameTimer.Stop();

                // Play the time end sound using a new SoundPlayer instance
                using (SoundPlayer timeEndSoundPlayer = new SoundPlayer("C:\\Users\\PC\\Desktop\\Memory-Matching-Game\\Memory Matching Game\\Resources\\gameTimeEnd.wav"))
                {
                    timeEndSoundPlayer.Play();
                }

                MessageBox.Show("Time's up! Game Over!");
                Application.Exit();
            }
        }
    }
}
