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
            var armors = _content_database.WOXBaseItems.OfType<Armor>().ToList();
            _armor_panel_dropdown.DataSource = armors;
            _armor_panel_dropdown.DisplayMember = "Name";
            _armor_panel_dropdown.SelectedIndexChanged += HandleArmorTabSelectedArmorChanged;
        }

        private void InitializeWeaponTab()
        {
            var weapons = _content_database.WOXBaseItems.OfType<Weapon>().ToList();
            _weapon_panel_dropdown.DataSource = weapons;
            _weapon_panel_dropdown.DisplayMember = "Name";
            _weapon_panel_dropdown.SelectedIndexChanged += HandleWeaponTabSelectedWeaponChanged;
        }

        private void HandleArmorTabSelectedArmorChanged(object sender, EventArgs args)
        {

        }

        private void HandleWeaponTabSelectedWeaponChanged(object sender, EventArgs eventArgs)
        {
            
        }

        
        
    }
}
