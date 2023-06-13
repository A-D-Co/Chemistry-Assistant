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
            this._bt_Apps = new Chemistry_Assistant.Button_WOC();
            this._bt_Pse = new Chemistry_Assistant.Button_WOC();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SwitchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SwitchPanel
            // 
            this.SwitchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.SwitchPanel.Controls.Add(this._bt_Apps);
            this.SwitchPanel.Controls.Add(this._bt_Pse);
            this.SwitchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SwitchPanel.Location = new System.Drawing.Point(0, 0);
            this.SwitchPanel.Name = "SwitchPanel";
            this.SwitchPanel.Size = new System.Drawing.Size(1904, 43);
            this.SwitchPanel.TabIndex = 0;
            // 
            // _bt_Apps
            // 
            this._bt_Apps.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this._bt_Apps.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this._bt_Apps.FlatAppearance.BorderSize = 0;
            this._bt_Apps.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this._bt_Apps.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this._bt_Apps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._bt_Apps.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bt_Apps.Location = new System.Drawing.Point(143, 3);
            this._bt_Apps.Name = "_bt_Apps";
            this._bt_Apps.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this._bt_Apps.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this._bt_Apps.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this._bt_Apps.Size = new System.Drawing.Size(134, 34);
            this._bt_Apps.TabIndex = 1;
            this._bt_Apps.Text = "Apps";
            this._bt_Apps.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this._bt_Apps.UseVisualStyleBackColor = true;
            this._bt_Apps.Click += new System.EventHandler(this.Bt_Apps_Click);
            // 
            // _bt_Pse
            // 
            this._bt_Pse.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this._bt_Pse.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this._bt_Pse.FlatAppearance.BorderSize = 0;
            this._bt_Pse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this._bt_Pse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this._bt_Pse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._bt_Pse.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bt_Pse.Location = new System.Drawing.Point(3, 3);
            this._bt_Pse.Name = "_bt_Pse";
            this._bt_Pse.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this._bt_Pse.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this._bt_Pse.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this._bt_Pse.Size = new System.Drawing.Size(134, 34);
            this._bt_Pse.TabIndex = 0;
            this._bt_Pse.Text = "PSe";
            this._bt_Pse.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this._bt_Pse.UseVisualStyleBackColor = true;
            this._bt_Pse.Click += new System.EventHandler(this.BT_Pse_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 43);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1904, 998);
            this.MainPanel.TabIndex = 1;
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
        private Button_WOC _bt_Pse;
        private Button_WOC _bt_Apps;
    }
}

