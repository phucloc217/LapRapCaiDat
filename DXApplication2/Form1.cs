using DXApplication2.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DXApplication2
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            Frm_THXayDungCauHinh frm = new Frm_THXayDungCauHinh();
            frm.MdiParent=this;
            frm.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }
    }
}
