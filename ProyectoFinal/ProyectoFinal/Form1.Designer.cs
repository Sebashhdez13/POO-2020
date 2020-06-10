namespace ProyectoFinal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MarioPlayer = new System.Windows.Forms.PictureBox();
            this.PlantaArriba = new System.Windows.Forms.PictureBox();
            this.PlantaAbajo = new System.Windows.Forms.PictureBox();
            this.Barrera = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.Puntaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MarioPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlantaArriba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlantaAbajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barrera)).BeginInit();
            this.SuspendLayout();
            // 
            // MarioPlayer
            // 
            this.MarioPlayer.BackColor = System.Drawing.Color.Transparent;
            this.MarioPlayer.Image = global::ProyectoFinal.Properties.Resources.Captura2;
            this.MarioPlayer.Location = new System.Drawing.Point(98, 279);
            this.MarioPlayer.Name = "MarioPlayer";
            this.MarioPlayer.Size = new System.Drawing.Size(54, 94);
            this.MarioPlayer.TabIndex = 0;
            this.MarioPlayer.TabStop = false;
            // 
            // PlantaArriba
            // 
            this.PlantaArriba.BackColor = System.Drawing.Color.Transparent;
            this.PlantaArriba.Image = global::ProyectoFinal.Properties.Resources.Planta_super_mario;
            this.PlantaArriba.Location = new System.Drawing.Point(212, -37);
            this.PlantaArriba.Name = "PlantaArriba";
            this.PlantaArriba.Size = new System.Drawing.Size(54, 264);
            this.PlantaArriba.TabIndex = 1;
            this.PlantaArriba.TabStop = false;
            // 
            // PlantaAbajo
            // 
            this.PlantaAbajo.BackColor = System.Drawing.Color.Transparent;
            this.PlantaAbajo.Image = global::ProyectoFinal.Properties.Resources.planta_boca_abajo;
            this.PlantaAbajo.Location = new System.Drawing.Point(212, 425);
            this.PlantaAbajo.Name = "PlantaAbajo";
            this.PlantaAbajo.Size = new System.Drawing.Size(59, 272);
            this.PlantaAbajo.TabIndex = 2;
            this.PlantaAbajo.TabStop = false;
            // 
            // Barrera
            // 
            this.Barrera.Image = global::ProyectoFinal.Properties.Resources.piso;
            this.Barrera.Location = new System.Drawing.Point(0, 640);
            this.Barrera.Name = "Barrera";
            this.Barrera.Size = new System.Drawing.Size(318, 68);
            this.Barrera.TabIndex = 3;
            this.Barrera.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 10;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Puntaje
            // 
            this.Puntaje.AutoSize = true;
            this.Puntaje.BackColor = System.Drawing.Color.Transparent;
            this.Puntaje.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Puntaje.ForeColor = System.Drawing.Color.Black;
            this.Puntaje.Location = new System.Drawing.Point(118, 253);
            this.Puntaje.Name = "Puntaje";
            this.Puntaje.Size = new System.Drawing.Size(20, 23);
            this.Puntaje.TabIndex = 4;
            this.Puntaje.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(318, 709);
            this.Controls.Add(this.Puntaje);
            this.Controls.Add(this.Barrera);
            this.Controls.Add(this.PlantaAbajo);
            this.Controls.Add(this.PlantaArriba);
            this.Controls.Add(this.MarioPlayer);
            this.Name = "Form1";
            this.Text = "Flappy Mario";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.MarioPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlantaArriba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlantaAbajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barrera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MarioPlayer;
        private System.Windows.Forms.PictureBox PlantaArriba;
        private System.Windows.Forms.PictureBox PlantaAbajo;
        private System.Windows.Forms.PictureBox Barrera;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label Puntaje;
    }
}

