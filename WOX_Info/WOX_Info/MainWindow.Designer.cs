namespace WOX_Info
{
    partial class MainWindow
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
            this._tab_panel = new System.Windows.Forms.TabControl();
            this._armor_panel = new System.Windows.Forms.TabPage();
            this._armor_panel_select_label = new System.Windows.Forms.Label();
            this._armor_panel_dropdown = new System.Windows.Forms.ComboBox();
            this._weapon_panel = new System.Windows.Forms.TabPage();
            this._weapon_panel_select_label = new System.Windows.Forms.Label();
            this._weapon_panel_dropdown = new System.Windows.Forms.ComboBox();
            this._tab_panel.SuspendLayout();
            this._armor_panel.SuspendLayout();
            this._weapon_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tab_panel
            // 
            this._tab_panel.Controls.Add(this._armor_panel);
            this._tab_panel.Controls.Add(this._weapon_panel);
            this._tab_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tab_panel.Location = new System.Drawing.Point(0, 0);
            this._tab_panel.Name = "_tab_panel";
            this._tab_panel.SelectedIndex = 0;
            this._tab_panel.Size = new System.Drawing.Size(362, 284);
            this._tab_panel.TabIndex = 0;
            // 
            // _armor_panel
            // 
            this._armor_panel.BackColor = System.Drawing.Color.Transparent;
            this._armor_panel.Controls.Add(this._armor_panel_select_label);
            this._armor_panel.Controls.Add(this._armor_panel_dropdown);
            this._armor_panel.Location = new System.Drawing.Point(4, 22);
            this._armor_panel.Name = "_armor_panel";
            this._armor_panel.Padding = new System.Windows.Forms.Padding(3);
            this._armor_panel.Size = new System.Drawing.Size(354, 258);
            this._armor_panel.TabIndex = 0;
            this._armor_panel.Text = "Armors";
            // 
            // _armor_panel_select_label
            // 
            this._armor_panel_select_label.AutoSize = true;
            this._armor_panel_select_label.Location = new System.Drawing.Point(8, 3);
            this._armor_panel_select_label.Name = "_armor_panel_select_label";
            this._armor_panel_select_label.Size = new System.Drawing.Size(73, 13);
            this._armor_panel_select_label.TabIndex = 1;
            this._armor_panel_select_label.Text = "Select Armor :";
            // 
            // _armor_panel_dropdown
            // 
            this._armor_panel_dropdown.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this._armor_panel_dropdown.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this._armor_panel_dropdown.FormattingEnabled = true;
            this._armor_panel_dropdown.Location = new System.Drawing.Point(11, 19);
            this._armor_panel_dropdown.Name = "_armor_panel_dropdown";
            this._armor_panel_dropdown.Size = new System.Drawing.Size(121, 21);
            this._armor_panel_dropdown.TabIndex = 0;
            // 
            // _weapon_panel
            // 
            this._weapon_panel.BackColor = System.Drawing.Color.Transparent;
            this._weapon_panel.Controls.Add(this._weapon_panel_dropdown);
            this._weapon_panel.Controls.Add(this._weapon_panel_select_label);
            this._weapon_panel.Location = new System.Drawing.Point(4, 22);
            this._weapon_panel.Name = "_weapon_panel";
            this._weapon_panel.Padding = new System.Windows.Forms.Padding(3);
            this._weapon_panel.Size = new System.Drawing.Size(354, 258);
            this._weapon_panel.TabIndex = 1;
            this._weapon_panel.Text = "Weapons";
            // 
            // _weapon_panel_select_label
            // 
            this._weapon_panel_select_label.AutoSize = true;
            this._weapon_panel_select_label.Location = new System.Drawing.Point(8, 3);
            this._weapon_panel_select_label.Name = "_weapon_panel_select_label";
            this._weapon_panel_select_label.Size = new System.Drawing.Size(87, 13);
            this._weapon_panel_select_label.TabIndex = 0;
            this._weapon_panel_select_label.Text = "Select Weapon :";
            // 
            // _weapon_panel_dropdown
            // 
            this._weapon_panel_dropdown.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this._weapon_panel_dropdown.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this._weapon_panel_dropdown.FormattingEnabled = true;
            this._weapon_panel_dropdown.Location = new System.Drawing.Point(11, 19);
            this._weapon_panel_dropdown.Name = "_weapon_panel_dropdown";
            this._weapon_panel_dropdown.Size = new System.Drawing.Size(121, 21);
            this._weapon_panel_dropdown.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 284);
            this.Controls.Add(this._tab_panel);
            this.Name = "MainWindow";
            this.Text = "World of Xeen Info!";
            this._tab_panel.ResumeLayout(false);
            this._armor_panel.ResumeLayout(false);
            this._armor_panel.PerformLayout();
            this._weapon_panel.ResumeLayout(false);
            this._weapon_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl _tab_panel;
        private System.Windows.Forms.TabPage _armor_panel;
        private System.Windows.Forms.TabPage _weapon_panel;
        private System.Windows.Forms.Label _armor_panel_select_label;
        private System.Windows.Forms.ComboBox _armor_panel_dropdown;
        private System.Windows.Forms.Label _weapon_panel_select_label;
        private System.Windows.Forms.ComboBox _weapon_panel_dropdown;
    }
}

