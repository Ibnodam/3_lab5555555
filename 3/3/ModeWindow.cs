using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _3
{


    public class ModeWindow : Window
    {
        private string? header;
        private int[] cordinates = new int[2];
        private int horizontal_length;
        private int vertical_length;
        private string color;
        private bool isvisible;
        private bool borderOn;

        public string? Header { get { return header; } set { if (value != "") header = value; else header = "_Default_"; } }

        public int[] Cordinates
        {
            get { return cordinates; }
            set
            {
                cordinates[0] = Convert.ToInt32(value[0]);
                cordinates[1] = Convert.ToInt32(value[1]);
            }
        }


        public int Horizontal_length { get { return horizontal_length; } set { if (value >= 1) horizontal_length = value; else horizontal_length = 1; } }

        public int Vertical_length { get { return vertical_length; } set { if (value >= 1) vertical_length = value; else vertical_length = 1; } }

        public string Color { get { return color; } set { if (value != "") color = value; else color = "Honeydew"; } }

        public bool Isvisible { get { return isvisible; } set { isvisible = value; } }
        public bool BorderOn { get { return borderOn; } set { borderOn = value; } }


        public ModeWindow(string header, int coor_x, int coor_y, int horizont, int vertical, string color, bool isvisible)
        {
            Header = header;
            Cordinates[0] = coor_x;
            Cordinates[1] = coor_y;
            Horizontal_length = horizont;
            Vertical_length = vertical;
            Color = color;
            this.Title = Header;
            this.Top = Cordinates[0];
            this.Left = Cordinates[1];
            this.Width = Horizontal_length;
            this.Height = Vertical_length;
            
            this.Show();


        }


    }

}
