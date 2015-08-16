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
        }

        private void InitializeArmorTab()
        {
            var armors = _content_database.WOXBaseItems.OfType<Armor>().ToList();
            _armor_panel_base_armor_box.DataSource = armors;
            _armor_panel_base_armor_box.DisplayMember = "Name";
            _armor_panel_base_armor_box.SelectedIndexChanged += HandleArmorTabSelectedArmorChanged;
        }

        private void HandleArmorTabSelectedArmorChanged(object sender, EventArgs args)
        {

        }
    }
}
