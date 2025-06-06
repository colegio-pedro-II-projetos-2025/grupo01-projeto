using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoLp2.Entidade;

namespace TrabalhoLp2.Forms
{
    internal partial class MainForm: Form
    {
        
        private Usuario usuarioLogado;
        public MainForm(Usuario usuario)
        {
            usuarioLogado = usuario;
            InitializeComponent();
        }
    }
}
