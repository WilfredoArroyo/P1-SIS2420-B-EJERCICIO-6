using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio2
{
    public partial class Frm_P6 : Form
    {
        public Frm_P6()
        {
            InitializeComponent();
        } 
        private void frm_programa_Load(object sender, EventArgs e)
        {
            Cbbox_operaciones.Items.Add("NUMEROS PRIMOS");
            Cbbox_operaciones.Items.Add("NUMEROS PERFECTOS");
            Cbbox_operaciones.Items.Add("SERIE FIBONACCI");


        }

        private void btn_genenar_Click(object sender, EventArgs e)
        {
            lbx_num.Items.Clear();
            int Cantidad = Convert.ToInt32(txt_numero.Text);
            string Elegir = Cbbox_operaciones.Text;
            if (Elegir == "NUMEROS PRIMOS")
            {
                int cont = 0;
                while(cont < Cantidad)
                for (int i = 2; i <= 100000; i++)
                {
                    bool esPrimo = true;
                    
                    for (int j = 2; j <= Math.Sqrt(i); j++)
                    {
                        if (i % j == 0)
                        {
                            esPrimo = false;
                            break;
                        }
                    }

                    if (esPrimo)
                    {
                        lbx_num.Items.Add(i);
                            cont++;
                            if (cont == Cantidad)
                            {
                                i = 1000000;
                            }
                    }
                    
                }
            }
            
            if (Elegir == "NUMEROS PERFECTOS")
            {
                int num = 0;
                int cont = 0;
                while (num < 1000000)
                {
                    if (esPerfecto(num))
                    {
                        lbx_num.Items.Add(num);

                        cont++;
                        if (cont == Cantidad) 
                        {
                            num = 1000000;
                        }
                    }
                    num++;
                }
            }
            if (Elegir == "SERIE FIBONACCI")
            {
                int v1 = 0;
                int v2 = 1;

                for (int i = 0; i < Cantidad; i++)
                {
                    int temp = v1;

                    v1 = v2;
                    v2 = temp + v1;
                    lbx_num.Items.Add(v2);
                }
            }

        }

        static bool esPerfecto(int n)
        {
            int suma = 0;
            int i = 1;
            while (i < n)
            {
                if (n % i == 0) 
                {
                    suma += i;
                    if (suma > n) return false;
                }
                i++;
            }
            return (suma == n);
        }
    }
}
