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
            this._armor_panel_stats_box = new System.Windows.Forms.GroupBox();
            this._armor_panel_listview = new System.Windows.Forms.ListView();
            this._armor_panel_select_label = new System.Windows.Forms.Label();
            this._armor_panel_dropdown = new System.Windows.Forms.ComboBox();
            this._weapon_panel = new System.Windows.Forms.TabPage();
            this._weapon_panel_stats_box = new System.Windows.Forms.GroupBox();
            this._weapon_panel_listview = new System.Windows.Forms.ListView();
            this._weapon_panel_dropdown = new System.Windows.Forms.ComboBox();
            this._weapon_panel_select_label = new System.Windows.Forms.Label();
            this._accessories_panel = new System.Windows.Forms.TabPage();
            this._accessories_panel_select_label = new System.Windows.Forms.Label();
            this._accessories_panel_dropdown = new System.Windows.Forms.ComboBox();
            this._accessories_panel_stats_box = new System.Windows.Forms.GroupBox();
            this._accessories_panel_listview = new System.Windows.Forms.ListView();
            this._tab_panel.SuspendLayout();
            this._armor_panel.SuspendLayout();
            this._armor_panel_stats_box.SuspendLayout();
            this._weapon_panel.SuspendLayout();
            this._weapon_panel_stats_box.SuspendLayout();
            this._accessories_panel.SuspendLayout();
            this._accessories_panel_stats_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tab_panel
            // 
            this._tab_panel.Controls.Add(this._armor_panel);
            this._tab_panel.Controls.Add(this._weapon_panel);
            this._tab_panel.Controls.Add(this._accessories_panel);
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
            this._armor_panel.Controls.Add(this._armor_panel_stats_box);
            this._armor_panel.Controls.Add(this._armor_panel_select_label);
            this._armor_panel.Controls.Add(this._armor_panel_dropdown);
            this._armor_panel.Location = new System.Drawing.Point(4, 22);
            this._armor_panel.Name = "_armor_panel";
            this._armor_panel.Padding = new System.Windows.Forms.Padding(3);
            this._armor_panel.Size = new System.Drawing.Size(354, 258);
            this._armor_panel.TabIndex = 0;
            this._armor_panel.Text = "Armors";
            // 
            // _armor_panel_stats_box
            // 
            this._armor_panel_stats_box.Controls.Add(this._armor_panel_listview);
            this._armor_panel_stats_box.Location = new System.Drawing.Point(11, 47);
            this._armor_panel_stats_box.Name = "_armor_panel_stats_box";
            this._armor_panel_stats_box.Size = new System.Drawing.Size(335, 203);
            this._armor_panel_stats_box.TabIndex = 2;
            this._armor_panel_stats_box.TabStop = false;
            this._armor_panel_stats_box.Text = "Stats";
            // 
            // _armor_panel_listview
            // 
            this._armor_panel_listview.Location = new System.Drawing.Point(7, 20);
            this._armor_panel_listview.Name = "_armor_panel_listview";
            this._armor_panel_listview.Size = new System.Drawing.Size(322, 177);
            this._armor_panel_listview.TabIndex = 0;
            this._armor_panel_listview.UseCompatibleStateImageBehavior = false;
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
            this._weapon_panel.Controls.Add(this._weapon_panel_stats_box);
            this._weapon_panel.Controls.Add(this._weapon_panel_dropdown);
            this._weapon_panel.Controls.Add(this._weapon_panel_select_label);
            this._weapon_panel.Location = new System.Drawing.Point(4, 22);
            this._weapon_panel.Name = "_weapon_panel";
            this._weapon_panel.Padding = new System.Windows.Forms.Padding(3);
            this._weapon_panel.Size = new System.Drawing.Size(354, 258);
            this._weapon_panel.TabIndex = 1;
            this._weapon_panel.Text = "Weapons";
            // 
            // _weapon_panel_stats_box
            // 
            this._weapon_panel_stats_box.Controls.Add(this._weapon_panel_listview);
            this._weapon_panel_stats_box.Location = new System.Drawing.Point(11, 47);
            this._weapon_panel_stats_box.Name = "_weapon_panel_stats_box";
            this._weapon_panel_stats_box.Size = new System.Drawing.Size(335, 203);
            this._weapon_panel_stats_box.TabIndex = 2;
            this._weapon_panel_stats_box.TabStop = false;
            this._weapon_panel_stats_box.Text = "Stats";
            // 
            // _weapon_panel_listview
            // 
            this._weapon_panel_listview.Location = new System.Drawing.Point(7, 20);
            this._weapon_panel_listview.Name = "_weapon_panel_listview";
            this._weapon_panel_listview.Size = new System.Drawing.Size(322, 177);
            this._weapon_panel_listview.TabIndex = 0;
            this._weapon_panel_listview.UseCompatibleStateImageBehavior = false;
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
            // _weapon_panel_select_label
            // 
            this._weapon_panel_select_label.AutoSize = true;
            this._weapon_panel_select_label.Location = new System.Drawing.Point(8, 3);
            this._weapon_panel_select_label.Name = "_weapon_panel_select_label";
            this._weapon_panel_select_label.Size = new System.Drawing.Size(87, 13);
            this._weapon_panel_select_label.TabIndex = 0;
            this._weapon_panel_select_label.Text = "Select Weapon :";
            // 
            // _accessories_panel
            // 
            this._accessories_panel.BackColor = System.Drawing.Color.Transparent;
            this._accessories_panel.Controls.Add(this._accessories_panel_stats_box);
            this._accessories_panel.Controls.Add(this._accessories_panel_dropdown);
            this._accessories_panel.Controls.Add(this._accessories_panel_select_label);
            this._accessories_panel.Location = new System.Drawing.Point(4, 22);
            this._accessories_panel.Name = "_accessories_panel";
            this._accessories_panel.Padding = new System.Windows.Forms.Padding(3);
            this._accessories_panel.Size = new System.Drawing.Size(354, 258);
            this._accessories_panel.TabIndex = 2;
            this._accessories_panel.Text = "Accessories";
            // 
            // _accessories_panel_select_label
            // 
            this._accessories_panel_select_label.AutoSize = true;
            this._accessories_panel_select_label.Location = new System.Drawing.Point(8, 3);
            this._accessories_panel_select_label.Name = "_accessories_panel_select_label";
            this._accessories_panel_select_label.Size = new System.Drawing.Size(92, 13);
            this._accessories_panel_select_label.TabIndex = 0;
            this._accessories_panel_select_label.Text = "Select Accessory:";
            // 
            // _accessories_panel_dropdown
            // 
            this._accessories_panel_dropdown.FormattingEnabled = true;
            this._accessories_panel_dropdown.Location = new System.Drawing.Point(11, 19);
            this._accessories_panel_dropdown.Name = "_accessories_panel_dropdown";
            this._accessories_panel_dropdown.Size = new System.Drawing.Size(121, 21);
            this._accessories_panel_dropdown.TabIndex = 1;
            // 
            // _accessories_panel_stats_box
            // 
            this._accessories_panel_stats_box.Controls.Add(this._accessories_panel_listview);
            this._accessories_panel_stats_box.Location = new System.Drawing.Point(11, 47);
            this._accessories_panel_stats_box.Name = "_accessories_panel_stats_box";
            this._accessories_panel_stats_box.Size = new System.Drawing.Size(335, 203);
            this._accessories_panel_stats_box.TabIndex = 2;
            this._accessories_panel_stats_box.TabStop = false;
            this._accessories_panel_stats_box.Text = "Stats";
            // 
            // _accessories_panel_listview
            // 
            this._accessories_panel_listview.Location = new System.Drawing.Point(7, 20);
            this._accessories_panel_listview.Name = "_accessories_panel_listview";
            this._accessories_panel_listview.Size = new System.Drawing.Size(322, 177);
            this._accessories_panel_listview.TabIndex = 0;
            this._accessories_panel_listview.UseCompatibleStateImageBehavior = false;
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
            this._armor_panel_stats_box.ResumeLayout(false);
            this._weapon_panel.ResumeLayout(false);
            this._weapon_panel.PerformLayout();
            this._weapon_panel_stats_box.ResumeLayout(false);
            this._accessories_panel.ResumeLayout(false);
            this._accessories_panel.PerformLayout();
            this._accessories_panel_stats_box.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox _armor_panel_stats_box;
        private System.Windows.Forms.ListView _armor_panel_listview;
        private System.Windows.Forms.GroupBox _weapon_panel_stats_box;
        private System.Windows.Forms.ListView _weapon_panel_listview;
        private System.Windows.Forms.TabPage _accessories_panel;
        private System.Windows.Forms.Label _accessories_panel_select_label;
        private System.Windows.Forms.ComboBox _accessories_panel_dropdown;
        private System.Windows.Forms.GroupBox _accessories_panel_stats_box;
        private System.Windows.Forms.ListView _accessories_panel_listview;
    }
}

