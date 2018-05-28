using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private Circle Cirle;
        private List<Circle> circles;
        private bool is_checked;
        private static int click_counter;
        private Circle active_circle;
        
        public Form1()
        {
            InitializeComponent();
            graphics = panel.CreateGraphics();
            Hints.Text = "*Double click for choose centre\r\n*Double click for choose edge\r\n*Choose the circle in 'Shapes' then Remove for delet" +
    "e circle\r\n*Choose the circle in 'Shapes'then Change for choose color\r\n";
            circles = new List<Circle>();
            Cirle = new Circle();
            is_checked = false;
            click_counter = 0;
        }

        public static OpenFileDialog create_open_file()
        {
            OpenFileDialog open_file = new OpenFileDialog
            {
                Filter = "(*.xml)|*.xml",
                RestoreDirectory = true,
                CheckFileExists = true,
                CheckPathExists = true,
                Title = "Choose"
            };

            return open_file;
        }

        public static SaveFileDialog create_save_file()
        {
            SaveFileDialog save_file = new SaveFileDialog
            {
                RestoreDirectory = true,
                DefaultExt = "xml",
                CheckPathExists = true,
                ValidateNames = true,
                Title = "Save"
            };

            return save_file;
        }



        private void Open_Click(object sender, EventArgs e)
        {
            open_file = create_open_file();
            if (open_file.ShowDialog() == DialogResult.OK)
            {
                Reset();
                circles = Serializate.deserealizate(open_file.FileName);
                Graphic.Redraw(panel, graphics, circles);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            save_file = create_save_file();

            if (save_file.ShowDialog() == DialogResult.OK)
            {
                Serializate.Serializate_list(circles, save_file.FileName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void shape_click_menu(object sender, EventArgs e)
        {
            shape_click_menus.DropDownItems.Clear();
            List<ToolStripMenuItem> nodes = new List<ToolStripMenuItem>();
            foreach (Circle circl in circles)
            {
                ToolStripMenuItem node = new ToolStripMenuItem(circl.Color.ToString() + "-" + circl.radius());
                node.Click += new EventHandler(shapes_in_menu);
                nodes.Add(node);
            }
            shape_click_menus.DropDownItems.AddRange(nodes.ToArray());
        }

        private void shapes_in_menu(object sender, EventArgs e)
        {
            ToolStripMenuItem tsim = sender as ToolStripMenuItem;
            var circl = circles.Find(p => p.Color.ToString()+"-"+p.radius() == tsim.Text);
            circles.Remove(circl);
            circles.Add(circl);
            Graphic.Redraw(panel, graphics, circles);
            active_circle = circl;
            is_checked = true;
            Change.Visible = true;
            Remove.Visible = true;
            this.Invalidate();
        }


        private void choose_color(object sender, EventArgs e)
        {
            ColorDialog color_dialog = new ColorDialog();
            color_dialog.AllowFullOpen = false;
            color_dialog.ShowHelp = true;
            color_dialog.Color = Change.ForeColor;
            if (color_dialog.ShowDialog() == DialogResult.OK)
            {
                circles.Remove(active_circle);
                active_circle.Color = color_dialog.Color;
                circles.Add(active_circle);
                Graphic.Redraw(panel, graphics, circles);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelForPainting_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void panelForPainting_DoubleClick(object sender, EventArgs e)
        {
            MouseEventArgs mouse_event = e as MouseEventArgs;
            if (mouse_event.Button == MouseButtons.Left)
            {
                Point point = new Point(mouse_event.Location.X, mouse_event.Location.Y);
                if (click_counter == 0)
                {
                    Cirle.Centre = panel.PointToClient(Cursor.Position);
                    click_counter++;
                }
                else if (click_counter == 1)
                {
                    Cirle.Edge = panel.PointToClient(Cursor.Position);
                    circles.Add(Cirle);
                    Cirle = new Circle();
                    Graphic.Redraw(panel, graphics, circles);
                    click_counter = 0;
                }
            }
        }

       

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
           
        }



        private void Remove_circle(object sender, EventArgs e)
        {
            if (active_circle != null)
            {
                circles.Remove(active_circle);
                active_circle = null;
                is_checked = false;
                Change.Visible = false;
                Remove.Visible = false;
                Graphic.Redraw(panel, graphics, circles);
            }
        }


        private void panel_painting(object sender, EventArgs e)
        {
            MouseEventArgs mouse_event = e as MouseEventArgs;
            if (mouse_event.Button == MouseButtons.Right)
            {
                Point point = new Point(mouse_event.Location.X, mouse_event.Location.Y);

                if (!is_checked)
                {
                    active_circle = circles.FirstOrDefault(p =>
                        {
                            if(Circle.calculate_distance(p.Centre,p.Edge)>Circle.calculate_distance(p.Centre,point))
                            {
                                return true;
                            }
                            return false;
                    });
                    if (active_circle != null)
                    {
                        is_checked = true;
                        Change.Visible = true;
                        Remove.Visible = true;
                    }
                }
                else
                {
                    if (active_circle == null)
                    {
                        throw new ApplicationException("Can`t find this figure ... ");
                    }
                    circles.Remove(active_circle);
                    active_circle.Move(point);
                    circles.Add(active_circle);
                    Graphic.Redraw(panel, graphics, circles);
                }
            }
            else
            {
                
                active_circle = null;
                is_checked = false;
                Change.Visible = false;
                Remove.Visible = false;
            }
        }
        
    }
}
