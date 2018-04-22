using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Drawing;
using System.Windows.Forms;

class Projectile
{
    Vector2 facingVector;
    Vector2 velocity;
    Vector2 position;
    float TargetRadians;
    float InitialSpeed;
    public int Damage;
    Image image;


    public Projectile(Vector2 _objectPos, Vector2 _targetPos, float initialSpeed, Image _Image, int Dmg)
    {
        TargetRadians = (float)Math.Atan2(_objectPos.Y - _targetPos.Y, _objectPos.X - _targetPos.X);
        position = _objectPos;
        InitialSpeed = initialSpeed;
        Damage = Dmg;
        image = _Image;
    }

    public void Update(float dt)
    {
        facingVector.X = (float)Math.Cos(TargetRadians);
        facingVector.Y = (float)Math.Sin(TargetRadians);

        Vector2 acceleration = facingVector * InitialSpeed;
        velocity = acceleration * dt;

        position -= velocity;

    }

    public void Draw(PictureBox pictureBox)
    {
        if (pictureBox.Image == null)
        {
            pictureBox.Image = image;
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
        }
        pictureBox.Location = new Point((int)position.X, (int)position.Y);

    }

    public void RotateImage(PictureBox pictureBox, Image image, float angle)
    {
        if (pictureBox == null || pictureBox.Image == null)
            return;

        Image tempImage = pictureBox.Image;
        pictureBox.Image = Utilities.RotateImage(image, angle);

        if (tempImage != null) tempImage.Dispose();
    }

}

