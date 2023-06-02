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

        public Move(int width, int Height)
        {
            formWidth = width;
            formHeight = Height;

            //wird breite und länge der panel genommen 
            location = new Vector2(random.Next(width), random.Next(Height));
            velocity = new Vector2(1, 1);

            wasserstoff = new RectangleF(location.X, location.Y, 10, 10);
            sauerstoff = new RectangleF(location.X, location.Y, 10, 10);

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


            //wenn wasserstoff mölkule sicht mit sauerstoff mulekule stoßen sollte wassermölekue entstehen
            //
            //
            //Funktionert nicht**
            if (sauerstoff.IntersectsWith(wasserstoff))
            {

                Console.WriteLine("geht doch man ");

            }

            
        }

        /// <summary>
        /// https://simpledevcode.wordpress.com/2014/08/10/collision-detection-in-c-net-java-example/
        /// </summary>
        //Rectangel um mölekule zu zeichenen
        RectangleF wasserstoff;
        RectangleF sauerstoff;

        public void OnpaintSauerstoff(Graphics e)
        {
            
            
            //sauerstoff = new Rectangle((int)location.X + 5, (int)location.Y + 5, 10, 10);

            sauerstoff.X = location.X;
            sauerstoff.Y = location.Y;
            e.FillEllipse(new SolidBrush(Color.Red), sauerstoff);
            e.FillEllipse(new SolidBrush(Color.DarkRed), sauerstoff);



        }
        public void OnpaintWasserstoff(Graphics e)
        {

            
            wasserstoff.X= location.X;
            wasserstoff.Y = location.Y;

            //wasserstoff = new Rectangle((int)location.X + 5, (int)location.Y + 5, 10, 10);

            e.FillEllipse(new SolidBrush(Color.Blue), wasserstoff);
            e.FillEllipse(new SolidBrush(Color.DarkBlue), wasserstoff);


        }

    }
}
