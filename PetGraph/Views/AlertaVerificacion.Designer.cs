namespace PetGraph.Views
{
    partial class AlertaVerificacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlertaVerificacion));
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCompletado = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Press Start 2P", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(156, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(365, 78);
            this.label3.TabIndex = 10;
            this.label3.Text = "¿Estás seguro que quieres verificar tu gráfico?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PetGraph.Properties.Resources.helpLogo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCompletado
            // 
            this.buttonCompletado.BackColor = System.Drawing.Color.LightGreen;
            this.buttonCompletado.CausesValidation = false;
            this.buttonCompletado.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonCompletado.FlatAppearance.BorderSize = 0;
            this.buttonCompletado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonCompletado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCompletado.Font = new System.Drawing.Font("Press Start 2P", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCompletado.ForeColor = System.Drawing.Color.White;
            this.buttonCompletado.Location = new System.Drawing.Point(347, 167);
            this.buttonCompletado.Name = "buttonCompletado";
            this.buttonCompletado.Size = new System.Drawing.Size(128, 46);
            this.buttonCompletado.TabIndex = 17;
            this.buttonCompletado.TabStop = false;
            this.buttonCompletado.Text = "Si";
            this.buttonCompletado.UseVisualStyleBackColor = false;
            this.buttonCompletado.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.buttonCompletado.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.BackColor = System.Drawing.Color.IndianRed;
            this.buttonCerrar.CausesValidation = false;
            this.buttonCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonCerrar.FlatAppearance.BorderSize = 0;
            this.buttonCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCerrar.Font = new System.Drawing.Font("Press Start 2P", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrar.ForeColor = System.Drawing.Color.White;
            this.buttonCerrar.Location = new System.Drawing.Point(176, 167);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(128, 46);
            this.buttonCerrar.TabIndex = 18;
            this.buttonCerrar.TabStop = false;
            this.buttonCerrar.Text = "No";
            this.buttonCerrar.UseVisualStyleBackColor = false;
            this.buttonCerrar.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.buttonCerrar.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // AlertaVerificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 240);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonCompletado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlertaVerificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlertaVerificacion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonCompletado;
        private System.Windows.Forms.Button buttonCerrar;
    }
}