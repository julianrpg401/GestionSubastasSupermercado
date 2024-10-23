namespace GestionSubastasSupermercado
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
            gbSubasta = new GroupBox();
            rbComprador = new RadioButton();
            rbEspectador = new RadioButton();
            gbTipoUsuario = new GroupBox();
            cmbTipoSubasta = new ComboBox();
            lblTipoSubasta = new Label();
            gbSubasta.SuspendLayout();
            gbTipoUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // gbSubasta
            // 
            gbSubasta.Controls.Add(lblTipoSubasta);
            gbSubasta.Controls.Add(cmbTipoSubasta);
            gbSubasta.Location = new Point(12, 155);
            gbSubasta.Name = "gbSubasta";
            gbSubasta.Size = new Size(452, 289);
            gbSubasta.TabIndex = 0;
            gbSubasta.TabStop = false;
            gbSubasta.Text = "Subasta";
            // 
            // rbComprador
            // 
            rbComprador.AutoSize = true;
            rbComprador.Location = new Point(80, 54);
            rbComprador.Name = "rbComprador";
            rbComprador.Size = new Size(129, 29);
            rbComprador.TabIndex = 1;
            rbComprador.TabStop = true;
            rbComprador.Text = "Comprador";
            rbComprador.UseVisualStyleBackColor = true;
            // 
            // rbEspectador
            // 
            rbEspectador.AutoSize = true;
            rbEspectador.Location = new Point(246, 54);
            rbEspectador.Name = "rbEspectador";
            rbEspectador.Size = new Size(125, 29);
            rbEspectador.TabIndex = 2;
            rbEspectador.TabStop = true;
            rbEspectador.Text = "Espectador";
            rbEspectador.UseVisualStyleBackColor = true;
            // 
            // gbTipoUsuario
            // 
            gbTipoUsuario.Controls.Add(rbComprador);
            gbTipoUsuario.Controls.Add(rbEspectador);
            gbTipoUsuario.Location = new Point(12, 12);
            gbTipoUsuario.Name = "gbTipoUsuario";
            gbTipoUsuario.Size = new Size(452, 118);
            gbTipoUsuario.TabIndex = 3;
            gbTipoUsuario.TabStop = false;
            gbTipoUsuario.Text = "Tipo de usuario";
            // 
            // cmbTipoSubasta
            // 
            cmbTipoSubasta.FormattingEnabled = true;
            cmbTipoSubasta.Items.AddRange(new object[] { "Ascendente", "Descendente", "Cerrada" });
            cmbTipoSubasta.Location = new Point(177, 43);
            cmbTipoSubasta.Name = "cmbTipoSubasta";
            cmbTipoSubasta.Size = new Size(194, 33);
            cmbTipoSubasta.TabIndex = 0;
            // 
            // lblTipoSubasta
            // 
            lblTipoSubasta.AutoSize = true;
            lblTipoSubasta.Location = new Point(19, 46);
            lblTipoSubasta.Name = "lblTipoSubasta";
            lblTipoSubasta.Size = new Size(138, 25);
            lblTipoSubasta.TabIndex = 1;
            lblTipoSubasta.Text = "Tipo de subasta";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 564);
            Controls.Add(gbTipoUsuario);
            Controls.Add(gbSubasta);
            Name = "Form1";
            Text = "Form1";
            gbSubasta.ResumeLayout(false);
            gbSubasta.PerformLayout();
            gbTipoUsuario.ResumeLayout(false);
            gbTipoUsuario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbSubasta;
        private RadioButton rbComprador;
        private RadioButton rbEspectador;
        private GroupBox gbTipoUsuario;
        private ComboBox cmbTipoSubasta;
        private Label lblTipoSubasta;
    }
}
