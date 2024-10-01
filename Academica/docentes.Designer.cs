
namespace academica
{
    partial class docentes
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
            this.lblBuscarDocentes = new System.Windows.Forms.Label();
            this.txtBuscarDocentes = new System.Windows.Forms.TextBox();
            this.grdDatosDocentes = new System.Windows.Forms.DataGridView();
            this.idDocente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materia1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materia2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivela_cademico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbEdicionDocentes = new System.Windows.Forms.GroupBox();
            this.btnEliminarDocentes = new System.Windows.Forms.Button();
            this.btnModificarDocentes = new System.Windows.Forms.Button();
            this.btnNuevoDocentes = new System.Windows.Forms.Button();
            this.grbNavegacionDocentes = new System.Windows.Forms.GroupBox();
            this.lblRegistrosDocentes = new System.Windows.Forms.Label();
            this.btnUltimoDocentes = new System.Windows.Forms.Button();
            this.btnSiguienteDocentes = new System.Windows.Forms.Button();
            this.btnAnteriorDocentes = new System.Windows.Forms.Button();
            this.btnPrimeroDocentes = new System.Windows.Forms.Button();
            this.grbDatosDocentes = new System.Windows.Forms.GroupBox();
            this.cmbEspecialidadDocente = new System.Windows.Forms.ComboBox();
            this.lblEspecialidadDocente = new System.Windows.Forms.Label();
            this.lblNivelAcademico = new System.Windows.Forms.Label();
            this.txtNivelAcademicoDocentes = new System.Windows.Forms.TextBox();
            this.lblMateria2 = new System.Windows.Forms.Label();
            this.txtMateria2Docentes = new System.Windows.Forms.TextBox();
            this.lblMateria1 = new System.Windows.Forms.Label();
            this.txtMateria1Docentes = new System.Windows.Forms.TextBox();
            this.lblNombreDocentes = new System.Windows.Forms.Label();
            this.txtNombreDocentes = new System.Windows.Forms.TextBox();
            this.lblCodigoDocentes = new System.Windows.Forms.Label();
            this.txtCodigoDocentes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosDocentes)).BeginInit();
            this.grbEdicionDocentes.SuspendLayout();
            this.grbNavegacionDocentes.SuspendLayout();
            this.grbDatosDocentes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBuscarDocentes
            // 
            this.lblBuscarDocentes.AutoSize = true;
            this.lblBuscarDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarDocentes.Location = new System.Drawing.Point(416, 49);
            this.lblBuscarDocentes.Name = "lblBuscarDocentes";
            this.lblBuscarDocentes.Size = new System.Drawing.Size(91, 24);
            this.lblBuscarDocentes.TabIndex = 21;
            this.lblBuscarDocentes.Text = "BUSCAR:";
            // 
            // txtBuscarDocentes
            // 
            this.txtBuscarDocentes.Location = new System.Drawing.Point(507, 54);
            this.txtBuscarDocentes.Name = "txtBuscarDocentes";
            this.txtBuscarDocentes.Size = new System.Drawing.Size(347, 20);
            this.txtBuscarDocentes.TabIndex = 22;
            this.txtBuscarDocentes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarDocentes_KeyUp);
            // 
            // grdDatosDocentes
            // 
            this.grdDatosDocentes.AllowUserToAddRows = false;
            this.grdDatosDocentes.AllowUserToDeleteRows = false;
            this.grdDatosDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosDocentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDocente,
            this.codigo,
            this.nombre,
            this.materia1,
            this.materia2,
            this.nivela_cademico,
            this.especialidad});
            this.grdDatosDocentes.Location = new System.Drawing.Point(420, 80);
            this.grdDatosDocentes.Name = "grdDatosDocentes";
            this.grdDatosDocentes.ReadOnly = true;
            this.grdDatosDocentes.Size = new System.Drawing.Size(628, 252);
            this.grdDatosDocentes.TabIndex = 20;
            this.grdDatosDocentes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatosDocentes_CellClick);
            this.grdDatosDocentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatosDocentes_CellClick);
            // 
            // idDocente
            // 
            this.idDocente.DataPropertyName = "idDocente";
            this.idDocente.HeaderText = "ID";
            this.idDocente.Name = "idDocente";
            this.idDocente.ReadOnly = true;
            this.idDocente.Visible = false;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "CODIGO";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // materia1
            // 
            this.materia1.DataPropertyName = "materia1";
            this.materia1.HeaderText = "MATERIA1";
            this.materia1.Name = "materia1";
            this.materia1.ReadOnly = true;
            // 
            // materia2
            // 
            this.materia2.DataPropertyName = "materia2";
            this.materia2.HeaderText = "MATERIA2";
            this.materia2.Name = "materia2";
            this.materia2.ReadOnly = true;
            // 
            // nivela_cademico
            // 
            this.nivela_cademico.DataPropertyName = "nivel_academico";
            this.nivela_cademico.HeaderText = "NIVEL ACADEMICO";
            this.nivela_cademico.Name = "nivela_cademico";
            this.nivela_cademico.ReadOnly = true;
            // 
            // especialidad
            // 
            this.especialidad.DataPropertyName = "especialidad";
            this.especialidad.HeaderText = "Especialidad";
            this.especialidad.Name = "especialidad";
            this.especialidad.ReadOnly = true;
            // 
            // grbEdicionDocentes
            // 
            this.grbEdicionDocentes.Controls.Add(this.btnEliminarDocentes);
            this.grbEdicionDocentes.Controls.Add(this.btnModificarDocentes);
            this.grbEdicionDocentes.Controls.Add(this.btnNuevoDocentes);
            this.grbEdicionDocentes.Location = new System.Drawing.Point(231, 338);
            this.grbEdicionDocentes.Name = "grbEdicionDocentes";
            this.grbEdicionDocentes.Size = new System.Drawing.Size(294, 58);
            this.grbEdicionDocentes.TabIndex = 19;
            this.grbEdicionDocentes.TabStop = false;
            this.grbEdicionDocentes.Text = "Navegacion";
            // 
            // btnEliminarDocentes
            // 
            this.btnEliminarDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDocentes.Location = new System.Drawing.Point(189, 19);
            this.btnEliminarDocentes.Name = "btnEliminarDocentes";
            this.btnEliminarDocentes.Size = new System.Drawing.Size(97, 38);
            this.btnEliminarDocentes.TabIndex = 6;
            this.btnEliminarDocentes.Text = "Eliminar";
            this.btnEliminarDocentes.UseVisualStyleBackColor = true;
            this.btnEliminarDocentes.Click += new System.EventHandler(this.btnEliminarDocentes_Click);
            // 
            // btnModificarDocentes
            // 
            this.btnModificarDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarDocentes.Location = new System.Drawing.Point(87, 19);
            this.btnModificarDocentes.Name = "btnModificarDocentes";
            this.btnModificarDocentes.Size = new System.Drawing.Size(104, 38);
            this.btnModificarDocentes.TabIndex = 5;
            this.btnModificarDocentes.Text = "Modificar";
            this.btnModificarDocentes.UseVisualStyleBackColor = true;
            this.btnModificarDocentes.Click += new System.EventHandler(this.btnModificarDocentes_Click);
            // 
            // btnNuevoDocentes
            // 
            this.btnNuevoDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoDocentes.Location = new System.Drawing.Point(6, 19);
            this.btnNuevoDocentes.Name = "btnNuevoDocentes";
            this.btnNuevoDocentes.Size = new System.Drawing.Size(83, 38);
            this.btnNuevoDocentes.TabIndex = 4;
            this.btnNuevoDocentes.Text = "Nuevo";
            this.btnNuevoDocentes.UseVisualStyleBackColor = true;
            this.btnNuevoDocentes.Click += new System.EventHandler(this.btnNuevoDocentes_Click);
            // 
            // grbNavegacionDocentes
            // 
            this.grbNavegacionDocentes.Controls.Add(this.lblRegistrosDocentes);
            this.grbNavegacionDocentes.Controls.Add(this.btnUltimoDocentes);
            this.grbNavegacionDocentes.Controls.Add(this.btnSiguienteDocentes);
            this.grbNavegacionDocentes.Controls.Add(this.btnAnteriorDocentes);
            this.grbNavegacionDocentes.Controls.Add(this.btnPrimeroDocentes);
            this.grbNavegacionDocentes.Location = new System.Drawing.Point(12, 338);
            this.grbNavegacionDocentes.Name = "grbNavegacionDocentes";
            this.grbNavegacionDocentes.Size = new System.Drawing.Size(213, 58);
            this.grbNavegacionDocentes.TabIndex = 18;
            this.grbNavegacionDocentes.TabStop = false;
            this.grbNavegacionDocentes.Text = "Navegacion";
            // 
            // lblRegistrosDocentes
            // 
            this.lblRegistrosDocentes.AutoSize = true;
            this.lblRegistrosDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrosDocentes.Location = new System.Drawing.Point(76, 24);
            this.lblRegistrosDocentes.Name = "lblRegistrosDocentes";
            this.lblRegistrosDocentes.Size = new System.Drawing.Size(63, 24);
            this.lblRegistrosDocentes.TabIndex = 10;
            this.lblRegistrosDocentes.Text = "x de n";
            // 
            // btnUltimoDocentes
            // 
            this.btnUltimoDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoDocentes.Location = new System.Drawing.Point(172, 14);
            this.btnUltimoDocentes.Name = "btnUltimoDocentes";
            this.btnUltimoDocentes.Size = new System.Drawing.Size(35, 38);
            this.btnUltimoDocentes.TabIndex = 3;
            this.btnUltimoDocentes.Text = ">|";
            this.btnUltimoDocentes.UseVisualStyleBackColor = true;
            this.btnUltimoDocentes.Click += new System.EventHandler(this.btnUltimoDocentes_Click);
            // 
            // btnSiguienteDocentes
            // 
            this.btnSiguienteDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteDocentes.Location = new System.Drawing.Point(139, 14);
            this.btnSiguienteDocentes.Name = "btnSiguienteDocentes";
            this.btnSiguienteDocentes.Size = new System.Drawing.Size(35, 38);
            this.btnSiguienteDocentes.TabIndex = 2;
            this.btnSiguienteDocentes.Text = ">";
            this.btnSiguienteDocentes.UseVisualStyleBackColor = true;
            this.btnSiguienteDocentes.Click += new System.EventHandler(this.btnSiguienteDocentes_Click);
            // 
            // btnAnteriorDocentes
            // 
            this.btnAnteriorDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorDocentes.Location = new System.Drawing.Point(40, 18);
            this.btnAnteriorDocentes.Name = "btnAnteriorDocentes";
            this.btnAnteriorDocentes.Size = new System.Drawing.Size(35, 38);
            this.btnAnteriorDocentes.TabIndex = 1;
            this.btnAnteriorDocentes.Text = "<";
            this.btnAnteriorDocentes.UseVisualStyleBackColor = true;
            this.btnAnteriorDocentes.Click += new System.EventHandler(this.btnAnteriorDocentes_Click);
            // 
            // btnPrimeroDocentes
            // 
            this.btnPrimeroDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroDocentes.Location = new System.Drawing.Point(7, 18);
            this.btnPrimeroDocentes.Name = "btnPrimeroDocentes";
            this.btnPrimeroDocentes.Size = new System.Drawing.Size(35, 38);
            this.btnPrimeroDocentes.TabIndex = 0;
            this.btnPrimeroDocentes.Text = "|<";
            this.btnPrimeroDocentes.UseVisualStyleBackColor = true;
            this.btnPrimeroDocentes.Click += new System.EventHandler(this.btnPrimeroDocentes_Click);
            // 
            // grbDatosDocentes
            // 
            this.grbDatosDocentes.Controls.Add(this.cmbEspecialidadDocente);
            this.grbDatosDocentes.Controls.Add(this.lblEspecialidadDocente);
            this.grbDatosDocentes.Controls.Add(this.lblNivelAcademico);
            this.grbDatosDocentes.Controls.Add(this.txtNivelAcademicoDocentes);
            this.grbDatosDocentes.Controls.Add(this.lblMateria2);
            this.grbDatosDocentes.Controls.Add(this.txtMateria2Docentes);
            this.grbDatosDocentes.Controls.Add(this.lblMateria1);
            this.grbDatosDocentes.Controls.Add(this.txtMateria1Docentes);
            this.grbDatosDocentes.Controls.Add(this.lblNombreDocentes);
            this.grbDatosDocentes.Controls.Add(this.txtNombreDocentes);
            this.grbDatosDocentes.Controls.Add(this.lblCodigoDocentes);
            this.grbDatosDocentes.Controls.Add(this.txtCodigoDocentes);
            this.grbDatosDocentes.Enabled = false;
            this.grbDatosDocentes.Location = new System.Drawing.Point(11, 39);
            this.grbDatosDocentes.Name = "grbDatosDocentes";
            this.grbDatosDocentes.Size = new System.Drawing.Size(390, 293);
            this.grbDatosDocentes.TabIndex = 17;
            this.grbDatosDocentes.TabStop = false;
            this.grbDatosDocentes.Text = "Datos Docentes";
            // 
            // cmbEspecialidadDocente
            // 
            this.cmbEspecialidadDocente.FormattingEnabled = true;
            this.cmbEspecialidadDocente.Items.AddRange(new object[] {
            "Informatico/a",
            "Contador/a",
            "Matematico/a",
            "Fisico/a",
            "Filosofo/a",
            "Abogado/a",
            "Salud",
            "Bilingüe"});
            this.cmbEspecialidadDocente.Location = new System.Drawing.Point(173, 243);
            this.cmbEspecialidadDocente.Name = "cmbEspecialidadDocente";
            this.cmbEspecialidadDocente.Size = new System.Drawing.Size(136, 21);
            this.cmbEspecialidadDocente.TabIndex = 11;
            this.cmbEspecialidadDocente.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblEspecialidadDocente
            // 
            this.lblEspecialidadDocente.AutoSize = true;
            this.lblEspecialidadDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidadDocente.Location = new System.Drawing.Point(37, 240);
            this.lblEspecialidadDocente.Name = "lblEspecialidadDocente";
            this.lblEspecialidadDocente.Size = new System.Drawing.Size(123, 24);
            this.lblEspecialidadDocente.TabIndex = 10;
            this.lblEspecialidadDocente.Text = "Especialidad:";
            // 
            // lblNivelAcademico
            // 
            this.lblNivelAcademico.AutoSize = true;
            this.lblNivelAcademico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivelAcademico.Location = new System.Drawing.Point(31, 201);
            this.lblNivelAcademico.Name = "lblNivelAcademico";
            this.lblNivelAcademico.Size = new System.Drawing.Size(158, 24);
            this.lblNivelAcademico.TabIndex = 9;
            this.lblNivelAcademico.Text = "Nivel Academico:";
            // 
            // txtNivelAcademicoDocentes
            // 
            this.txtNivelAcademicoDocentes.Location = new System.Drawing.Point(206, 205);
            this.txtNivelAcademicoDocentes.Name = "txtNivelAcademicoDocentes";
            this.txtNivelAcademicoDocentes.Size = new System.Drawing.Size(176, 20);
            this.txtNivelAcademicoDocentes.TabIndex = 8;
            // 
            // lblMateria2
            // 
            this.lblMateria2.AutoSize = true;
            this.lblMateria2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria2.Location = new System.Drawing.Point(31, 156);
            this.lblMateria2.Name = "lblMateria2";
            this.lblMateria2.Size = new System.Drawing.Size(86, 24);
            this.lblMateria2.TabIndex = 7;
            this.lblMateria2.Text = "Materia2:";
            // 
            // txtMateria2Docentes
            // 
            this.txtMateria2Docentes.Location = new System.Drawing.Point(131, 160);
            this.txtMateria2Docentes.Name = "txtMateria2Docentes";
            this.txtMateria2Docentes.Size = new System.Drawing.Size(178, 20);
            this.txtMateria2Docentes.TabIndex = 6;
            // 
            // lblMateria1
            // 
            this.lblMateria1.AutoSize = true;
            this.lblMateria1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria1.Location = new System.Drawing.Point(31, 116);
            this.lblMateria1.Name = "lblMateria1";
            this.lblMateria1.Size = new System.Drawing.Size(86, 24);
            this.lblMateria1.TabIndex = 5;
            this.lblMateria1.Text = "Materia1:";
            // 
            // txtMateria1Docentes
            // 
            this.txtMateria1Docentes.Location = new System.Drawing.Point(131, 120);
            this.txtMateria1Docentes.Name = "txtMateria1Docentes";
            this.txtMateria1Docentes.Size = new System.Drawing.Size(178, 20);
            this.txtMateria1Docentes.TabIndex = 4;
            // 
            // lblNombreDocentes
            // 
            this.lblNombreDocentes.AutoSize = true;
            this.lblNombreDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDocentes.Location = new System.Drawing.Point(31, 76);
            this.lblNombreDocentes.Name = "lblNombreDocentes";
            this.lblNombreDocentes.Size = new System.Drawing.Size(84, 24);
            this.lblNombreDocentes.TabIndex = 3;
            this.lblNombreDocentes.Text = "Nombre:";
            // 
            // txtNombreDocentes
            // 
            this.txtNombreDocentes.Location = new System.Drawing.Point(131, 80);
            this.txtNombreDocentes.Name = "txtNombreDocentes";
            this.txtNombreDocentes.Size = new System.Drawing.Size(251, 20);
            this.txtNombreDocentes.TabIndex = 2;
            // 
            // lblCodigoDocentes
            // 
            this.lblCodigoDocentes.AutoSize = true;
            this.lblCodigoDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoDocentes.Location = new System.Drawing.Point(31, 37);
            this.lblCodigoDocentes.Name = "lblCodigoDocentes";
            this.lblCodigoDocentes.Size = new System.Drawing.Size(76, 24);
            this.lblCodigoDocentes.TabIndex = 1;
            this.lblCodigoDocentes.Text = "Codigo:";
            // 
            // txtCodigoDocentes
            // 
            this.txtCodigoDocentes.Location = new System.Drawing.Point(131, 41);
            this.txtCodigoDocentes.Name = "txtCodigoDocentes";
            this.txtCodigoDocentes.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoDocentes.TabIndex = 0;
            // 
            // docentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 434);
            this.Controls.Add(this.lblBuscarDocentes);
            this.Controls.Add(this.txtBuscarDocentes);
            this.Controls.Add(this.grdDatosDocentes);
            this.Controls.Add(this.grbEdicionDocentes);
            this.Controls.Add(this.grbNavegacionDocentes);
            this.Controls.Add(this.grbDatosDocentes);
            this.Name = "docentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMINISTRACIÓN DE DOCENTES";
            this.Load += new System.EventHandler(this.docentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosDocentes)).EndInit();
            this.grbEdicionDocentes.ResumeLayout(false);
            this.grbNavegacionDocentes.ResumeLayout(false);
            this.grbNavegacionDocentes.PerformLayout();
            this.grbDatosDocentes.ResumeLayout(false);
            this.grbDatosDocentes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarDocentes;
        private System.Windows.Forms.TextBox txtBuscarDocentes;
        private System.Windows.Forms.DataGridView grdDatosDocentes;
        private System.Windows.Forms.GroupBox grbEdicionDocentes;
        private System.Windows.Forms.Button btnEliminarDocentes;
        private System.Windows.Forms.Button btnModificarDocentes;
        private System.Windows.Forms.Button btnNuevoDocentes;
        private System.Windows.Forms.GroupBox grbNavegacionDocentes;
        private System.Windows.Forms.Label lblRegistrosDocentes;
        private System.Windows.Forms.Button btnUltimoDocentes;
        private System.Windows.Forms.Button btnSiguienteDocentes;
        private System.Windows.Forms.Button btnAnteriorDocentes;
        private System.Windows.Forms.Button btnPrimeroDocentes;
        private System.Windows.Forms.GroupBox grbDatosDocentes;
        private System.Windows.Forms.Label lblMateria1;
        private System.Windows.Forms.TextBox txtMateria1Docentes;
        private System.Windows.Forms.Label lblNombreDocentes;
        private System.Windows.Forms.TextBox txtNombreDocentes;
        private System.Windows.Forms.Label lblCodigoDocentes;
        private System.Windows.Forms.TextBox txtCodigoDocentes;
        private System.Windows.Forms.Label lblNivelAcademico;
        private System.Windows.Forms.TextBox txtNivelAcademicoDocentes;
        private System.Windows.Forms.Label lblMateria2;
        private System.Windows.Forms.TextBox txtMateria2Docentes;
        private System.Windows.Forms.ComboBox cmbEspecialidadDocente;
        private System.Windows.Forms.Label lblEspecialidadDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn materia1;
        private System.Windows.Forms.DataGridViewTextBoxColumn materia2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivela_cademico;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidad;
    }
}