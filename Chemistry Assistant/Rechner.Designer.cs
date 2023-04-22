namespace Chemistry_Assistant
{
    partial class Rechner
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
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_Formel = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BT_Rechnen = new System.Windows.Forms.Button();
            this.L_Formel = new System.Windows.Forms.Label();
            this.L_Mol = new System.Windows.Forms.Label();
            this.TB_Mol = new System.Windows.Forms.TextBox();
            this.L_Masse = new System.Windows.Forms.Label();
            this.TB_Masse = new System.Windows.Forms.TextBox();
            this.TB_MolareMass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(436, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rechner";
            // 
            // Tb_Formel
            // 
            this.Tb_Formel.Location = new System.Drawing.Point(199, 140);
            this.Tb_Formel.Name = "Tb_Formel";
            this.Tb_Formel.Size = new System.Drawing.Size(199, 20);
            this.Tb_Formel.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // BT_Rechnen
            // 
            this.BT_Rechnen.Location = new System.Drawing.Point(168, 265);
            this.BT_Rechnen.Name = "BT_Rechnen";
            this.BT_Rechnen.Size = new System.Drawing.Size(75, 23);
            this.BT_Rechnen.TabIndex = 3;
            this.BT_Rechnen.Text = "Rechnen";
            this.BT_Rechnen.UseVisualStyleBackColor = true;
            this.BT_Rechnen.Click += new System.EventHandler(this.BT_Rechnen_Click);
            // 
            // L_Formel
            // 
            this.L_Formel.AutoSize = true;
            this.L_Formel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Formel.Location = new System.Drawing.Point(118, 140);
            this.L_Formel.Name = "L_Formel";
            this.L_Formel.Size = new System.Drawing.Size(66, 29);
            this.L_Formel.TabIndex = 4;
            this.L_Formel.Text = "Formel";
            // 
            // L_Mol
            // 
            this.L_Mol.AutoSize = true;
            this.L_Mol.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Mol.Location = new System.Drawing.Point(141, 163);
            this.L_Mol.Name = "L_Mol";
            this.L_Mol.Size = new System.Drawing.Size(43, 29);
            this.L_Mol.TabIndex = 5;
            this.L_Mol.Text = "Mol";
            // 
            // TB_Mol
            // 
            this.TB_Mol.Location = new System.Drawing.Point(199, 166);
            this.TB_Mol.Name = "TB_Mol";
            this.TB_Mol.Size = new System.Drawing.Size(199, 20);
            this.TB_Mol.TabIndex = 6;
            this.TB_Mol.Text = "1";
            this.TB_Mol.TextChanged += new System.EventHandler(this.TB_Mol_TextChanged);
            // 
            // L_Masse
            // 
            this.L_Masse.AutoSize = true;
            this.L_Masse.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Masse.Location = new System.Drawing.Point(91, 189);
            this.L_Masse.Name = "L_Masse";
            this.L_Masse.Size = new System.Drawing.Size(93, 29);
            this.L_Masse.TabIndex = 7;
            this.L_Masse.Text = "Masse in g";
            // 
            // TB_Masse
            // 
            this.TB_Masse.AccessibleName = "";
            this.TB_Masse.Location = new System.Drawing.Point(199, 192);
            this.TB_Masse.Name = "TB_Masse";
            this.TB_Masse.Size = new System.Drawing.Size(199, 20);
            this.TB_Masse.TabIndex = 8;
            this.TB_Masse.Text = "0";
            this.TB_Masse.TextChanged += new System.EventHandler(this.TB_Masse_TextChanged);
            // 
            // TB_MolareMass
            // 
            this.TB_MolareMass.Location = new System.Drawing.Point(199, 218);
            this.TB_MolareMass.Name = "TB_MolareMass";
            this.TB_MolareMass.ReadOnly = true;
            this.TB_MolareMass.Size = new System.Drawing.Size(199, 20);
            this.TB_MolareMass.TabIndex = 9;
            this.TB_MolareMass.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Molmasse (g/mol)";
            // 
            // Rechner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_MolareMass);
            this.Controls.Add(this.TB_Masse);
            this.Controls.Add(this.L_Masse);
            this.Controls.Add(this.TB_Mol);
            this.Controls.Add(this.L_Mol);
            this.Controls.Add(this.L_Formel);
            this.Controls.Add(this.BT_Rechnen);
            this.Controls.Add(this.Tb_Formel);
            this.Controls.Add(this.label1);
            this.Name = "Rechner";
            this.Size = new System.Drawing.Size(985, 489);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_Formel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button BT_Rechnen;
        private System.Windows.Forms.Label L_Formel;
        private System.Windows.Forms.Label L_Mol;
        private System.Windows.Forms.TextBox TB_Mol;
        private System.Windows.Forms.Label L_Masse;
        private System.Windows.Forms.TextBox TB_Masse;
        private System.Windows.Forms.TextBox TB_MolareMass;
        private System.Windows.Forms.Label label2;
    }
}
