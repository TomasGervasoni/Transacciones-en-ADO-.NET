﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Transacciones_en_ADO.NET
{
    public partial class Tareas : Form
    {
        public Tareas()
        {
            InitializeComponent();
        }

        private void Tareas_Load(object sender, EventArgs e)
        {
            CargarTareas();
        }
        private void CargarTareas()
        {
            grTareas.Rows.Clear();
            // cargar la grilla con los datos de las tareas
            String[] Estados = new String[3] { "Pendiente", "Terminada", "Anulada"};

            CUsuario usr = new CUsuario();
            CTarea tarea = new CTarea();
            DataTable TablaTarea = tarea.GetTareas();
            foreach (DataRow dr in TablaTarea.Rows)
            {
                String Nombre = usr.GetUsuario((int)dr["usuario"]);
                grTareas.Rows.Add(dr["Fecha"].ToString().Substring(0, 10),
                dr["Hora"].ToString(),
                Nombre, Estados[(int)dr["Estado"]]);
            }
        }

        private void btnAnularTarea_Click(object sender, EventArgs e)
        {
            if (grTareas.SelectedRows.Count == 1)
            {
                try
                {
                    DateTime fecha =
                    DateTime.Parse(grTareas.SelectedRows[0].Cells[0].Value.ToString());
                    String hora =
                    grTareas.SelectedRows[0].Cells[1].Value.ToString();
                    CTarea tarea = new CTarea();
                    tarea.AnularTarea(fecha, hora);
                    CargarTareas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una tarea para anular");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
