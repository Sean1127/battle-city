﻿namespace Tank
{
    partial class Form_game_2player
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_game_2player));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer_move = new System.Windows.Forms.Timer(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "my1_yellow_up_1.png");
            this.imageList1.Images.SetKeyName(1, "my1_yellow_up_2.png");
            this.imageList1.Images.SetKeyName(2, "my1_yellow_down_1.png");
            this.imageList1.Images.SetKeyName(3, "my1_yellow_down_2.png");
            this.imageList1.Images.SetKeyName(4, "my1_yellow_left_1.png");
            this.imageList1.Images.SetKeyName(5, "my1_yellow_left_2.png");
            this.imageList1.Images.SetKeyName(6, "my1_yellow_right_1.png");
            this.imageList1.Images.SetKeyName(7, "my1_yellow_right_2.png");
            // 
            // timer_move
            // 
            this.timer_move.Interval = 4;
            this.timer_move.Tick += new System.EventHandler(this.timer_move_Tick);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "my1_green_up_1.png");
            this.imageList2.Images.SetKeyName(1, "my1_green_up_2.png");
            this.imageList2.Images.SetKeyName(2, "my1_green_down_1.png");
            this.imageList2.Images.SetKeyName(3, "my1_green_down_2.png");
            this.imageList2.Images.SetKeyName(4, "my1_green_left_1.png");
            this.imageList2.Images.SetKeyName(5, "my1_green_left_2.png");
            this.imageList2.Images.SetKeyName(6, "my1_green_right_1.png");
            this.imageList2.Images.SetKeyName(7, "my1_green_right_2.png");
            // 
            // Form_game_2player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Name = "Form_game_2player";
            this.Text = "Battle City 2016";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_game_2player_FormClosed);
            this.Load += new System.EventHandler(this.Form_game_2player_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_game_2player_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form_game_2player_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer_move;
        private System.Windows.Forms.ImageList imageList2;
    }
}