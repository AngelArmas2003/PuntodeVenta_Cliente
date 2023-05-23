using Newtonsoft.Json;
using PuntodeVenta_Cliente.Entidades.Request;
using PuntodeVenta_Cliente.Entidades.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntodeVenta_Cliente
{
    public partial class frmPV : Form
    {
        int contador = 0;

        public frmPV()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
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


            string cadena = "21" + mm + dd + aa + hh + mi + s + txtTienda.Text + "34";
            
            txtBoleto.Text = cadena;
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


            string pro = txtproveedor.Text;

            string cadena = pro + mm + dd + aa + hh + mi + s + txttienda2.Text + "34";
          
            txtBoleto.Text = cadena;

        }

        private void button7_Click(object sender, EventArgs e)
        {

            int min = Convert.ToInt32(txtminutos.Text);

            DateTime now = DateTime.Now.AddMinutes(-min);


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

            string pro = txtproveedor.Text;
            string cadena = pro + mm + dd + aa + hh + mi + s + txttienda2.Text + "34";
            
            txtBoleto.Text = cadena;
        }

        private void button8_Click(object sender, EventArgs e)
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


            string cadena = "12" + 23 + dd + aa + hh + mi + s + txtTienda.Text + "34";

            txtBoleto.Text = cadena;
        }

        private void button6_Click(object sender, EventArgs e)
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


            string cadena = "12" + mm + dd + aa + "45" + mi + s + txtTienda.Text + "34";

            txtBoleto.Text = cadena;
        }

        private void button5_Click(object sender, EventArgs e)
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


            string cadena = "12" + mm + dd + aa + hh + mi + s + "3434" + "34";

            txtBoleto.Text = cadena;
        }

        private void button3_Click(object sender, EventArgs e)
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


            string cadena = "12" + mm + dd + aa + hh + mi + s + txtTienda.Text + "78";

            txtBoleto.Text = cadena;
        }

        private void frmPV_Load(object sender, EventArgs e)
        {
            cbAmbiente.DropDownStyle = ComboBoxStyle.DropDownList;
            Limpiar();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (txtBoleto.Text == string.Empty)
            {
                lblusuario.Text = "Escane o capture el Boleto de estacionamiento";
                lblusuario.ForeColor = Color.BlanchedAlmond;
                lblusuario.ForeColor = Color.BlueViolet;
                txtBoleto.Focus();
            }
            else
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

              var JsonRest = PostItem(txtJsonConsulta.Text);
                //var gg = JsonConvert.DeserializeObject<ValicacionModelResponseConsultaBoleto>(JsonRest);


                txtValidacion.Text = JsonRest;


                System.Net.ServicePointManager.ServerCertificateValidationCallback += delegate { return true; };
            //    PaymentServicerReference.PaymentServiceSoapClient client = new PaymentServicerReference.PaymentServiceSoapClient();
            //var consulta = txtJsonConsulta.Text;
            //txtValidacion.Text = client.consultaBoletoRequest(consulta);

            var myDeserializedClass = JsonConvert.DeserializeObject<ValicacionModelResponseConsultaBoleto>(JsonRest.ToString());

            lblId.Text=   myDeserializedClass.consultaBoleto.idBoleto;
            lblmensaje.Text= myDeserializedClass.consultaBoleto.descripcionError;


            if (myDeserializedClass.consultaBoleto.monto == "")
            {
                lblMonto.Text = "0.0";
                    //timer1.Start();
                    //timer1.Interval = 1000;
                }
            else {
                lblMonto.Text = myDeserializedClass.consultaBoleto.monto;
            }

            if (myDeserializedClass.consultaBoleto.codRepuesta == "01" && myDeserializedClass.consultaBoleto.codigoError == "03")
            {
                lblusuario.Text = " Tiene 15 minutos de tolerancia para Salir de la Plaza";
                lblusuario.ForeColor = Color.BlanchedAlmond;
                lblusuario.ForeColor = Color.BlueViolet;

                btnconfirma.Visible = false;
                btncancela.Visible = false;

                //timer1.Start();
                //timer1.Interval = 1000;
                contador = 1;
                    this.txtBoleto.Enabled = false;



                }

            if (myDeserializedClass.consultaBoleto.codRepuesta == "00" && myDeserializedClass.consultaBoleto.codigoError == "00")
            {
                lblusuario.Text = "Seleccione una opcion";
                lblusuario.ForeColor = Color.BlueViolet;
                btnconfirma.Visible = true;
                //btncancela .Visible = true;

                    this.txtBoleto.Enabled = false;

                }









            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        public  void Limpiar()
        {
            lblusuario.Text = "Escane o capture el Boleto de estacionamiento";
            lblusuario.ForeColor = Color.BlanchedAlmond;
            lblusuario.ForeColor = Color.BlueViolet;

            btnconfirma.Visible = false;
            btncancela.Visible = false;
            button10.Visible = false;
            lblId.Text = string.Empty;
            lblMonto.Text ="0.00";
            lblmensaje.Text = string.Empty;
            txtnotiBoletoPagadoPendiente.Clear();
            txtJsonConsulta.Clear();
            txtValidacion.Clear();
            txtBoleto.Clear();
           
            txtSafe.Clear();
            txtReversoRequest.Visible = false;
            txtReversoRequest.Clear();
           
            textBox7.Visible = false;
            textBox7.Clear();

            label21.Visible = false;
            label22.Visible = false;
            txtBoleto.Enabled = true;
            txtBoleto.Focus();
            btncancela.Visible = false;
            btndesconexion.Visible = false;
            txtnotiBoletoPagadoPendiente.Visible = false;
            txtSafe.Visible = false;
            label24.Visible = false;
            lblSolictar.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (contador == 4)
            {
                Limpiar();
                contador = 0;
                this.txtBoleto.Enabled = true;
                timer1.Stop();
                this.txtBoleto.Focus();
            }

            contador = contador + 1;


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btncancela_Click(object sender, EventArgs e)
        {
            label21.Text = "Json revBoletoPagadoRequest";
            txtReversoRequest.Visible = true;
            txtReversoRequest.Clear();

            textBox7.Visible = true;
            textBox7.Clear();

            label21.Visible = true;
            label22.Visible = true;
            button10.Visible = false;

            txtnotiBoletoPagadoPendiente.Clear();


            var myDeserializedClass = JsonConvert.DeserializeObject<ValicacionModelResponseConsultaBoleto>(txtValidacion.Text);


            ValicacionModelrev jsonObject = new ValicacionModelrev();
            jsonObject.revBoletoPagadoRequest = new Entidades.Request.revBoletoPagadoModal()
            {
                idBoleto = txtBoleto.Text,
                te = txtTerminal.Text,
                tr = txtTranaccion.Text,
                tda = txtTienda.Text,
                monto = myDeserializedClass.consultaBoleto.monto



            };



            txtReversoRequest.Text = JsonConvert.SerializeObject(jsonObject);



            var d = JsonConvert.DeserializeObject(txtValidacion.Text);


            PaymentServicerReference.PaymentServiceSoapClient client = new PaymentServicerReference.PaymentServiceSoapClient();
            var consulta = txtReversoRequest.Text;
            textBox7.Text = client.revBoletoPagadoRequest(consulta);


            lblusuario.Text = "Pago Cancelado";
            lblusuario.ForeColor = Color.BlanchedAlmond;
            lblusuario.ForeColor = Color.BlueViolet;
            
            //timer1.Start();
            //timer1.Interval = 1000;
            contador = 1;


            //ValicacionModelResponseConsultaBoleto jsonObjectr = new ValicacionModelResponseConsultaBoleto();




        }

        private void btnconfirma_Click(object sender, EventArgs e)
        {
            txtReversoRequest.Visible = true;
            button10.Visible = true;
            txtReversoRequest.Clear();

            textBox7.Visible = true;
            textBox7.Clear();

            label21.Visible = true;
            label22.Visible = true;



            ValicacionModelnoti jsonObject = new ValicacionModelnoti();
            jsonObject.notiBoletoPagadoRequest = new notiBoletoPagadoModal()
            {
                idBoleto = txtBoleto.Text,
                te = txtTerminal.Text,
                tr = txtTranaccion.Text,
                tda = txtTienda.Text


            };


            txtReversoRequest.Text = JsonConvert.SerializeObject(jsonObject);
            label21.Text = "Armar Json Request";

            btncancela.Visible = true;




        }

        private void button10_Click(object sender, EventArgs e)
        {

            try
            {

                var consulta = txtReversoRequest.Text;

                textBox7.Text = PostItemNoti(consulta);


                label21.Text = "Json notiBoletoPagadoRequest";

                //PaymentServicerReference.PaymentServiceSoapClient client = new PaymentServicerReference.PaymentServiceSoapClient();
              
                //client.notiBoletoPagadoRequest(consulta);



                var myDeserializedClass = JsonConvert.DeserializeObject<ValidacionnotiBoletoPagadoResponse>(textBox7.Text);

                lblId.Text = myDeserializedClass.notiBoletoPagado.idBoleto;
                lblmensaje.Text = myDeserializedClass.notiBoletoPagado.descripcionError;
                //timer1.Start();
                //timer1.Interval = 1000;
                btncancela.Visible = false;
                btndesconexion.Visible = true;
                txtnotiBoletoPagadoPendiente.Visible = true;
                txtSafe.Visible = true;
                label24.Visible = true;
                lblSolictar.Visible = true;
                lblSolictar.Text = "Si requiere Probar desconexion, solice detener el servicio de cobro al Administrador ";

            }
            catch (Exception ex)
            {
              
            }
        }

        private void txtBoleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtBoleto.Text == string.Empty)
                {
                    lblusuario.Text = "Escane o capture el Boleto de estacionamiento";
                    lblusuario.ForeColor = Color.BlanchedAlmond;
                    lblusuario.ForeColor = Color.BlueViolet;
                    txtBoleto.Focus();
                }
                else
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
                    System.Net.ServicePointManager.ServerCertificateValidationCallback += delegate { return true; };
                    PaymentServicerReference.PaymentServiceSoapClient client = new PaymentServicerReference.PaymentServiceSoapClient();
                    var consulta = txtJsonConsulta.Text;
                    txtValidacion.Text = client.consultaBoletoRequest(consulta);

                    var myDeserializedClass = JsonConvert.DeserializeObject<ValicacionModelResponseConsultaBoleto>(txtValidacion.Text);

                    lblId.Text = myDeserializedClass.consultaBoleto.idBoleto;
                    lblmensaje.Text = myDeserializedClass.consultaBoleto.descripcionError;


                    if (myDeserializedClass.consultaBoleto.monto == "")
                    {
                        lblMonto.Text = "0.0";
                        //timer1.Start();
                        //timer1.Interval = 1000;
                    }
                    else
                    {
                        lblMonto.Text = myDeserializedClass.consultaBoleto.monto;
                    }

                    if (myDeserializedClass.consultaBoleto.codRepuesta == "01" && myDeserializedClass.consultaBoleto.codigoError == "03")
                    {
                        lblusuario.Text = " Tiene 15 minutos de tolerancia para Salir de la Plaza";
                        lblusuario.ForeColor = Color.BlanchedAlmond;
                        lblusuario.ForeColor = Color.BlueViolet;

                        btnconfirma.Visible = false;
                        btncancela.Visible = false;

                        //timer1.Start();
                        //timer1.Interval = 1000;
                        contador = 1;
                        this.txtBoleto.Enabled = false;



                    }

                    if (myDeserializedClass.consultaBoleto.codRepuesta == "00" && myDeserializedClass.consultaBoleto.codigoError == "00")
                    {
                        lblusuario.Text = "Seleccione una opcion";
                        lblusuario.ForeColor = Color.BlueViolet;
                        btnconfirma.Visible = true;
                        btncancela.Visible = true;

                        this.txtBoleto.Enabled = false;



                    }







                }
            }
        }



        public void MessageSafe()


        {

            var myDeserializedClass = JsonConvert.DeserializeObject<ValidacionnotiBoletoPagadoResponse>(textBox7.Text);

          
            lblmensaje.Text = myDeserializedClass.notiBoletoPagado.descripcionError;


            string valorFace = "";

            ValicacionModelSafe jsonObject = new ValicacionModelSafe();
            jsonObject.Transaccion_ticket = new consultaSafeModal()
            {
                id_transaccion ="462",
                id_proveedor = "0",
                idboleto = myDeserializedClass.notiBoletoPagado.idBoleto,
                tienda = "",
                caja = "001",
                transaccion = "000001",
                hora_entrada = "",
                fecha_entrada = "",
                monto = "11.56",
                cod_autorizacion = "",
                cod_error = "",
                motivo = "",
                hora_cobro = "",
                fecha_cobro = "",
                duracion = "",


            };

            txtSafe.Clear();

            txtSafe.Text = JsonConvert.SerializeObject(jsonObject);

            valorFace = txtSafe.Text;

            try
            {

                PaymentServicerReference.PaymentServiceSoapClient client = new PaymentServicerReference.PaymentServiceSoapClient();
                var consulta = valorFace;

                textBox7.Text = PostItemNoti(consulta);

                //textBox7.Text = client.notiBoletoPagadoRequest(consulta);

                lblestado.Text = "Servicio Web Activo";
                lblestado.BackColor = Color.Green;

                //txtnotiBoletoPagadoPendiente.Text= client.notiBoletoPagadoRequest(consulta);

                txtnotiBoletoPagadoPendiente.Text = PostItemNoti(consulta);

                timer2.Stop();

              

            }
            catch (Exception ex)
            {

            }


        }

        private void button11_Click(object sender, EventArgs e)
        {



            var resp = MessageBox.Show("Esta detenido el Servicio?","Alerta", MessageBoxButtons.YesNo);

            if (resp==DialogResult.Yes)
            { 


            try
            {
                //PaymentServicerReference.PaymentServiceSoapClient client = new PaymentServicerReference.PaymentServiceSoapClient();
                var consulta = txtReversoRequest.Text;
                //textBox7.Text = client.notiBoletoPagadoRequest(consulta);

                    textBox7.Text = PostItemNoti(consulta);



            }
            catch (Exception ex)

            {
                lblestado.Text = "Servicio Web no Responde";
                lblestado.BackColor = Color.Red;

                timer2.Interval = 1000;
                timer2.Start();

               

            }

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            MessageSafe();


        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private  string PostItem(string data)
        {
            string url = "";

            if (cbAmbiente.Text == "DESARROLLO")
            {
                 url = $"https://www.parkauto.com.mx:8446/api/consultaBoletoRequest";
            }
            else if (cbAmbiente.Text == "PRODUCCION")
            {
                 url = $"https://www.parkauto.com.mx:8443/api/consultaBoletoRequest";
            }
            string responseBody = "";
          
        
            var request = (HttpWebRequest)WebRequest.Create(url);
            string json = data;

           var jsonrr = JsonConvert.DeserializeObject(data);

            request.Method = "POST";
            request.ContentType = "application/json";
            request.Accept = "application/json";
           


            try
            {

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        //if (strReader == null) rer;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                             responseBody = objReader.ReadToEnd();
                            // Do something with responseBody
                            Console.WriteLine(responseBody);
                            return responseBody;

                        }
                    }
                }
                return responseBody;

            }
            catch (WebException ex)
            {
                return responseBody;
            }
        }
        private string PostItemNoti(string data)
        {
            string url = "";

            if (cbAmbiente.Text == "DESARROLLO")
            {
                url = $"https://www.parkauto.com.mx:8446/api/notiBoletoPagadoRequest";
            }
            else if (cbAmbiente.Text == "PRODUCCION")
            {
                url = $"https://www.parkauto.com.mx:8443/api/notiBoletoPagadoRequest";
            }
            string responseBody = "";
            

            var request = (HttpWebRequest)WebRequest.Create(url);
            string json = data;

            var jsonrr = JsonConvert.DeserializeObject(data);

            request.Method = "POST";
            request.ContentType = "application/json";
            request.Accept = "application/json";


            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            try
            {

               

                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        //if (strReader == null) rer;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            responseBody = objReader.ReadToEnd();
                            // Do something with responseBody
                            Console.WriteLine(responseBody);
                            return responseBody;

                        }
                    }
                }
                return responseBody;

            }
            catch (WebException ex)
            {
                return responseBody;
            }
        }

        

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbAmbiente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
