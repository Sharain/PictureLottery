using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PictureLottery
{
    public partial class Form1 : Form
    {
        //public static class dataengine
        //{
        //    string int jcolor = 
        //}
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Animals_Click(object sender, EventArgs e)
        {
            var strButton_Text=Start_Animals.Text;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "C:\\temp\\play.wav";
            if (strButton_Text == "Start_Animals")
            {
                player.LoadAsync();
                player.PlayLooping();   
                Start_Animals.Text = "Stop";
                timer_animals.Enabled = true;
                //listfile[j].Remove(0);
                //animals.Image = Image.FromFile("c:\\temp\\dog.png");
                //anim
                //Timer timer = new Timer();
                //timer.Interval = 500;
                //timer.Enabled = true;
                //timer.Start();
                
            }
            else
            {
                player.Stop();
                Start_Animals.Text = "Start_Animals";
                timer_animals.Enabled = false;
            }
            //

            //animals.SizeMode = "StretchImage";
            
            
        }

        private void animals_Click(object sender, EventArgs e)
        {
            

        }
        int i = 0;
        private void timer_animals_Tick(object sender, EventArgs e)
        {

            FileInfo[] listfile = getfilenames("C:\\temp\\pictures\\animals");
            List<string> listfile1 = new List<string>();
            foreach (FileInfo f in listfile)
            {
                listfile1.Add(f.ToString());

            }

            //listfile.ToList();
            if (i == listfile1.Count())
            {
                i = 0;
            }

            //string filepath = "C:\\temp\\pictures\\animals\\" + i.ToString() + ".png";
            string filepath = "C:\\temp\\pictures\\animals\\" + listfile1[i].ToString();
            animals.Image = Image.FromFile(filepath);

            i++;
        }
        int j = 0;

        //DirectoryInfo dir = new DirectoryInfo("C:\\temp\\pictures\\colors");
        //DirectoryInfo[] listdir = dir.GetDirectories():
        //FileInfo[] listfile =         
        //int colors_count
        private void timer_colors_Tick(object sender, EventArgs e)
        {
            FileInfo[] listfile = getfilenames("C:\\temp\\pictures\\colors");
            List<string> listfile1 = new List<string>();
            foreach(FileInfo f in listfile)
            {
                listfile1.Add(f.ToString());
                
            }
            
            //listfile.ToList();
            if (j == listfile1.Count())
            {
                j = 0;
            }
            
            //string filepath = "C:\\temp\\pictures\\animals\\" + i.ToString() + ".png";
            string filepath = "C:\\temp\\pictures\\colors\\" + listfile1[j].ToString();
            colors.Image = Image.FromFile(filepath);
            
            j++;
            
        }
        //public void picturechange(string folderpath)
        //{
        //    FileInfo[] listfile = getfilenames("C:\\temp\\pictures\\colors");
        //    List<string> listfile1 = new List<string>();            
        //    foreach (FileInfo f in listfile)
        //    {
        //        listfile1.Add(f.ToString());

        //    }

        //    //listfile.ToList();


        //    //string filepath = "C:\\temp\\pictures\\animals\\" + i.ToString() + ".png";
        //    //string filepath = folderpath + listfile1[j].ToString();
        //    string filepath;
        //    Timer timerA = new Timer();
        //    timerA.Interval = 200;
        //    foreach (string l in listfile1)
        //    {
        //        filepath = folderpath + l.ToString();
        //    }
        //}
        public FileInfo[] getfilenames(string folderpath)
        {
            DirectoryInfo dir = new DirectoryInfo(folderpath);

            return dir.GetFiles();
        }

        private void Start_Colors_Click(object sender, EventArgs e)
        {
            var strButton_Text = Start_Colors.Text;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "C:\\temp\\play.wav";
            if (strButton_Text == "Start_Colors")
            {
                
                player.LoadAsync();
                player.PlayLooping();                
                Start_Colors.Text = "Stop";
                timer_colors.Enabled = true;                

            }
            else
            {
                player.Stop();
                Start_Colors.Text = "Start_Colors";
                timer_colors.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
