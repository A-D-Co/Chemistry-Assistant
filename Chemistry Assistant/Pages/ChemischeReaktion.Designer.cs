namespace Chemistry_Assistant.Pages
{
    partial class ChemischeReaktion
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this._Trb_Sauerstoff = new System.Windows.Forms.TrackBar();
            this._Trb_Wasserstoff = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._T_Movement = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._Trb_Sauerstoff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Trb_Wasserstoff)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 450);
            this.panel1.TabIndex = 0;
            // 
            // _Trb_Sauerstoff
            // 
            this._Trb_Sauerstoff.Location = new System.Drawing.Point(434, 308);
            this._Trb_Sauerstoff.Name = "_Trb_Sauerstoff";
            this._Trb_Sauerstoff.Size = new System.Drawing.Size(309, 45);
            this._Trb_Sauerstoff.TabIndex = 1;
            this._Trb_Sauerstoff.Scroll += new System.EventHandler(this._Trb_Sauerstoff_Scroll);
            // 
            // _Trb_Wasserstoff
            // 
            this._Trb_Wasserstoff.Location = new System.Drawing.Point(434, 379);
            this._Trb_Wasserstoff.Name = "_Trb_Wasserstoff";
            this._Trb_Wasserstoff.Size = new System.Drawing.Size(309, 45);
            this._Trb_Wasserstoff.TabIndex = 2;
            this._Trb_Wasserstoff.Scroll += new System.EventHandler(this._Trb_Wasserstoff_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(439, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sauerstoff";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(439, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wasserstoff";
            // 
            // _T_Movement
            // 
            this._T_Movement.Tick += new System.EventHandler(this._T_Movement_Tick);
            // 
            // ChemischeReaktion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._Trb_Wasserstoff);
            this.Controls.Add(this._Trb_Sauerstoff);
            this.Controls.Add(this.panel1);
            this.Name = "ChemischeReaktion";
            this.Text = "ChemischeReaktion";
            ((System.ComponentModel.ISupportInitialize)(this._Trb_Sauerstoff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Trb_Wasserstoff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar _Trb_Sauerstoff;
        private System.Windows.Forms.TrackBar _Trb_Wasserstoff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer _T_Movement;
    }
}