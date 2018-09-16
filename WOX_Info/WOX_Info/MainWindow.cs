using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WOX_Info.Classes;
using WOX_Info.Items;

namespace WOX_Info
{
    public partial class MainWindow : Form
    {
        private ContentDatabase _content_database;

        public MainWindow()
        {
            InitializeComponent();

            InitData();
            InitPanels();
        }

        private void InitData()
        {
            _content_database = new ContentDatabase();
        }

        private void InitPanels()
        {
            InitializeArmorTab();
            InitializeWeaponTab();
        }

        private void InitializeArmorTab()
        {
            // Armor dropdown
            var armors = _content_database.WOXBaseItems.OfType<Armor>().ToList();
            _armor_panel_dropdown.DataSource = armors;
            _armor_panel_dropdown.DisplayMember = "Name";
            _armor_panel_dropdown.SelectedIndexChanged += HandleArmorTabSelectedArmorChanged;

            // Armor listview
            _armor_panel_list_view.View = View.Details;
            _armor_panel_list_view.Columns.Add("Stat");
            _armor_panel_list_view.Columns.Add("Value");
        }

        private void InitializeWeaponTab()
        {
            // Weapon dropdown
            var weapons = _content_database.WOXBaseItems.OfType<Weapon>().ToList();
            _weapon_panel_dropdown.DataSource = weapons;
            _weapon_panel_dropdown.DisplayMember = "Name";
            _weapon_panel_dropdown.SelectedIndexChanged += HandleWeaponTabSelectedWeaponChanged;

            // Weapon listview
            _weapon_panel_list_view.View = View.Details;
            _weapon_panel_list_view.Columns.Add("Stat");
            _weapon_panel_list_view.Columns.Add("Value");
        }

        private void HandleArmorTabSelectedArmorChanged(object sender, EventArgs args)
        {
            _armor_panel_list_view.Items.Clear();
            if (_armor_panel_dropdown.SelectedItem is Armor selectedItem)
            {
                _armor_panel_list_view.Items.AddRange(selectedItem.ToListViewItems().ToArray());
            }
        }

        private void HandleWeaponTabSelectedWeaponChanged(object sender, EventArgs eventArgs)
        {
            _weapon_panel_list_view.Items.Clear();
            if (_weapon_panel_dropdown.SelectedItem is Weapon selectedItem)
            {
                _weapon_panel_list_view.Items.AddRange(selectedItem.ToListViewItems().ToArray());
            }
        }

        
        
    }
}
