namespace HolaWindowsForms
{
    partial class SaludarForm
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
            lblHola = new Label();
            lblNombreApellido = new Label();
            SuspendLayout();
            // 
            // lblHola
            // 
            lblHola.AutoSize = true;
            lblHola.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHola.Location = new Point(65, 41);
            lblHola.Name = "lblHola";
            lblHola.Size = new Size(219, 25);
            lblHola.TabIndex = 0;
            lblHola.Text = "¡Hola, Windows Forms!";
            // 
            // lblNombreApellido
            // 
            lblNombreApellido.AutoSize = true;
            lblNombreApellido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreApellido.Location = new Point(39, 98);
            lblNombreApellido.Name = "lblNombreApellido";
            lblNombreApellido.Size = new Size(173, 21);
            lblNombreApellido.TabIndex = 1;
            lblNombreApellido.Text = "label nombre y apellido";
            // 
            // SaludarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 212);
            Controls.Add(lblNombreApellido);
            Controls.Add(lblHola);
            Name = "SaludarForm";
            Text = "SaludarForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHola;
        private Label lblNombreApellido;
    }
}