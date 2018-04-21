using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Windows.Forms;


class PlayerControl
{
    public Ufo ufo = new Ufo();
    private Control _control;

    public PlayerControl()
    {
        
    }

    public PlayerControl(Control control)
    {
        _control = control;

        _control.KeyDown += ufo_KeyDown;

    }

    public void ufo_KeyDown(object sender, KeyEventArgs e)
    {
        //int ufoMoveSpeed = 1;
        if (e.KeyCode == Keys.W) ufo.Accelerate();

        if (e.KeyCode == Keys.S) ;

        if (e.KeyCode == Keys.A) ufo.facingDegrees += 2;

        if (e.KeyCode == Keys.D) ufo.facingDegrees -= 2;

        if (e.KeyCode == Keys.Escape) Application.Exit();
    }
}

