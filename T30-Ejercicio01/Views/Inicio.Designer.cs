namespace T30_Ejercicio01
{
    partial class ViewInicio
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
            btnNuevoCliente = new Button();
            SuspendLayout();
            // 
            // btnNuevoCliente
            // 
            btnNuevoCliente.Location = new Point(328, 104);
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.Size = new Size(130, 23);
            btnNuevoCliente.TabIndex = 0;
            btnNuevoCliente.Text = "Nuevo cliente";
            btnNuevoCliente.UseVisualStyleBackColor = true;
            btnNuevoCliente.Click += btnNuevoCliente_Click;
            // 
            // ViewInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNuevoCliente);
            Name = "ViewInicio";
            Text = "Inicio";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnNuevoCliente;
    }
}