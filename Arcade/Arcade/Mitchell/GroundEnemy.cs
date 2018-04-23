using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Windows.Forms;
using System.Drawing;


class GroundEnemy:Vector2dObject
{
    public List<GroundEnemy> groundEnemies = new List<GroundEnemy>();
    public List<PictureBox> groundEnemiesPictureBoxes = new List<PictureBox>();

    public GroundEnemy()
    {
        facingDegrees = 90.0f;
        isAccelerating = false;
        velocity = new Vector2(0.0f, 0.0f);
        gravity = 0.0f;
        Health = 0;
    }

    public GroundEnemy(Vector2 _objectPos, Vector2 _targetPos, float initialSpeed, Image _Image, int health)
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
        groundEnemies.Add(new GroundEnemy(position, TargetPos, accelAmount, image, Health));
        groundEnemiesPictureBoxes.Add(new PictureBox());
    }

    public override void Update(float dt)
    {

        TargetRadians = (float)Math.Atan2(position.Y - TargetPos.Y, position.X - TargetPos.X);

        
        facingVector.X = Math.Cos(TargetRadians).ToFloat();
        //facingVector.Y = Math.Sin(TargetRadians).ToFloat();

        ///update the velocity if the car is accelerating
        if (isAccelerating)
        {

            Vector2 acceleration = facingVector * accelAmount;
            //if (velocity.Magnitude <= maxSpeed)//set max speed
            velocity.X = (acceleration.X * dt);

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

