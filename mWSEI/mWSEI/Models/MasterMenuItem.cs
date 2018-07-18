using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace mWSEI.Models
{
    public class MasterMenuItem
    {
        public string Title { get; set; }
        //public string iconSource { get; set; }
        public Color BackgroundColor { get; set; }
        public Type TargetType { get; set; }

        public MasterMenuItem(string Title, Color BackgroundColor, Type TargetType)
        {
            this.Title = Title;
            this.BackgroundColor = BackgroundColor;
            this.TargetType = TargetType;
        }
    }
}
