using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstMVCWithRazor.ViewModels
{
    public class HomeModel
    {
        public HomeModel(int antal)
        {
            Antal = antal;
        }

        public int Antal { get; set; }
    }
}