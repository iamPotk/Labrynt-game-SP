using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace labrynt.SP
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch spriteBatch;





        Texture2D brickbg;
        Rectangle BRICKIN = new Rectangle(0, 0, 800, 800);





        Texture2D labryntpng;
        Vector2 labryntbackground = new Vector2(0, 0);
        Rectangle labryntrect = new Rectangle(100, 0, 700, 480);


        /*

        Texture2D Wall1;
        Rectangle wall1rect = new Rectangle(50, 50, 300, 10);




        Texture2D Wall2;
        Rectangle wall2rect = new Rectangle(350, 50, 10, 150);



        Texture2D Wall3;
        Rectangle wall3rect = new Rectangle(50, 200, 300, 10);



        Texture2D Wall4;
        Rectangle wall4rect = new Rectangle(50, 200, 10, 100);




        Texture2D Wall5;
        Rectangle wall5rect = new Rectangle(150, 250, 200, 10);




        Texture2D Wall6;
        Rectangle wall6rect = new Rectangle(150, 250, 10, 100);



        Texture2D Wall7;
        Rectangle wall7rect = new Rectangle(250, 250, 10, 100);



        Texture2D Wall8;
        Rectangle wall8rect = new Rectangle(50, 350, 300, 10);



        Texture2D Wall9;
        Rectangle wall9rect = new Rectangle(50, 350, 10, 100);



        Texture2D Wall10;
        Rectangle wall10rect = new Rectangle(100, 250, 300, 180);

        */







        Texture2D snail;
        Vector2 snailbg = new Vector2(0, 0);
        Rectangle snailrect = new Rectangle(0, 0, 50, 50);


        KeyboardState kibord = Keyboard.GetState();


        bool intersection(Rectangle A, Rectangle B)
        {
            if (A.Intersects(B))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        bool dead = false;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);


            labryntpng = Content.Load<Texture2D>("labarint1");
            brickbg = Content.Load<Texture2D>("whitebrick");
            snail = Content.Load<Texture2D>("pngwing.com");
           /* Wall1 = Content.Load<Texture2D>("Linehori");
            Wall2 = Content.Load<Texture2D>("line1");
            Wall3 = Content.Load<Texture2D>("Line11");
            Wall4 = Content.Load<Texture2D>("Line111");
            Wall5 = Content.Load<Texture2D>("Line1111");
            Wall6 = Content.Load<Texture2D>("Linevert");
            Wall7 = Content.Load<Texture2D>("Line2");
            Wall8 = Content.Load<Texture2D>("Line22");
            Wall9 = Content.Load<Texture2D>("Line222");
            Wall10 = Content.Load<Texture2D>("Line2222");
            */





        }

        protected override void Update(GameTime gameTime)
        {


            kibord = Keyboard.GetState();

            if (kibord.IsKeyDown(Keys.A))
            {
                snailrect.X -= 1;

            }
            else if (kibord.IsKeyDown(Keys.D))
            {

                snailrect.X += 1;

            }
            else if (kibord.IsKeyDown(Keys.W))
            {

                snailrect.Y -= 1;

            }

            else if (kibord.IsKeyDown(Keys.S))
            {

                snailrect.Y += 1;

            }


            if (kibord.IsKeyDown(Keys.Back))
            {
                snailrect.X -= 1;

            }
            else if (kibord.IsKeyDown(Keys.Down))
            {

                snailrect.X += 1;

            }
            else if (kibord.IsKeyDown(Keys.H))
            {

                snailrect.Y -= 1;

            }

            else if (kibord.IsKeyDown(Keys.F))
            {

                snailrect.Y += 1;

            }







            if (intersection(snailrect , labryntrect))
            {
                dead = true;
            }












        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            spriteBatch.Draw(brickbg, BRICKIN, color:Color.White);
            if (!dead)
            {
                spriteBatch.Draw(labryntpng, labryntrect, color: Color.White);
            }
            spriteBatch.Draw(labryntpng,labryntrect,color:Color.Red);



            /*
            spriteBatch.Draw(Wall1, wall1rect, color: Color.White);


            spriteBatch.Draw(Wall1, wall1rect, color: Color.White);
            spriteBatch.Draw(Wall2, wall1rect, color: Color.White);
            spriteBatch.Draw(Wall3, wall1rect, color: Color.White);
            spriteBatch.Draw(Wall4, wall1rect, color: Color.White);
            spriteBatch.Draw(Wall5, wall1rect, color: Color.White);
            spriteBatch.Draw(Wall6, wall1rect, color: Color.White);
            spriteBatch.Draw(Wall7, wall1rect, color: Color.White);
            spriteBatch.Draw(Wall8, wall1rect, color: Color.White);
            spriteBatch.Draw(Wall9, wall1rect, color: Color.White);
            spriteBatch.Draw(Wall10, wall1rect, color: Color.White);

            */














            spriteBatch.Draw(snail, snailrect, color:Color.White);



            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}