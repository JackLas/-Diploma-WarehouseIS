using System;
using System.Windows.Forms;
using Warehouse.Controllers.Admin;

namespace Warehouse.Views.General
{
    public partial class NewShelfForm : Form
    {
        private AdminController m_ctrl;
        public NewShelfForm(AdminController ctrl)
        {
            InitializeComponent();
            m_ctrl = ctrl;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_name.Text.Length == 0)
            {
                MessageBox.Show("Введіть назву");
                return;
            }

            int length = -1;
            if (tb_max_length.Text.Length == 0 || !int.TryParse(tb_max_length.Text, out length))
            {
                MessageBox.Show("Перевірте значення довжини");
                return;
            }

            int width = -1;
            if (tb_max_width.Text.Length == 0 || !int.TryParse(tb_max_width.Text, out width))
            {
                MessageBox.Show("Перевірте значення ширини");
                return;
            }

            int height = -1;
            if (tb_max_height.Text.Length == 0 || !int.TryParse(tb_max_height.Text, out height))
            {
                MessageBox.Show("Перевірте значення висоти");
                return;
            }

            int weight = -1;
            if (tb_max_weight.Text.Length == 0 || !int.TryParse(tb_max_weight.Text, out weight))
            {
                MessageBox.Show("Перевірте значення висоти");
                return;
            }

            int levels = -1;
            if (tb_levels.Text.Length == 0 || !int.TryParse(tb_levels.Text, out levels))
            {
                MessageBox.Show("Перевірте значення висоти");
                return;
            }

            m_ctrl.addNewShelf(tb_name.Text, length, width, height, weight, levels);
            this.Close();
        }
    }
}
