using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Post-it
            Create a PostIt a struct that has
            a BackgroundColor
            a Text on it
            a TextColor
            Create a few example post-it objects:
            an orange with blue text: "Idea 1"
            a pink with black text: "Awesome"
            a yellow with green text: "Superb!"*/

            PostIt Idea;
            Idea.BackgroundColor = Color.Orange;
            Idea.TextColor = Color.Blue;
            Idea.Text = "Idea 1";

            PostIt Awesome;
            Awesome.BackgroundColor = Color.Pink;
            Awesome.TextColor = Color.Black;
            Awesome.Text = "Awesome";

            PostIt Superb;
            Superb.BackgroundColor = Color.Yellow;
            Superb.TextColor = Color.Green;
            Superb.Text = "Superb!";
        }

        struct PostIt
        {
            public Color BackgroundColor;
            public string Text;
            public Color TextColor;
        }
    }
}
