using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarefa2_arvore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            List<int> numeros = txtArray.Text.Split(',').Select(c=> int.Parse(c)).ToList();
            
            int raiz = 0;
            int indiceRaiz = 0;
            List<int> nosEsquerda = new List<int>();
            List<int> nosDireita = new List<int>();

            try
            {
                raiz = numeros.Max();
                indiceRaiz = numeros.IndexOf(raiz);


                nosEsquerda.AddRange(numeros.GetRange(0, indiceRaiz).OrderByDescending(c => c));
                nosDireita.AddRange(numeros.GetRange(indiceRaiz + 1, numeros.Count - indiceRaiz - 1).OrderByDescending(c => c));


                txtRaiz.Text = raiz.ToString();
                txtNosEsquerda.Text = string.Join(",", nosEsquerda);
                txtNosDireita.Text = string.Join(",", nosDireita);

            }
            catch (Exception)
            {

                throw;
            }





}
    }
}
