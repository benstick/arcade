using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Windows.Forms;
using System.Drawing;


class Vector2dObject
{
    public List<Projectile> projectiles = new List<Projectile>();
    public List<PictureBox> projectilepictureBoxes = new List<PictureBox>();

    public Vector2 position;
    public Vector2 TargetPos;
    public Vector2 velocity;
    public Vector2 facingVector;
    public Vector2 _size;
    public float gravity;
    public float facingDegrees;
    public float TargetRadians;
    public float accelAmount;
    public float firerate;

    public int Health;
    public Image image;

    public bool isFiring;
    public bool isAccelerating;
    public bool isTurnningLeft;
    public bool isTurnningRight;

    public Vector2dObject()
    {
        facingDegrees = 0.0f;
        isAccelerating = false;
        velocity = new Vector2(0.0f, 0.0f);
        gravity = 0.02f;
        Health = 0;
    }

    virtual public void Update(float dt)
    {

        if (isTurnningLeft)
        {
            facingDegrees -= 2;
        }

        if (isTurnningRight)
        {
            facingDegrees += 2;
        }

        float radiansPerDegree = Math.PI.ToFloat() / 180.0f;
        facingVector.X = Math.Cos(radiansPerDegree * (facingDegrees)).ToFloat();
        facingVector.Y = Math.Sin(radiansPerDegree * (facingDegrees)).ToFloat();

        //implement grvaity
        velocity.Y += gravity;

        ///update the velocity if the car is accelerating
        if (isAccelerating)
        {

            Vector2 acceleration = facingVector * accelAmount;
            //if (velocity.Magnitude <= maxSpeed)//set max speed
            velocity = (acceleration * dt);

        }



        //Vector2 slidingDirection=new Vector2(-facingVector.Y, facingVector.X);
        //float slidingSpeed = velocity.Dot(slidingDirection);
        //velocity -= slidingSpeed * slidingDirection;
        //slidingSpeed *= 0.9f;
        //velocity += slidingSpeed * slidingDirection;



        //update the position
        position += velocity;



    }

    public void Draw(PictureBox pictureBox)
    {
        if (pictureBox.Image == null)
        {
            pictureBox.Image = image;

            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
        }
        RotateImage(pictureBox, image, facingDegrees);
        pictureBox.Location = new Point((int)position.X, (int)position.Y);
    }

    public void RotateImage(PictureBox pictureBox, Image _image, float angle)
    {
        if (pictureBox == null || pictureBox.Image == null)
            return;

        Image tempImage = pictureBox.Image;
        pictureBox.Image = Utilities.RotateImage(_image, angle);

        if (tempImage != null) tempImage.Dispose();
    }

    public Point ToPoint(Vector2 position)
    {
        return new Point((int)position.X, (int)position.Y);
    }

}

public static class MathExtensions
{
    public static float ToFloat(this double value)
    {
        return (float)value;
    }
}


