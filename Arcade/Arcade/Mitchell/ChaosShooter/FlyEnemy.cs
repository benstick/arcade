using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Numerics;


class FlyEnemy : Vector2dObject
{
    public List<FlyEnemy> flyEnemies = new List<FlyEnemy>();
    public List<PictureBox> flyEnemiesPictureBoxes = new List<PictureBox>();

    public FlyEnemy()
    {
        facingDegrees = 0.0f;
        isAccelerating = false;
        velocity = new Vector2(0.0f, 0.0f);
        gravity = 0.0f;
        Health = 0;
    }

    public FlyEnemy(Vector2 _objectPos, Vector2 _targetPos, float initialSpeed, Image _Image, int health)
    {
        position = _objectPos;
        TargetRadians = (float)Math.Atan2(_objectPos.Y - _targetPos.Y, _objectPos.X - _targetPos.X);
        accelAmount = initialSpeed;
        image = _Image;
        isAccelerating = true;
        Health = health;
    }

    public void CreateEnemy()
    {
        flyEnemies.Add(new FlyEnemy(position, TargetPos, accelAmount, image, Health));
        flyEnemiesPictureBoxes.Add(new PictureBox());
    }

    public override void Update(float dt)
    {
        TargetRadians = (float)Math.Atan2(position.Y - TargetPos.Y, position.X - TargetPos.X);
        facingDegrees = TargetRadians * (180.0f / Math.PI.ToFloat()) - 180.0f;
        facingVector.X = Math.Cos(TargetRadians).ToFloat();
        facingVector.Y = Math.Sin(TargetRadians).ToFloat();

        ///update the velocity if the car is accelerating
        if (isAccelerating)
        {

            Vector2 acceleration = facingVector * accelAmount;
            //if (velocity.Magnitude <= maxSpeed)//set max speed
            velocity = (acceleration * dt);

        }
        //update the position
        position -= velocity;

    }

    public void Fire(List<Projectile> pj, List<PictureBox> pjpb)
    {
        if (isFiring && firerate >= 1.0f)
        {
            pj.Add(new Projectile(
                position,
                TargetPos,
                500.0f,
                Arcade.Properties.Resources.projectile1,
                1)
                );
            pjpb.Add(new PictureBox());
            firerate = 0;
        }
    }

}

