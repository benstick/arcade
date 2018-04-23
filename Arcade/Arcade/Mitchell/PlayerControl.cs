using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Windows.Forms;
using System.Drawing;


class PlayerControl
{
    public Vector2dObject ufo = new Vector2dObject();
    public Point MousePosition;
    public List<Projectile> projectiles = new List<Projectile>();
    public List<PictureBox> projectilepictureBoxes = new List<PictureBox>();
    public void KeyBoard_KeyDown(object sender, KeyEventArgs e)
    {

        if (e.KeyCode == Keys.W) ufo.isAccelerating = true;

       // if (e.KeyCode == Keys.S) ;

        if (e.KeyCode == Keys.A) ufo.isTurnningLeft = true;

        if (e.KeyCode == Keys.D) ufo.isTurnningRight = true;

    }

    public void KeyBoard_KeyUp(object sender, KeyEventArgs e)
    {

        if (e.KeyCode == Keys.W) ufo.isAccelerating = false;

        //if (e.KeyCode == Keys.S) ;

        if (e.KeyCode == Keys.A) ufo.isTurnningLeft = false;

        if (e.KeyCode == Keys.D) ufo.isTurnningRight = false;

    }

    public float firerate;
    public bool isFiring;

    public void MouseButton_Down(object sender, MouseEventArgs e)
    {

        if (e.Button == MouseButtons.Left)
        {
            isFiring = true;
        }
    }

    public void MouseButton_Up(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            isFiring = false;
        }
    }

    public void Fire()
    {
        if (isFiring && firerate >= 0.03f)
        {
            projectiles.Add(new Projectile(
                ufo.position + (ufo._size / 2.0f),
                PointToVector2d(MousePosition),
                2000f,
                Arcade.Properties.Resources.projectile1,
                50)
                );
            projectilepictureBoxes.Add(new PictureBox());
            firerate = 0;
        }
    }

    public Vector2 PointToVector2d(Point point)
    {
        return new Vector2(point.X, point.Y);
    }
}


