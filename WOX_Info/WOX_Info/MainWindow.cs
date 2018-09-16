using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
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
            InitializeAccessoriesTab();
        }

        private void InitializeArmorTab()
        {
            // Armor dropdown
            var armors = _content_database.WOXBaseItems.OfType<Armor>().ToList();
            _armor_panel_dropdown.DataSource = armors;
            _armor_panel_dropdown.DisplayMember = "Name";
            _armor_panel_dropdown.SelectedIndexChanged += (object sender, EventArgs args) => HandleDropDownSelectedChanged(_armor_panel_dropdown, _armor_panel_listview);

            // Armor listview
            _armor_panel_listview.View = View.Details;
            _armor_panel_listview.Columns.Add("Stat");
            _armor_panel_listview.Columns.Add("Value");

            // Init first value in listview
            HandleDropDownSelectedChanged(_armor_panel_dropdown, _armor_panel_listview);
        }

        private void InitializeWeaponTab()
        {
            // Weapon dropdown
            var weapons = _content_database.WOXBaseItems.OfType<Weapon>().ToList();
            _weapon_panel_dropdown.DataSource = weapons;
            _weapon_panel_dropdown.DisplayMember = "Name";
            _weapon_panel_dropdown.SelectedIndexChanged += (object sender, EventArgs args) => HandleDropDownSelectedChanged(_weapon_panel_dropdown, _weapon_panel_listview);

            // Weapon listview
            _weapon_panel_listview.View = View.Details;
            _weapon_panel_listview.Columns.Add("Stat");
            _weapon_panel_listview.Columns.Add("Value");

            // Init first value in listview
            HandleDropDownSelectedChanged(_weapon_panel_dropdown, _weapon_panel_listview);
        }

        private void InitializeAccessoriesTab()
        {
            // Weapon dropdown
            var accessories = _content_database.WOXBaseItems.OfType<Accessory>().ToList();
            _accessories_panel_dropdown.DataSource = accessories;
            _accessories_panel_dropdown.DisplayMember = "Name";
            _accessories_panel_dropdown.SelectedIndexChanged += (object sender, EventArgs args) => HandleDropDownSelectedChanged(_accessories_panel_dropdown, _accessories_panel_listview);

            // Weapon listview
            _accessories_panel_listview.View = View.Details;
            _accessories_panel_listview.Columns.Add("Stat");
            _accessories_panel_listview.Columns.Add("Value");

            // Init first value in listview
            HandleDropDownSelectedChanged(_accessories_panel_dropdown, _accessories_panel_listview);
        }

        private void HandleDropDownSelectedChanged(ComboBox dropdown, ListView listView)
        {
            listView.Items.Clear();
            if (dropdown.SelectedItem is BaseItem selectedItem)
            {
                listView.Items.AddRange(selectedItem.ToListViewItems().ToArray());
            }
        }


    }
}
