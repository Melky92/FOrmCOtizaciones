namespace FOrmCOtizaciones
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
            this.dataGridViewDatos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelTotalMonto = new System.Windows.Forms.Label();
            this.buttonMaximo = new System.Windows.Forms.Button();
            this.buttonMinimo = new System.Windows.Forms.Button();
            this.labelAnual = new System.Windows.Forms.Label();
            this.labelAnualMonto = new System.Windows.Forms.Label();
            this.buttonRecomendado = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.labelReducido = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDatos
            // 
            this.dataGridViewDatos.AllowUserToAddRows = false;
            this.dataGridViewDatos.AllowUserToDeleteRows = false;
            this.dataGridViewDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewDatos.Location = new System.Drawing.Point(15, 15);
            this.dataGridViewDatos.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dataGridViewDatos.Name = "dataGridViewDatos";
            this.dataGridViewDatos.RowHeadersVisible = false;
            this.dataGridViewDatos.Size = new System.Drawing.Size(731, 742);
            this.dataGridViewDatos.TabIndex = 0;
            this.dataGridViewDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDatos_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 77;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Detalle";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 104;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            this.Column3.Width = 98;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Escogido";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column4.Width = 126;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(112, 124);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(83, 31);
            this.labelTotal.TabIndex = 1;
            this.labelTotal.Text = "Total:";
            // 
            // labelTotalMonto
            // 
            this.labelTotalMonto.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelTotalMonto.Location = new System.Drawing.Point(261, 123);
            this.labelTotalMonto.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTotalMonto.Name = "labelTotalMonto";
            this.labelTotalMonto.Size = new System.Drawing.Size(109, 39);
            this.labelTotalMonto.TabIndex = 2;
            this.labelTotalMonto.Text = "10000,00";
            this.labelTotalMonto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonMaximo
            // 
            this.buttonMaximo.Location = new System.Drawing.Point(351, 399);
            this.buttonMaximo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonMaximo.Name = "buttonMaximo";
            this.buttonMaximo.Size = new System.Drawing.Size(300, 50);
            this.buttonMaximo.TabIndex = 3;
            this.buttonMaximo.Text = "Costo Máximo";
            this.buttonMaximo.UseVisualStyleBackColor = true;
            this.buttonMaximo.Click += new System.EventHandler(this.buttonMaximo_Click);
            // 
            // buttonMinimo
            // 
            this.buttonMinimo.Location = new System.Drawing.Point(351, 337);
            this.buttonMinimo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonMinimo.Name = "buttonMinimo";
            this.buttonMinimo.Size = new System.Drawing.Size(300, 50);
            this.buttonMinimo.TabIndex = 4;
            this.buttonMinimo.Text = "Costo Mínimo";
            this.buttonMinimo.UseVisualStyleBackColor = true;
            this.buttonMinimo.Click += new System.EventHandler(this.buttonMinimo_Click);
            // 
            // labelAnual
            // 
            this.labelAnual.AutoSize = true;
            this.labelAnual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnual.Location = new System.Drawing.Point(112, 177);
            this.labelAnual.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelAnual.Name = "labelAnual";
            this.labelAnual.Size = new System.Drawing.Size(91, 31);
            this.labelAnual.TabIndex = 5;
            this.labelAnual.Text = "Anual:";
            // 
            // labelAnualMonto
            // 
            this.labelAnualMonto.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelAnualMonto.Location = new System.Drawing.Point(260, 176);
            this.labelAnualMonto.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelAnualMonto.Name = "labelAnualMonto";
            this.labelAnualMonto.Size = new System.Drawing.Size(110, 39);
            this.labelAnualMonto.TabIndex = 6;
            this.labelAnualMonto.Text = "10000,00";
            this.labelAnualMonto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonRecomendado
            // 
            this.buttonRecomendado.Location = new System.Drawing.Point(351, 461);
            this.buttonRecomendado.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonRecomendado.Name = "buttonRecomendado";
            this.buttonRecomendado.Size = new System.Drawing.Size(300, 50);
            this.buttonRecomendado.TabIndex = 7;
            this.buttonRecomendado.Text = "Recomendado";
            this.buttonRecomendado.UseVisualStyleBackColor = true;
            this.buttonRecomendado.Click += new System.EventHandler(this.buttonRecomendado_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(118, 304);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(200, 40);
            this.buttonGuardar.TabIndex = 8;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // labelReducido
            // 
            this.labelReducido.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelReducido.Location = new System.Drawing.Point(560, 241);
            this.labelReducido.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelReducido.Name = "labelReducido";
            this.labelReducido.Size = new System.Drawing.Size(165, 39);
            this.labelReducido.TabIndex = 11;
            this.labelReducido.Text = "10000,00";
            this.labelReducido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelReducido.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(469, 252);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Reducido:";
            this.label4.Visible = false;
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(118, 252);
            this.buttonCargar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(200, 40);
            this.buttonCargar.TabIndex = 13;
            this.buttonCargar.Text = "Cargar";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 640);
            this.Controls.Add(this.labelReducido);
            this.Controls.Add(this.labelAnualMonto);
            this.Controls.Add(this.labelAnual);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonRecomendado);
            this.Controls.Add(this.buttonMinimo);
            this.Controls.Add(this.buttonMaximo);
            this.Controls.Add(this.labelTotalMonto);
            this.Controls.Add(this.dataGridViewDatos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDatos;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelTotalMonto;
        private System.Windows.Forms.Button buttonMaximo;
        private System.Windows.Forms.Button buttonMinimo;
        private System.Windows.Forms.Label labelAnual;
        private System.Windows.Forms.Label labelAnualMonto;
        private System.Windows.Forms.Button buttonRecomendado;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label labelReducido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
    }
}

