namespace Enumexamples
{
    partial class Formviembenida
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
            this.lblrol = new System.Windows.Forms.Label();
            this.lblstatususu = new System.Windows.Forms.Label();
            this.lblnombreusu = new System.Windows.Forms.Label();
            this.lblnombrecom = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsbusuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbAdministrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbconsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbinventario = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbingresarusuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(559, 108);
            this.label1.TabIndex = 1;
            this.label1.Text = "Viembenido";
            // 
            // lblrol
            // 
            this.lblrol.AutoSize = true;
            this.lblrol.Location = new System.Drawing.Point(12, 95);
            this.lblrol.Name = "lblrol";
            this.lblrol.Size = new System.Drawing.Size(35, 13);
            this.lblrol.TabIndex = 2;
            this.lblrol.Text = "label2";
            // 
            // lblstatususu
            // 
            this.lblstatususu.AutoSize = true;
            this.lblstatususu.Location = new System.Drawing.Point(12, 171);
            this.lblstatususu.Name = "lblstatususu";
            this.lblstatususu.Size = new System.Drawing.Size(35, 13);
            this.lblstatususu.TabIndex = 3;
            this.lblstatususu.Text = "label3";
            // 
            // lblnombreusu
            // 
            this.lblnombreusu.AutoSize = true;
            this.lblnombreusu.Location = new System.Drawing.Point(12, 146);
            this.lblnombreusu.Name = "lblnombreusu";
            this.lblnombreusu.Size = new System.Drawing.Size(35, 13);
            this.lblnombreusu.TabIndex = 4;
            this.lblnombreusu.Text = "label4";
            // 
            // lblnombrecom
            // 
            this.lblnombrecom.AutoSize = true;
            this.lblnombrecom.Location = new System.Drawing.Point(12, 121);
            this.lblnombrecom.Name = "lblnombrecom";
            this.lblnombrecom.Size = new System.Drawing.Size(35, 13);
            this.lblnombrecom.TabIndex = 5;
            this.lblnombrecom.Text = "label5";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbusuarios,
            this.tsbconsulta,
            this.tsbinventario});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsbusuarios
            // 
            this.tsbusuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdministrar,
            this.tsbingresarusuario});
            this.tsbusuarios.Name = "tsbusuarios";
            this.tsbusuarios.Size = new System.Drawing.Size(71, 21);
            this.tsbusuarios.Text = "Usuarios";
            // 
            // tsbAdministrar
            // 
            this.tsbAdministrar.Name = "tsbAdministrar";
            this.tsbAdministrar.Size = new System.Drawing.Size(180, 22);
            this.tsbAdministrar.Text = "Editar usuarios";
            // 
            // tsbconsulta
            // 
            this.tsbconsulta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarEmpleadosToolStripMenuItem});
            this.tsbconsulta.Name = "tsbconsulta";
            this.tsbconsulta.Size = new System.Drawing.Size(76, 21);
            this.tsbconsulta.Text = "Consultas";
            // 
            // consultarEmpleadosToolStripMenuItem
            // 
            this.consultarEmpleadosToolStripMenuItem.Name = "consultarEmpleadosToolStripMenuItem";
            this.consultarEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.consultarEmpleadosToolStripMenuItem.Text = "Consultar empleados";
            // 
            // tsbinventario
            // 
            this.tsbinventario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarProductoToolStripMenuItem,
            this.eliminarProductoToolStripMenuItem});
            this.tsbinventario.Name = "tsbinventario";
            this.tsbinventario.Size = new System.Drawing.Size(77, 21);
            this.tsbinventario.Text = "Inventario";
            // 
            // registrarProductoToolStripMenuItem
            // 
            this.registrarProductoToolStripMenuItem.Name = "registrarProductoToolStripMenuItem";
            this.registrarProductoToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.registrarProductoToolStripMenuItem.Text = "Registrar Producto";
            // 
            // eliminarProductoToolStripMenuItem
            // 
            this.eliminarProductoToolStripMenuItem.Name = "eliminarProductoToolStripMenuItem";
            this.eliminarProductoToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.eliminarProductoToolStripMenuItem.Text = "Eliminar producto";
            // 
            // tsbingresarusuario
            // 
            this.tsbingresarusuario.Name = "tsbingresarusuario";
            this.tsbingresarusuario.Size = new System.Drawing.Size(180, 22);
            this.tsbingresarusuario.Text = "Ingresar usuario";
            // 
            // Formviembenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblnombrecom);
            this.Controls.Add(this.lblnombreusu);
            this.Controls.Add(this.lblstatususu);
            this.Controls.Add(this.lblrol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Formviembenida";
            this.Text = "Formviembenida";
            this.Load += new System.EventHandler(this.Formviembenida_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblrol;
        private System.Windows.Forms.Label lblstatususu;
        private System.Windows.Forms.Label lblnombreusu;
        private System.Windows.Forms.Label lblnombrecom;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsbusuarios;
        private System.Windows.Forms.ToolStripMenuItem tsbAdministrar;
        private System.Windows.Forms.ToolStripMenuItem tsbingresarusuario;
        private System.Windows.Forms.ToolStripMenuItem tsbconsulta;
        private System.Windows.Forms.ToolStripMenuItem consultarEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsbinventario;
        private System.Windows.Forms.ToolStripMenuItem registrarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarProductoToolStripMenuItem;
    }
}