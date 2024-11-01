namespace Act
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
            this.tBdni = new System.Windows.Forms.TextBox();
            this.tBpatente = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBtipo = new System.Windows.Forms.ComboBox();
            this.rBcliente = new System.Windows.Forms.RadioButton();
            this.rBdenuncia = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bGenerar = new System.Windows.Forms.Button();
            this.Turnos = new System.Windows.Forms.GroupBox();
            this.bCliente = new System.Windows.Forms.Button();
            this.lBtickets = new System.Windows.Forms.ListBox();
            this.bDenuncia = new System.Windows.Forms.Button();
            this.bImportar = new System.Windows.Forms.Button();
            this.bExportar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Turnos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBdni
            // 
            this.tBdni.Location = new System.Drawing.Point(79, 12);
            this.tBdni.Name = "tBdni";
            this.tBdni.Size = new System.Drawing.Size(132, 20);
            this.tBdni.TabIndex = 1;
            // 
            // tBpatente
            // 
            this.tBpatente.Location = new System.Drawing.Point(122, 34);
            this.tBpatente.Name = "tBpatente";
            this.tBpatente.Size = new System.Drawing.Size(100, 20);
            this.tBpatente.TabIndex = 2;
            this.tBpatente.Text = "Patente";
            this.tBpatente.TextChanged += new System.EventHandler(this.tBpatente_TextChanged);
            this.tBpatente.Enter += new System.EventHandler(this.tBpatente_Enter);
            this.tBpatente.Leave += new System.EventHandler(this.tBpatente_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBtipo);
            this.groupBox1.Controls.Add(this.rBcliente);
            this.groupBox1.Controls.Add(this.rBdenuncia);
            this.groupBox1.Controls.Add(this.tBpatente);
            this.groupBox1.Location = new System.Drawing.Point(13, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 110);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del cliente";
            // 
            // cBtipo
            // 
            this.cBtipo.FormattingEnabled = true;
            this.cBtipo.Items.AddRange(new object[] {
            "Auto",
            "Moto",
            "Equipo de trabajo",
            "Bicicleta"});
            this.cBtipo.Location = new System.Drawing.Point(122, 69);
            this.cBtipo.Name = "cBtipo";
            this.cBtipo.Size = new System.Drawing.Size(100, 21);
            this.cBtipo.TabIndex = 5;
            this.cBtipo.Text = "Tipo";
            // 
            // rBcliente
            // 
            this.rBcliente.AutoSize = true;
            this.rBcliente.Location = new System.Drawing.Point(18, 69);
            this.rBcliente.Name = "rBcliente";
            this.rBcliente.Size = new System.Drawing.Size(91, 17);
            this.rBcliente.TabIndex = 4;
            this.rBcliente.TabStop = true;
            this.rBcliente.Text = "Nuevo cliente";
            this.rBcliente.UseVisualStyleBackColor = true;
            // 
            // rBdenuncia
            // 
            this.rBdenuncia.AutoSize = true;
            this.rBdenuncia.Location = new System.Drawing.Point(18, 34);
            this.rBdenuncia.Name = "rBdenuncia";
            this.rBdenuncia.Size = new System.Drawing.Size(71, 17);
            this.rBdenuncia.TabIndex = 3;
            this.rBdenuncia.TabStop = true;
            this.rBdenuncia.Text = "Denuncia";
            this.rBdenuncia.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "DNI";
            // 
            // bGenerar
            // 
            this.bGenerar.Location = new System.Drawing.Point(262, 97);
            this.bGenerar.Name = "bGenerar";
            this.bGenerar.Size = new System.Drawing.Size(75, 64);
            this.bGenerar.TabIndex = 5;
            this.bGenerar.Text = "Generar Ticket";
            this.bGenerar.UseVisualStyleBackColor = true;
            this.bGenerar.Click += new System.EventHandler(this.bGenerar_Click);
            // 
            // Turnos
            // 
            this.Turnos.Controls.Add(this.bCliente);
            this.Turnos.Controls.Add(this.lBtickets);
            this.Turnos.Controls.Add(this.bDenuncia);
            this.Turnos.Location = new System.Drawing.Point(11, 153);
            this.Turnos.Name = "Turnos";
            this.Turnos.Size = new System.Drawing.Size(234, 210);
            this.Turnos.TabIndex = 6;
            this.Turnos.TabStop = false;
            this.Turnos.Text = "Turnos";
            // 
            // bCliente
            // 
            this.bCliente.Location = new System.Drawing.Point(124, 133);
            this.bCliente.Name = "bCliente";
            this.bCliente.Size = new System.Drawing.Size(75, 64);
            this.bCliente.TabIndex = 10;
            this.bCliente.Text = "Atender nuevo cliente";
            this.bCliente.UseVisualStyleBackColor = true;
            this.bCliente.Click += new System.EventHandler(this.bCliente_Click);
            // 
            // lBtickets
            // 
            this.lBtickets.FormattingEnabled = true;
            this.lBtickets.Location = new System.Drawing.Point(9, 19);
            this.lBtickets.Name = "lBtickets";
            this.lBtickets.Size = new System.Drawing.Size(213, 108);
            this.lBtickets.TabIndex = 0;
            // 
            // bDenuncia
            // 
            this.bDenuncia.Location = new System.Drawing.Point(20, 133);
            this.bDenuncia.Name = "bDenuncia";
            this.bDenuncia.Size = new System.Drawing.Size(75, 64);
            this.bDenuncia.TabIndex = 9;
            this.bDenuncia.Text = "Atender denuncia";
            this.bDenuncia.UseVisualStyleBackColor = true;
            this.bDenuncia.Click += new System.EventHandler(this.bDenuncia_Click);
            // 
            // bImportar
            // 
            this.bImportar.Location = new System.Drawing.Point(262, 195);
            this.bImportar.Name = "bImportar";
            this.bImportar.Size = new System.Drawing.Size(75, 64);
            this.bImportar.TabIndex = 7;
            this.bImportar.Text = "Importar vehiculos";
            this.bImportar.UseVisualStyleBackColor = true;
            this.bImportar.Click += new System.EventHandler(this.bImportar_Click);
            // 
            // bExportar
            // 
            this.bExportar.Location = new System.Drawing.Point(262, 279);
            this.bExportar.Name = "bExportar";
            this.bExportar.Size = new System.Drawing.Size(75, 64);
            this.bExportar.TabIndex = 8;
            this.bExportar.Text = "Exportar tickets";
            this.bExportar.UseVisualStyleBackColor = true;
            this.bExportar.Click += new System.EventHandler(this.bExportar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 64);
            this.button1.TabIndex = 9;
            this.button1.Text = "Ver vehiculos registrados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 382);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bExportar);
            this.Controls.Add(this.bImportar);
            this.Controls.Add(this.Turnos);
            this.Controls.Add(this.bGenerar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tBdni);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Turnos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBdni;
        private System.Windows.Forms.TextBox tBpatente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBtipo;
        private System.Windows.Forms.RadioButton rBcliente;
        private System.Windows.Forms.RadioButton rBdenuncia;
        private System.Windows.Forms.Button bGenerar;
        private System.Windows.Forms.GroupBox Turnos;
        private System.Windows.Forms.Button bCliente;
        private System.Windows.Forms.ListBox lBtickets;
        private System.Windows.Forms.Button bDenuncia;
        private System.Windows.Forms.Button bImportar;
        private System.Windows.Forms.Button bExportar;
        private System.Windows.Forms.Button button1;
    }
}

