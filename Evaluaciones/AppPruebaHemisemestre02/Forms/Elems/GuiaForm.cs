using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidades.Entidades;
using Logica.Controladores;

namespace AppPruebaHemisemestre02.Forms.Elems
{
    public partial class GuiaForm : Form
    {
        private readonly GuiaLN GuiaLN = new GuiaLN();
        private readonly GuiaDetalleLN GuiaDetalleLN = new GuiaDetalleLN();
        private readonly CamionLN CamionLN = new CamionLN();
        private readonly EncomiendaLN EncomiendaLN = new EncomiendaLN();
        private AdmGuia AdmGuia { get; }
        public GuiaForm(AdmGuia adm)
        {
            InitializeComponent();
            AdmGuia = adm;
            inicializarCamiones();
        }

        private void inicializarCamiones()
        {
            try
            {
                List<Camion> lista = new List<Camion>();
                foreach (Camion item in CamionLN.Listar())
                {
                    if (item.estado.Equals("DISPONIBLE"))
                    {
                        lista.Add(item);
                    }
                }
                if (lista.Count == 0)
                {
                    MessageBox.Show("No hay camiones disponibles, ingrese uno nuevo o libere los existentes");
                    Close();
                } else
                {
                    camionSource.DataSource = lista;
                    comboCamion.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (encomiendasSource.Count > 0)
            {
                try
                {
                    Guia guia = crearGuia();
                    if (GuiaLN.Insertar(guia))
                    {
                        int idGuia = GuiaLN.Obtener(guia).id;
                        foreach (Encomiendas item in encomiendasSource)
                        {
                            GuiaDetalleLN.Insertar(new Guia_detalle(item.id, idGuia));
                            EncomiendaLN.ActualizarEstado(item.id);
                        }
                        CamionLN.ActualizarEstadoOcupado(guia.id_camion);
                    }
                    MessageBox.Show("Correctamente registrado!");
                    AdmGuia.cargarListado();
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No puede enviar generar una guia sí no hay encomiendas embarcadas!");
            }
        }

        private Guia crearGuia()
        {
            return new Guia(
                0,
                (int)comboCamion.SelectedValue,
                txtFecha.Value,
                int.Parse(txtCantEncomiendas.Text),
                decimal.Parse(txtPesoTotal.Text)
                );
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            encomiendasSource.List.Clear();
            List<Encomiendas> lista = EncomiendaLN.Listar();
            decimal pesoActual;
            decimal pesoMax = decimal.Parse(txtPesoMax.Text);
            decimal pesoAcumulado = 0;
            lista.ForEach(elem =>
            {
                if (elem.estado.Equals("EN ESPERA"))
                {
                    pesoActual = decimal.Parse(txtPesoTotal.Text);
                    if ((pesoActual + elem.peso) <= pesoMax)
                    {
                        encomiendasSource.List.Add(elem);
                    }
                }
            });
            if (encomiendasSource.Count == 0)
            {
                MessageBox.Show("No se consiguió añadir encomiendas para este camion, " + Environment.NewLine +
                    "el peso de las encomiendas en espera es muy alto o no existen encomiendas en espera.");
            }
            else
            {
                foreach (Encomiendas item in encomiendasSource.List)
                {
                    pesoAcumulado += item.peso;
                }
                txtCantEncomiendas.Text = encomiendasSource.List.Count.ToString();
                txtPesoTotal.Text = pesoAcumulado.ToString();
            }
        }

        private void comboCamion_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboCamion.SelectedItem != null)
            {
                txtPesoMax.Text = ((Camion)comboCamion.SelectedItem).peso_max.ToString();
            }
        }
    }
}
