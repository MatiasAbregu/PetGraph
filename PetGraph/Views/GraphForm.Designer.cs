﻿namespace PetGraph.Views
{
    partial class GraphForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCompletado = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCerrar = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Puntaje: 0";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "(0, 0)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(411, 319);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(70, 89);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(781, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Objetivo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Click += new System.EventHandler(this.ClickObjetivo);
            this.label3.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonCompletado);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.labelCerrar);
            this.panel2.Location = new System.Drawing.Point(571, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 202);
            this.panel2.TabIndex = 7;
            this.panel2.Visible = false;
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
            this.buttonCompletado.Location = new System.Drawing.Point(31, 168);
            this.buttonCompletado.Name = "buttonCompletado";
            this.buttonCompletado.Size = new System.Drawing.Size(265, 28);
            this.buttonCompletado.TabIndex = 16;
            this.buttonCompletado.TabStop = false;
            this.buttonCompletado.Text = "¡Completar el objetivo!";
            this.buttonCompletado.UseVisualStyleBackColor = false;
            this.buttonCompletado.Click += new System.EventHandler(this.buttonCompletado_Click);
            this.buttonCompletado.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.buttonCompletado.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 127);
            this.label4.TabIndex = 5;
            this.label4.Text = "Represente el siguiente conjunto o función en el eje de cordenadas cartesianas:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCerrar
            // 
            this.labelCerrar.AutoSize = true;
            this.labelCerrar.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F);
            this.labelCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelCerrar.Location = new System.Drawing.Point(2, 2);
            this.labelCerrar.MinimumSize = new System.Drawing.Size(35, 0);
            this.labelCerrar.Name = "labelCerrar";
            this.labelCerrar.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.labelCerrar.Size = new System.Drawing.Size(35, 27);
            this.labelCerrar.TabIndex = 15;
            this.labelCerrar.Text = "X";
            this.labelCerrar.Click += new System.EventHandler(this.labelCerrar_Click);
            this.labelCerrar.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.labelCerrar.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::PetGraph.Properties.Resources.exclamation;
            this.pictureBox3.Location = new System.Drawing.Point(863, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.ClickObjetivo);
            this.pictureBox3.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::PetGraph.Properties.Resources.controls_image;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 654);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(901, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GraphForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PetGraph - ¡Juega!";
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.GraphForm_Scroll);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GraphForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GraphForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GraphForm_KeyUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelCerrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCompletado;
    }
}