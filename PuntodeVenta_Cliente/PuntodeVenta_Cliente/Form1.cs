using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using PuntodeVenta_Cliente.Entidades.Request;


namespace PuntodeVenta_Cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



            ValicacionModel jsonObject = new ValicacionModel();
            jsonObject.consultaBoletoRequest = new consultaBoletoModal()
            {
                idBoleto = txtBoleto.Text,
                te = txtTerminal.Text,
                tr = txtTranaccion.Text,
                tda = txtTienda.Text
                

            };

         



            txtJsonConsulta.Text = JsonConvert.SerializeObject(jsonObject);

        }

        private void button2_Click(object sender, EventArgs e)
        {   

            PaymentServicerReference.PaymentServiceSoapClient client = new PaymentServicerReference.PaymentServiceSoapClient();
            var consulta = txtJsonConsulta.Text;
             txtValidacion.Text=   client.consultaBoletoRequest(consulta);
        }









        private void RbIdBoletoOK_CheckedChanged(object sender, EventArgs e)
        {
            txtBoleto.Text = textBox1.Text;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            txtBoleto.Text = textBox2.Text;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            txtBoleto.Text = textBox3.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtBoleto.Text = textBox4.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtBoleto.Text = textBox5.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtBoleto.Text = textBox6.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RbIdBoletoOK.Checked = true;
            txtBoleto.Text = "12071121111230557234";
        }

        private void button4_Click(object sender, EventArgs e)
        {

            DateTime now = DateTime.Now;


            string dd = now.Day.ToString();
            if (dd.Length == 1)
            {
                dd = "0" + dd;
            }


            string mm = now.Month.ToString();

            if (mm.Length == 1)
            {
                mm = "0" + mm;
            }
            string aa = now.Year.ToString();

            aa = aa.Substring(2, 2);

            string hh = now.Hour.ToString();
            if (hh.Length == 1)
            {
                hh = "0" + hh;
            }



            string mi = now.Minute.ToString();

            if (mi.Length == 1)
            {
                mi = "0" + mi;
            }


            string s = now.Second.ToString();
            if (s.Length == 1)
            {
                s = "0" + s;
            }


            string cadena = "12" + mm + dd + aa + hh + mi + s + txtTienda.Text + "34";
            textBox1.Text = cadena;
            txtBoleto.Text = cadena; 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ValicacionModelrev jsonObject = new ValicacionModelrev();
            jsonObject.revBoletoPagadoRequest = new revBoletoPagadoModal()
            {
                idBoleto = txtBoleto.Text,
                te = txtTerminal.Text,
                tr = txtTranaccion.Text,
                tda = txtTienda.Text,
                monto = "120.00"
               


            };

         

            txtReversoRequest.Text = JsonConvert.SerializeObject(jsonObject);

          

            var d = JsonConvert.DeserializeObject(txtValidacion.Text);

           



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            PaymentServicerReference.PaymentServiceSoapClient client = new PaymentServicerReference.PaymentServiceSoapClient();
            var consulta = txtReversoRequest.Text;
            textBox7.Text = client.revBoletoPagadoRequest(consulta);
        }

        private void button7_Click(object sender, EventArgs e)
        {

            DateTime now = DateTime.Now.AddMinutes(-17);


            string dd = now.Day.ToString();
            if (dd.Length == 1)
            {
                dd = "0" + dd;
            }


            string mm = now.Month.ToString();

            if (mm.Length == 1)
            {
                mm = "0" + mm;
            }
            string aa = now.Year.ToString();

            aa = aa.Substring(2, 2);

            string hh = now.Hour.ToString();
            if (hh.Length == 1)
            {
                hh = "0" + hh;
            }



            string mi = now.Minute.ToString();

            if (mi.Length == 1)
            {
                mi = "0" + mi;
            }


            string s = now.Second.ToString();
            if (s.Length == 1)
            {
                s = "0" + s;
            }


            string cadena = "12" + mm + dd + aa + hh + mi + s + txtTienda.Text + "34";
            textBox1.Text = cadena;
            txtBoleto.Text = cadena;
        }
    }
}

