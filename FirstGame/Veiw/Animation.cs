using System;
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
namespace FirstGame.Veiw
{
	public class Animation
	{// The image representing the collection of images used for animation
		private Texture2D spriteStrip;

		public Texture2D SpriteSTrp
		{
			get{ return spriteStrip; }
			set { spriteStrip = value; }
		}

		// The scale used to display the sprite strip
		private float scale;

		public float Scale
		{
			get { return scale; }
			set{scale = value;}
		}

		// The time since we last updated the frame
		private int elapsedTime;

		public int ElapsedTime
		{
			get{ return elapsedTime; }
			set{elapsedTime= value;}
		}

		// The time we display a frame until the next one
		private int frameTime;

		public int FrameTime
		{
			get { return frameTime; }
			set { frameTime =value; }
		}
		// The number of frames that the animation contains
		private	int frameCount;

		public int FrameCount
		{
			get { return frameCount; }
			set { frameCount = value; }
		}

		// The index of the current frame we are displaying
		private int currentFrame;

		public int CurrentFrame 
		{
			get { return currentFrame; }
			set { currentFrame = value; }
		}

		// The color of the frame we will be displaying
		private Color color;

		public Color Color
		{
			get { return color; }
			set { color = value; }
		}

		// The area of the image strip we want to display
		private	Rectangle sourceRect = new Rectangle();


		// The area where we want to display the image strip in the game
			private 	Rectangle destinationRect = new Rectangle();

		// Width of a given frame
	
		private int frameWidth;

		public int FrameWidth
		{
			get { return frameWidth; }
			set { frameWidth = value; }
		}

		// Height of a given frame

		private int frameHeight;
		public int FrameHeight
		{
			get { return frameHeight;}
			set { frameHeight = value; }
		}

		// The state of the Animation
		private bool active;
		public bool Active
		{
			get { return active; }
			set { active = value; }
		}

		// Determines if the animation will keep playing or deactivate after one run
		private bool looping; 
		public bool Looping
		{
			get { return looping; }
			set { looping = value; }
		}

		// Width of a given frame
		public Vector2 Position;

		public void Initialize()
		{
		}
		public void Update()
		{
		}
		public void Draw()
		{
		}
		public Animation ()
		{
		}
	}
}

