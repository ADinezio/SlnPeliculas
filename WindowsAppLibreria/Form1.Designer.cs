namespace WindowsAppLibreria
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnMostrarPorGenero = new System.Windows.Forms.Button();
            this.gridPeliculas = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.lblEliminarId = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(117, 64);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(93, 46);
            this.btnInsertar.TabIndex = 0;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(563, 193);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(91, 46);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnMostrarPorGenero
            // 
            this.btnMostrarPorGenero.Location = new System.Drawing.Point(563, 130);
            this.btnMostrarPorGenero.Name = "btnMostrarPorGenero";
            this.btnMostrarPorGenero.Size = new System.Drawing.Size(91, 46);
            this.btnMostrarPorGenero.TabIndex = 2;
            this.btnMostrarPorGenero.Text = "Mostrar por Genero";
            this.btnMostrarPorGenero.UseVisualStyleBackColor = true;
            this.btnMostrarPorGenero.Click += new System.EventHandler(this.btnMostrarPorGenero_Click);
            // 
            // gridPeliculas
            // 
            this.gridPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPeliculas.Location = new System.Drawing.Point(12, 245);
            this.gridPeliculas.Name = "gridPeliculas";
            this.gridPeliculas.Size = new System.Drawing.Size(876, 193);
            this.gridPeliculas.TabIndex = 3;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(563, 64);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(91, 46);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(286, 145);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(111, 15);
            this.lblGenero.TabIndex = 5;
            this.lblGenero.Text = "Ingresar Genero";
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(413, 144);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(100, 20);
            this.txtGenero.TabIndex = 6;
            // 
            // lblEliminarId
            // 
            this.lblEliminarId.AutoSize = true;
            this.lblEliminarId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminarId.Location = new System.Drawing.Point(250, 209);
            this.lblEliminarId.Name = "lblEliminarId";
            this.lblEliminarId.Size = new System.Drawing.Size(147, 15);
            this.lblEliminarId.TabIndex = 7;
            this.lblEliminarId.Text = "Ingresar ID a eliminar";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(413, 208);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 486);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblEliminarId);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.gridPeliculas);
            this.Controls.Add(this.btnMostrarPorGenero);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnInsertar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridPeliculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnMostrarPorGenero;
        private System.Windows.Forms.DataGridView gridPeliculas;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label lblEliminarId;
        private System.Windows.Forms.TextBox txtID;
    }
}

