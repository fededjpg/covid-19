using Clases.ApiRest;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clases
{
    public partial class Form1 : Form
    {
        DBApi dBApi = new DBApi();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            Estado estado = new Estado
            {
                id = textId.Text
               
            };

            string json = JsonConvert.SerializeObject(estado);
            dynamic respuesta = dBApi.Delete("http://covid-19.test/api/semaforo.php", json);
            MessageBox.Show(respuesta.ToString());
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            Estado estado = new Estado
            {
                estado = txtTrabajador.Text,
                color = txtNombresPost.Text,
                casos = textCasos.Text,
                muertes = textMuertes.Text
            };

            string json = JsonConvert.SerializeObject(estado);

            dynamic respuesta = dBApi.Post("http://covid-19.test/api/semaforo.php", json);

            MessageBox.Show(respuesta.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Procesos Covid-19";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textMuertes_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Estado estado = new Estado
            {
                id = textId.Text,
                estado = txtTrabajador.Text,
                color = txtNombresPost.Text,
                casos = textCasos.Text,
                muertes = textMuertes.Text
            };

            string json = JsonConvert.SerializeObject(estado);

            dynamic respuesta = dBApi.Put("http://covid-19.test/api/semaforo.php", json);

            MessageBox.Show(respuesta.ToString());
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarM_Click(object sender, EventArgs e)
        {
            Municipio municipio = new Municipio
            {
                municipios = txtMunicipio.Text,
                casos = txtCasoM.Text,
                tasa_incidencia = txtTadaIncidencia.Text
            };

            string json = JsonConvert.SerializeObject(municipio);

            dynamic respuesta = dBApi.Post("http://covid-19.test/api/casos.php", json);

            MessageBox.Show(respuesta.ToString());
        }

        private void btnActualizarM_Click(object sender, EventArgs e)
        {
            Municipio municipio = new Municipio
            {
                id = txtIdM.Text,
                municipios = txtMunicipio.Text,
                casos = txtCasoM.Text,
                tasa_incidencia = txtTadaIncidencia.Text
            };

            string json = JsonConvert.SerializeObject(municipio);

            dynamic respuesta = dBApi.Put("http://covid-19.test/api/casos.php", json);

            MessageBox.Show(respuesta.ToString());
        }

        private void btnEliminarM_Click(object sender, EventArgs e)
        {
            Municipio municipio = new Municipio
            {
                id = txtIdM.Text
            };

            string json = JsonConvert.SerializeObject(municipio);

            dynamic respuesta = dBApi.Delete("http://covid-19.test/api/casos.php", json);

            MessageBox.Show(respuesta.ToString());
        }
    }

    public class Estado
    {
        public string id { get; set; }
        public string estado { get; set; }
        public string color { get; set; }
        public string casos { get; set; }
        public string muertes { get; set; }
    }

    public class Municipio
    {
        public string id { get; set; }
        public string municipios { get; set; }
        public string casos { get; set; }
        public string tasa_incidencia { get; set; }
    }
}

