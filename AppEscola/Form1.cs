using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscola
{
    public partial class FrmPrincipal : Form
    {
        //variaveis global
        float n1, n2, n3, n4, media;

       
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            dtData.Text = DateTime.Now.ToString();
            lblNome.Text = Program.usuario;
        }
        public void resultado()
        {
            n1 = float.Parse(txtNota1.Text);
            n2 = float.Parse(txtNota2.Text);
            n3 = float.Parse(txtNota3.Text);
            n4 = float.Parse(txtNota4.Text);

            media = (n1 + n2 + n3 + n4) / 4;

            lblResMedia.Text = media.ToString();
        }
        public void mediaAluno()
        {
          if (media < 7)
            {
                lblStatus.Text = "Reprovado";
            }
          else if (media == 7)
            {
                lblStatus.Text = "Aprovando com o minimo";
            }
          else if (media > 7)
            {
                lblStatus.Text = "Aprovado, parabéns";
            }
          
        }

        private void btnExecultar_Click(object sender, EventArgs e)
        {
            resultado();
            mediaAluno();
        }

    }
}
