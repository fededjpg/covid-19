namespace Clases
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
            this.btnPrueba = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.textMuertes = new System.Windows.Forms.TextBox();
            this.textCasos = new System.Windows.Forms.TextBox();
            this.txtTrabajador = new System.Windows.Forms.TextBox();
            this.txtNombresPost = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.txtTadaIncidencia = new System.Windows.Forms.TextBox();
            this.txtCasoM = new System.Windows.Forms.TextBox();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.txtIdM = new System.Windows.Forms.TextBox();
            this.btnAgregarM = new System.Windows.Forms.Button();
            this.btnActualizarM = new System.Windows.Forms.Button();
            this.btnEliminarM = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrueba
            // 
            this.btnPrueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrueba.Location = new System.Drawing.Point(338, 374);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(84, 30);
            this.btnPrueba.TabIndex = 0;
            this.btnPrueba.Text = "Eliminar";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // btnPost
            // 
            this.btnPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPost.Location = new System.Drawing.Point(63, 374);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(83, 30);
            this.btnPost.TabIndex = 2;
            this.btnPost.Text = "Agregar";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textId);
            this.groupBox1.Controls.Add(this.textMuertes);
            this.groupBox1.Controls.Add(this.textCasos);
            this.groupBox1.Controls.Add(this.txtTrabajador);
            this.groupBox1.Controls.Add(this.txtNombresPost);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(63, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 293);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Estado";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "Muertes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Casos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Id";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(104, 28);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(223, 29);
            this.textId.TabIndex = 16;
            // 
            // textMuertes
            // 
            this.textMuertes.Location = new System.Drawing.Point(102, 232);
            this.textMuertes.Name = "textMuertes";
            this.textMuertes.Size = new System.Drawing.Size(225, 29);
            this.textMuertes.TabIndex = 15;
            this.textMuertes.TextChanged += new System.EventHandler(this.textMuertes_TextChanged);
            // 
            // textCasos
            // 
            this.textCasos.Location = new System.Drawing.Point(102, 175);
            this.textCasos.Name = "textCasos";
            this.textCasos.Size = new System.Drawing.Size(225, 29);
            this.textCasos.TabIndex = 14;
            // 
            // txtTrabajador
            // 
            this.txtTrabajador.Location = new System.Drawing.Point(102, 131);
            this.txtTrabajador.Name = "txtTrabajador";
            this.txtTrabajador.Size = new System.Drawing.Size(225, 29);
            this.txtTrabajador.TabIndex = 13;
            // 
            // txtNombresPost
            // 
            this.txtNombresPost.Location = new System.Drawing.Point(102, 76);
            this.txtNombresPost.Name = "txtNombresPost";
            this.txtNombresPost.Size = new System.Drawing.Size(225, 29);
            this.txtNombresPost.TabIndex = 11;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(188, 374);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(90, 30);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Id);
            this.groupBox2.Controls.Add(this.txtTadaIncidencia);
            this.groupBox2.Controls.Add(this.txtCasoM);
            this.groupBox2.Controls.Add(this.txtMunicipio);
            this.groupBox2.Controls.Add(this.txtIdM);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(524, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 293);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Municipio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 24);
            this.label9.TabIndex = 12;
            this.label9.Text = "Tasa Incidencia";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 24);
            this.label8.TabIndex = 6;
            this.label8.Text = "Casos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "Municipio";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(17, 28);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(25, 24);
            this.Id.TabIndex = 4;
            this.Id.Text = "Id";
            // 
            // txtTadaIncidencia
            // 
            this.txtTadaIncidencia.Location = new System.Drawing.Point(154, 232);
            this.txtTadaIncidencia.Name = "txtTadaIncidencia";
            this.txtTadaIncidencia.Size = new System.Drawing.Size(223, 29);
            this.txtTadaIncidencia.TabIndex = 3;
            // 
            // txtCasoM
            // 
            this.txtCasoM.Location = new System.Drawing.Point(154, 164);
            this.txtCasoM.Name = "txtCasoM";
            this.txtCasoM.Size = new System.Drawing.Size(223, 29);
            this.txtCasoM.TabIndex = 2;
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Location = new System.Drawing.Point(154, 98);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(223, 29);
            this.txtMunicipio.TabIndex = 1;
            // 
            // txtIdM
            // 
            this.txtIdM.Location = new System.Drawing.Point(154, 28);
            this.txtIdM.Name = "txtIdM";
            this.txtIdM.Size = new System.Drawing.Size(223, 29);
            this.txtIdM.TabIndex = 0;
            // 
            // btnAgregarM
            // 
            this.btnAgregarM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarM.Location = new System.Drawing.Point(524, 374);
            this.btnAgregarM.Name = "btnAgregarM";
            this.btnAgregarM.Size = new System.Drawing.Size(79, 29);
            this.btnAgregarM.TabIndex = 12;
            this.btnAgregarM.Text = "Agregar";
            this.btnAgregarM.UseVisualStyleBackColor = true;
            this.btnAgregarM.Click += new System.EventHandler(this.btnAgregarM_Click);
            // 
            // btnActualizarM
            // 
            this.btnActualizarM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarM.Location = new System.Drawing.Point(678, 373);
            this.btnActualizarM.Name = "btnActualizarM";
            this.btnActualizarM.Size = new System.Drawing.Size(79, 30);
            this.btnActualizarM.TabIndex = 13;
            this.btnActualizarM.Text = "Actualizar";
            this.btnActualizarM.UseVisualStyleBackColor = true;
            this.btnActualizarM.Click += new System.EventHandler(this.btnActualizarM_Click);
            // 
            // btnEliminarM
            // 
            this.btnEliminarM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarM.Location = new System.Drawing.Point(845, 374);
            this.btnEliminarM.Name = "btnEliminarM";
            this.btnEliminarM.Size = new System.Drawing.Size(75, 29);
            this.btnEliminarM.TabIndex = 14;
            this.btnEliminarM.Text = "Eliminar";
            this.btnEliminarM.UseVisualStyleBackColor = true;
            this.btnEliminarM.Click += new System.EventHandler(this.btnEliminarM_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(962, 462);
            this.Controls.Add(this.btnEliminarM);
            this.Controls.Add(this.btnActualizarM);
            this.Controls.Add(this.btnAgregarM);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.btnPrueba);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrueba;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTrabajador;
        private System.Windows.Forms.TextBox txtNombresPost;
        private System.Windows.Forms.TextBox textCasos;
        private System.Windows.Forms.TextBox textMuertes;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTadaIncidencia;
        private System.Windows.Forms.TextBox txtCasoM;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.TextBox txtIdM;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAgregarM;
        private System.Windows.Forms.Button btnActualizarM;
        private System.Windows.Forms.Button btnEliminarM;
    }
}

