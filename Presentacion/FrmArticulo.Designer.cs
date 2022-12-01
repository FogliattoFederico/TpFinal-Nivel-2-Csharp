namespace Presentacion
{
    partial class FrmArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArticulo));
            this.dgvArticulo = new System.Windows.Forms.DataGridView();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tlsAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsEliminar = new System.Windows.Forms.ToolStripButton();
            this.lbCampo = new System.Windows.Forms.Label();
            this.lbCriterio = new System.Windows.Forms.Label();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.cbxCampo = new System.Windows.Forms.ComboBox();
            this.cbxCriterio = new System.Windows.Forms.ComboBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulo
            // 
            this.dgvArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArticulo.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.dgvArticulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArticulo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvArticulo.Location = new System.Drawing.Point(22, 55);
            this.dgvArticulo.MultiSelect = false;
            this.dgvArticulo.Name = "dgvArticulo";
            this.dgvArticulo.ReadOnly = true;
            this.dgvArticulo.RowHeadersWidth = 62;
            this.dgvArticulo.RowTemplate.Height = 28;
            this.dgvArticulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulo.Size = new System.Drawing.Size(978, 418);
            this.dgvArticulo.TabIndex = 0;
            this.dgvArticulo.SelectionChanged += new System.EventHandler(this.dgvArticulo_SelectionChanged);
            // 
            // pbImagen
            // 
            this.pbImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImagen.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pbImagen.Location = new System.Drawing.Point(1031, 55);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(439, 418);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 1;
            this.pbImagen.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsAgregar,
            this.toolStripButton2,
            this.tlsModificar,
            this.toolStripButton1,
            this.tlsEliminar,
            this.toolStripSeparator1,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1499, 34);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tlsAgregar
            // 
            this.tlsAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tlsAgregar.Image = ((System.Drawing.Image)(resources.GetObject("tlsAgregar.Image")));
            this.tlsAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsAgregar.Name = "tlsAgregar";
            this.tlsAgregar.Size = new System.Drawing.Size(80, 29);
            this.tlsAgregar.Text = "&Agregar";
            this.tlsAgregar.Click += new System.EventHandler(this.tlsAgregar_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(6, 38);
            // 
            // tlsModificar
            // 
            this.tlsModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tlsModificar.Image = ((System.Drawing.Image)(resources.GetObject("tlsModificar.Image")));
            this.tlsModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsModificar.Name = "tlsModificar";
            this.tlsModificar.Size = new System.Drawing.Size(91, 33);
            this.tlsModificar.Text = "&Modificar";
            this.tlsModificar.Click += new System.EventHandler(this.tlsModificar_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(6, 38);
            // 
            // tlsEliminar
            // 
            this.tlsEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tlsEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tlsEliminar.Image")));
            this.tlsEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsEliminar.Name = "tlsEliminar";
            this.tlsEliminar.Size = new System.Drawing.Size(78, 33);
            this.tlsEliminar.Text = "&Eliminar";
            this.tlsEliminar.Click += new System.EventHandler(this.tlsEliminar_Click);
            // 
            // lbCampo
            // 
            this.lbCampo.AutoSize = true;
            this.lbCampo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCampo.Location = new System.Drawing.Point(18, 523);
            this.lbCampo.Name = "lbCampo";
            this.lbCampo.Size = new System.Drawing.Size(76, 25);
            this.lbCampo.TabIndex = 4;
            this.lbCampo.Text = "Campo";
            // 
            // lbCriterio
            // 
            this.lbCriterio.AutoSize = true;
            this.lbCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCriterio.Location = new System.Drawing.Point(381, 523);
            this.lbCriterio.Name = "lbCriterio";
            this.lbCriterio.Size = new System.Drawing.Size(74, 25);
            this.lbCriterio.TabIndex = 5;
            this.lbCriterio.Text = "Criterio";
            // 
            // lbFiltro
            // 
            this.lbFiltro.AutoSize = true;
            this.lbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltro.Location = new System.Drawing.Point(749, 523);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(54, 25);
            this.lbFiltro.TabIndex = 6;
            this.lbFiltro.Text = "Filtro";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.Location = new System.Drawing.Point(1102, 512);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(169, 43);
            this.BtnBuscar.TabIndex = 7;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // cbxCampo
            // 
            this.cbxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCampo.FormattingEnabled = true;
            this.cbxCampo.Location = new System.Drawing.Point(142, 519);
            this.cbxCampo.Name = "cbxCampo";
            this.cbxCampo.Size = new System.Drawing.Size(169, 28);
            this.cbxCampo.TabIndex = 8;
            this.cbxCampo.SelectedIndexChanged += new System.EventHandler(this.cbxCampo_SelectedIndexChanged);
            // 
            // cbxCriterio
            // 
            this.cbxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCriterio.FormattingEnabled = true;
            this.cbxCriterio.Location = new System.Drawing.Point(510, 519);
            this.cbxCriterio.Name = "cbxCriterio";
            this.cbxCriterio.Size = new System.Drawing.Size(169, 28);
            this.cbxCriterio.TabIndex = 9;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(863, 520);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(169, 26);
            this.txtFiltro.TabIndex = 10;
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(76, 33);
            this.toolStripButton3.Text = "A&cerca..";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // FrmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1499, 595);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.cbxCriterio);
            this.Controls.Add(this.cbxCampo);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.lbFiltro);
            this.Controls.Add(this.lbCriterio);
            this.Controls.Add(this.lbCampo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.dgvArticulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.FrmArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulo;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tlsAgregar;
        private System.Windows.Forms.ToolStripSeparator toolStripButton2;
        private System.Windows.Forms.ToolStripButton tlsModificar;
        private System.Windows.Forms.ToolStripSeparator toolStripButton1;
        private System.Windows.Forms.ToolStripButton tlsEliminar;
        private System.Windows.Forms.Label lbCampo;
        private System.Windows.Forms.Label lbCriterio;
        private System.Windows.Forms.Label lbFiltro;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.ComboBox cbxCampo;
        private System.Windows.Forms.ComboBox cbxCriterio;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}

