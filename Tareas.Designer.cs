namespace Transacciones_en_ADO.NET
{
    partial class Tareas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.grTareas = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAnularTarea = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estado de Tareas";
            // 
            // grTareas
            // 
            this.grTareas.AllowUserToAddRows = false;
            this.grTareas.AllowUserToDeleteRows = false;
            this.grTareas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grTareas.ColumnHeadersVisible = false;
            this.grTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Hora,
            this.Usuario,
            this.Estado});
            this.grTareas.Location = new System.Drawing.Point(12, 82);
            this.grTareas.Name = "grTareas";
            this.grTareas.ReadOnly = true;
            this.grTareas.RowHeadersVisible = false;
            this.grTareas.Size = new System.Drawing.Size(659, 211);
            this.grTareas.TabIndex = 1;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // btnAnularTarea
            // 
            this.btnAnularTarea.Location = new System.Drawing.Point(356, 311);
            this.btnAnularTarea.Name = "btnAnularTarea";
            this.btnAnularTarea.Size = new System.Drawing.Size(109, 40);
            this.btnAnularTarea.TabIndex = 2;
            this.btnAnularTarea.Text = "Anular Tarea";
            this.btnAnularTarea.UseVisualStyleBackColor = true;
            this.btnAnularTarea.Click += new System.EventHandler(this.btnAnularTarea_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(483, 311);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(109, 40);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Tareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 374);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAnularTarea);
            this.Controls.Add(this.grTareas);
            this.Controls.Add(this.label1);
            this.Name = "Tareas";
            this.Text = "Tareas";
            this.Load += new System.EventHandler(this.Tareas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grTareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grTareas;
        private System.Windows.Forms.Button btnAnularTarea;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}