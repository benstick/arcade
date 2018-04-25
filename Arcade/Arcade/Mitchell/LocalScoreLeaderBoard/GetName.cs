using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public partial class GetName : Form
{
    public string UserName = null;
    public bool done=false;

        public GetName()
    {
        InitializeComponent();
    }

    private void OK_Click(object sender, EventArgs e)
    {
        UserName = GetTitle.Text;
        done = true;
    }
}

