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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._lbl_Wasserstoff_zustand = new System.Windows.Forms.Label();
            this._lbl_sauerstoff_zustand = new System.Windows.Forms.Label();
            this._lbl_Vollstaedige = new System.Windows.Forms.Label();
            this._P_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._Trb_Sauerstoff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Trb_Wasserstoff)).BeginInit();
            this.SuspendLayout();
            // 
            // _P_Container
            // 
            this._P_Container.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this._P_Container.Controls.Add(this._lbl_Vollstaedige);
            this._P_Container.Location = new System.Drawing.Point(12, 39);
            this._P_Container.Name = "_P_Container";
            this._P_Container.Size = new System.Drawing.Size(324, 399);
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
            this.label3.Location = new System.Drawing.Point(474, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "H2";
            // 
            // _lbl_wasserstoff
            // 
            this._lbl_wasserstoff.AutoSize = true;
            this._lbl_wasserstoff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbl_wasserstoff.Location = new System.Drawing.Point(474, 103);
            this._lbl_wasserstoff.Name = "_lbl_wasserstoff";
            this._lbl_wasserstoff.Size = new System.Drawing.Size(24, 25);
            this._lbl_wasserstoff.TabIndex = 6;
            this._lbl_wasserstoff.Text = "0";
            // 
            // labl2
            // 
            this.labl2.AutoSize = true;
            this.labl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labl2.Location = new System.Drawing.Point(519, 39);
            this.labl2.Name = "labl2";
            this.labl2.Size = new System.Drawing.Size(40, 25);
            this.labl2.TabIndex = 7;
            this.labl2.Text = "O2";
            // 
            // _lbl_sauerstoff
            // 
            this._lbl_sauerstoff.AutoSize = true;
            this._lbl_sauerstoff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbl_sauerstoff.Location = new System.Drawing.Point(519, 103);
            this._lbl_sauerstoff.Name = "_lbl_sauerstoff";
            this._lbl_sauerstoff.Size = new System.Drawing.Size(24, 25);
            this._lbl_sauerstoff.TabIndex = 8;
            this._lbl_sauerstoff.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(565, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "H2O";
            // 
            // _lbl_Wasser
            // 
            this._lbl_Wasser.AutoSize = true;
            this._lbl_Wasser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbl_Wasser.Location = new System.Drawing.Point(565, 103);
            this._lbl_Wasser.Name = "_lbl_Wasser";
            this._lbl_Wasser.Size = new System.Drawing.Size(24, 25);
            this._lbl_Wasser.TabIndex = 10;
            this._lbl_Wasser.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Info;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 27);
            this.label5.TabIndex = 11;
            this.label5.Text = "2H2 + O2 = 2H2O";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(342, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Endzustand";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(339, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ausg. zustand";
            // 
            // _lbl_Wasserstoff_zustand
            // 
            this._lbl_Wasserstoff_zustand.AutoSize = true;
            this._lbl_Wasserstoff_zustand.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbl_Wasserstoff_zustand.Location = new System.Drawing.Point(474, 65);
            this._lbl_Wasserstoff_zustand.Name = "_lbl_Wasserstoff_zustand";
            this._lbl_Wasserstoff_zustand.Size = new System.Drawing.Size(24, 25);
            this._lbl_Wasserstoff_zustand.TabIndex = 14;
            this._lbl_Wasserstoff_zustand.Text = "0";
            // 
            // _lbl_sauerstoff_zustand
            // 
            this._lbl_sauerstoff_zustand.AutoSize = true;
            this._lbl_sauerstoff_zustand.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbl_sauerstoff_zustand.Location = new System.Drawing.Point(519, 66);
            this._lbl_sauerstoff_zustand.Name = "_lbl_sauerstoff_zustand";
            this._lbl_sauerstoff_zustand.Size = new System.Drawing.Size(24, 25);
            this._lbl_sauerstoff_zustand.TabIndex = 15;
            this._lbl_sauerstoff_zustand.Text = "0";
            // 
            // _lbl_Vollstaedige
            // 
            this._lbl_Vollstaedige.AutoSize = true;
            this._lbl_Vollstaedige.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbl_Vollstaedige.Location = new System.Drawing.Point(49, 190);
            this._lbl_Vollstaedige.Name = "_lbl_Vollstaedige";
            this._lbl_Vollstaedige.Size = new System.Drawing.Size(212, 25);
            this._lbl_Vollstaedige.TabIndex = 16;
            this._lbl_Vollstaedige.Text = "Vollständige zustand";
            this._lbl_Vollstaedige.Visible = false;
            // 
            // ChemischeReaktion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._lbl_sauerstoff_zustand);
            this.Controls.Add(this._lbl_Wasserstoff_zustand);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
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
            this._P_Container.ResumeLayout(false);
            this._P_Container.PerformLayout();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label _lbl_Wasserstoff_zustand;
        private System.Windows.Forms.Label _lbl_sauerstoff_zustand;
        private System.Windows.Forms.Label _lbl_Vollstaedige;
    }
}