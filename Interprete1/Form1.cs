using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using com.calitha.goldparser;

namespace Interprete1
{
    public partial class Form1 : Form
    {
        MyParser Parser;
        public Form1()
        {
            Parser = new MyParser(Application.StartupPath + "\\interprete1.cgt");
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            MyParser.TablaSimbolo.Clear();
            MyParser.salida = string.Empty;
            MyParser.errores = string.Empty;
            ClearType();
            lstVTabla.Items.Clear();
            Parser.Parse(txtSoftware.Text);
            for (int i=0; i < MyParser.TablaSimbolo.Count; i++)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(MyParser.TablaSimbolo[i].id), 0);
                item.SubItems.Add(Convert.ToString(MyParser.TablaSimbolo[i].tipo));
                if (MyParser.TablaSimbolo[i].tipo == "entero")
                    item.SubItems.Add(Convert.ToString(MyParser.entero[MyParser.TablaSimbolo[i].indice]));
                else if (MyParser.TablaSimbolo[i].tipo == "real")
                    item.SubItems.Add(Convert.ToString(MyParser.real[MyParser.TablaSimbolo[i].indice]));
                else if (MyParser.TablaSimbolo[i].tipo == "cadena")
                    item.SubItems.Add(MyParser.cadena[MyParser.TablaSimbolo[i].indice]);
                else if (MyParser.TablaSimbolo[i].tipo == "caracter")
                    item.SubItems.Add(Convert.ToString(MyParser.caracter[MyParser.TablaSimbolo[i].indice]));
                lstVTabla.Items.Add(item);
            }
            txtSalida.Text = MyParser.salida;
        }
        public void ClearType()
        {
            for (int i = 0; i < MyParser.entero.Length; i++) MyParser.entero[i] = 0;
            for (int i = 0; i < MyParser.real.Length; i++) MyParser.real[i] = 0.0;
            for (int i = 0; i < MyParser.cadena.Length; i++) MyParser.cadena[i] = "";
            for (int i = 0; i < MyParser.caracter.Length; i++) MyParser.caracter[i] = ' ';
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtSoftware.Text = string.Empty;
            txtSalida.Text = string.Empty;
            txtErrores.Text = string.Empty;
            lstVTabla.Items.Clear();
        }
    }
}
