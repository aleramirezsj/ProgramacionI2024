namespace LibrosDesktop.Views
{
    partial class AgregarEditarLibroView
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
            label1 = new Label();
            txtNombre = new TextBox();
            txtAutor = new TextBox();
            label2 = new Label();
            txtEditorial = new TextBox();
            label3 = new Label();
            txtPortadaUrl = new TextBox();
            label4 = new Label();
            txtSinopsis = new TextBox();
            label5 = new Label();
            numericPaginas = new NumericUpDown();
            label6 = new Label();
            txtGenero = new TextBox();
            label7 = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            pictureBoxPortada = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numericPaginas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPortada).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 33);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(106, 32);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(332, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(106, 71);
            txtAutor.Margin = new Padding(2);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(332, 23);
            txtAutor.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 71);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Autor:";
            // 
            // txtEditorial
            // 
            txtEditorial.Location = new Point(106, 115);
            txtEditorial.Margin = new Padding(2);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(332, 23);
            txtEditorial.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 115);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 4;
            label3.Text = "Editorial:";
            // 
            // txtPortadaUrl
            // 
            txtPortadaUrl.Location = new Point(106, 151);
            txtPortadaUrl.Margin = new Padding(2);
            txtPortadaUrl.Name = "txtPortadaUrl";
            txtPortadaUrl.Size = new Size(332, 23);
            txtPortadaUrl.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 151);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 6;
            label4.Text = "Portada Url:";
            // 
            // txtSinopsis
            // 
            txtSinopsis.Location = new Point(106, 309);
            txtSinopsis.Margin = new Padding(2);
            txtSinopsis.Multiline = true;
            txtSinopsis.Name = "txtSinopsis";
            txtSinopsis.Size = new Size(332, 53);
            txtSinopsis.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 309);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 8;
            label5.Text = "Sinopsis:";
            // 
            // numericPaginas
            // 
            numericPaginas.Location = new Point(106, 381);
            numericPaginas.Margin = new Padding(2);
            numericPaginas.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericPaginas.Name = "numericPaginas";
            numericPaginas.Size = new Size(74, 23);
            numericPaginas.TabIndex = 10;
            numericPaginas.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 381);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 11;
            label6.Text = "Páginas:";
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(106, 414);
            txtGenero.Margin = new Padding(2);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(332, 23);
            txtGenero.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 414);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 12;
            label7.Text = "Genero:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(157, 450);
            btnGuardar.Margin = new Padding(2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(78, 20);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "&Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(258, 450);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(78, 20);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pictureBoxPortada
            // 
            pictureBoxPortada.Location = new Point(201, 179);
            pictureBoxPortada.Name = "pictureBoxPortada";
            pictureBoxPortada.Size = new Size(135, 125);
            pictureBoxPortada.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPortada.TabIndex = 16;
            pictureBoxPortada.TabStop = false;
            // 
            // AgregarEditarLibroView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 481);
            Controls.Add(pictureBoxPortada);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtGenero);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(numericPaginas);
            Controls.Add(txtSinopsis);
            Controls.Add(label5);
            Controls.Add(txtPortadaUrl);
            Controls.Add(label4);
            Controls.Add(txtEditorial);
            Controls.Add(label3);
            Controls.Add(txtAutor);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "AgregarEditarLibroView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Agregar/Editar libro";
            ((System.ComponentModel.ISupportInitialize)numericPaginas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPortada).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtAutor;
        private Label label2;
        private TextBox txtEditorial;
        private Label label3;
        private TextBox txtPortadaUrl;
        private Label label4;
        private TextBox txtSinopsis;
        private Label label5;
        private NumericUpDown numericPaginas;
        private Label label6;
        private TextBox txtGenero;
        private Label label7;
        private Button btnGuardar;
        private Button btnCancelar;
        private PictureBox pictureBoxPortada;
    }
}