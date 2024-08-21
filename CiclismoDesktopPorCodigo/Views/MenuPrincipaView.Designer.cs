namespace CiclismoDesktopPorCodigo
{
    partial class MenuPrincipalView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            principalToolStripMenuItem = new ToolStripMenuItem();
            gestionarClientesToolStripMenuItem = new ToolStripMenuItem();
            gestionarClientesStoredProceduresToolStripMenuItem = new ToolStripMenuItem();
            gestionarClientesORMToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            salirDelSistemaToolStripMenuItem = new ToolStripMenuItem();
            pruebasConLinqToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { principalToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // principalToolStripMenuItem
            // 
            principalToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gestionarClientesToolStripMenuItem, gestionarClientesStoredProceduresToolStripMenuItem, gestionarClientesORMToolStripMenuItem, pruebasConLinqToolStripMenuItem });
            principalToolStripMenuItem.Name = "principalToolStripMenuItem";
            principalToolStripMenuItem.Size = new Size(94, 29);
            principalToolStripMenuItem.Text = "Principal";
            // 
            // gestionarClientesToolStripMenuItem
            // 
            gestionarClientesToolStripMenuItem.Name = "gestionarClientesToolStripMenuItem";
            gestionarClientesToolStripMenuItem.Size = new Size(415, 34);
            gestionarClientesToolStripMenuItem.Text = "Gestionar clientes";
            gestionarClientesToolStripMenuItem.Click += gestionarClientesToolStripMenuItem_Click;
            // 
            // gestionarClientesStoredProceduresToolStripMenuItem
            // 
            gestionarClientesStoredProceduresToolStripMenuItem.Name = "gestionarClientesStoredProceduresToolStripMenuItem";
            gestionarClientesStoredProceduresToolStripMenuItem.Size = new Size(415, 34);
            gestionarClientesStoredProceduresToolStripMenuItem.Text = "Gestionar Clientes (Stored Procedures)";
            gestionarClientesStoredProceduresToolStripMenuItem.Click += gestionarClientesStoredProceduresToolStripMenuItem_Click;
            // 
            // gestionarClientesORMToolStripMenuItem
            // 
            gestionarClientesORMToolStripMenuItem.Name = "gestionarClientesORMToolStripMenuItem";
            gestionarClientesORMToolStripMenuItem.Size = new Size(415, 34);
            gestionarClientesORMToolStripMenuItem.Text = "Gestionar Clientes (ORM)";
            gestionarClientesORMToolStripMenuItem.Click += gestionarClientesORMToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirDelSistemaToolStripMenuItem });
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(61, 29);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            salirDelSistemaToolStripMenuItem.Size = new Size(241, 34);
            salirDelSistemaToolStripMenuItem.Text = "Salir del sistema";
            salirDelSistemaToolStripMenuItem.Click += salirDelSistemaToolStripMenuItem_Click;
            // 
            // pruebasConLinqToolStripMenuItem
            // 
            pruebasConLinqToolStripMenuItem.Name = "pruebasConLinqToolStripMenuItem";
            pruebasConLinqToolStripMenuItem.Size = new Size(415, 34);
            pruebasConLinqToolStripMenuItem.Text = "Pruebas con Linq";
            pruebasConLinqToolStripMenuItem.Click += pruebasConLinqToolStripMenuItem_Click;
            // 
            // MenuPrincipalView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuPrincipalView";
            Text = "Ciclismo Desktop por código";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem principalToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem salirDelSistemaToolStripMenuItem;
        private ToolStripMenuItem gestionarClientesToolStripMenuItem;
        private ToolStripMenuItem gestionarClientesStoredProceduresToolStripMenuItem;
        private ToolStripMenuItem gestionarClientesORMToolStripMenuItem;
        private ToolStripMenuItem pruebasConLinqToolStripMenuItem;
    }
}
