using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MemoryGameProject.Properties;

namespace MemoryGameProject
{
    public partial class Form1 : Form
    {
        private const int Card_Number = 8;
        private Image[] Images_Array = new Image[Card_Number];

        private bool m_IsFirst = true;
        private int m_Count = 0;

        private PictureBox m_FirstPictureBox;
        private PictureBox m_SecondPictureBox;

        private MessagBoxDesign msg = new MessagBoxDesign();


        public Form1()
        {
            InitializeComponent();

            SetImagesArray();

            restart();
        }

        public void Swap (int i, int j)
        {
            Image image = Images_Array[i];
            Images_Array[i] = Images_Array[j];
            Images_Array[j] = image;
        }

        private void SetImagesArray()
        {
            Images_Array[0] = Resources.Michael_Jordan;
            Images_Array[1] = Resources.Michael_Jordan;

            Images_Array[2] = Resources.BeetleJuice;
            Images_Array[3] = Resources.BeetleJuice;

            Images_Array[4] = Resources.IsraelAirForce;
            Images_Array[5] = Resources.IsraelAirForce;

            Images_Array[6] = Resources.CoronaVirus;
            Images_Array[7] = Resources.CoronaVirus;

            Random rnd = new Random();

            for (int i = 0; i < Card_Number; i++)
            {
                Swap(i, rnd.Next(Card_Number));
            }
        }

        public bool IsImagesMatch(Image image1, Image image2)
        {
            try
            {
                //create instance or System.Drawing.ImageConverter to convert
                //each image to a byte array
                ImageConverter converter = new ImageConverter();
                //create 2 byte arrays, one for each image
                byte[] imgBytes1 = new byte[1];
                byte[] imgBytes2 = new byte[1];

                //convert images to byte array
                imgBytes1 = (byte[])converter.ConvertTo(image1, imgBytes2.GetType());
                imgBytes2 = (byte[])converter.ConvertTo(image2, imgBytes1.GetType());

                //now compute a hash for each image from the byte arrays
                System.Security.Cryptography.SHA256Managed sha = new System.Security.Cryptography.SHA256Managed();
                byte[] imgHash1 = sha.ComputeHash(imgBytes1);
                byte[] imgHash2 = sha.ComputeHash(imgBytes2);

                //now let's compare the hashes
                for (int i = 0; i < imgHash1.Length && i < imgHash2.Length; i++)
                {
                    //whoops, found a non-match, exit the loop
                    //with a false value
                    if (!(imgHash1[i] == imgHash2[i]))
                        return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            //we made it this far so the images must match
            return true;
        }



        private void pictureBox_Card_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;


            string PhotoName = pictureBox.Name;

            int k = int.Parse(PhotoName.Substring(PhotoName.Length - 1));
            k--;

            if (!IsImagesMatch(pictureBox.Image, Resources.back))
                pictureBox.Image = Resources.back;
            else
                pictureBox.Image = Images_Array[k];

            if (!m_IsFirst)
            {
                m_SecondPictureBox = pictureBox;
                timer1.Start();
            }
            else
            {
                m_FirstPictureBox = pictureBox;
            }

            m_IsFirst = !m_IsFirst;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (IsImagesMatch(m_FirstPictureBox.Image, m_SecondPictureBox.Image))
            {
                m_FirstPictureBox.Image = Resources.YouFoundAMatch;
                m_SecondPictureBox.Image = Resources.YouFoundAMatch;

                m_FirstPictureBox.Enabled = false;
                m_SecondPictureBox.Enabled = false;
                m_Count += 2;
            }

            else
            {
                m_FirstPictureBox.Image = Resources.back;
                m_SecondPictureBox.Image = Resources.back;
            }
           
            timer1.Stop();

            if (m_Count == Card_Number)
            {
                msg.Show(); // automaticly opens a MessageBox window. 
            }
        }

        private void GameTitle_Click(object sender, EventArgs e)
        {
            Text = "Welcome to the Memory Game!";
            
        }

        

        private void restart()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            m_Count = 0;

            Images_Array[0] = Resources.back;
            Images_Array[1] = Resources.back;

            Images_Array[2] = Resources.back;
            Images_Array[3] = Resources.back;

            Images_Array[4] = Resources.back;
            Images_Array[5] = Resources.back;

            Images_Array[6] = Resources.back;
            Images_Array[7] = Resources.back;

            SetImagesArray();

            m_FirstPictureBox.Image = Resources.back;
            m_SecondPictureBox.Image = Resources.back;
            m_Third

        }
    }
}

