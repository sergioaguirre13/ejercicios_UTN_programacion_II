namespace HolaWindowsForms
{
    partial class HolaForm
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            btnSaludar = new Button();
            txtApellido = new TextBox();
            lblApellido = new Label();
            cmbMateria = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(74, 9);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 18);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(59, 40);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // btnSaludar
            // 
            btnSaludar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaludar.Location = new Point(250, 180);
            btnSaludar.Name = "btnSaludar";
            btnSaludar.Size = new Size(128, 39);
            btnSaludar.TabIndex = 2;
            btnSaludar.Text = "S A L U D A R";
            btnSaludar.UseVisualStyleBackColor = true;
            btnSaludar.Click += btnSaludar_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(202, 40);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 4;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(216, 9);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(74, 18);
            lblApellido.TabIndex = 5;
            lblApellido.Text = "Apellido";
            // 
            // cmbMateria
            // 
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Location = new Point(112, 119);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(140, 23);
            cmbMateria.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(112, 82);
            label1.Name = "label1";
            label1.Size = new Size(140, 18);
            label1.TabIndex = 7;
            label1.Text = "Materia Favorita";
            // 
            // HolaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 231);
            Controls.Add(label1);
            Controls.Add(cmbMateria);
            Controls.Add(lblApellido);
            Controls.Add(txtApellido);
            Controls.Add(btnSaludar);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "HolaForm";
            Text = "HolaForm";
            Load += HolaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Button btnSaludar;
        private TextBox txtApellido;
        private Label lblApellido;
        private ComboBox cmbMateria;
        private Label label1;
    }
}
