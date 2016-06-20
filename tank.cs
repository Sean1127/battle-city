﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = Tank.Enum.Color;

namespace Tank
{
    public class Tank : Object
    {
        // basic attributes
        public bool dirUp { get; set; }
        public bool dirDown { get; set; }
        public bool dirLeft { get; set; }
        public bool dirRight { get; set; }
        public Color color { get; set; }
        public int speed { get; set; }
        public int level { get; set; }
        public int ammo { get; set; }
        // animation attributes
        public ImageList[][][] imageList_tank { get; set; }
        public bool spawning { get; set; }
        public bool exploding { get; set; }
        public int tick { get; set; }
        // temp attributes
        public ImageList temp { get; set; } // 
        public bool temp2 { get; set; } // 

        public Tank(ImageList imageList1, int x, int y/*, ImageList[][][] imageList_tank*/)
        {
            this.temp = imageList1; //
            this.temp2 = false; //

            this.Size = new Size(32, 32);
            this.SizeMode = PictureBoxSizeMode.AutoSize;
            this.speed = 1;
            this.Top = y;
            this.Left = x;

            this.animation = new ImageList();
            this.animation.ImageSize = new Size(32, 32);
            this.animation.Images.Add(Image.FromFile(Environment.CurrentDirectory + @"\..\..\image\shield1.png"));
            this.animation.Images.Add(Image.FromFile(Environment.CurrentDirectory + @"\..\..\image\shield2.png"));
            this.animation.Images.Add(Image.FromFile(Environment.CurrentDirectory + @"\..\..\image\spawn1.png"));
            this.animation.Images.Add(Image.FromFile(Environment.CurrentDirectory + @"\..\..\image\spawn2.png"));
            this.animation.Images.Add(Image.FromFile(Environment.CurrentDirectory + @"\..\..\image\spawn3.png"));
            this.animation.Images.Add(Image.FromFile(Environment.CurrentDirectory + @"\..\..\image\spawn4.png"));
            this.animation.Images.Add(Image.FromFile(Environment.CurrentDirectory + @"\..\..\image\pop1.png"));
            this.animation.Images.Add(Image.FromFile(Environment.CurrentDirectory + @"\..\..\image\pop2.png"));
            this.animation.Images.Add(Image.FromFile(Environment.CurrentDirectory + @"\..\..\image\pop3.png"));
            this.animation.Images.Add(Image.FromFile(Environment.CurrentDirectory + @"\..\..\image\big_pop1.png"));
            this.animation.Images.Add(Image.FromFile(Environment.CurrentDirectory + @"\..\..\image\big_pop2.png"));
            this.timer = new Timer();
            this.timer.Interval = 200;
            this.timer.Tick += new System.EventHandler(this.timer_tick);
            this.tick = 0;
        }

        public void Explode()
        {
            exploding = true;
            timer.Start();
        }

        public void Spawn()
        {
            spawning = true;
            timer.Start();
        }

        private void timer_tick(object sender, EventArgs e)
        {
            if(spawning==true)
            {
                switch (tick)
                {
                    case 0:
                        this.Image = animation.Images[5];
                        break;
                    case 1:
                        this.Image = animation.Images[4];
                        break;
                    case 2:
                        this.Image = animation.Images[3];
                        break;
                    case 3:
                        this.Image = animation.Images[2];
                        break;
                    case 4:
                        this.Image = animation.Images[2];
                        break;
                    case 5:
                        this.Image = animation.Images[3];
                        break;
                    case 6:
                        this.Image = animation.Images[4];
                        break;
                    case 7:
                        this.Image = animation.Images[5];
                        break;
                    case 8:
                        this.Image = animation.Images[5];
                        break;
                    case 9:
                        this.Image = animation.Images[4];
                        break;
                    case 10:
                        this.Image = animation.Images[3];
                        break;
                    case 11:
                        this.Image = animation.Images[2];
                        break;
                    case 12:
                        this.Image = animation.Images[2];
                        break;
                    case 13:
                        this.Image = animation.Images[3];
                        break;
                    case 14:
                        this.Image = animation.Images[4];
                        break;
                    case 15:
                        this.Image = animation.Images[5];
                        break;
                    default:
                        this.Image = temp.Images[0];
                        timer.Stop();
                        spawning = false;
                        tick = 0;
                        return;
                }
            }
            else if(exploding)
            {
                switch (tick)
                {
                    default:
                        this.Image = animation.Images[0];
                        timer.Stop();
                        exploding = false;
                        tick = 0;
                        return;
                }
            }
            tick++;
        }

        public void MoveUp()
        {
            this.Top -= speed;
            this.Image = (temp2) ? temp.Images[0] : temp.Images[1];
            temp2 = (temp2) ? false : true;
        }

        public void MoveDown()
        {
            this.Top += speed;
            this.Image = (temp2) ? temp.Images[2] : temp.Images[3];
            temp2 = (temp2) ? false : true;
        }

        public void MoveLeft()
        {
            this.Left -= speed;
            this.Image = (temp2) ? temp.Images[4] : temp.Images[5];
            temp2 = (temp2) ? false : true;
        }

        public void MoveRight()
        {
            this.Left += speed;
            this.Image = (temp2) ? temp.Images[6] : temp.Images[7];
            temp2 = (temp2) ? false : true;
        }

        public bool collision()
        {
            return true;
        }

        public void fire()
        {

        }

        public void upgrade()
        {

        }
    }
}
