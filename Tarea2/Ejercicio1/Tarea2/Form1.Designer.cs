namespace Tarea2
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
            lblSueldoNeto = new Label();
            lblAfp = new Label();
            lblArs = new Label();
            lblIsr = new Label();
            txtSueldoNeto = new TextBox();
            txtAfp = new TextBox();
            txtArs = new TextBox();
            txtIsr = new TextBox();
            lblAfpResultado = new Label();
            lblResultadoArs = new Label();
            lblResultadoIsr = new Label();
            lblResultadoDescuento = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblSueldoNeto
            // 
            lblSueldoNeto.AutoSize = true;
            lblSueldoNeto.Location = new Point(3, 9);
            lblSueldoNeto.Name = "lblSueldoNeto";
            lblSueldoNeto.Size = new Size(72, 15);
            lblSueldoNeto.TabIndex = 0;
            lblSueldoNeto.Text = "Sueldo Neto";
            // 
            // lblAfp
            // 
            lblAfp.AutoSize = true;
            lblAfp.Location = new Point(3, 48);
            lblAfp.Name = "lblAfp";
            lblAfp.Size = new Size(28, 15);
            lblAfp.TabIndex = 1;
            lblAfp.Text = "AFP";
            // 
            // lblArs
            // 
            lblArs.AutoSize = true;
            lblArs.Location = new Point(3, 92);
            lblArs.Name = "lblArs";
            lblArs.Size = new Size(28, 15);
            lblArs.TabIndex = 2;
            lblArs.Text = "ARS";
            // 
            // lblIsr
            // 
            lblIsr.AutoSize = true;
            lblIsr.Location = new Point(3, 135);
            lblIsr.Name = "lblIsr";
            lblIsr.Size = new Size(23, 15);
            lblIsr.TabIndex = 3;
            lblIsr.Text = "ISR";
            // 
            // txtSueldoNeto
            // 
            txtSueldoNeto.Location = new Point(92, 6);
            txtSueldoNeto.Name = "txtSueldoNeto";
            txtSueldoNeto.Size = new Size(696, 23);
            txtSueldoNeto.TabIndex = 4;
            // 
            // txtAfp
            // 
            txtAfp.Location = new Point(92, 45);
            txtAfp.Name = "txtAfp";
            txtAfp.Size = new Size(696, 23);
            txtAfp.TabIndex = 5;
            // 
            // txtArs
            // 
            txtArs.Location = new Point(92, 84);
            txtArs.Name = "txtArs";
            txtArs.Size = new Size(696, 23);
            txtArs.TabIndex = 6;
            // 
            // txtIsr
            // 
            txtIsr.Location = new Point(92, 127);
            txtIsr.Name = "txtIsr";
            txtIsr.Size = new Size(696, 23);
            txtIsr.TabIndex = 7;
            // 
            // lblAfpResultado
            // 
            lblAfpResultado.AutoSize = true;
            lblAfpResultado.Location = new Point(3, 219);
            lblAfpResultado.Name = "lblAfpResultado";
            lblAfpResultado.Size = new Size(83, 15);
            lblAfpResultado.TabIndex = 10;
            lblAfpResultado.Text = "Resultado AFP";
            // 
            // lblResultadoArs
            // 
            lblResultadoArs.AutoSize = true;
            lblResultadoArs.Location = new Point(3, 259);
            lblResultadoArs.Name = "lblResultadoArs";
            lblResultadoArs.Size = new Size(83, 15);
            lblResultadoArs.TabIndex = 11;
            lblResultadoArs.Text = "Resultado ARS";
            // 
            // lblResultadoIsr
            // 
            lblResultadoIsr.AutoSize = true;
            lblResultadoIsr.Location = new Point(3, 300);
            lblResultadoIsr.Name = "lblResultadoIsr";
            lblResultadoIsr.Size = new Size(78, 15);
            lblResultadoIsr.TabIndex = 12;
            lblResultadoIsr.Text = "Resultado ISR";
            // 
            // lblResultadoDescuento
            // 
            lblResultadoDescuento.AutoSize = true;
            lblResultadoDescuento.Location = new Point(3, 338);
            lblResultadoDescuento.Name = "lblResultadoDescuento";
            lblResultadoDescuento.Size = new Size(118, 15);
            lblResultadoDescuento.TabIndex = 13;
            lblResultadoDescuento.Text = "Resultado Descuento";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(713, 219);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 14;
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
            Controls.Add(lblResultadoDescuento);
            Controls.Add(lblResultadoIsr);
            Controls.Add(lblResultadoArs);
            Controls.Add(lblAfpResultado);
            Controls.Add(txtIsr);
            Controls.Add(txtArs);
            Controls.Add(txtAfp);
            Controls.Add(txtSueldoNeto);
            Controls.Add(lblIsr);
            Controls.Add(lblArs);
            Controls.Add(lblAfp);
            Controls.Add(lblSueldoNeto);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSueldoNeto;
        private Label lblAfp;
        private Label lblArs;
        private Label lblIsr;
        private TextBox txtSueldoNeto;
        private TextBox txtAfp;
        private TextBox txtArs;
        private TextBox txtIsr;
        private Label lblAfpResultado;
        private Label lblResultadoArs;
        private Label lblResultadoIsr;
        private Label lblResultadoDescuento;
        private Button btnCalcular;
    }
}
