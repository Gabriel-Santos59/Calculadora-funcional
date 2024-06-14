namespace Calculadora_funcional
{
    partial class FormPrincipal
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
            lblTitulo = new Label();
            btnCalculadora = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BorderStyle = BorderStyle.Fixed3D;
            lblTitulo.Font = new Font("Segoe UI", 18F);
            lblTitulo.Location = new Point(160, 92);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(442, 34);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Clique abaixo para acessar a calculadora";
            // 
            // btnCalculadora
            // 
            btnCalculadora.Location = new Point(294, 219);
            btnCalculadora.Name = "btnCalculadora";
            btnCalculadora.Size = new Size(148, 61);
            btnCalculadora.TabIndex = 1;
            btnCalculadora.Text = "Calculadora";
            btnCalculadora.UseVisualStyleBackColor = true;
            btnCalculadora.Click += btnCalculadora_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalculadora);
            Controls.Add(lblTitulo);
            Name = "FormPrincipal";
            Text = "Tela Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnCalculadora;
    }
}
