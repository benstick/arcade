using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Windows.Forms;
using System.Drawing;


class Ufo
{
    public Vector2 position;
    public Vector2 velocity;
    public Vector2 facingVector;
    public float gravity;
    public float facingDegrees;
    public float maxSpeed;

    bool isAccelerating;

    public Ufo()
    {
        facingDegrees = 270.0f;
        isAccelerating = false;
        maxSpeed = 0.0f;
        velocity = new Vector2(0.0f, 0.0f);
        gravity = 0.02f;
    }


    public void Accelerate()
    {
        isAccelerating = true;
    }

    public void Update(float dt)
    {
        facingDegrees %= 360;
        float radiansPerDegree = Math.PI.ToFloat() / 180.0f;
        facingVector.X = Math.Cos(radiansPerDegree * facingDegrees).ToFloat();
        facingVector.Y = Math.Sin(radiansPerDegree * facingDegrees).ToFloat();

        ///update the velocity if the car is accelerating
        if (isAccelerating)
        {
            float accelAmount = 100;

            Vector2 acceleration = facingVector * accelAmount;
            //if (velocity.Magnitude <= maxSpeed)//set max speed
            velocity = (acceleration * dt);

            isAccelerating = false;
        }

        //Vector2 slidingDirection=new Vector2(-facingVector.Y, facingVector.X);
        //float slidingSpeed = velocity.Dot(slidingDirection);
        //velocity -= slidingSpeed * slidingDirection;
        //slidingSpeed *= 0.9f;
        //velocity += slidingSpeed * slidingDirection;

        //update the position
        position += velocity;

        //implement grvaity
        velocity.Y += gravity;

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


