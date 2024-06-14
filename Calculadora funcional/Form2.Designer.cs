namespace Calculadora_funcional
{
    partial class FormCalculadora
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
            lblValor1 = new Label();
            lblValor2 = new Label();
            lblResultado = new Label();
            btnSoma = new Button();
            btnMultiplicação = new Button();
            btnSubtração = new Button();
            btnDivisão = new Button();
            btnLimpar = new Button();
            txtValor1 = new TextBox();
            txtValor2 = new TextBox();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // lblValor1
            // 
            lblValor1.AutoSize = true;
            lblValor1.Font = new Font("Segoe UI", 15F);
            lblValor1.Location = new Point(12, 46);
            lblValor1.Name = "lblValor1";
            lblValor1.Size = new Size(73, 28);
            lblValor1.TabIndex = 0;
            lblValor1.Text = "Valor 1";
            // 
            // lblValor2
            // 
            lblValor2.AutoSize = true;
            lblValor2.Font = new Font("Segoe UI", 15F);
            lblValor2.Location = new Point(12, 114);
            lblValor2.Name = "lblValor2";
            lblValor2.Size = new Size(73, 28);
            lblValor2.TabIndex = 1;
            lblValor2.Text = "Valor 2";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 15F);
            lblResultado.Location = new Point(12, 358);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(98, 28);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "Resultado";
            // 
            // btnSoma
            // 
            btnSoma.Location = new Point(347, 46);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(95, 36);
            btnSoma.TabIndex = 3;
            btnSoma.Text = "Soma";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnMultiplicação
            // 
            btnMultiplicação.Location = new Point(347, 121);
            btnMultiplicação.Name = "btnMultiplicação";
            btnMultiplicação.Size = new Size(95, 37);
            btnMultiplicação.TabIndex = 4;
            btnMultiplicação.Text = "Multiplicação";
            btnMultiplicação.UseVisualStyleBackColor = true;
            btnMultiplicação.Click += btnMultiplicação_Click;
            // 
            // btnSubtração
            // 
            btnSubtração.Location = new Point(497, 46);
            btnSubtração.Name = "btnSubtração";
            btnSubtração.Size = new Size(93, 36);
            btnSubtração.TabIndex = 5;
            btnSubtração.Text = "Subtração";
            btnSubtração.UseVisualStyleBackColor = true;
            btnSubtração.Click += btnSubtração_Click;
            // 
            // btnDivisão
            // 
            btnDivisão.Location = new Point(497, 121);
            btnDivisão.Name = "btnDivisão";
            btnDivisão.Size = new Size(93, 37);
            btnDivisão.TabIndex = 6;
            btnDivisão.Text = "Divisão";
            btnDivisão.UseVisualStyleBackColor = true;
            btnDivisão.Click += btnDivisão_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(147, 222);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(93, 36);
            btnLimpar.TabIndex = 8;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(134, 48);
            txtValor1.Multiline = true;
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(140, 26);
            txtValor1.TabIndex = 9;
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(134, 122);
            txtValor2.Multiline = true;
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(140, 31);
            txtValor2.TabIndex = 10;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(134, 355);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(140, 31);
            txtResultado.TabIndex = 11;
            // 
            // FormCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResultado);
            Controls.Add(txtValor2);
            Controls.Add(txtValor1);
            Controls.Add(btnLimpar);
            Controls.Add(btnDivisão);
            Controls.Add(btnSubtração);
            Controls.Add(btnMultiplicação);
            Controls.Add(btnSoma);
            Controls.Add(lblResultado);
            Controls.Add(lblValor2);
            Controls.Add(lblValor1);
            Name = "FormCalculadora";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblValor1;
        private Label lblValor2;
        private Label lblResultado;
        private Button btnSoma;
        private Button btnMultiplicação;
        private Button btnSubtração;
        private Button btnDivisão;
        private Button btnLimpar;
        private TextBox txtValor1;
        private TextBox txtValor2;
        private TextBox txtResultado;
    }
}