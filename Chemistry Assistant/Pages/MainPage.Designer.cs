namespace Chemistry_Assistant
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.SwitchPanel = new System.Windows.Forms.Panel();
            this.Bt_Rechner = new System.Windows.Forms.Button();
            this.BT_Pse = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Bt_simulation = new System.Windows.Forms.Button();
            this.SwitchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SwitchPanel
            // 
            this.SwitchPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.SwitchPanel.Controls.Add(this.Bt_simulation);
            this.SwitchPanel.Controls.Add(this.Bt_Rechner);
            this.SwitchPanel.Controls.Add(this.BT_Pse);
            this.SwitchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SwitchPanel.Location = new System.Drawing.Point(0, 0);
            this.SwitchPanel.Name = "SwitchPanel";
            this.SwitchPanel.Size = new System.Drawing.Size(1904, 35);
            this.SwitchPanel.TabIndex = 0;
            // 
            // Bt_Rechner
            // 
            this.Bt_Rechner.Dock = System.Windows.Forms.DockStyle.Left;
            this.Bt_Rechner.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_Rechner.Location = new System.Drawing.Point(128, 0);
            this.Bt_Rechner.Name = "Bt_Rechner";
            this.Bt_Rechner.Size = new System.Drawing.Size(142, 35);
            this.Bt_Rechner.TabIndex = 1;
            this.Bt_Rechner.Text = "Rechner";
            this.Bt_Rechner.UseVisualStyleBackColor = true;
            this.Bt_Rechner.Click += new System.EventHandler(this.Bt_Rechner_Click);
            // 
            // BT_Pse
            // 
            this.BT_Pse.BackColor = System.Drawing.Color.Transparent;
            this.BT_Pse.Dock = System.Windows.Forms.DockStyle.Left;
            this.BT_Pse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_Pse.Location = new System.Drawing.Point(0, 0);
            this.BT_Pse.Name = "BT_Pse";
            this.BT_Pse.Size = new System.Drawing.Size(128, 35);
            this.BT_Pse.TabIndex = 0;
            this.BT_Pse.Text = "Perioden System";
            this.BT_Pse.UseVisualStyleBackColor = false;
            this.BT_Pse.Click += new System.EventHandler(this.BT_Pse_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 35);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1904, 1006);
            this.MainPanel.TabIndex = 1;
            // 
            // Bt_simulation
            // 
            this.Bt_simulation.Dock = System.Windows.Forms.DockStyle.Left;
            this.Bt_simulation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_simulation.Location = new System.Drawing.Point(270, 0);
            this.Bt_simulation.Name = "Bt_simulation";
            this.Bt_simulation.Size = new System.Drawing.Size(142, 35);
            this.Bt_simulation.TabIndex = 2;
            this.Bt_simulation.Text = "Simulation";
            this.Bt_simulation.UseVisualStyleBackColor = true;
            this.Bt_simulation.Click += new System.EventHandler(this.Bt_simulation_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.SwitchPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SwitchPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SwitchPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button BT_Pse;
        private System.Windows.Forms.Button Bt_Rechner;
        private System.Windows.Forms.Button Bt_simulation;
    }
}

