namespace MDI_editor
{
    public partial class Form1 : Form
    {
        private int formindex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // File → New
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formindex++;   // нэр давхцахаас сэргийлж тоолуур ашиглав
            Form ChildForm = new Form();
            ChildForm.Name = "Child" + formindex;
            ChildForm.Text = "Child" + formindex;
            ChildForm.MdiParent = this;
            TextBox txtBox = new TextBox();
            txtBox.Dock = DockStyle.Fill;
            txtBox.Multiline = true;
            ChildForm.Controls.Add(txtBox);
            ChildForm.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }
    }
}