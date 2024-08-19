using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMaiorValorVetor
{
    public partial class MaiorValor : Form
    {
        public MaiorValor()
        {
            InitializeComponent();
        }

        int[] numeros = new int[4];
        int index = 0, aux = 0;

        private void btnMostar_Click(object sender, EventArgs e)
        {
            if (index < 4)
            {
                MessageBox.Show("Digite todos os valores no vetor");
            }
            else
            {
                listNumero.Items.Clear();

                for (int i = 0; i < numeros.Length; i++)
                {
                    if (numeros[i] > aux)
                    {
                        aux = numeros[i];
                    }
                }

                listNumero.Items.Add(aux);
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumero.Text) == false)
            {
                if (index < numeros.Length)
                {
                    numeros[index] = int.Parse(txtNumero.Text);
                    index++;

                    if (index == numeros.Length)
                    {
                        btnAdd.Enabled = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Digite algum valor!");
            }
            txtNumero.Text = null;
        }
    }
}
