namespace ExamenTopicos
{
    partial class frmMenu
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
            this.BtnAlumnos = new System.Windows.Forms.Button();
            this.btnProfesores = new System.Windows.Forms.Button();
            this.BtnClases = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProbarConexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAlumnos
            // 
            this.BtnAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlumnos.Location = new System.Drawing.Point(66, 105);
            this.BtnAlumnos.Name = "BtnAlumnos";
            this.BtnAlumnos.Size = new System.Drawing.Size(93, 37);
            this.BtnAlumnos.TabIndex = 0;
            this.BtnAlumnos.Text = "Alumnos";
            this.BtnAlumnos.UseVisualStyleBackColor = true;
            this.BtnAlumnos.Click += new System.EventHandler(this.BtnAlumnos_Click);
            // 
            // btnProfesores
            // 
            this.btnProfesores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfesores.Location = new System.Drawing.Point(165, 105);
            this.btnProfesores.Name = "btnProfesores";
            this.btnProfesores.Size = new System.Drawing.Size(131, 37);
            this.btnProfesores.TabIndex = 1;
            this.btnProfesores.Text = "Profesores";
            this.btnProfesores.UseVisualStyleBackColor = true;
            this.btnProfesores.Click += new System.EventHandler(this.btnProfesores_Click);
            // 
            // BtnClases
            // 
            this.BtnClases.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClases.Location = new System.Drawing.Point(302, 105);
            this.BtnClases.Name = "BtnClases";
            this.BtnClases.Size = new System.Drawing.Size(93, 37);
            this.BtnClases.TabIndex = 2;
            this.BtnClases.Text = "Clases";
            this.BtnClases.UseVisualStyleBackColor = true;
            this.BtnClases.Click += new System.EventHandler(this.BtnClases_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tablas BD Escuela";
            // 
            // btnProbarConexion
            // 
            this.btnProbarConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProbarConexion.Location = new System.Drawing.Point(378, 199);
            this.btnProbarConexion.Name = "btnProbarConexion";
            this.btnProbarConexion.Size = new System.Drawing.Size(74, 26);
            this.btnProbarConexion.TabIndex = 4;
            this.btnProbarConexion.Text = "Probar";
            this.btnProbarConexion.UseVisualStyleBackColor = true;
            this.btnProbarConexion.Click += new System.EventHandler(this.btnProbarConexion_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(464, 237);
            this.Controls.Add(this.btnProbarConexion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnClases);
            this.Controls.Add(this.btnProfesores);
            this.Controls.Add(this.BtnAlumnos);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAlumnos;
        private System.Windows.Forms.Button btnProfesores;
        private System.Windows.Forms.Button BtnClases;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProbarConexion;
    }
}