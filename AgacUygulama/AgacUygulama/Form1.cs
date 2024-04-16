using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgacUygulama
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IkiliAgacDugumu kok = new IkiliAgacDugumu(4);
            kok.sag = new IkiliAgacDugumu(12);
            kok.sag.sag = new IkiliAgacDugumu(1);
            kok.sag.sol = new IkiliAgacDugumu(7);

            kok.sol = new IkiliAgacDugumu(6);
            kok.sol.sol = new IkiliAgacDugumu(45);

            kok.PreOrder(kok);
            MessageBox.Show(kok.dugumler);
            kok.dugumler = "";

            kok.InOrder(kok);
            MessageBox.Show(kok.dugumler);
            kok.dugumler = "";

            kok.PostOrder(kok);
            MessageBox.Show(kok.dugumler);
            kok.dugumler = "";


            MessageBox.Show(kok.DugumSayisi(kok).ToString());
            MessageBox.Show(kok.YaprakSayisi(kok).ToString());


        }
    }
}
