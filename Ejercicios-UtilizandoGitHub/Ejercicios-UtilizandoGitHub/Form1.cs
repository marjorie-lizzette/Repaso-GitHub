using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicios_UtilizandoGitHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int kTAM = 10;
        int[] vector = new int[kTAM];

        void leerVector(int[] vector)
        {
            
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = int.Parse(Interaction.InputBox("Introduz el elemento:" + i));
                

            }
        }

        string MostrarVector(int[] vector)
        {
            string texto;
            texto = "Los elementos del vector son:\n";
            for (int i = 0; i < vector.Length; i++)
            {
                texto = texto + vector[i] + ",";
            }
            return texto;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            leerVector(vector);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
