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
            this.label1 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonMaximo = new System.Windows.Forms.Button();
            this.buttonMinimo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAnual = new System.Windows.Forms.Label();
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
            this.dataGridViewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewDatos.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewDatos.Name = "dataGridViewDatos";
            this.dataGridViewDatos.Size = new System.Drawing.Size(409, 536);
            this.dataGridViewDatos.TabIndex = 0;
            this.dataGridViewDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDatos_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 30;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Detalle";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            this.Column3.Width = 50;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Escogido";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column4.Width = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total:";
            // 
            // labelTotal
            // 
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelTotal.Location = new System.Drawing.Point(506, 227);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(83, 20);
            this.labelTotal.TabIndex = 2;
            this.labelTotal.Text = "10000,00";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonMaximo
            // 
            this.buttonMaximo.Location = new System.Drawing.Point(427, 41);
            this.buttonMaximo.Name = "buttonMaximo";
            this.buttonMaximo.Size = new System.Drawing.Size(162, 23);
            this.buttonMaximo.TabIndex = 3;
            this.buttonMaximo.Text = "Costo Máximo";
            this.buttonMaximo.UseVisualStyleBackColor = true;
            this.buttonMaximo.Click += new System.EventHandler(this.buttonMaximo_Click);
            // 
            // buttonMinimo
            // 
            this.buttonMinimo.Location = new System.Drawing.Point(427, 12);
            this.buttonMinimo.Name = "buttonMinimo";
            this.buttonMinimo.Size = new System.Drawing.Size(162, 23);
            this.buttonMinimo.TabIndex = 4;
            this.buttonMinimo.Text = "Costo Mínimo";
            this.buttonMinimo.UseVisualStyleBackColor = true;
            this.buttonMinimo.Click += new System.EventHandler(this.buttonMinimo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Anual:";
            // 
            // labelAnual
            // 
            this.labelAnual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnual.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelAnual.Location = new System.Drawing.Point(506, 288);
            this.labelAnual.Name = "labelAnual";
            this.labelAnual.Size = new System.Drawing.Size(83, 20);
            this.labelAnual.TabIndex = 6;
            this.labelAnual.Text = "10000,00";
            this.labelAnual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonRecomendado
            // 
            this.buttonRecomendado.Location = new System.Drawing.Point(427, 70);
            this.buttonRecomendado.Name = "buttonRecomendado";
            this.buttonRecomendado.Size = new System.Drawing.Size(162, 23);
            this.buttonRecomendado.TabIndex = 7;
            this.buttonRecomendado.Text = "Recomendado";
            this.buttonRecomendado.UseVisualStyleBackColor = true;
            this.buttonRecomendado.Click += new System.EventHandler(this.buttonRecomendado_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(431, 496);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(158, 23);
            this.buttonGuardar.TabIndex = 8;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // labelReducido
            // 
            this.labelReducido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReducido.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelReducido.Location = new System.Drawing.Point(506, 256);
            this.labelReducido.Name = "labelReducido";
            this.labelReducido.Size = new System.Drawing.Size(83, 20);
            this.labelReducido.TabIndex = 11;
            this.labelReducido.Text = "10000,00";
            this.labelReducido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(427, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Reducido:";
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(431, 525);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(158, 23);
            this.buttonCargar.TabIndex = 13;
            this.buttonCargar.Text = "Cargar";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 560);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelReducido);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonRecomendado);
            this.Controls.Add(this.labelAnual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonMinimo);
            this.Controls.Add(this.buttonMaximo);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonMaximo;
        private System.Windows.Forms.Button buttonMinimo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAnual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.Button buttonRecomendado;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label labelReducido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCargar;
    }
}

