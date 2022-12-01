namespace Presentacion
{
    partial class FrmAltaArticulo
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
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbImagen = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.txbImagen = new System.Windows.Forms.TextBox();
            this.txbPrecio = new System.Windows.Forms.TextBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(41, 25);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(59, 20);
            this.lbCodigo.TabIndex = 0;
            this.lbCodigo.Text = "Codigo";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(41, 91);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(65, 20);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(41, 157);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(92, 20);
            this.lbDescripcion.TabIndex = 2;
            this.lbDescripcion.Text = "Descripcion";
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Location = new System.Drawing.Point(41, 223);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(53, 20);
            this.lbMarca.TabIndex = 3;
            this.lbMarca.Text = "Marca";
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(41, 289);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(78, 20);
            this.lbCategoria.TabIndex = 4;
            this.lbCategoria.Text = "Categoria";
            // 
            // lbImagen
            // 
            this.lbImagen.AutoSize = true;
            this.lbImagen.Location = new System.Drawing.Point(41, 355);
            this.lbImagen.Name = "lbImagen";
            this.lbImagen.Size = new System.Drawing.Size(63, 20);
            this.lbImagen.TabIndex = 5;
            this.lbImagen.Text = "Imagen";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(41, 421);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(53, 20);
            this.lbPrecio.TabIndex = 6;
            this.lbPrecio.Text = "Precio";
            // 
            // txbCodigo
            // 
            this.txbCodigo.Location = new System.Drawing.Point(212, 25);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(121, 26);
            this.txbCodigo.TabIndex = 0;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(212, 84);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(121, 26);
            this.txbNombre.TabIndex = 1;
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Location = new System.Drawing.Point(212, 150);
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(121, 26);
            this.txbDescripcion.TabIndex = 2;
            // 
            // txbImagen
            // 
            this.txbImagen.Location = new System.Drawing.Point(212, 349);
            this.txbImagen.Name = "txbImagen";
            this.txbImagen.Size = new System.Drawing.Size(121, 26);
            this.txbImagen.TabIndex = 5;
            this.txbImagen.Leave += new System.EventHandler(this.txbImagen_Leave);
            // 
            // txbPrecio
            // 
            this.txbPrecio.Location = new System.Drawing.Point(212, 415);
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.Size = new System.Drawing.Size(121, 26);
            this.txbPrecio.TabIndex = 6;
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(212, 214);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(121, 28);
            this.cboMarca.TabIndex = 3;
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(212, 289);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 28);
            this.cboCategoria.TabIndex = 4;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(161, 519);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(163, 69);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(458, 519);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(163, 69);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxArticulo.Location = new System.Drawing.Point(404, 25);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(374, 416);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 17;
            this.pbxArticulo.TabStop = false;
            // 
            // FrmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 695);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.txbPrecio);
            this.Controls.Add(this.txbImagen);
            this.Controls.Add(this.txbDescripcion);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.txbCodigo);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbImagen);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaArticulo";
            this.Load += new System.EventHandler(this.FrmAltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Label lbImagen;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.TextBox txbImagen;
        private System.Windows.Forms.TextBox txbPrecio;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pbxArticulo;
    }
}