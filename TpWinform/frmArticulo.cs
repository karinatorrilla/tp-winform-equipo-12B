﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;

namespace TpWinform
{
    public partial class frmArticulo : Form
    {
        private List<Articulo> listaArticulo;
        public frmArticulo()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("¡Gracias por usar el programa!");
        }



        // Carga el listado de lista Articulos
        private void cargar()
        {
            ListadoArticuloNegocio negocio = new ListadoArticuloNegocio();
            try
            {
                listaArticulo = negocio.Listar();
                dgvArticulos.DataSource = listaArticulo;
                dgvArticulos.Columns["Id"].Visible = false;
                dgvArticulos.Columns["Imagen"].Visible = false;
                pbImagen.Load(listaArticulo[0].Imagen.ImagenUrl);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            ///Cuando selecciono otra fila, cambia la imagen del picture box
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagenArticulo(seleccionado.Imagen.ImagenUrl);

        }

        private void cargarImagenArticulo(string imagen)
        {
            try
            {

                pbImagen.Load(imagen);
            }
            catch (Exception)
            {

                pbImagen.Load("https://t4.ftcdn.net/jpg/07/91/22/59/360_F_791225927_caRPPH99D6D1iFonkCRmCGzkJPf36QDw.jpg");


            }
        }


        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            frmAgregarArticulo alta = new frmAgregarArticulo();
            alta.ShowDialog();
            cargar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                string buscar = txtBuscar.Text;
                if (buscar.Length >= 3) // se cambia de nuevo a 3, ya no es optimo para la  DB  estar a cada rato haciendo una consulta por una sola letra
                {
                    dgvArticulos.DataSource = negocio.Filtrar(buscar);
                }
                else
                {
                    dgvArticulos.DataSource = null; // limpia el dataSource
                    cargar();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }


        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //List<Articulo> listaFiltrada;


            //string buscar = txtBuscar.Text;

            //if (buscar.Length >= 3)
            //{
            //    listaFiltrada = listaArticulo.FindAll(a => a.Nombre.ToUpper().Contains(buscar.ToUpper()));
            //}
            //else
            //{
            //    listaFiltrada = listaArticulo;
            //}

            //dgvArticulos.DataSource = null; // limpia el dataSource
            //dgvArticulos.DataSource = listaFiltrada;

        }

        //Botón de modificar artículo...
        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = new Articulo();
            //Console.WriteLine("HOLA.. "+ dgvArticulos.CurrentRow);
            try
            {

                if (dgvArticulos.CurrentRow != null)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    frmAgregarArticulo modificar = new frmAgregarArticulo(seleccionado);
                    modificar.ShowDialog();
                    cargar();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un artículo de la lista!");
                }




            }
            catch (Exception)
            {
                MessageBox.Show("Primero seleccione el articulo a modificar de la lista");
            }

        }



    }
}
