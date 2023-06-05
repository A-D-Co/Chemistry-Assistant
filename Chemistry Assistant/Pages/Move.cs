using System;
using System.Drawing;
using System.Numerics;

namespace Chemistry_Assistant.Pages
{
    class Move
    {
        static Random random = new Random();

        Vector2 location;
        Vector2 velocity;

        int formWidth;
        int formHeight;

        public Move(int width, int height)
        {
            formWidth = width;
            formHeight = height;


            location = new Vector2(random.Next(width) - sauerstoff.Width, random.Next(height) - sauerstoff.Height);
            velocity = new Vector2(1, 1);

                sauerstoff = new RectangleF(location.X, location.Y, 15, 15);
                wasser = new RectangleF(location.X, location.Y, 15, 15);
                wasserstoff = new RectangleF(location.X, location.Y, 15, 15);
            
        }

        public void Update()
        {

            //wenn der bereite kleienr als null ist oder größer als panel briete stößt sich auf andene seite 
            if (location.X < 0 || location.X > this.formWidth - 10)
            {
                velocity.X = velocity.X * -1;
            }
            //wenn der höhe kleiner als null ist oder größer als panel höhe stößt sich auf anden seite
            if (location.Y < 0 || location.Y > this.formHeight - 10)
            {

                velocity.Y = velocity.Y * -1;
            }

            //sonst beweget sicht auf der seite der sich stoßt
            location = Vector2.Add(location, velocity);



            
        }

        /// <summary>
        /// https://simpledevcode.wordpress.com/2014/08/10/collision-detection-in-c-net-java-example/
        /// </summary>
        //Rectangel um mölekule zu zeichenen
        public RectangleF wasserstoff;
        public RectangleF sauerstoff;
        public RectangleF wasser;
        public void OnpaintSauerstoff(Graphics e)
        {

            sauerstoff.X = location.X;
            sauerstoff.Y = location.Y;
            e.FillEllipse(new SolidBrush(Color.Red), sauerstoff);


        }
        public void OnpaintWasser(Graphics e)
        {

            wasser.X = location.X;
            wasser.Y = location.Y;
            e.FillEllipse(new SolidBrush(Color.Yellow), wasser);

        }
        public void OnpaintWasserstoff(Graphics e)
        {
            wasserstoff.X = location.X;
            wasserstoff.Y = location.Y;
            e.FillEllipse(new SolidBrush(Color.Blue), wasserstoff);
        }

    }
}
