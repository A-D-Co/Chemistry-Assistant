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
            this._P_Container = new System.Windows.Forms.Panel();
            this._Trb_Sauerstoff = new System.Windows.Forms.TrackBar();
            this._Trb_Wasserstoff = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._lbl_wasserstoff = new System.Windows.Forms.Label();
            this.labl2 = new System.Windows.Forms.Label();
            this._lbl_sauerstoff = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._lbl_Wasser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._Trb_Sauerstoff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Trb_Wasserstoff)).BeginInit();
            this.SuspendLayout();
            // 
            // _P_Container
            // 
            this._P_Container.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this._P_Container.Location = new System.Drawing.Point(12, 12);
            this._P_Container.Name = "_P_Container";
            this._P_Container.Size = new System.Drawing.Size(324, 426);
            this._P_Container.TabIndex = 0;
            this._P_Container.Paint += new System.Windows.Forms.PaintEventHandler(this._P_Container_Paint1);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(454, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "H2";
            // 
            // _lbl_wasserstoff
            // 
            this._lbl_wasserstoff.AutoSize = true;
            this._lbl_wasserstoff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbl_wasserstoff.Location = new System.Drawing.Point(499, 22);
            this._lbl_wasserstoff.Name = "_lbl_wasserstoff";
            this._lbl_wasserstoff.Size = new System.Drawing.Size(24, 25);
            this._lbl_wasserstoff.TabIndex = 6;
            this._lbl_wasserstoff.Text = "0";
            // 
            // labl2
            // 
            this.labl2.AutoSize = true;
            this.labl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labl2.Location = new System.Drawing.Point(454, 47);
            this.labl2.Name = "labl2";
            this.labl2.Size = new System.Drawing.Size(40, 25);
            this.labl2.TabIndex = 7;
            this.labl2.Text = "O2";
            // 
            // _lbl_sauerstoff
            // 
            this._lbl_sauerstoff.AutoSize = true;
            this._lbl_sauerstoff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbl_sauerstoff.Location = new System.Drawing.Point(499, 47);
            this._lbl_sauerstoff.Name = "_lbl_sauerstoff";
            this._lbl_sauerstoff.Size = new System.Drawing.Size(24, 25);
            this._lbl_sauerstoff.TabIndex = 8;
            this._lbl_sauerstoff.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(439, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "H2O";
            // 
            // _lbl_Wasser
            // 
            this._lbl_Wasser.AutoSize = true;
            this._lbl_Wasser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbl_Wasser.Location = new System.Drawing.Point(499, 72);
            this._lbl_Wasser.Name = "_lbl_Wasser";
            this._lbl_Wasser.Size = new System.Drawing.Size(24, 25);
            this._lbl_Wasser.TabIndex = 10;
            this._lbl_Wasser.Text = "0";
            // 
            // ChemischeReaktion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._lbl_Wasser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._lbl_sauerstoff);
            this.Controls.Add(this.labl2);
            this.Controls.Add(this._lbl_wasserstoff);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._Trb_Wasserstoff);
            this.Controls.Add(this._Trb_Sauerstoff);
            this.Controls.Add(this._P_Container);
            this.Name = "ChemischeReaktion";
            this.Text = "ChemischeReaktion";
            this.Load += new System.EventHandler(this.ChemischeReaktion_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Trb_Sauerstoff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Trb_Wasserstoff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel _P_Container;
        private System.Windows.Forms.TrackBar _Trb_Sauerstoff;
        private System.Windows.Forms.TrackBar _Trb_Wasserstoff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label _lbl_wasserstoff;
        private System.Windows.Forms.Label labl2;
        private System.Windows.Forms.Label _lbl_sauerstoff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label _lbl_Wasser;
    }
}