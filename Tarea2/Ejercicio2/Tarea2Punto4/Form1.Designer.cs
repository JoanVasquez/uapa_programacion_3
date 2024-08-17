namespace Tarea2Punto4
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtExamen = new TextBox();
            txtPlataforma = new TextBox();
            txtActitudesValores = new TextBox();
            txtTrabajoFinal = new TextBox();
            lblNota = new Label();
            lblResultado = new Label();
            lblCalificacionLiteral = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Examen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1;
            label2.Text = "Plataforma";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 121);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 2;
            label3.Text = "Actitudes y Valores";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 176);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 3;
            label4.Text = "Trabajo Final";
            // 
            // txtExamen
            // 
            txtExamen.Location = new Point(168, 6);
            txtExamen.Name = "txtExamen";
            txtExamen.Size = new Size(620, 23);
            txtExamen.TabIndex = 4;
            // 
            // txtPlataforma
            // 
            txtPlataforma.Location = new Point(168, 56);
            txtPlataforma.Name = "txtPlataforma";
            txtPlataforma.Size = new Size(620, 23);
            txtPlataforma.TabIndex = 5;
            // 
            // txtActitudesValores
            // 
            txtActitudesValores.Location = new Point(168, 118);
            txtActitudesValores.Name = "txtActitudesValores";
            txtActitudesValores.Size = new Size(620, 23);
            txtActitudesValores.TabIndex = 6;
            // 
            // txtTrabajoFinal
            // 
            txtTrabajoFinal.Location = new Point(168, 173);
            txtTrabajoFinal.Name = "txtTrabajoFinal";
            txtTrabajoFinal.Size = new Size(620, 23);
            txtTrabajoFinal.TabIndex = 7;
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.Location = new Point(12, 245);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(33, 15);
            lblNota.TabIndex = 8;
            lblNota.Text = "Nota";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(12, 302);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 9;
            lblResultado.Text = "Resultado";
            // 
            // lblCalificacionLiteral
            // 
            lblCalificacionLiteral.AutoSize = true;
            lblCalificacionLiteral.Location = new Point(12, 354);
            lblCalificacionLiteral.Name = "lblCalificacionLiteral";
            lblCalificacionLiteral.Size = new Size(104, 15);
            lblCalificacionLiteral.TabIndex = 10;
            lblCalificacionLiteral.Text = "Calificacion Literal";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(713, 265);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 11;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(lblCalificacionLiteral);
            Controls.Add(lblResultado);
            Controls.Add(lblNota);
            Controls.Add(txtTrabajoFinal);
            Controls.Add(txtActitudesValores);
            Controls.Add(txtPlataforma);
            Controls.Add(txtExamen);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtExamen;
        private TextBox txtPlataforma;
        private TextBox txtActitudesValores;
        private TextBox txtTrabajoFinal;
        private Label lblNota;
        private Label lblResultado;
        private Label lblCalificacionLiteral;
        private Button btnCalcular;
    }
}
