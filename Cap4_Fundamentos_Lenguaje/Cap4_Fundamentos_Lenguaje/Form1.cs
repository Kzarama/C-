using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap4_Fundamentos_Lenguaje
{
    public partial class FrmCap4 : Form
    {
        public FrmCap4()
        {
            InitializeComponent();
        }

        private void BtnCalcula_Click(object sender, EventArgs e)
        {
            Char Op;
            Op = this.CbxOperacion.Text.Substring(0, 1)[0];
            this.TxtOperacion.Text = TxtOp1.Text+" "+Op+" "+TxtOp2.Text+" = ";
            switch (Op.ToString())
            {
                case "+":
                    TxtResultado.Text = Convert.ToString(
                        Convert.ToDecimal(TxtOp1.Text) + Convert.ToDecimal(TxtOp2.Text));
                    break;
                default: 
                    TxtResultado.Text = "No existe operación";
                    break;
            }
        }
    }
}
