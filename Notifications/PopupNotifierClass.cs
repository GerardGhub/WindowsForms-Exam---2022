﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace WindowsFormsApp4.Notifications
{
    public class PopupNotifierClass
    {
        public void DataNotExist(string Name)
        {
            PopupNotifier popup = new PopupNotifier();
            popup.TitleText = "Notifications!";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(255, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Data not Exist!  " + Name;
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 11F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Red;
            popup.Popup();
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;
            popup.ShowOptionsButton = true;


        }


        public void FillTheRequiredFields()
        {
            PopupNotifier popup = new PopupNotifier();
            popup.TitleText = "Notifications!";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(255, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Fill up the required fields!  ";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 11F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Red;
            popup.Popup();
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;
            popup.ShowOptionsButton = true;


        }
    }
}
