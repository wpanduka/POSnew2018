﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestProject.Models
{
    public class Constants
    {
        public static bool IsDev = true;

        public static Color BackgroundColor = Color.FromRgb(58, 153, 215);
        public static Color MainTextColor = Color.White;

        public static int LoginIconHeight = 120;

        //-------Login details

        // public static string LoginUrl = "http://192.168.43.226/UserLogin.php";
        public static string LoginUrl = "http://192.168.43.51/UserLogin.php";
        //  public static string LoginUrl = "http://192.168.43.226/Newlogin.html";
       // public static string BaseUrlpos = "http://192.168.43.209/";
        public static string BaseUrlpos = "http://192.168.43.51/";



    }
}
