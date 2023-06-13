namespace Chemistry_Assistant
{
    partial class Apps

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Apps));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Pb_Rechnen = new System.Windows.Forms.PictureBox();
            this.Pb_Simulation = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Rechnen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Simulation)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Molare Masse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(398, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chemische Reaktion";
            // 
            // Pb_Rechnen
            // 
            this.Pb_Rechnen.Image = global::Chemistry_Assistant.Properties.Resources.Calculator_PNG_Clipart;
            this.Pb_Rechnen.Location = new System.Drawing.Point(68, 70);
            this.Pb_Rechnen.Name = "Pb_Rechnen";
            this.Pb_Rechnen.Size = new System.Drawing.Size(240, 227);
            this.Pb_Rechnen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_Rechnen.TabIndex = 4;
            this.Pb_Rechnen.TabStop = false;
            this.Pb_Rechnen.Click += new System.EventHandler(this.Pb_Rechnen_Click);
            // 
            // Pb_Simulation
            // 
            this.Pb_Simulation.BackColor = System.Drawing.Color.Transparent;
            this.Pb_Simulation.Image = ((System.Drawing.Image)(resources.GetObject("Pb_Simulation.Image")));
            this.Pb_Simulation.Location = new System.Drawing.Point(381, 70);
            this.Pb_Simulation.Name = "Pb_Simulation";
            this.Pb_Simulation.Size = new System.Drawing.Size(240, 227);
            this.Pb_Simulation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_Simulation.TabIndex = 2;
            this.Pb_Simulation.TabStop = false;
            this.Pb_Simulation.Click += new System.EventHandler(this.Pb_Simulation_Click);
            // 
            // Apps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.Controls.Add(this.Pb_Rechnen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pb_Simulation);
            this.Controls.Add(this.label1);
            this.Name = "Apps";
            this.Size = new System.Drawing.Size(1920, 1080);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Rechnen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Simulation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Pb_Simulation;
        private System.Windows.Forms.PictureBox Pb_Rechnen;
    }
}
